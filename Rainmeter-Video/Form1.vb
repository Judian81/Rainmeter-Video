Imports Microsoft.VisualBasic.ApplicationServices
'Imports System.Drawing.Imaging

Public Class Form1
    Private playstate As String
    Private playposition As String = "0:00"

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
        '------
        'get rid of the alt+tab row
        ShowInTaskbar = False
        Dim Form1 As New Form With {
            .FormBorderStyle = FormBorderStyle.FixedToolWindow,
            .ShowInTaskbar = False
        }
        Owner = Form1
        '------

        Me.Label3.Visible = True
        Me.Label1.Visible = True


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
                            'Dim shell As New Shell32.Shell, objFolder As Shell32.Folder, objFile As Shell32.FolderItem
                            'Dim FileNameFromUrl As String = FileName(url)
                            'Dim FolderLocationFromUrl As String = PathName(url)
                            'Dim Width As Integer, Height As Integer, AspectRatio As Double, NewWidth As Double, NewHeight As Double
                            'objFolder = shell.NameSpace(FolderLocationFromUrl)
                            'objFile = objFolder.Items.Item(FileNameFromUrl)
                            'Height = objFolder.GetDetailsOf(objFile, 314)
                            'Width = objFolder.GetDetailsOf(objFile, 316)

                            'AspectRatio = Width / Height
                            'If Width > Height And Width >= 188 Then
                            '    NewWidth = 188
                            '    NewHeight = 188 / AspectRatio
                            'ElseIf Height > Width And Height >= 188 Then
                            '    NewWidth = 188 / AspectRatio
                            '    NewHeight = 188
                            'End If

                            ''top location
                            'Me.PictureBox2.Top = 0
                            'Me.PictureBox2.Left = 0
                            'Me.PictureBox2.Width = Me.Width - 50
                            'Me.PictureBox2.Height = ((Me.Height - NewHeight) / 2)
                            'If Me.PictureBox2.Height = 0 Then
                            '    Me.PictureBox2.Height = 1
                            'End If
                            'If Me.PictureBox2.Width = 0 Then
                            '    Me.PictureBox2.Width = 1
                            'End If

                            ''bottom locationb
                            'Me.PictureBox3.Left = 0
                            'Me.PictureBox3.Width = Me.Width - 50
                            'Me.PictureBox3.Height = ((Me.Height - NewHeight) / 2)
                            'Me.PictureBox3.Top = Me.Height - Me.PictureBox3.Height
                            'If Me.PictureBox3.Height = 0 Then
                            '    Me.PictureBox3.Height = 1
                            'End If
                            'If Me.PictureBox3.Width = 0 Then
                            '    Me.PictureBox3.Width = 1
                            'End If

                            ''left side
                            'Me.PictureBox4.Top = 0
                            'Me.PictureBox4.Left = 0
                            'Me.PictureBox4.Height = Me.Height
                            'Me.PictureBox4.Width = ((Me.Width - NewWidth) / 2)
                            'If Me.PictureBox4.Height = 0 Then
                            '    Me.PictureBox4.Height = 1
                            'End If
                            'If Me.PictureBox4.Width = 0 Then
                            '    Me.PictureBox4.Width = 1
                            'End If

                            ''right side
                            'Me.PictureBox5.Top = 0
                            'Me.PictureBox5.Height = Me.Height
                            'Me.PictureBox5.Width = ((Me.Width - NewWidth) / 2)
                            'Me.PictureBox5.Left = Me.Height - Me.PictureBox5.Width
                            'If Me.PictureBox5.Height = 0 Then
                            '    Me.PictureBox5.Height = 1
                            'End If
                            'If Me.PictureBox5.Width = 0 Then
                            '    Me.PictureBox5.Width = 1
                            'End If
                        End If
                        'If AxWindowsMediaPlayer1.Visible = False Then
                        '    Call SizePictures(False)
                        'Else
                        '    Call SizePictures(True)
                        'End If
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
                        If arg <> "" Then
                            duration = arg
                            If url <> "set position" Then
                                If duration = "0:00" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                                    Me.Timer1.Enabled = False
                                ElseIf playstate = "Play.png" Then
                                    AxWindowsMediaPlayer1.URL = url
                                    AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                                    Timer1.Enabled = True
                                ElseIf playstate = "Stop.png" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                                    Me.Timer1.Enabled = False
                                ElseIf playstate = "Pause.png" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.pause()
                                End If
                            End If
                        End If
                    Case 10
                        'use this for syncing
                        playposition = arg
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
        'For vA = Len(vZ) To 1 Step -1
        '    'first we have to find the extension and remove it from the string
        '    'If Mid(vZ, vA, 1) = "." Then
        '    'sFileName = Microsoft.VisualBasic.Left(vZ, vA - 1)
        '    'Exit For
        '    'End If
        'Next vA
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
                            'Dim shell As New Shell32.Shell, objFolder As Shell32.Folder, objFile As Shell32.FolderItem
                            'Dim FileNameFromUrl As String = FileName(url)
                            'Dim FolderLocationFromUrl As String = PathName(url)
                            'Dim Width As Integer, Height As Integer, AspectRatio As Double, NewWidth As Double, NewHeight As Double
                            'objFolder = shell.NameSpace(FolderLocationFromUrl)
                            'objFile = objFolder.Items.Item(FileNameFromUrl)
                            'Height = objFolder.GetDetailsOf(objFile, 314)
                            'Width = objFolder.GetDetailsOf(objFile, 316)

                            'AspectRatio = Width / Height
                            'Label4.Text = AspectRatio
                            'If Width > Height And Width >= 188 Then
                            '    NewWidth = 188
                            '    NewHeight = 188 / AspectRatio '+ 10
                            '    Label5.Text = NewHeight
                            '    If NewHeight > 188 Then
                            '        NewHeight = 188
                            '    End If
                            'ElseIf Height > Width And Height >= 188 Then
                            '    NewWidth = 188 / AspectRatio '+ 10
                            '    If NewWidth > 188 Then
                            '        NewWidth = 188
                            '    End If
                            '    NewHeight = 188
                            'End If

                            ''top location
                            'Me.PictureBox2.Top = 0
                            'Me.PictureBox2.Left = 0
                            'Me.PictureBox2.Width = Me.Width - 50
                            'Label6.Text = (Me.Height - NewHeight)
                            'Me.PictureBox2.Height = ((Me.Height - NewHeight) / 2)
                            'Label7.Text = (Me.Height - NewHeight) / 2
                            'If Me.PictureBox2.Height = 0 Then
                            '    Me.PictureBox2.Height = 1
                            'End If
                            'If Me.PictureBox2.Width = 0 Then
                            '    Me.PictureBox2.Width = 1
                            'End If

                            ''bottom locationb
                            'Me.PictureBox3.Left = 0
                            'Me.PictureBox3.Width = Me.Width - 50
                            'Me.PictureBox3.Height = ((Me.Height - NewHeight) / 2)
                            'Me.PictureBox3.Top = Me.Height - Me.PictureBox3.Height
                            'If Me.PictureBox3.Height = 0 Then
                            '    Me.PictureBox3.Height = 1
                            'End If
                            'If Me.PictureBox3.Width = 0 Then
                            '    Me.PictureBox3.Width = 1
                            'End If

                            ''left side
                            'Me.PictureBox4.Top = 0
                            'Me.PictureBox4.Left = 0
                            'Me.PictureBox4.Height = Me.Height
                            'Me.PictureBox4.Width = ((Me.Width - NewWidth) / 2)
                            'If Me.PictureBox4.Height = 0 Then
                            '    Me.PictureBox4.Height = 1
                            'End If
                            'If Me.PictureBox4.Width = 0 Then
                            '    Me.PictureBox4.Width = 1
                            'End If

                            ''right side
                            'Me.PictureBox5.Top = 0
                            'Me.PictureBox5.Height = Me.Height
                            'Me.PictureBox5.Width = ((Me.Width - NewWidth) / 2)
                            'Me.PictureBox5.Left = Me.Height - Me.PictureBox5.Width
                            'If Me.PictureBox5.Height = 0 Then
                            '    Me.PictureBox5.Height = 1
                            'End If
                            'If Me.PictureBox5.Width = 0 Then
                            '    Me.PictureBox5.Width = 1
                            'End If
                            'If AxWindowsMediaPlayer1.Visible = False Then
                            '    Call SizePictures(False)
                            'Else
                            '    Call SizePictures(True)
                            'End If
                        End If
                    Case 2
                        positiontemp = arg
                        If url = "set position" Then
                            'do not a thing
                        ElseIf positiontemp <> "" Then
                            position = Split(positiontemp, ":")(0) * 60 + Split(positiontemp, ":")(1)
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
                            playstate = "Play.png"
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
                                    AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = position
                                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                                    Timer1.Enabled = True
                                ElseIf playstate = "Stop.png" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                                    Me.Timer1.Enabled = False
                                ElseIf playstate = "Pause.png" Then
                                    AxWindowsMediaPlayer1.Ctlcontrols.pause()
                                End If
                            End If
                        End If
                    Case 10
                        'use this for syncing
                        playposition = arg
                End Select
            Next
        End If
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
        e.BringToForeground = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Me.PictureBox1.Left = 0
        'Me.PictureBox1.Top = 0
        'Me.PictureBox1.Width = Me.Width
        'Me.PictureBox1.Height = Me.Height
        'Me.PictureBox2.Top = 0
        'Me.PictureBox2.Width = Me.Width
        'Me.PictureBox3.Width = Me.Width
        'Me.PictureBox4.Top = 0
        'Me.PictureBox4.Left = 0
        'Me.PictureBox4.Height = Me.Height
        'Me.PictureBox5.Top = 0
        'Me.PictureBox5.Left = Me.Width - Me.PictureBox5.Width
        'Me.PictureBox5.Height = Me.Height
        'AxWindowsMediaPlayer1.Left = 0
        'AxWindowsMediaPlayer1.Top = 0
        'AxWindowsMediaPlayer1.Width = Me.Width
        'AxWindowsMediaPlayer1.Height = Me.Height
    End Sub

    'Private Sub SizePictures(sValue As Boolean)
    '    If sValue = True Then
    '        System.Windows.Forms.Application.DoEvents()
    '        Dim pbImage As New Bitmap(My.Computer.FileSystem.CurrentDirectory & "\background1.png")
    '        Dim bmp = New Bitmap(Me.PictureBox2.ClientSize.Width, Me.PictureBox2.ClientSize.Height)
    '        Using g As Graphics = Graphics.FromImage(bmp)
    '            g.Clear(Me.PictureBox2.BackColor)
    '            g.DrawImage(pbImage, -17, -186, 220, 491)
    '        End Using
    '        Me.PictureBox2.Image = bmp
    '        pbImage = New Bitmap(My.Computer.FileSystem.CurrentDirectory & "\background1.png")
    '        bmp = New Bitmap(Me.PictureBox3.ClientSize.Width, Me.PictureBox3.ClientSize.Height)
    '        Using g As Graphics = Graphics.FromImage(bmp)
    '            g.Clear(Me.PictureBox3.BackColor)
    '            g.DrawImage(pbImage, -17, -333, 220, 491)
    '        End Using
    '        Me.PictureBox3.Image = bmp
    '        pbImage = New Bitmap(My.Computer.FileSystem.CurrentDirectory & "\background1.png")
    '        bmp = New Bitmap(Me.PictureBox4.ClientSize.Width, Me.PictureBox4.ClientSize.Height)
    '        Using g As Graphics = Graphics.FromImage(bmp)
    '            g.Clear(Me.PictureBox4.BackColor)
    '            g.DrawImage(pbImage, -17, -186, 220, 491)
    '        End Using
    '        Me.PictureBox4.Image = bmp
    '        pbImage = New Bitmap(My.Computer.FileSystem.CurrentDirectory & "\background1.png")
    '        bmp = New Bitmap(Me.PictureBox5.ClientSize.Width, Me.PictureBox5.ClientSize.Height)
    '        Using g As Graphics = Graphics.FromImage(bmp)
    '            g.Clear(Me.PictureBox5.BackColor)
    '            g.DrawImage(pbImage, -17, -186, 220, 491)
    '        End Using
    '        Me.PictureBox5.Image = bmp
    '        Me.PictureBox2.Visible = True
    '        Me.PictureBox3.Visible = True
    '        Me.PictureBox4.Visible = True
    '        Me.PictureBox5.Visible = True
    '    ElseIf sValue = False Then
    '        Me.PictureBox2.Visible = False
    '        Me.PictureBox3.Visible = False
    '        Me.PictureBox4.Visible = False
    '        Me.PictureBox5.Visible = False
    '    End If
    'End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Call SizePictures(True)
        Me.PictureBox1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static timerunning As Integer
        timerunning += 1
        Me.Label3.Text = timerunning
        Me.Label1.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        If AxWindowsMediaPlayer1.Ctlcontrols.currentPosition >= 0.499 Then
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 0.9
            Timer1.Enabled = False
        End If
    End Sub
End Class