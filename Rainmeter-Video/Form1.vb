Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private playstate As String
    Private playposition As String = "0"

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
        Me.AxWindowsMediaPlayer1.Visible = False
        Me.PictureBox1.Visible = True
        Me.PictureBox1.ImageLocation = Application.StartupPath() & "\Default.png"
        Me.Label1.Visible = False
        Me.Timer1.Enabled = False
    End Sub

    Private Sub Me_StartupNextInstance(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
        Dim argcount As Integer, url As String, videotop As Integer, videoleft As Integer, imagelocation As String, duration As String
        argcount = 0
        url = ""
        duration = ""
        If e.CommandLine.Count > 0 Then
            For Each arg As String In e.CommandLine
                argcount += 1
                Select Case argcount
                    Case 1
                        If arg = "" Then
                            Exit Select
                        End If
                        url = arg
                        If url = "foo" Then
                            MsgBox("bar")
                            Exit Sub
                        End If
                        If url = "Set Position" Then
                            Exit Select
                        End If
                        If url = "No Video" Then
                            Me.AxWindowsMediaPlayer1.Visible = False
                            Me.AxWindowsMediaPlayer1.Ctlcontrols.stop()
                            Exit Select
                        End If
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
                            AxWindowsMediaPlayer1.URL = url
                        End If
                    Case 2
                        If arg <> "" Then
                            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Split(arg, ":")(0) * 60 + Split(arg, ":")(1) + 1
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
                        If url = "Set Position" Then
                            Exit Sub
                        End If
                    Case 7
                        If arg <> "" Then
                            playstate = arg
                        End If
                    Case 8
                        If arg <> "" Then
                            imagelocation = arg
                            Me.PictureBox1.ImageLocation = imagelocation
                        End If
                        If url = "No Video" Then
                            Exit Sub
                        End If
                    Case 9
                        If arg <> "" Then
                            duration = arg
                        End If
                End Select
            Next
            If AxWindowsMediaPlayer1.Visible = True Then
                If playstate = "Stop.png" Then
                    Me.AxWindowsMediaPlayer1.Ctlcontrols.stop()
                ElseIf playstate = "Play.png" Then
                    Me.AxWindowsMediaPlayer1.Ctlcontrols.play()
                ElseIf playstate = "Pause.png" Then
                    Me.AxWindowsMediaPlayer1.Ctlcontrols.pause()
                End If
            End If
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

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.Text = Split(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition, ",")(0)
    End Sub

End Class