<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolStrip1 = New ToolStrip()
        Me.ToolStripDropDownButton_File = New ToolStripDropDownButton()
        Me.ReloadCurrentWebpageToolStripMenuItem = New ToolStripMenuItem()
        Me.ExitAplicationToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator1 = New ToolStripSeparator()
        Me.ToolStripDropDownButton_Settings = New ToolStripDropDownButton()
        Me.EnableSpellCheckToolStripMenuItem = New ToolStripMenuItem()
        Me.EnableDarkModeToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator2 = New ToolStripSeparator()
        Me.ToolStripButton_About = New ToolStripButton()
        Me.TabControl1 = New TabControl()
        Me.TabPage_MdEditor = New TabPage()
        Me.ChromiumWebBrowser_MdEditor = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.TabPage_MdToHtml = New TabPage()
        Me.ChromiumWebBrowser_MdToHtml = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.TabPage_HtmlToMd = New TabPage()
        Me.ChromiumWebBrowser_HtmlToMD = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.TabPage_TableToMd = New TabPage()
        Me.ChromiumWebBrowser_TableToMd = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.TabPage_MdGuide = New TabPage()
        Me.ChromiumWebBrowser_MdGuide = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.TabPage_GitHubMdSyntax = New TabPage()
        Me.ChromiumWebBrowser_GitHubMdSyntax = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.TabPage_ChatGPT = New TabPage()
        Me.ChromiumWebBrowser_ChatGPT = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_MdEditor.SuspendLayout()
        Me.TabPage_MdToHtml.SuspendLayout()
        Me.TabPage_HtmlToMd.SuspendLayout()
        Me.TabPage_TableToMd.SuspendLayout()
        Me.TabPage_MdGuide.SuspendLayout()
        Me.TabPage_GitHubMdSyntax.SuspendLayout()
        Me.TabPage_ChatGPT.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        Me.ToolStrip1.BackColor = SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripDropDownButton_File, Me.ToolStripSeparator1, Me.ToolStripDropDownButton_Settings, Me.ToolStripSeparator2, Me.ToolStripButton_About})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripDropDownButton_File
        ' 
        Me.ToolStripDropDownButton_File.DropDownItems.AddRange(New ToolStripItem() {Me.ReloadCurrentWebpageToolStripMenuItem, Me.ExitAplicationToolStripMenuItem})
        Me.ToolStripDropDownButton_File.Image = My.Resources.Resources.Document
        Me.ToolStripDropDownButton_File.ImageTransparentColor = Color.Magenta
        Me.ToolStripDropDownButton_File.Name = "ToolStripDropDownButton_File"
        Me.ToolStripDropDownButton_File.Size = New Size(54, 22)
        Me.ToolStripDropDownButton_File.Text = "File"
        Me.ToolStripDropDownButton_File.ToolTipText = " File"
        ' 
        ' ReloadCurrentWebpageToolStripMenuItem
        ' 
        Me.ReloadCurrentWebpageToolStripMenuItem.Image = My.Resources.Resources.Refresh
        Me.ReloadCurrentWebpageToolStripMenuItem.Name = "ReloadCurrentWebpageToolStripMenuItem"
        Me.ReloadCurrentWebpageToolStripMenuItem.Size = New Size(180, 22)
        Me.ReloadCurrentWebpageToolStripMenuItem.Text = "Reload current page"
        Me.ReloadCurrentWebpageToolStripMenuItem.ToolTipText = "Reloads the current webpage"
        ' 
        ' ExitAplicationToolStripMenuItem
        ' 
        Me.ExitAplicationToolStripMenuItem.Image = My.Resources.Resources.Close
        Me.ExitAplicationToolStripMenuItem.Name = "ExitAplicationToolStripMenuItem"
        Me.ExitAplicationToolStripMenuItem.Size = New Size(180, 22)
        Me.ExitAplicationToolStripMenuItem.Text = "Exit"
        Me.ExitAplicationToolStripMenuItem.ToolTipText = "Close Application"
        ' 
        ' ToolStripSeparator1
        ' 
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' ToolStripDropDownButton_Settings
        ' 
        Me.ToolStripDropDownButton_Settings.DropDownItems.AddRange(New ToolStripItem() {Me.EnableSpellCheckToolStripMenuItem, Me.EnableDarkModeToolStripMenuItem})
        Me.ToolStripDropDownButton_Settings.Image = My.Resources.Resources.Settings
        Me.ToolStripDropDownButton_Settings.ImageTransparentColor = Color.Magenta
        Me.ToolStripDropDownButton_Settings.Name = "ToolStripDropDownButton_Settings"
        Me.ToolStripDropDownButton_Settings.Size = New Size(78, 22)
        Me.ToolStripDropDownButton_Settings.Text = "Settings"
        ' 
        ' EnableSpellCheckToolStripMenuItem
        ' 
        Me.EnableSpellCheckToolStripMenuItem.Checked = True
        Me.EnableSpellCheckToolStripMenuItem.CheckOnClick = True
        Me.EnableSpellCheckToolStripMenuItem.CheckState = CheckState.Checked
        Me.EnableSpellCheckToolStripMenuItem.Image = My.Resources.Resources.SpellCheck
        Me.EnableSpellCheckToolStripMenuItem.Name = "EnableSpellCheckToolStripMenuItem"
        Me.EnableSpellCheckToolStripMenuItem.Size = New Size(215, 22)
        Me.EnableSpellCheckToolStripMenuItem.Text = "Enable Spell Check"
        Me.EnableSpellCheckToolStripMenuItem.ToolTipText = "Enable Spell Check"
        ' 
        ' EnableDarkModeToolStripMenuItem
        ' 
        Me.EnableDarkModeToolStripMenuItem.CheckOnClick = True
        Me.EnableDarkModeToolStripMenuItem.Image = My.Resources.Resources.DarkTheme
        Me.EnableDarkModeToolStripMenuItem.Name = "EnableDarkModeToolStripMenuItem"
        Me.EnableDarkModeToolStripMenuItem.Size = New Size(215, 22)
        Me.EnableDarkModeToolStripMenuItem.Text = "Enable Dark Mode Browser"
        Me.EnableDarkModeToolStripMenuItem.ToolTipText = "Enables dark mode" & vbCrLf & vbCrLf & "( you must realod the webpage to take effect )"
        ' 
        ' ToolStripSeparator2
        ' 
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' ToolStripButton_About
        ' 
        Me.ToolStripButton_About.Image = My.Resources.Resources.InfoTipInline_11_11
        Me.ToolStripButton_About.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton_About.Name = "ToolStripButton_About"
        Me.ToolStripButton_About.Size = New Size(69, 22)
        Me.ToolStripButton_About.Text = "About..."
        ' 
        ' TabControl1
        ' 
        Me.TabControl1.Controls.Add(Me.TabPage_MdEditor)
        Me.TabControl1.Controls.Add(Me.TabPage_MdToHtml)
        Me.TabControl1.Controls.Add(Me.TabPage_HtmlToMd)
        Me.TabControl1.Controls.Add(Me.TabPage_TableToMd)
        Me.TabControl1.Controls.Add(Me.TabPage_MdGuide)
        Me.TabControl1.Controls.Add(Me.TabPage_GitHubMdSyntax)
        Me.TabControl1.Controls.Add(Me.TabPage_ChatGPT)
        Me.TabControl1.Dock = DockStyle.Fill
        Me.TabControl1.Location = New Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New Size(800, 425)
        Me.TabControl1.TabIndex = 2
        ' 
        ' TabPage_MdEditor
        ' 
        Me.TabPage_MdEditor.Controls.Add(Me.ChromiumWebBrowser_MdEditor)
        Me.TabPage_MdEditor.Location = New Point(4, 24)
        Me.TabPage_MdEditor.Name = "TabPage_MdEditor"
        Me.TabPage_MdEditor.Padding = New Padding(3)
        Me.TabPage_MdEditor.Size = New Size(792, 397)
        Me.TabPage_MdEditor.TabIndex = 0
        Me.TabPage_MdEditor.Text = "MD Editor"
        Me.TabPage_MdEditor.ToolTipText = "Markdown Editor"
        Me.TabPage_MdEditor.UseVisualStyleBackColor = True
        ' 
        ' ChromiumWebBrowser_MdEditor
        ' 
        Me.ChromiumWebBrowser_MdEditor.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser_MdEditor.Dock = DockStyle.Fill
        Me.ChromiumWebBrowser_MdEditor.Location = New Point(3, 3)
        Me.ChromiumWebBrowser_MdEditor.Name = "ChromiumWebBrowser_MdEditor"
        Me.ChromiumWebBrowser_MdEditor.Size = New Size(786, 391)
        Me.ChromiumWebBrowser_MdEditor.TabIndex = 0
        ' 
        ' TabPage_MdToHtml
        ' 
        Me.TabPage_MdToHtml.Controls.Add(Me.ChromiumWebBrowser_MdToHtml)
        Me.TabPage_MdToHtml.Location = New Point(4, 24)
        Me.TabPage_MdToHtml.Name = "TabPage_MdToHtml"
        Me.TabPage_MdToHtml.Padding = New Padding(3)
        Me.TabPage_MdToHtml.Size = New Size(792, 397)
        Me.TabPage_MdToHtml.TabIndex = 1
        Me.TabPage_MdToHtml.Text = "MD > HTML"
        Me.TabPage_MdToHtml.ToolTipText = "Convert Markdown to Html"
        Me.TabPage_MdToHtml.UseVisualStyleBackColor = True
        ' 
        ' ChromiumWebBrowser_MdToHtml
        ' 
        Me.ChromiumWebBrowser_MdToHtml.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser_MdToHtml.Dock = DockStyle.Fill
        Me.ChromiumWebBrowser_MdToHtml.Location = New Point(3, 3)
        Me.ChromiumWebBrowser_MdToHtml.Name = "ChromiumWebBrowser_MdToHtml"
        Me.ChromiumWebBrowser_MdToHtml.Size = New Size(786, 391)
        Me.ChromiumWebBrowser_MdToHtml.TabIndex = 0
        ' 
        ' TabPage_HtmlToMd
        ' 
        Me.TabPage_HtmlToMd.Controls.Add(Me.ChromiumWebBrowser_HtmlToMD)
        Me.TabPage_HtmlToMd.Location = New Point(4, 24)
        Me.TabPage_HtmlToMd.Name = "TabPage_HtmlToMd"
        Me.TabPage_HtmlToMd.Size = New Size(792, 397)
        Me.TabPage_HtmlToMd.TabIndex = 3
        Me.TabPage_HtmlToMd.Text = "HTML > MD"
        Me.TabPage_HtmlToMd.ToolTipText = "Convert Html to Markdown"
        Me.TabPage_HtmlToMd.UseVisualStyleBackColor = True
        ' 
        ' ChromiumWebBrowser_HtmlToMD
        ' 
        Me.ChromiumWebBrowser_HtmlToMD.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser_HtmlToMD.Dock = DockStyle.Fill
        Me.ChromiumWebBrowser_HtmlToMD.Location = New Point(0, 0)
        Me.ChromiumWebBrowser_HtmlToMD.Name = "ChromiumWebBrowser_HtmlToMD"
        Me.ChromiumWebBrowser_HtmlToMD.Size = New Size(792, 397)
        Me.ChromiumWebBrowser_HtmlToMD.TabIndex = 0
        ' 
        ' TabPage_TableToMd
        ' 
        Me.TabPage_TableToMd.Controls.Add(Me.ChromiumWebBrowser_TableToMd)
        Me.TabPage_TableToMd.Location = New Point(4, 24)
        Me.TabPage_TableToMd.Name = "TabPage_TableToMd"
        Me.TabPage_TableToMd.Padding = New Padding(3)
        Me.TabPage_TableToMd.Size = New Size(792, 397)
        Me.TabPage_TableToMd.TabIndex = 2
        Me.TabPage_TableToMd.Text = "Table > MD"
        Me.TabPage_TableToMd.ToolTipText = "Convert table to Markdown"
        Me.TabPage_TableToMd.UseVisualStyleBackColor = True
        ' 
        ' ChromiumWebBrowser_TableToMd
        ' 
        Me.ChromiumWebBrowser_TableToMd.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser_TableToMd.Dock = DockStyle.Fill
        Me.ChromiumWebBrowser_TableToMd.Location = New Point(3, 3)
        Me.ChromiumWebBrowser_TableToMd.Name = "ChromiumWebBrowser_TableToMd"
        Me.ChromiumWebBrowser_TableToMd.Size = New Size(786, 391)
        Me.ChromiumWebBrowser_TableToMd.TabIndex = 0
        ' 
        ' TabPage_MdGuide
        ' 
        Me.TabPage_MdGuide.Controls.Add(Me.ChromiumWebBrowser_MdGuide)
        Me.TabPage_MdGuide.Location = New Point(4, 24)
        Me.TabPage_MdGuide.Name = "TabPage_MdGuide"
        Me.TabPage_MdGuide.Size = New Size(792, 397)
        Me.TabPage_MdGuide.TabIndex = 4
        Me.TabPage_MdGuide.Text = "MD Guide"
        Me.TabPage_MdGuide.ToolTipText = "Markdown Guide"
        Me.TabPage_MdGuide.UseVisualStyleBackColor = True
        ' 
        ' ChromiumWebBrowser_MdGuide
        ' 
        Me.ChromiumWebBrowser_MdGuide.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser_MdGuide.Dock = DockStyle.Fill
        Me.ChromiumWebBrowser_MdGuide.Location = New Point(0, 0)
        Me.ChromiumWebBrowser_MdGuide.Name = "ChromiumWebBrowser_MdGuide"
        Me.ChromiumWebBrowser_MdGuide.Size = New Size(792, 397)
        Me.ChromiumWebBrowser_MdGuide.TabIndex = 0
        ' 
        ' TabPage_GitHubMdSyntax
        ' 
        Me.TabPage_GitHubMdSyntax.Controls.Add(Me.ChromiumWebBrowser_GitHubMdSyntax)
        Me.TabPage_GitHubMdSyntax.Location = New Point(4, 24)
        Me.TabPage_GitHubMdSyntax.Name = "TabPage_GitHubMdSyntax"
        Me.TabPage_GitHubMdSyntax.Size = New Size(792, 397)
        Me.TabPage_GitHubMdSyntax.TabIndex = 5
        Me.TabPage_GitHubMdSyntax.Text = "GitHub MD Syntax"
        Me.TabPage_GitHubMdSyntax.ToolTipText = "GitHub's Markdown Syntax"
        Me.TabPage_GitHubMdSyntax.UseVisualStyleBackColor = True
        ' 
        ' ChromiumWebBrowser_GitHubMdSyntax
        ' 
        Me.ChromiumWebBrowser_GitHubMdSyntax.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser_GitHubMdSyntax.Dock = DockStyle.Fill
        Me.ChromiumWebBrowser_GitHubMdSyntax.Location = New Point(0, 0)
        Me.ChromiumWebBrowser_GitHubMdSyntax.Name = "ChromiumWebBrowser_GitHubMdSyntax"
        Me.ChromiumWebBrowser_GitHubMdSyntax.Size = New Size(792, 397)
        Me.ChromiumWebBrowser_GitHubMdSyntax.TabIndex = 0
        ' 
        ' TabPage_ChatGPT
        ' 
        Me.TabPage_ChatGPT.Controls.Add(Me.ChromiumWebBrowser_ChatGPT)
        Me.TabPage_ChatGPT.Location = New Point(4, 24)
        Me.TabPage_ChatGPT.Name = "TabPage_ChatGPT"
        Me.TabPage_ChatGPT.Size = New Size(792, 397)
        Me.TabPage_ChatGPT.TabIndex = 6
        Me.TabPage_ChatGPT.Text = "ChatGPT"
        Me.TabPage_ChatGPT.ToolTipText = "ChatGPT"
        Me.TabPage_ChatGPT.UseVisualStyleBackColor = True
        ' 
        ' ChromiumWebBrowser_ChatGPT
        ' 
        Me.ChromiumWebBrowser_ChatGPT.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser_ChatGPT.Dock = DockStyle.Fill
        Me.ChromiumWebBrowser_ChatGPT.Location = New Point(0, 0)
        Me.ChromiumWebBrowser_ChatGPT.Name = "ChromiumWebBrowser_ChatGPT"
        Me.ChromiumWebBrowser_ChatGPT.Size = New Size(792, 397)
        Me.ChromiumWebBrowser_ChatGPT.TabIndex = 0
        ' 
        ' MainForm
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = SystemColors.Control
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "MainForm"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Markdown ToolBox"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_MdEditor.ResumeLayout(False)
        Me.TabPage_MdToHtml.ResumeLayout(False)
        Me.TabPage_HtmlToMd.ResumeLayout(False)
        Me.TabPage_TableToMd.ResumeLayout(False)
        Me.TabPage_MdGuide.ResumeLayout(False)
        Me.TabPage_GitHubMdSyntax.ResumeLayout(False)
        Me.TabPage_ChatGPT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton_Settings As ToolStripDropDownButton
    Friend WithEvents EnableSpellCheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton_About As ToolStripButton
    Friend WithEvents ToolStripDropDownButton_File As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_MdEditor As TabPage
    Friend WithEvents TabPage_MdToHtml As TabPage
    Friend WithEvents ChromiumWebBrowser_MdEditor As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents ChromiumWebBrowser_MdToHtml As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents TabPage_TableToMd As TabPage
    Friend WithEvents TabPage_HtmlToMd As TabPage
    Friend WithEvents TabPage_MdGuide As TabPage
    Friend WithEvents TabPage_GitHubMdSyntax As TabPage
    Friend WithEvents ChromiumWebBrowser_HtmlToMD As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents ChromiumWebBrowser_TableToMd As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents ChromiumWebBrowser_MdGuide As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents ChromiumWebBrowser_GitHubMdSyntax As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents TabPage_ChatGPT As TabPage
    Friend WithEvents ChromiumWebBrowser_ChatGPT As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents ExitAplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadCurrentWebpageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableDarkModeToolStripMenuItem As ToolStripMenuItem

End Class
