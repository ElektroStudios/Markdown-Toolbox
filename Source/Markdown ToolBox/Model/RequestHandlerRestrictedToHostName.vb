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

#Region " RequestHandlerRestrictedToHostName "

''' <summary>
''' Provides functionality to restrict navigation requests to a specific hostname.
''' <para></para>
''' Usage: Assign an instance of this class to the <see cref="ChromiumWebBrowser.RequestHandler"/> property.
''' </summary>
Friend NotInheritable Class RequestHandlerRestrictedToHostName : Inherits RequestHandler

#Region " Fields "

    ''' <summary>
    ''' The URL provided in <see cref="RequestHandlerRestrictedToHostName.New(Uri)"/> constructor.
    ''' </summary>
    Protected ReadOnly UserUrl As Uri

#End Region

#Region " Properties "

    ''' <summary>
    ''' Gets the hostname to which navigation requests are restricted.
    ''' </summary>
    Public ReadOnly Property HostName As String
        Get
            Return Me.UserUrl.Host
        End Get
    End Property

#End Region

#Region " Constructors "

    ''' <summary>
    ''' Initializes a new instance of the <see cref="RequestHandlerRestrictedToHostName"/> class.
    ''' </summary>
    ''' 
    ''' <param name="url">
    ''' An <see cref="Uri"/> from which to extract the hostname to which navigation requests will be restricted.
    ''' </param>
    <DebuggerStepThrough>
    Public Sub New(url As Uri)
        MyBase.New()
        Me.UserUrl = url
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the <see cref="RequestHandlerRestrictedToHostName"/> class.
    ''' </summary>
    ''' 
    ''' <param name="url">
    ''' An URL address from which to extract the hostname to which navigation requests will be restricted.
    ''' </param>
    <DebuggerStepThrough>
    Public Sub New(url As String)
        Me.New(New Uri(url))
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the <see cref="RequestHandlerRestrictedToHostName"/> class.
    ''' </summary>
    ''' 
    ''' <param name="chromiumWebBrowser">
    ''' An <see cref="IWebBrowser"/> instance from which to extract 
    ''' the hostname to which navigation requests will be restricted 
    ''' from the current URL address of the browser.
    ''' <para></para>
    ''' If the browser has not loaded any URL address, an exception will be thrown.
    ''' </param>
    <DebuggerStepThrough>
    Public Sub New(chromiumWebBrowser As IWebBrowser)
        MyBase.New()
        If String.IsNullOrEmpty(chromiumWebBrowser.Address) Then
            Throw New ArgumentException("The browser has not loaded any url address.", paramName:=NameOf(chromiumWebBrowser))
        End If
        Me.UserUrl = New Uri(chromiumWebBrowser.Address)
    End Sub

    ''' <summary>
    ''' Prevents a default instance of the <see cref="RequestHandlerRestrictedToHostName"/> class from being created.
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
        If requestUriSuccess AndAlso requestUri.Host.Equals(Me.HostName, StringComparison.OrdinalIgnoreCase) Then
            Return MyBase.OnBeforeBrowse(chromiumWebBrowser, browser, frame, request, userGesture, isRedirect)
        Else
            ' Cancel the navigation for malformed URIs
            ' or URIs that does not match the hostname.
            Return True
        End If

    End Function

#End Region

End Class

#End Region
