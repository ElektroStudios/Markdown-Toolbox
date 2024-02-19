#Region " Option Statements "

Option Explicit On
Option Strict On
Option Infer Off

#End Region

#Region " Imports "

Imports Microsoft.VisualBasic.ApplicationServices

Imports Jot
Imports Jot.Configuration
Imports Jot.Storage

#End Region
''' <summary>
''' Provides JOT related utilities.
''' </summary>
Friend Module JotUtil

#Region " Fields "

    ''' <summary>
    ''' The object responsible for tracking the specified properties of the specified target objects
    ''' in <see cref="JotUtil.formTrackingConfig"/> and <see cref="JotUtil.menuItemTrackingConfig"/>.
    ''' <para></para>
    ''' Tracking means persisting the values of the specified object properties,
    ''' and restoring this data when appropriate.
    ''' </summary>
    Private jotTracker As Tracker

    ''' <summary>
    ''' The object that determines how a target <see cref="Form"/> will be tracked. 
    ''' <para></para>
    ''' This includes list of properties to track, persist triggers and id getter.
    ''' </summary>
    Private formTrackingConfig As TrackingConfiguration(Of Form)

    ''' <summary>
    ''' The object that determines how a target <see cref="ToolStripMenuItem"/> will be tracked. 
    ''' <para></para>
    ''' This includes list of properties to track, persist triggers and id getter.
    ''' </summary>
    Private menuItemTrackingConfig As TrackingConfiguration(Of ToolStripMenuItem)

#End Region

#Region " Public Methods "

    ''' <summary>
    ''' Initializes JOT environment.
    ''' <para></para>
    ''' This method should be called on your main application thread (typically the UI thread)
    ''' and typically from the <see cref="WindowsFormsApplicationBase.Startup"/> event,
    ''' before the <see cref="MainForm"/> form is loaded.
    ''' </summary>
    <DebuggerStepperBoundary>
    Friend Sub InitializeJot()

        JotUtil.jotTracker = New Tracker()
        DirectCast(JotUtil.jotTracker.Store, JsonFileStore).FolderPath = Paths.JotCachePath

        JotUtil.formTrackingConfig = JotUtil.jotTracker.Configure(Of Form)
        With JotUtil.formTrackingConfig
            .Id(Function(f As Form) f.Name, SystemInformation.VirtualScreen.Size)
            .Properties(Function(f As Form) New With {f.Top, f.Width, f.Height, f.Left, f.WindowState})
            .PersistOn(NameOf(Form.Move), NameOf(Form.Resize), NameOf(Form.FormClosing))
            .WhenPersistingProperty(
                Sub(f As Form, pod As PropertyOperationData)
                    pod.Cancel = f.WindowState <> FormWindowState.Normal AndAlso
                               (pod.Property = NameOf(Form.Height) OrElse
                                pod.Property = NameOf(Form.Width) OrElse
                                pod.Property = NameOf(Form.Top) OrElse
                                pod.Property = NameOf(Form.Left))
                End Sub)
            .StopTrackingOn(NameOf(Form.FormClosing))
        End With

        JotUtil.menuItemTrackingConfig = JotUtil.jotTracker.Configure(Of ToolStripMenuItem)
        With JotUtil.menuItemTrackingConfig
            .Id(Function(i As ToolStripMenuItem) i.Name)
            .Properties(Function(i As ToolStripMenuItem) New With {i.Checked})
            .PersistOn(NameOf(ToolStripMenuItem.CheckedChanged))
            .StopTrackingOn(NameOf(ToolStripMenuItem.Disposed))
        End With

    End Sub

    ''' <summary>
    ''' Starts tracking the size and location of the <see cref="MainForm"/> form.
    ''' <para></para>
    ''' This method should be called in <see cref="MainForm.Load"/> event handler.
    ''' </summary>
    <DebuggerStepThrough>
    Friend Sub StartTrackingForm()
        JotUtil.formTrackingConfig.Track(My.Forms.MainForm)
    End Sub

    ''' <summary>
    ''' Starts tracking the <see cref="ToolStripMenuItem"/> checked states.
    ''' <para></para>
    ''' This method should be called in <see cref="MainForm.Shown"/> event handler, 
    ''' after the ChromiumWebBrowser is initialized.
    ''' </summary>
    <DebuggerStepThrough>
    Friend Sub StartTrackingMenuItems()
        JotUtil.menuItemTrackingConfig.Track(My.Forms.MainForm.EnableSpellCheckToolStripMenuItem)
    End Sub

#End Region

End Module
