#Region " Option Statements "

Option Explicit On
Option Strict On
Option Infer Off

#End Region

#Region " Imports "

Imports CefSharp
Imports CefSharp.WinForms

Imports ChromiumWebBrowserExtensions

#End Region

#Region " MainForm "

''' <summary>
''' The main form of the application.
''' </summary>
Partial Friend NotInheritable Class MainForm : Inherits Form

#Region " Private Fielda "

    ''' <summary>
    ''' Flag to determine whether the browsers should enable dark mode.
    ''' </summary>
    Private enableDarkMode As Boolean

#End Region

#Region " Event Handlers "

    ''' <summary>
    ''' Handles the <see cref="Form.Load"/> event of the <see cref="MainForm"/> form.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) _
    Handles MyBase.Load

        Me.InitializeBrowsers()
        JotUtil.StartTrackingForm()
    End Sub

    ''' <summary>
    ''' Handles the <see cref="Form.Shown"/> event of the <see cref="MainForm"/> form.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Sub MainForm_Shown(sender As Object, e As EventArgs) _
    Handles MyBase.Shown

        JotUtil.StartTrackingMenuItems()
    End Sub

    ''' <summary>
    ''' Handles the <see cref="Form.FormClosing"/> event of the <see cref="MainForm"/> form.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="FormClosingEventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) _
    Handles MyBase.FormClosing

        CefSharpUtil.ShutdownCefSharp()
    End Sub

    ''' <summary>
    ''' Handles the <see cref="ToolStripMenuItem.Click"/> event 
    ''' of the <see cref="MainForm.ReloadCurrentWebpageToolStripMenuItem"/> control.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Sub ReloadCurrentWebpageToolStripMenuItem_Click(sender As Object, e As EventArgs) _
    Handles ReloadCurrentWebpageToolStripMenuItem.Click

        Dim tabcontrol As TabControl = Me.TabControl1
        Dim currentTabPage As TabPage = tabcontrol.SelectedTab
        Dim browser As ChromiumWebBrowser = currentTabPage.Controls.OfType(Of ChromiumWebBrowser).Single()

        browser.Reload(ignoreCache:=True)
    End Sub

    ''' <summary>
    ''' Handles the <see cref="ToolStripMenuItem.Click"/> event 
    ''' of the <see cref="MainForm.ExitAplicationToolStripMenuItem"/> control.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Sub ExitAplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) _
    Handles ExitAplicationToolStripMenuItem.Click

        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the <see cref="ToolStripMenuItem.CheckedChanged"/> event 
    ''' of the <see cref="MainForm.EnableSpellCheckToolStripMenuItem"/> control.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Sub EnableSpellCheckToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) _
    Handles EnableSpellCheckToolStripMenuItem.CheckedChanged

        Dim menuItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        Dim browser As ChromiumWebBrowser = Me.ChromiumWebBrowser_MdEditor

        If browser.IsBrowserInitialized Then
            browser.SetBrowserPreference("browser.enable_spellchecking", menuItem.Checked, Nothing)
        End If
    End Sub

    ''' <summary>
    ''' Handles the <see cref="ToolStripMenuItem.CheckedChanged"/> event 
    ''' of the <see cref="MainForm.EnableDarkModeToolStripMenuItem"/> control.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Async Sub EnableDarkModeToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) _
    Handles EnableDarkModeToolStripMenuItem.CheckedChanged

        Me.enableDarkMode = Not Me.enableDarkMode

        Await Me.ChromiumWebBrowser_MdEditor.SetDarkModeAsync(Me.enableDarkMode)
        Await Me.ChromiumWebBrowser_MdToHtml.SetDarkModeAsync(Me.enableDarkMode)
        Await Me.ChromiumWebBrowser_HtmlToMD.SetDarkModeAsync(Me.enableDarkMode)
        Await Me.ChromiumWebBrowser_TableToMd.SetDarkModeAsync(Me.enableDarkMode)
        Await Me.ChromiumWebBrowser_MdGuide.SetDarkModeAsync(Me.enableDarkMode)
        Await Me.ChromiumWebBrowser_GitHubMdSyntax.SetDarkModeAsync(Me.enableDarkMode)
        Await Me.ChromiumWebBrowser_ChatGPT.SetDarkModeAsync(Me.enableDarkMode)
    End Sub

    ''' <summary>
    ''' Handles the <see cref="ToolStripButton.Click"/> event 
    ''' of the <see cref="MainForm.ToolStripButton_About"/> control.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Sub ToolStripButton_About_Click(sender As Object, e As EventArgs) _
    Handles ToolStripButton_About.Click

        Using aboutBox As New AboutForm()
            aboutBox.ShowDialog()
        End Using
    End Sub

    ''' <summary>
    ''' Handles the <see cref="ChromiumWebBrowser.IsBrowserInitializedChanged"/> event 
    ''' for all of the <see cref="ChromiumWebBrowser"/> controls.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Async Sub ChromiumWebBrowser_IsBrowserInitializedChanged(sender As Object, e As EventArgs) Handles _
         ChromiumWebBrowser_MdEditor.IsBrowserInitializedChanged,
         ChromiumWebBrowser_MdToHtml.IsBrowserInitializedChanged,
         ChromiumWebBrowser_HtmlToMD.IsBrowserInitializedChanged,
         ChromiumWebBrowser_TableToMd.IsBrowserInitializedChanged,
         ChromiumWebBrowser_MdGuide.IsBrowserInitializedChanged,
         ChromiumWebBrowser_GitHubMdSyntax.IsBrowserInitializedChanged,
         ChromiumWebBrowser_ChatGPT.IsBrowserInitializedChanged

        Dim browser As ChromiumWebBrowser = DirectCast(sender, ChromiumWebBrowser)
        If browser.IsBrowserInitialized Then
            Await browser.SetDarkModeAsync(Me.enableDarkMode)
        End If

    End Sub

    ''' <summary>
    ''' Handles the <see cref="ChromiumWebBrowser.FrameLoadEnd"/> event 
    ''' for all of the <see cref="ChromiumWebBrowser"/> controls.
    ''' </summary>
    ''' 
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="FrameLoadEndEventArgs"/> instance containing the event data.
    ''' </param>
    <DebuggerStepperBoundary>
    Private Async Sub ChromiumWebBrowser_FrameLoadEnd(sender As Object, e As FrameLoadEndEventArgs) _
        Handles ChromiumWebBrowser_MdEditor.FrameLoadEnd,
                ChromiumWebBrowser_MdToHtml.FrameLoadEnd,
                ChromiumWebBrowser_HtmlToMD.FrameLoadEnd,
                ChromiumWebBrowser_TableToMd.FrameLoadEnd,
                ChromiumWebBrowser_MdGuide.FrameLoadEnd,
                ChromiumWebBrowser_GitHubMdSyntax.FrameLoadEnd,
                ChromiumWebBrowser_ChatGPT.FrameLoadEnd

        If e.Frame.IsMain Then
            Dim browser As ChromiumWebBrowser = DirectCast(sender, ChromiumWebBrowser)
            Await browser.SetDarkModeAsync(Me.enableDarkMode)
        End If

    End Sub

