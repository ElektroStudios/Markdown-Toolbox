#Region " Option Statements "

Option Explicit On
Option Strict On
Option Infer Off

#End Region

#Region " Imports "

Imports CefSharp
Imports CefSharp.Handler
Imports CefSharp.WinForms

#End Region

#Region " RequestHandlerByUrlCondition "

''' <summary>
''' Provides functionality to allow or restrict navigation requests 
''' based on whether the requested URL satisfies the condition 
''' of a specified predicate function.
''' <para></para>
''' Usage: Assign an instance of this class to the <see cref="ChromiumWebBrowser.RequestHandler"/> property.
''' </summary>
Friend NotInheritable Class RequestHandlerByUrlCondition : Inherits RequestHandler

#Region " Properties "

    ''' <summary>
    ''' Gets the predicate function used to allow or restrict navigation requests.
    ''' </summary>
    ''' 
    ''' <value>
    ''' A predicate function that takes a <see cref="Uri"/> as input and returns
    ''' a <see cref="Boolean"/> indicating whether the condition is satisfied.
    ''' <para></para>
    ''' The predicate function must return <see langword="True"/> to allow 
    ''' navigation to the requested URL, or <see langword="False"/> otherwise.
    ''' </value>
    Public ReadOnly Property UriPredicate As Func(Of Uri, Boolean)

#End Region

#Region " Constructors "

    ''' <summary>
    ''' Initializes a new instance of the <see cref="RequestHandlerRestrictedToHostName"/> class.
    ''' </summary>
    ''' 
    ''' <param name="uriPredicate">
    ''' A predicate function that takes a <see cref="Uri"/> as input and returns
    ''' a <see cref="Boolean"/> indicating whether the condition is satisfied.
    ''' <para></para>
    ''' The predicate function must return <see langword="True"/> to allow 
    ''' navigation to the requested URL, or <see langword="False"/> otherwise.
    ''' </param>
    <DebuggerStepThrough>
    Public Sub New(uriPredicate As Func(Of Uri, Boolean))
        MyBase.New()
        Me.UriPredicate = uriPredicate
    End Sub

    ''' <summary>
    ''' Prevents a default instance of the <see cref="RequestHandlerByUrlCondition"/> class from being created.
    ''' </summary>
    <DebuggerNonUserCode>
    Private Sub New()
    End Sub

#End Region

#Region " Event Raisers "

    ''' <summary>
    ''' Called before browser navigation. 
    ''' <para></para>
    ''' If the navigation is allowed, <see cref="IWebBrowser.FrameLoadStart"/> 
    ''' and <see cref="IWebBrowser.FrameLoadEnd"/> will be called.
    ''' <para></para>
    ''' If the navigation is canceled, <see cref="IWebBrowser.LoadError"/> will be called 
    ''' with an <see cref="CefErrorCode.Aborted"/> error code. 
    ''' </summary>
    ''' 
    ''' <param name="chromiumWebBrowser">
    ''' The ChromiumWebBrowser control.
    ''' </param>
    ''' 
    ''' <param name="browser">
    ''' The browser object.
    ''' </param>
    ''' 
    ''' <param name="frame">
    ''' The frame the request is coming from.
    ''' </param>
    ''' 
    ''' <param name="request">
    ''' The request object (It cannot be modified in this callback).
    ''' </param>
    ''' 
    ''' <param name="userGesture">
    ''' The value will be <see langword="True"/> if the browser navigated via explicit user gesture (e.g. clicking a link) 
    ''' or <see langword="False"/> if it navigated automatically (e.g. via the DomContentLoaded event).
    ''' </param>
    ''' 
    ''' <param name="isRedirect">
    ''' Has the request been redirected.
    ''' </param>
    ''' 
    ''' <returns>
    ''' Returns <see langword="True"/> to cancel the navigation, 
    ''' or <see langword="False"/> to allow the navigation to proceed.
    ''' </returns>
    <DebuggerStepperBoundary>
    Protected Overrides Function OnBeforeBrowse(chromiumWebBrowser As IWebBrowser,
                                                browser As IBrowser,
                                                frame As IFrame,
                                                request As IRequest,
                                                userGesture As Boolean,
                                                isRedirect As Boolean
                                                ) As Boolean

        Dim requestUri As Uri = Nothing
#If NETCOREAPP Then
        Dim uriCreationOptions As New UriCreationOptions()
        Dim requestUriSuccess As Boolean = Uri.TryCreate(request.Url, uriCreationOptions, requestUri)
#Else
        Dim requestUriSuccess As Boolean = Uri.TryCreate(request.Url, UriKind.RelativeOrAbsolute, requestUri)
#End If
        If requestUriSuccess AndAlso Me.UriPredicate(requestUri) Then
            Return MyBase.OnBeforeBrowse(chromiumWebBrowser, browser, frame, request, userGesture, isRedirect)
        Else
            ' Cancel the navigation for malformed URIs
            ' or URIs that does not satisfies the predicate function.
            Return True
        End If

    End Function

#End Region

End Class

#End Region
