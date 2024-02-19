#Region " Option Statements "

Option Explicit On
Option Strict On
Option Infer Off

#End Region

#Region " Imports "

Imports System.Runtime.CompilerServices

Imports CefSharp
Imports CefSharp.WinForms

#End Region

#Region " ChromiumWebBrowserExtensions "

''' <summary>
''' Provides extension methods for <see cref="ChromiumWebBrowser"/> type.
''' </summary>
<HideModuleName>
Friend Module ChromiumWebBrowserExtensions

#Region " Public Methods "

    ''' <summary>
    ''' Sets a value associated with the provided preference name 
    ''' for the source <see cref="ChromiumWebBrowser"/> object.
    ''' <para></para>
    ''' If <paramref name="value"/> is null, the preference will be restored to its default value. 
    ''' <para></para>
    ''' If setting the preference fails, a error message will be populated 
    ''' in <paramref name="refErrorMsg"/> parameter with a detailed 
    ''' description of the problem. 
    ''' </summary>
    ''' 
    ''' <param name="browser">
    ''' The source <see cref="ChromiumWebBrowser"/> which to set a preference name.
    ''' </param>
    ''' 
    ''' <param name="preferenceName">
    ''' The ame of the preference to set.
    ''' </param>
    ''' 
    ''' <param name="value">
    ''' The value for the preference.
    ''' </param>
    ''' 
    ''' <param name="refErrorMsg">
    ''' If setting the preference fails, a error message will be populated 
    ''' in <paramref name="refErrorMsg"/> parameter with a detailed 
    ''' description of the problem. 
    ''' </param>
    ''' 
    ''' <returns>
    ''' Returns <see langword="True"/> if the preference was set successfully; 
    ''' otherwise, <see langword="False"/>.
    ''' </returns>
    ''' 
    ''' <exception cref="InvalidOperationException">
    ''' Browser has not been initialized.
    ''' </exception>
    <Extension>
    <DebuggerStepThrough>
    Public Function SetBrowserPreference(browser As ChromiumWebBrowser,
                                         preferenceName As String, value As Object,
                                         ByRef refErrorMsg As String) As Boolean

        If Not browser.IsBrowserInitialized Then
            Throw New InvalidOperationException("Browser has not been initialized.")
        End If

        Dim refLambdaErrorMsg As String = ""
        Dim success As Boolean

        Dim t As Task = Cef.UIThreadTaskFactory.StartNew(
            Sub()
                Dim requestContext As IRequestContext = browser.GetBrowserHost().RequestContext
                success = requestContext.SetPreference(preferenceName, value, refLambdaErrorMsg)
            End Sub)

        t.Wait()

        refErrorMsg = refLambdaErrorMsg
        Return success

    End Function

#End Region

End Module

#End Region