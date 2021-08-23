Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private playstate As String
    Private playposition As String = "0:00"

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance

        ShowInTaskbar = False
        Dim Form1 As New Form With {
            .FormBorderStyle = FormBorderStyle.FixedToolWindow,
            .ShowInTaskbar = False
        }
        Owner = Form1

        AxWindowsMediaPlayer1.settings.mute = True
        AxWindowsMediaPlayer1.settings.volume = 0
        Me.Timer1.Enabled = False
    End Sub

    Private Sub Me_StartupNextInstance(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
        Dim argcount As Integer, url As String, position As Integer, videotop As Integer, videoleft As Integer, positiontemp As String, imagelocation As String, duration As String
        argcount = 0
        url = ""
        position = 0
        If e.CommandLine.Count > 0 Then
            For Each arg As String In e.CommandLine
                argcount += 1
                Select Case argcount
                    Case 1
                        url = arg
                        If url = "set position" Then
                            'do not a thing
                        ElseIf url = "sync position" Then
                            'do not a thing
                        ElseIf url = "sync new song" Then
                            Timer1.Enabled = True
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
                        ElseIf url <> "" Then
                            AxWindowsMediaPlayer1.Visible = True
                        End If
                    Case 2
                        If arg <> "" Then
                            positiontemp = arg
                            If url = "set position" Then
                                'do not a thing
                            ElseIf positiontemp <> "0" Then
                                position = Split(positiontemp, ":")(0) * 60 + Split(positiontemp, ":")(1)
                            End If
                        End If
                    Case 3
                        If arg <> "" Then
                            videoleft = CInt(Val(arg))
                            Me.Left = videoleft
                            AxWindowsMediaPlayer1.Left = 0
                        End If
                    Case 4
                        If arg <> "" Then
                            videotop = CInt(Val(arg))
                            Me.Top = videotop
                            AxWindowsMediaPlayer1.Top = 0
                        End If
                    Case 5
                        If arg <> "" Then
                            Me.Width = CInt(Val(arg))
                            AxWindowsMediaPlayer1.Width = Me.Width
                        End If
                    Case 6
                        If arg <> "" Then
                            Me.Height = CInt(Val(arg))
                            AxWindowsMediaPlayer1.Height = Me.Height
                        End If
                    Case 7
                        If arg = "Pause.png" And playstate = "Pause.png" Then
                            playstate = "Pause1.png"
                        ElseIf arg = "Pause.png" And playstate = "Pause1.png" Then
                            playstate = "Pause.png"
                        ElseIf arg <> "" Then
                            playstate = arg
                        End If
                    Case 8
                        If arg <> "" Then
                            imagelocation = arg
                            If url = "set position" Then
                                'do not a thing
                            ElseIf imagelocation <> "" Then
                                Me.PictureBox1.ImageLocation = imagelocation
                            End If
                        Else
                            Me.PictureBox1.ImageLocation = ""
                        End If
                    Case 9
                        If arg <> "" Then
                            duration = arg
                            If url <> "set position" Then
                                If duration = "0:00" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                                    Me.Timer1.Enabled = False
                                ElseIf playstate = "Play.png" Then
                                    AxWindowsMediaPlayer1.URL = url
                                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                                    Timer1.Enabled = True
                                ElseIf playstate = "Stop.png" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                                    Me.Timer1.Enabled = False
                                ElseIf playstate = "Pause.png" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.pause()
                                ElseIf playstate = "Pause1.png" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                                End If
                            End If
                        End If
                    Case 10
                        playposition = Split(arg, ":")(0) * 60 + Split(arg, ":")(1)
                        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = playposition
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
        AxWindowsMediaPlayer1.Left = 0
        AxWindowsMediaPlayer1.Top = 0
        AxWindowsMediaPlayer1.Width = Me.Width
        AxWindowsMediaPlayer1.Height = Me.Height
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.PictureBox1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static timerunning As Integer
        timerunning += 1
        If AxWindowsMediaPlayer1.Ctlcontrols.currentPosition >= 0.499 Then
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 0.9
            Timer1.Enabled = False
        End If
    End Sub
End Class