Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Environment
Imports System.Net
Imports Shell32
Imports System.IO

Public Class MainWindow
    Dim isInstalling = False
    Dim TargetPath As String
    Dim extractedModsbefore As Boolean = False
    Dim extractedMusicbefore As Boolean = False
    Dim Params As String = ""
    Dim filesizesha1 As String

    Public WithEvents Wc As New WebClient
    Public WithEvents Wc2 As New WebClient
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.gingolingoo.de/")
    End Sub

    Function isOS64bit()
        If Environment.Is64BitOperatingSystem = True Then
            console.debuglbl.AppendText("OS Architecture:            " & "x64" & vbNewLine)
        Else
            console.debuglbl.AppendText("OS Architecture:            " & "x86" & vbNewLine)
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExecuteParams()

        optionsstrip.Visible = False
        installpathtxt.Text = My.Settings.installpath
        versionlbl.Text = My.Application.Info.Version.ToString

        filesizesha1 = getSHA1Hash(GetDownloadSize("https://www.gingolingoo.de/files/Symphonia.zip"))
        console.debuglbl.AppendText(My.Computer.Clock.LocalTime.ToString & vbNewLine & vbNewLine)
        console.debuglbl.AppendText("OS Full Name:               " & My.Computer.Info.OSFullName & vbNewLine)
        console.debuglbl.AppendText("OS Platform:                " & My.Computer.Info.OSPlatform & vbNewLine)
        isOS64bit()
        console.debuglbl.AppendText("OS Version:                 " & My.Computer.Info.OSVersion & vbNewLine)
        console.debuglbl.AppendText("UI Culture:                 " & My.Computer.Info.InstalledUICulture.ToString & vbNewLine)
        console.debuglbl.AppendText("Total Physical Memory:      " & My.Computer.Info.TotalPhysicalMemory & " bytes (" & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 ^ 3, 1) & " GB)" & vbNewLine)
        console.debuglbl.AppendText("Total Virtual Memory:       " & My.Computer.Info.TotalVirtualMemory & " bytes (" & Math.Round(My.Computer.Info.TotalVirtualMemory / 1024 ^ 3, 1) & " GB)" & vbNewLine & vbNewLine)
        console.debuglbl.AppendText("Installer Version:          " & My.Application.Info.Version.ToString & vbNewLine)
        console.debuglbl.AppendText("CommandLineArgs:            " & Params.ToString & vbNewLine & vbNewLine)
        console.debuglbl.AppendText("Installed SHA1:             " & My.Settings.SHA1.ToString & vbNewLine)
        console.debuglbl.AppendText("Serverfile SHA1:            " & filesizesha1.ToString & vbNewLine)
        console.debuglbl.AppendText("Serverfile Size:            " & GetDownloadSize("https://www.gingolingoo.de/files/Symphonia.zip") & " bytes (" & Math.Round(GetDownloadSize("https://www.gingolingoo.de/files/Symphonia.zip") / 1024 ^ 2, 1) & " MB)" & vbNewLine & vbNewLine)
        'console.debuglbl.AppendText("Need to update: " & needToUpdate().ToString)
    End Sub

    Public Sub ExecuteParams()
        Dim args As String()
        args = Environment.GetCommandLineArgs()

        'bei 1 starten, weil das Programm IMMER seinen eigenen 
        'FULLPATH als ersten Parameter erkennt!
        For i As Integer = 1 To args.Length - 1
            Select Case args(i).ToLower

                Case "debug"
                    Params = "debug"
                    consolebtn.Visible = True
                    console.Show()

                Case "invis"
                    Params = "invis"
                    playbtn.PerformClick()
                    Me.Hide()
                    Me.ShowInTaskbar = False

                Case Else
                    MessageBox.Show("Unbekannter Parameter:" & vbCrLf & args(i), "Unbekannt!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
            End Select
        Next
    End Sub


    Private Sub playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click
        Dim Response As String
        Try
            If My.Settings.installpath = "" Then
                console.debuglbl.AppendText("InstallPath: " & "none" & vbNewLine)
                Response = MsgBox("Es wurde noch kein Installationspfad gesetzt. Soll der Standard Minecraftpfad verwendet werden?" & vbNewLine & vbNewLine & "HINWEIS: Es wird ausdrücklich empfohlen, ein eigenes Profil mit eigenem Ordner in Minecraft anzulegen.", vbYesNoCancel, "Installationspfad nicht gesetzt.")
                If Response = vbYes Then
                    My.Settings.installpath = appData & "\.minecraft"
                ElseIf Response = vbNo Then
                    FolderBrowserDialog1.ShowDialog()
                    My.Settings.installpath = FolderBrowserDialog1.SelectedPath

                ElseIf Response = vbCancel Then
                    MsgBox("Kein Installationspfad festgelegt. Programm wird beendet.")
                    Application.Exit()
                End If
                console.debuglbl.AppendText("New InstallPath: " & My.Settings.installpath & vbNewLine)
            End If
            If My.Settings.installpath = "" Then
                MsgBox("Kein Installationspfad festgelegt. Programm wird beendet.")
                Application.Exit()
            End If
            installpathtxt.Text = My.Settings.installpath
        Catch ex As Exception

        End Try
        My.Settings.Save()
        console.debuglbl.AppendText("InstallPath: " & My.Settings.installpath & vbNewLine)
        console.debuglbl.AppendText("Starting download..." & vbNewLine)
        downloadModpack()
    End Sub

    Private Sub Wc_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Wc.DownloadProgressChanged
        progress.Value = e.ProgressPercentage
        Dim ibreceived As Double = e.BytesReceived / 1024 ^ 2
        Dim ibtoreceive As Double = e.TotalBytesToReceive / 1024 ^ 2
        progress.Value = e.ProgressPercentage
        progresslbl.Text = Math.Round(ibreceived, 2).ToString("#,##0.00") & "MB von " & Math.Round(ibtoreceive, 2).ToString("#,##0.00") & "MB - " & e.ProgressPercentage & "%"
        playbtn.Text = "Lade herunter... " & e.ProgressPercentage & "%"
        filenamelbl.Text = TargetPath
        installpathbtn.Enabled = False
        installpathtxt.Enabled = False
        playbtn.Image = Nothing
        playbtn.Enabled = False
        isInstalling = True
    End Sub

    Private Sub Wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wc.DownloadFileCompleted
        isInstalling = False
        installpathbtn.Enabled = True
        installpathtxt.Enabled = True
        playbtn.Enabled = True
        playbtn.Text = "Installieren"
        playbtn.Image = My.Resources.book_writable
        'downloadMusic()
        extractModpack() 'Neue ab Version 2019.12.31.0
    End Sub

    Private Sub Wc2_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Wc2.DownloadProgressChanged
        progress.Value = e.ProgressPercentage
        Dim ibreceived As Double = e.BytesReceived / 1024 / 1024
        Dim ibtoreceive As Double = e.TotalBytesToReceive / 1024 / 1024
        progress.Value = e.ProgressPercentage
        progresslbl.Text = Math.Round(ibreceived, 2).ToString("#,##0.00") & "MB von " & Math.Round(ibtoreceive, 2).ToString("#,##0.00") & "MB - " & e.ProgressPercentage & "%"
        playbtn.Text = "Lade herunter... " & e.ProgressPercentage & "%"
        filenamelbl.Text = TargetPath
        installpathbtn.Enabled = False
        installpathtxt.Enabled = False
        playbtn.Image = Nothing
        playbtn.Enabled = False
        isInstalling = True
    End Sub

    Private Sub Wc2_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wc2.DownloadFileCompleted
        isInstalling = False
        installpathbtn.Enabled = True
        installpathtxt.Enabled = True
        playbtn.Enabled = True
        playbtn.Text = "Installieren"
        playbtn.Image = My.Resources.book_writable
        extractModpack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles installpathbtn.Click
        FolderBrowserDialog1.ShowDialog()
        My.Settings.installpath = FolderBrowserDialog1.SelectedPath
        installpathtxt.Text = My.Settings.installpath
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If File.Exists(My.Settings.installpath & "\Symphonia.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\Symphonia.zip")
        End If
        'If File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
        '    My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        'End If
        'If File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
        '   My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPJM.zip")
        'End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Response As String
        If isInstalling = True Then
            Response = MsgBox("Wirklich abbrechen? Das Modpack muss dann erneut Heruntergeladen und entpackt werden.", vbYesNo, "Installation abbrechen?")
            If Response = vbYes Then
                Wc.CancelAsync()
                Wc2.CancelAsync()
            ElseIf Response = vbNo Then
                e.Cancel = True
            End If
        Else
            'alles in Ordnung
        End If
    End Sub

    Function downloadModpack()
        AddHandler Wc.DownloadProgressChanged, AddressOf Wc_DownloadProgressChanged
        AddHandler Wc.DownloadFileCompleted, AddressOf Wc_DownloadFileCompleted
        If File.Exists(My.Settings.installpath & "\Symphonia.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\Symphonia.zip")
        End If
        'If File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
        '   My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        'End If
        TargetPath = My.Settings.installpath & "\Symphonia.zip"
        'TargetPath = My.Settings.installpath & "\GSMPNM.zip"
        console.debuglbl.AppendText("Downloading zipfile to " & TargetPath & vbNewLine)
        Wc.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/Symphonia.zip"), TargetPath)
        'Wc.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/GSMPNM.zip"), TargetPath)
        playbtn.Image = Nothing
        installpathbtn.Enabled = False
        installpathtxt.Enabled = False
        playbtn.Enabled = False
        isInstalling = True
        Return Nothing
    End Function

    Function downloadMusic()
        If Not Wc2.IsBusy Then
            Dim Response As String
            Response = MsgBox("Soll die Ambientmusik heruntergeladen werden? Sie ist nicht notwendig, aber verbessert das Spielerlebnis erheblich." & vbNewLine & vbNewLine & "Ungefähre Größe: 300 Megabyte", vbYesNo, "Musik installieren?")
            If Response = vbYes Then
                AddHandler Wc2.DownloadProgressChanged, AddressOf Wc2_DownloadProgressChanged
                AddHandler Wc2.DownloadFileCompleted, AddressOf Wc2_DownloadFileCompleted
                If File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
                    My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPJM.zip")
                End If
                TargetPath = My.Settings.installpath & "\GSMPJM.zip"
                Wc2.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/GSMPJM.zip"), TargetPath)
                playbtn.Image = Nothing
                playbtn.Enabled = False
                installpathbtn.Enabled = False
                installpathtxt.Enabled = False
                isInstalling = True
            ElseIf Response = vbNo Then
                playbtn.Enabled = True
                installpathbtn.Enabled = True
                installpathtxt.Enabled = True
                playbtn.Text = "Installieren"
                playbtn.Image = My.Resources.book_writable
                extractModpack()
            End If
        End If
        Return Nothing
    End Function

    Function extractModpack()
        If extractedModsbefore = True Then
            'Workaround für doppeltes entpacken - Schlampig, aber nötig, bis ich ne bessere Lösung habe!
        Else
            Try
                If Not File.Exists(My.Settings.installpath & "\Symphonia.zip") Then
                    'If Not File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
                    'keine Daten da zum Entpacken O.o Wie kann das passieren?!
                Else
                    If Not Directory.Exists(My.Settings.installpath & "\mods\") Then
                        console.debuglbl.AppendText("Folder 'mods' does not exist, moving on..." & vbNewLine)
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Mods... "
                        console.debuglbl.AppendText("Deleting Folder 'mods'..." & vbNewLine)
                        Directory.Delete(My.Settings.installpath & "\mods\", True)
                    End If

                    If Not Directory.Exists(My.Settings.installpath & "\config\") Then

                        console.debuglbl.AppendText("Folder 'config' does not exist, moving on..." & vbNewLine)
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Configs... "
                        console.debuglbl.AppendText("Deleting Folder 'config'..." & vbNewLine)
                        Directory.Delete(My.Settings.installpath & "\config\", True)
                    End If

                    If Not File.Exists(My.Settings.installpath & "\options.txt") Then
                        console.debuglbl.AppendText("File 'options.txt' does not exist, moving on..." & vbNewLine)
                        'Datei gibts nicht
                    Else
                        playbtn.Text = "Lösche options.txt... "
                        console.debuglbl.AppendText("Deleting file 'options.txt'..." & vbNewLine)
                        My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\options.txt")
                    End If

                    If Not File.Exists(My.Settings.installpath & "\servers.dat") Then
                        console.debuglbl.AppendText("File 'servers.dat' does not exist, moving on..." & vbNewLine)
                        'Datei gibts nicht
                    Else
                        playbtn.Text = "Lösche servers.dat... "
                        console.debuglbl.AppendText("Deleting file 'servers.dat'..." & vbNewLine)
                        My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\servers.dat")
                    End If

                    Me.Enabled = False
                    playbtn.Text = "Entpacke Mods... "
                    installpathbtn.Enabled = False
                    installpathtxt.Enabled = False
                    playbtn.Image = Nothing
                    playbtn.Enabled = False
                    isInstalling = True
                    console.debuglbl.AppendText("Extracting " & My.Settings.installpath & "\Symphonia.zip" & vbNewLine)
                    ExtractZipFileToContainingFolder(My.Settings.installpath & "\Symphonia.zip")
                    'ExtractZipFileToContainingFolder(My.Settings.installpath & "\GSMPNM.zip")
                    extractedModsbefore = True
                End If
                'extractMusic()
                console.debuglbl.AppendText("Setting SHA1 Hash " & filesizesha1 & " as installed version" & vbNewLine)
                My.Settings.SHA1 = filesizesha1
                console.debuglbl.AppendText("Finished downloading zipfile to " & TargetPath & vbNewLine)
                playbtn.Text = "Schließe ab... "
                MsgBox("Fertig! :)")
                Me.Enabled = True
            Catch exc As Exception
                console.debuglbl.AppendText("Extraction failed: " & exc.ToString & vbNewLine)
                MsgBox(exc.ToString)
            End Try
        End If
        If Params.Contains("invis") Then
            Me.Close()
        End If
        Return Nothing
    End Function

    Function extractMusic()
        If extractedMusicbefore = True Then
            'Workaround für doppeltes entpacken - Schlampig, aber nötig, bis ich ne bessere Lösung habe!
        Else
            Try
                If Not File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
                    'keine Musik da zum Entpacken :(
                Else

                    If Not Directory.Exists(My.Settings.installpath & "\ambience_music\") Then
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Musik... "
                        Directory.Delete(My.Settings.installpath & "\ambience_music\", True)
                    End If

                    playbtn.Text = "Entpacke Musik... "
                    installpathbtn.Enabled = False
                    installpathtxt.Enabled = False
                    playbtn.Image = Nothing
                    playbtn.Enabled = False
                    isInstalling = True

                    ExtractZipFileToContainingFolder(My.Settings.installpath & "\GSMPJM.zip")
                    extractedMusicbefore = True
                End If
            Catch exc As Exception
                MsgBox(exc.ToString)
            End Try
        End If
        Return Nothing
    End Function
    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As WebRequest = WebRequest.Create(URL)
        r.Method = WebRequestMethods.Http.Head
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function

    Sub ExtractZipFileToContainingFolder(ByVal ZipFile As String)
        Dim Shl As New Shell
        Dim ExtractFolder As Folder = Shl.NameSpace(Path.GetDirectoryName(ZipFile))
        Dim ZipFolder As Folder = Shl.NameSpace(ZipFile)
        ExtractFolder.CopyHere(ZipFolder.Items)
    End Sub

    Private Sub filenamelbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles filenamelbl.LinkClicked
        Process.Start(My.Settings.installpath)
    End Sub

    Private Sub consolebtn_Click(sender As Object, e As EventArgs) Handles consolebtn.Click
        console.Show()
    End Sub
End Class