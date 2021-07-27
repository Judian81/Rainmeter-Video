Imports System
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'when the application is closing, remove the handler to the Application`s StartupNextInstance event
        RemoveHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'add a handler to the Application`s StartupNextInstance event
        AddHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
        'get the arguments passed to the applications command line arguments. This will be the filename of the
        'file that was double clicked which will open the first instance of your program.
        Dim argcount As Integer, url As String, position As Integer, positiontemp As String, pause As String, duration As String
        duration = ""
        pause = ""
        argcount = 0
        url = ""
        positiontemp = ""
        position = 0
        AxWindowsMediaPlayer1.settings.mute = True
        AxWindowsMediaPlayer1.settings.volume = 0
        If My.Application.CommandLineArgs.Count > 0 Then
            For Each arg As String In My.Application.CommandLineArgs
                argcount += 1
                Select Case argcount
                    Case 1
                        url = arg
                        If Strings.Right(url, 4) = ".3gp" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".aa" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".aac" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".aax" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".act" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".aiff" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".alac" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".amr" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".ape" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".au" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".awb" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".dss" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".dvf" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".flac" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".gsm" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 6) = ".iklax" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".ivs" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".m4a" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".m4b" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".m4p" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".mmf" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".mp3" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".mpc" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".msv" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".nmf" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".ogg" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".oga" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".mogg" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".opus" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".ra" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".rm" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".raw" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".rf64" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".sln" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".tta" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".voc" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".vox" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".wav" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".wma" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".wv" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".webm" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".8svx" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".cda" Then
                            AxWindowsMediaPlayer1.Visible = False
                        Else
                            AxWindowsMediaPlayer1.Visible = True
                        End If
                    Case 2
                        positiontemp = arg
                        position = Split(positiontemp, ":")(0) * 60 + Split(positiontemp, ":")(1)
                    Case 3
                        Me.Left = arg + 10
                        AxWindowsMediaPlayer1.Left = 0
                    Case 4
                        Me.Top = arg + 193
                        AxWindowsMediaPlayer1.Top = 0
                    Case 5
                        Me.Width = arg
                        AxWindowsMediaPlayer1.Width = Me.Width
                    Case 6
                        Me.Height = arg
                        AxWindowsMediaPlayer1.Height = Me.Height
                    Case 7
                        pause = arg
                    Case 8
                        Me.PictureBox1.ImageLocation = arg
                    Case 9
                        duration = arg
                        If pause = "Pause.png" And duration <> "0:00" Then
                            AxWindowsMediaPlayer1.URL = url
                            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                            AxWindowsMediaPlayer1.Ctlcontrols.play()
                        Else
                            AxWindowsMediaPlayer1.Ctlcontrols.pause()
                        End If
                End Select
            Next
        End If
    End Sub

    'this is the handler for the Application`s StartupNextInstance event
    Private Sub Me_StartupNextInstance(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
        'get the command line arguments that where passed to this application when the user double clicks on
        'a file and your application is already opened.
        Dim argcount As Integer, url As String, position As Integer, positiontemp As String, pause As String, duration As String
        duration = ""
        pause = ""
        argcount = 0
        url = ""
        positiontemp = ""
        position = 0
        If e.CommandLine.Count > 0 Then
            For Each arg As String In e.CommandLine
                argcount += 1
                Select Case argcount
                    Case 1
                        url = arg
                        If Strings.Right(url, 4) = ".3gp" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".aa" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".aac" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".aax" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".act" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".aiff" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".alac" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".amr" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".ape" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".au" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".awb" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".dss" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".dvf" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".flac" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".gsm" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 6) = ".iklax" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".ivs" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".m4a" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".m4b" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".m4p" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".mmf" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".mp3" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".mpc" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".msv" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".nmf" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".ogg" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".oga" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".mogg" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".opus" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".ra" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".rm" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".raw" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".rf64" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".sln" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".tta" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".voc" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".vox" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".wav" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".wma" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 3) = ".wv" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".webm" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 5) = ".8svx" Then
                            AxWindowsMediaPlayer1.Visible = False
                        ElseIf Strings.Right(url, 4) = ".cda" Then
                            AxWindowsMediaPlayer1.Visible = False
                        Else
                            AxWindowsMediaPlayer1.Visible = True
                        End If
                    Case 2
                        positiontemp = arg
                        position = Split(positiontemp, ":")(0) * 60 + Split(positiontemp, ":")(1)
                    Case 3
                        Me.Left = arg + 10
                        AxWindowsMediaPlayer1.Left = 0
                    Case 4
                        Me.Top = arg + 193
                        AxWindowsMediaPlayer1.Top = 0
                    Case 5
                        Me.Width = arg
                        AxWindowsMediaPlayer1.Width = Me.Width
                    Case 6
                        Me.Height = arg
                        AxWindowsMediaPlayer1.Height = Me.Height
                    Case 7
                        pause = arg
                    Case 8
                        Me.PictureBox1.ImageLocation = arg
                    Case 9
                        duration = arg
                        If pause = "Pause.png" And duration <> "0:00" Then
                            AxWindowsMediaPlayer1.URL = url
                            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                            AxWindowsMediaPlayer1.Ctlcontrols.play()
                        Else
                            AxWindowsMediaPlayer1.Ctlcontrols.pause()
                        End If
                End Select
            Next
        End If
        'if the app is minimized then restore it
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
        'if the app is in the background then bring it to the foreground
        'e.BringToForeground = False
    End Sub
End Class