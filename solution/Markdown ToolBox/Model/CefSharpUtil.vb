#Region " Option Statements "

Option Explicit On
Option Strict On
Option Infer Off

#End Region

#Region " Imports "

Imports Microsoft.VisualBasic.ApplicationServices

Imports CefSharp
Imports CefSharp.WinForms

#End Region

''' <summary>
''' Provides Cefsharp related utilities.
''' </summary>
Friend Module CefSharpUtil

#Region " Public Methods "

    ''' <summary>
    ''' Initializes the CefSharp environment with optimal settings.
    ''' <para></para>
    ''' This method MUST be called on your main application thread (typically the UI thread)
    ''' and typically from the <see cref="WindowsFormsApplicationBase.Startup"/> event,
    ''' before any browser instance is created.
    ''' </summary>
    ''' 
    ''' <param name="settings">
    ''' Optional. The CefSharp settings to use for initialization.
    ''' </param>
    ''' 
    ''' <returns>
    ''' Returns <see langword="True"/> if the internal call to method <see cref="Cef.Initialize"/> succeed; 
    ''' otherwise, <see langword="False"/>.
    ''' </returns>
    ''' 
    ''' <exception cref="InvalidOperationException">
    ''' Cefsharp is already initialized.
    ''' </exception>
    <DebuggerStepperBoundary>
    Friend Function InitializeCefSharp(Optional settings As CefSettings = Nothing) As Boolean

#If Not NETCOREAPP AndAlso PLATFORM = "AnyCPU" Then
            ' GitHub: Feature Request - Add AnyCPU Support #1714
            ' Add <CefSharpAnyCpuSupport>true</CefSharpAnyCpuSupport> to the first <PropertyGroup> in your .vbproj file. 
            ' https://github.com/cefsharp/CefSharp/issues/1714
            CefRuntime.SubscribeAnyCpuAssemblyResolver()
#End If

        If Cef.IsInitialized Then
            Throw New InvalidOperationException("Cefsharp has already been initialized.")
        End If

        If settings Is Nothing Then

            settings = New CefSettings With {
                    .CachePath = Paths.CefSharpCachePath,
                    .RootCachePath = Paths.CefSharpCachePath,
                    .CommandLineArgsDisabled = False,
                    .IgnoreCertificateErrors = True,
                    .Locale = "en-US",
                    .LogFile = Paths.CefSharpLogFilePath,
                    .LogSeverity = LogSeverity.Error,
                    .PersistSessionCookies = True,
                    .PersistUserPreferences = False,
                    .WindowlessRenderingEnabled = False ', .BackgroundColor = &HFF1E1E1EUI
                }
        End If

        settings.CefCommandLineArgs.Add("--enable-features=WebContentsForceDark")
        settings.CefCommandLineArgs.Add("enable-media-stream")
        ' settings.CefCommandLineArgs.Add("extensions-on-chrome-urls")
        ' settings.CefCommandLineArgs.Add("show-component-extension-options")
        ' settings.CefCommandLineArgs.Add("enable-extension-activity-logging")
        ' settings.CefCommandLineArgs.Add("extensions-not-webstore")
        ' settings.CefCommandLineArgs.Add("disable-web-security")
        ' settings.CefCommandLineArgs.Add("allow-running-insecure-content")

        Dim success As Boolean = Cef.Initialize(settings, performDependencyCheck:=True)
        Return success
    End Function

    ''' <summary>
    ''' Safely shutdowns the CefSharp environment.
    ''' <para></para>
    ''' This method should be called on the main application thread
    ''' to shutdown the CEF browser process before the application exits.
    ''' </summary>
    ''' 
    ''' <exception cref="System.InvalidOperationException">
    ''' CefSharp has already been shutdown.
    ''' </exception>
    <DebuggerStepperBoundary>
    Friend Sub ShutdownCefSharp()
        If Cef.IsShutdown Then
            Throw New InvalidOperationException("CefSharp has already been shutdown.")
        End If

        Cef.PreShutdown()
        Cef.Shutdown()
    End Sub

#End Region

End Module