#End Region

#Region " Private Methods "

    ''' <summary>
    ''' Loads the URLs in the web browsers and assigns their corresponding request handlers.
    ''' </summary>
    <DebuggerStepperBoundary>
    Private Async Sub InitializeBrowsers()

        ' Markdown Editor
        Me.ChromiumWebBrowser_MdEditor.RequestHandler =
            New RequestHandlerByUrlCondition(
                Function(uri As Uri)
                    Return uri.ToString().Equals(Urls.UrlMdEditor, StringComparison.OrdinalIgnoreCase)
                End Function)
        Await Me.ChromiumWebBrowser_MdEditor.LoadUrlAsync(Urls.UrlMdEditor)
        Await Me.ChromiumWebBrowser_MdEditor.WaitForInitialLoadAsync()

#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed

        ' Avoiding the "Await" operator on "LoadUrlAsync" function
        ' is recommended for these browsers, as it will slow down
        ' the loading times of the Form and the web pages
        ' by requiring them to load sequentially.
        '
        ' Without the "Await" operator, these browsers 
        ' will start loading their web pages when 
        ' clicking on the corresponding tab in the UI.

        ' Markdown to Html
        Me.ChromiumWebBrowser_MdToHtml.RequestHandler =
            New RequestHandlerByUrlCondition(
                Function(uri As Uri)
                    Return uri.ToString().Equals(Urls.UrlMdToHtml, StringComparison.OrdinalIgnoreCase)
                End Function)
        Me.ChromiumWebBrowser_MdToHtml.LoadUrlAsync(Urls.UrlMdToHtml)

        ' Html to Markdown
        Me.ChromiumWebBrowser_HtmlToMD.RequestHandler =
            New RequestHandlerByUrlCondition(
                Function(uri As Uri)
                    Return uri.ToString().Equals(Urls.UrlHtmlToMd, StringComparison.OrdinalIgnoreCase)
                End Function)
        Me.ChromiumWebBrowser_HtmlToMD.LoadUrlAsync(Urls.UrlHtmlToMd)

        ' Table to Markdown
        Me.ChromiumWebBrowser_TableToMd.RequestHandler =
            New RequestHandlerByUrlCondition(
                Function(uri As Uri)
                    Return uri.ToString().Equals(Urls.UrlTableToMd, StringComparison.OrdinalIgnoreCase)
                End Function)
        Me.ChromiumWebBrowser_TableToMd.LoadUrlAsync(Urls.UrlTableToMd)

        ' Markdown Guide
        Me.ChromiumWebBrowser_MdGuide.RequestHandler =
            New RequestHandlerByUrlCondition(
                Function(uri As Uri)
                    Dim allowedUrls As String() = {
                        "https://www.markdownguide.org/",
                        "https://www.markdownguide.org/getting-started/",
                        "https://www.markdownguide.org/cheat-sheet/",
                        "https://www.markdownguide.org/basic-syntax/",
                        "https://www.markdownguide.org/extended-syntax/",
                        "https://www.markdownguide.org/hacks/",
                        "https://www.markdownguide.org/tools/"
                    }
                    Return allowedUrls.Contains(uri.ToString())
                End Function)
        Me.ChromiumWebBrowser_MdGuide.LoadUrlAsync(Urls.UrlMdGuide)

        ' GitHub's Markdown Syntax
        Me.ChromiumWebBrowser_GitHubMdSyntax.RequestHandler =
            New RequestHandlerByUrlCondition(
                Function(uri As Uri)
                    Return uri.ToString().Contains("get-started/writing-on-github", StringComparison.OrdinalIgnoreCase)
                End Function)
        Me.ChromiumWebBrowser_GitHubMdSyntax.LoadUrlAsync(Urls.UrlGitHubMdSyntax)

        ' ChatGPT
        'Me.ChromiumWebBrowser_ChatGPT.RequestHandler =
        '    New RequestHandlerRestrictedToHostName(Urls.UrlChatGPT)
        Me.ChromiumWebBrowser_ChatGPT.LoadUrlAsync(Urls.UrlChatGPT)


#Enable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed

    End Sub

#End Region

End Class

#End Region
