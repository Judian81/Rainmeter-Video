Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private playstate As String

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
        '------
        'get rid of the alt+tab row
        ShowInTaskbar = False
        Dim Form1 As New Form()
        Form1.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Form1.ShowInTaskbar = False
        Owner = Form1
        '------
        Dim argcount As Integer, url As String, position As Integer, positiontemp As String, duration As String, imagelocation As String
        duration = ""
        argcount = 0
        url = ""
        positiontemp = ""
        position = 0
        imagelocation = ""
        'Me.Text = Me.Handle.ToString()
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
                        ElseIf url <> "" Then
                            AxWindowsMediaPlayer1.Visible = True
                            Dim shell As New Shell32.Shell
                            Dim objFolder As Shell32.Folder
                            Dim objFile As Shell32.FolderItem
                            Dim FileNameFromUrl As String = FileName(url)
                            Dim FolderLocationFromUrl As String = PathName(url)
                            Dim Width As Integer, Height As Integer, AspectRatio As Integer
                            objFolder = shell.NameSpace(FolderLocationFromUrl)
                            objFile = objFolder.Items.Item(FileNameFromUrl)
                            Height = objFolder.GetDetailsOf(objFile, 314)
                            Width = objFolder.GetDetailsOf(objFile, 316)
                            AspectRatio = Width / Height
                            Me.PictureBox2.Height = Me.Height / AspectRatio / 2 - 5
                            Me.PictureBox3.Top = 0
                            Me.PictureBox3.Height = Me.Height / AspectRatio / 2 - 5
                            Me.PictureBox3.Top = Me.Height - Me.PictureBox3.Height
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
                        If arg = "Pause.png" And playstate = "Pause.png" Then
                            playstate = "Play.png"
                        ElseIf arg <> "" Then
                            playstate = arg
                        End If
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
                            If (playstate = "Play.png" Or playstate = "Next.png" Or playstate = "Previous.png") And duration <> "0:00" And duration <> "" Then
                                AxWindowsMediaPlayer1.URL = url
                                AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                                AxWindowsMediaPlayer1.Ctlcontrols.play()
                            ElseIf playstate = "Stop.png" Then
                                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                            ElseIf duration <> "" Or playstate = "Pause.png" Then
                                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                            End If
                        End If
                End Select
            Next
        End If
    End Sub

    'this is meant to remove the file that is selected like this "C:\like\you\file.exe" and give you the pathname in return
    Function PathName(vZ As String) As String
        Dim vA As Integer, stemppath As String
        stemppath = ""
        'loop through every char to find when the folder is all that is left
        For vA = Len(vZ) To 1 Step -1
            'it looks for char \
            If Mid(vZ, vA, 1) = "\" Then
                'this is what we wanted "C:\like\you\", ended up with the path without the file
                stemppath = Microsoft.VisualBasic.Left(vZ, vA)
                Exit For
            End If
        Next vA
        Return stemppath
        'warning: if you is a directory and you do not use a "\" at the end than i gots messy and then that is what you get "C:\like\" missing the folder "you"
    End Function

    'if you want the file name from a directory string you can use it like "c:\bravo.com"
    Function FileName(vZ As String) As String
        Dim vA As Integer, sFileName As String
        sFileName = ""
        For vA = Len(vZ) To 1 Step -1
            'first we have to find the extension and remove it from the string
            'If Mid(vZ, vA, 1) = "." Then
            'sFileName = Microsoft.VisualBasic.Left(vZ, vA - 1)
            'Exit For
            'End If
        Next vA
        If sFileName = "" Then
            sFileName = vZ
        End If
        'so now the filename and directory is left. so we have to figur out when the path is beginning and remove that too.
        For vA = Len(sFileName) To 1 Step -1
            If Mid(sFileName, vA, 1) = "\" Then
                'path removed, file extension removed. al we have left is the name of the file
                sFileName = Microsoft.VisualBasic.Right(sFileName, Len(sFileName) - vA)
                Exit For
            End If
        Next vA
        Return sFileName
    End Function

    Private Sub Me_StartupNextInstance(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
        Dim argcount As Integer, url As String, position As Integer, positiontemp As String, duration As String, imagelocation As String, videotop As Integer, videoleft As Integer
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
                        ElseIf url <> "" Then
                            AxWindowsMediaPlayer1.Visible = True
                            Dim shell As New Shell32.Shell
                            Dim objFolder As Shell32.Folder
                            Dim objFile As Shell32.FolderItem
                            Dim FileNameFromUrl As String = FileName(url)
                            Dim FolderLocationFromUrl As String = PathName(url)
                            Dim Width As Integer, Height As Integer, AspectRatio As Integer
                            objFolder = shell.NameSpace(FolderLocationFromUrl)
                            objFile = objFolder.Items.Item(FileNameFromUrl)
                            Height = objFolder.GetDetailsOf(objFile, 314)
                            Width = objFolder.GetDetailsOf(objFile, 316)
                            AspectRatio = Width / Height
                            Me.PictureBox2.Height = Me.Height / AspectRatio / 2 - 5
                            Me.PictureBox3.Top = 0
                            Me.PictureBox3.Height = Me.Height / AspectRatio / 2 - 5
                            Me.PictureBox3.Top = Me.Height - Me.PictureBox3.Height
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
                        If arg = "Pause.png" And playstate = "Pause.png" Then
                            playstate = "Play.png"
                        ElseIf arg <> "" Then
                            playstate = arg
                        End If
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
                            If duration = "0:00" Then
                                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                            ElseIf playstate = "Play.png" Then
                                AxWindowsMediaPlayer1.URL = url
                                AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                                AxWindowsMediaPlayer1.Ctlcontrols.play()
                            ElseIf playstate = "Stop.png" Then
                                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                            ElseIf playstate = "Pause.png" Then
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
        Me.PictureBox2.Top = 0
        Me.PictureBox2.Width = Me.Width
        Me.PictureBox3.Width = Me.Width
        Me.PictureBox4.Top = 0
        Me.PictureBox4.Left = 0
        Me.PictureBox4.Height = Me.Height
        Me.PictureBox5.Top = 0
        Me.PictureBox5.Left = Me.Width - Me.PictureBox5.Width
        Me.PictureBox5.Height = Me.Height
        AxWindowsMediaPlayer1.Left = 0
        AxWindowsMediaPlayer1.Top = 0
        AxWindowsMediaPlayer1.Width = Me.Width
        AxWindowsMediaPlayer1.Height = Me.Height
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
End Class