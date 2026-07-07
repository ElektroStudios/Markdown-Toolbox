#Region " Imports "

Imports System.Text

Imports Microsoft.VisualBasic.ApplicationServices

#End Region

#Region " MyApplication "

Namespace My

    Partial Friend Class MyApplication

#Region " Event-Handlers "

        ''' <summary>
        ''' Handles the <see cref="WindowsFormsApplicationBase.Startup"/> event for this application,
        ''' which is raised when the application starts, before the startup form is created.
        ''' </summary>
        <DebuggerStepThrough>
        Private Shared Sub Application_Startup() Handles Me.Startup

            Try
                JotUtil.InitializeJot()

            Catch ex As Exception
                MyApplication.ShowErrorMessageAndExitApplication(
                    "Jot failure. Method 'JotUtil.InitializeJot' failed with exception message: " & Environment.NewLine &
                    ex.Message)

            End Try

            Try
                Dim cefSharpSuccess As Boolean = CefSharpUtil.InitializeCefsharp()
                If Not cefSharpSuccess Then
                    MyApplication.ShowErrorMessageAndExitApplication(
                        "CefSharp failure. Method 'Cef.Initialized' failed," & Environment.NewLine &
                        "check the 'CefSharp.log' log file for more details.")

                End If

            Catch ex As Exception
                MyApplication.ShowErrorMessageAndExitApplication(
                    "CefSharp failure. Method 'CefSharpUtil.InitializeCefsharp' failed with exception message: " & Environment.NewLine &
                    ex.Message)

            End Try
        End Sub

#End Region

        ''' <summary>
        ''' Shows a <see cref="MessageBox"/> with the provided error message, and exits the application with exit code 1.
        ''' </summary>
        ''' 
        ''' <param name="errMsg">
        ''' The error message.
        ''' </param>
        <DebuggerStepThrough>
        Private Shared Sub ShowErrorMessageAndExitApplication(errMsg As String)
            MessageBox.Show(Nothing, errMsg, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Environment.Exit(1)
        End Sub

    End Class

End Namespace

#End Region
