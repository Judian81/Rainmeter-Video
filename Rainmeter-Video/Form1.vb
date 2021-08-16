Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
        Dim argcount As Integer, url As String, position As Integer, positiontemp As String, pause As String, duration As String, imagelocation As String
        duration = ""
        pause = ""
        argcount = 0
        url = ""
        positiontemp = ""
        position = 0
        imagelocation = ""
        Me.Text = Me.Handle.ToString()
        AxWindowsMediaPlayer1.settings.mute = True
        AxWindowsMediaPlayer1.settings.volume = 0
        If My.Application.CommandLineArgs.Count > 0 Then
            For Each arg As String In My.Application.CommandLineArgs
                argcount += 1
                Select Case argcount
                    Case 1
                        url = arg
                        If url = "set position" Then
                            'do not a thing
                        ElseIf Strings.Right(url, 4) = ".3gp" Then
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
                        If url = "set position" Then
                            'do not a thing
                        ElseIf positiontemp <> "" Then
                            position = Split(positiontemp, ":")(0) * 60 + Split(positiontemp, ":")(1)
                        End If
                    Case 3
                        Me.Left = CInt(Val(arg))
                        AxWindowsMediaPlayer1.Left = 0
                    Case 4
                        Me.Top = CInt(Val(arg))
                        AxWindowsMediaPlayer1.Top = 0
                    Case 5
                        Me.Width = CInt(Val(arg))
                        AxWindowsMediaPlayer1.Width = Me.Width
                    Case 6
                        Me.Height = CInt(Val(arg))
                        AxWindowsMediaPlayer1.Height = Me.Height
                    Case 7
                        pause = arg
                    Case 8
                        imagelocation = arg
                        If url = "set position" Then
                            'do not a thing
                        ElseIf imagelocation <> "" Then
                            Me.PictureBox1.ImageLocation = imagelocation
                        End If
                    Case 9
                        duration = arg
                        If url <> "set position" Then
                            If pause = "Pause1.png" And duration <> "0:00" And duration <> "" Then
                                AxWindowsMediaPlayer1.URL = url
                                AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                                AxWindowsMediaPlayer1.Ctlcontrols.play()
                            ElseIf duration <> "" Then
                                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                            End If
                        End If
                End Select
            Next
        End If
    End Sub

    Private Sub Me_StartupNextInstance(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
        Dim argcount As Integer, url As String, position As Integer, positiontemp As String, pause As String, duration As String, imagelocation As String, videotop As Integer, videoleft As Integer
        pause = ""
        argcount = 0
        url = ""
        position = 0
        imagelocation = ""
        If e.CommandLine.Count > 0 Then
            For Each arg As String In e.CommandLine
                argcount += 1
                Select Case argcount
                    Case 1
                        url = arg
                        If url = "set position" Then
                            'do not a thing
                        ElseIf Strings.Right(url, 4) = ".3gp" Then
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
                        If url = "set position" Then
                            'do not a thing
                        ElseIf positiontemp <> "" Then
                            position = Split(positiontemp, ":")(0) * 60 + Split(positiontemp, ":")(1)
                        End If
                    Case 3
                        videoleft = CInt(Val(arg))
                        Me.Left = videoleft
                        AxWindowsMediaPlayer1.Left = 0
                    Case 4
                        videotop = CInt(Val(arg))
                        Me.Top = videotop
                        AxWindowsMediaPlayer1.Top = 0
                    Case 5
                        Me.Width = CInt(Val(arg))
                        AxWindowsMediaPlayer1.Width = Me.Width
                    Case 6
                        Me.Height = CInt(Val(arg))
                        AxWindowsMediaPlayer1.Height = Me.Height
                    Case 7
                        pause = arg
                    Case 8
                        imagelocation = arg
                        If url = "set position" Then
                            'do not a thing
                        ElseIf imagelocation <> "" Then
                            Me.PictureBox1.ImageLocation = imagelocation
                        End If
                    Case 9
                        duration = arg
                        If url <> "set position" Then
                            If pause = "Pause1.png" And duration <> "0:00" And duration <> "" Then
                                AxWindowsMediaPlayer1.URL = url
                                AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                                AxWindowsMediaPlayer1.Ctlcontrols.play()
                            ElseIf duration <> "" Then
                                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                            End If
                        End If
                End Select
            Next
        End If
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
        e.BringToForeground = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.PictureBox1.Left = 0
        Me.PictureBox1.Top = 0
        Me.PictureBox1.Width = Me.Width
        Me.PictureBox1.Height = Me.Height
        Me.AxWindowsMediaPlayer1.Left = 0
        Me.AxWindowsMediaPlayer1.Top = 0
        Me.AxWindowsMediaPlayer1.Width = Me.Width
        Me.AxWindowsMediaPlayer1.Height = Me.Height
    End Sub
End Class