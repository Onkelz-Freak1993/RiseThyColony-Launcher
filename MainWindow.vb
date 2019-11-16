Imports System.ComponentModel
Imports System.Environment
Imports System.Net
Imports Shell32
Imports System.IO

Public Class MainWindow
    Dim isInstalling = False
    Dim TargetPath As String
    Dim extractedModsbefore As Boolean = False
    Dim extractedMusicbefore As Boolean = False

    Public WithEvents Wc As New WebClient
    Public WithEvents Wc2 As New WebClient
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.gingolingoo.de/")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optionsstrip.Visible = False
        installpathtxt.Text = My.Settings.installpath
        versionlbl.Text = "Release-Version " & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString
    End Sub

    Private Sub playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click
        Dim Response As String
        Try
            If My.Settings.installpath = "" Then
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
            End If
            If My.Settings.installpath = "" Then
                MsgBox("Kein Installationspfad festgelegt. Programm wird beendet.")
                Application.Exit()
            End If
            installpathtxt.Text = My.Settings.installpath
        Catch ex As Exception

        End Try
        My.Settings.Save()
        downloadModpack()
    End Sub

    Private Sub Wc_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Wc.DownloadProgressChanged
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

    Private Sub Wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wc.DownloadFileCompleted
        isInstalling = False
        installpathbtn.Enabled = True
        installpathtxt.Enabled = True
        playbtn.Enabled = True
        playbtn.Text = "Installieren"
        playbtn.Image = My.Resources.book_writable
        downloadMusic()
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
        If File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        End If
        If File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPJM.zip")
        End If
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
        If File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        End If
        TargetPath = My.Settings.installpath & "\GSMPNM.zip"
        Wc.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/GSMPNM.zip"), TargetPath)
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
                If Not File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
                    'keine Daten da zum Entpacken O.o Wie kann das passieren?!
                Else

                    If Not Directory.Exists(My.Settings.installpath & "\mods\") Then
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Mods... "
                        Directory.Delete(My.Settings.installpath & "\mods\", True)
                    End If

                    If Not Directory.Exists(My.Settings.installpath & "\config\") Then
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Configs... "
                        Directory.Delete(My.Settings.installpath & "\config\", True)
                    End If

                    If Not File.Exists(My.Settings.installpath & "\options.txt") Then
                        'Datei gibts nicht
                    Else
                        playbtn.Text = "Lösche options.txt... "
                        My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\options.txt")
                    End If

                    Me.Enabled = False
                    playbtn.Text = "Entpacke Mods... "
                    installpathbtn.Enabled = False
                    installpathtxt.Enabled = False
                    playbtn.Image = Nothing
                    playbtn.Enabled = False
                    isInstalling = True

                    ExtractZipFileToContainingFolder(My.Settings.installpath & "\GSMPNM.zip")
                    extractedModsbefore = True
                End If
                extractMusic()
                playbtn.Text = "Schließe ab... "
                MsgBox("Fertig! :)")
                Me.Enabled = True
            Catch exc As Exception
                MsgBox(exc.ToString)
            End Try
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

    Sub ExtractZipFileToContainingFolder(ByVal ZipFile As String)
        Dim Shl As New Shell
        Dim ExtractFolder As Folder = Shl.NameSpace(Path.GetDirectoryName(ZipFile))
        Dim ZipFolder As Folder = Shl.NameSpace(ZipFile)
        ExtractFolder.CopyHere(ZipFolder.Items)
    End Sub

    Private Sub filenamelbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles filenamelbl.LinkClicked
        Process.Start(My.Settings.installpath)
    End Sub
End Class