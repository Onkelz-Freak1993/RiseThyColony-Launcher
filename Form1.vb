Imports System.ComponentModel
Imports System.Environment
Imports System.Net
'Imports System.IO 
'Imports System.IO.Compression

Public Class Form1
    Dim isInstalling = False
    Dim TargetPath As String
    Dim Stage As Integer = 0
    Dim speed As Integer
    Dim length As Long
    Dim sw As New Stopwatch

    Public WithEvents Wc As New WebClient
    Public WithEvents Wc2 As New WebClient
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.gingolingoo.de/")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installpathtxt.Text = My.Settings.installpath
        versionlbl.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click
        Dim Response As String
        playbtn.Image = Nothing
        Try
            If My.Settings.installpath = "" Then
                Response = MsgBox("Es wurde noch kein Installationspfad gesetzt. Soll der Standard Minecraftpfad verwendet werden?", vbYesNoCancel, "Installationspfad nicht angegeben")
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
            installpathtxt.Text = My.Settings.installpath
        Catch ex As Exception

        End Try
        My.Settings.Save()
        downloadModpack()
        'extractModpack()
        'extractMusic()
    End Sub

    Private Sub Wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wc.DownloadFileCompleted
        System.Media.SystemSounds.Asterisk.Play()
        isInstalling = False
        playbtn.Enabled = True
        playbtn.Text = "Installieren"
        playbtn.Image = My.Resources.book_writable
        downloadMusic()
    End Sub
    Private Sub Wc_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Wc.DownloadProgressChanged
        progress.Value = e.ProgressPercentage
        Dim info As New IO.FileInfo(TargetPath)
        length = (info.Length) / 100
        speed = length / sw.Elapsed.Seconds
        If speed = 0 Then
            'workaround for arithmetic error
        End If
        progresslbl.Text = Math.Round(e.BytesReceived / 1024 / 1024, 1) & "MB von " & Math.Round(e.TotalBytesToReceive / 1024 / 1024, 1) & "MB - " & speed & "kb/s" & e.ProgressPercentage & "%"
        playbtn.Text = "Lade herunter... " & e.ProgressPercentage & "%"
        filenamelbl.Text = TargetPath
    End Sub

    Private Sub Wc2_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wc2.DownloadFileCompleted
        System.Media.SystemSounds.Asterisk.Play()
        isInstalling = False
        playbtn.Enabled = True
        playbtn.Text = "Installieren"
        playbtn.Image = My.Resources.book_writable
    End Sub
    Private Sub Wc2_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Wc2.DownloadProgressChanged
        progress.Value = e.ProgressPercentage
        Dim info As New IO.FileInfo(TargetPath)
        length = (info.Length) / 100
        speed = length / sw.Elapsed.Seconds
        progresslbl.Text = e.BytesReceived & " von " & e.TotalBytesToReceive & " - " & speed & "kb/s" & e.ProgressPercentage & "%"

        playbtn.Text = "Lade herunter... " & e.ProgressPercentage & "%"
        filenamelbl.Text = TargetPath
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        My.Settings.installpath = FolderBrowserDialog1.SelectedPath
        installpathtxt.Text = My.Settings.installpath
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If System.IO.File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        End If
        If System.IO.File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPJM.zip")
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Response As String
        If isInstalling = True Then
            Response = MsgBox("Wirklich abbrechen? Das Modpack muss dann erneut Heruntergeladen werden.", vbYesNo, "Installation abbrechen?")
            If Response = vbYes Then
                Wc.CancelAsync()
            ElseIf Response = vbNo Then
                e.Cancel = True
            End If
        Else
            'alles in Ordnung
        End If
    End Sub

    Async Function downloadModpack() As Task
        AddHandler Wc.DownloadProgressChanged, AddressOf Wc_DownloadProgressChanged
        AddHandler Wc.DownloadFileCompleted, AddressOf Wc_DownloadFileCompleted
        If System.IO.File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        End If
        TargetPath = My.Settings.installpath & "\GSMPNM.zip"
        Wc.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/GSMPNM.zip"), TargetPath)
        playbtn.Enabled = False
        isInstalling = True
    End Function
    Async Function downloadMusic() As Task
        Timer1.Stop()
        Dim Response As String
        Response = MsgBox("Soll die Ambientmusik heruntergeladen werden? Sie ist nicht notwendig, aber verbessert das Spielerlebnis erheblich." & vbNewLine & "Ungefähre Größe: 300 Megabyte", vbYesNo, "Musik installieren?")
        If Response = vbYes Then
            AddHandler Wc2.DownloadProgressChanged, AddressOf Wc2_DownloadProgressChanged
            AddHandler Wc2.DownloadFileCompleted, AddressOf Wc2_DownloadFileCompleted
            If System.IO.File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
                My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPJM.zip")
            End If
            TargetPath = My.Settings.installpath & "\GSMPJM.zip"
            Wc2.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/GSMPJM.zip"), TargetPath)
            playbtn.Enabled = False
            isInstalling = True
            Stage = 2
        ElseIf Response = vbNo Then
            Stage = 1
            'keine Musik :(
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Wc.IsBusy Then

        End If
    End Sub

    Async Function extractModpack() As Task
        Timer2.Start()
    End Function

    Async Function extractMusic() As Task
        Timer3.Start()
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Stage >= 1 Then
            Timer2.Stop()
            Dim sc As New Shell32.Shell()
            Dim output As Shell32.Folder = sc.NameSpace(My.Settings.installpath)
            Dim input As Shell32.Folder = sc.NameSpace(My.Settings.installpath & "\GSMPNM.zip")
            output.CopyHere(input.Items, 4)
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Stage = 2 Then
            Try
                If Not System.IO.File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
                    'keine Musik da zum Entpacken
                End If
            Catch
                'Erneut versuchen
            End Try
        Else
            Timer3.Stop()
            'Dim sc As New Shell32.Shell()
            'Dim output As Shell32.Folder = sc.NameSpace(My.Settings.installpath)
            'Dim input As Shell32.Folder = sc.NameSpace(My.Settings.installpath & "\GSMPJM.zip")
            'output.CopyHere(input.Items, 4)
        End If
    End Sub
End Class
