Imports System.ComponentModel
Imports System.Environment
Imports System.IO

Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        If Not My.Settings.Params.Contains("debug") Then
            TabControl1.TabPages.Remove(TabControl1.TabPages(2))
        End If
        installpathtxt.Text = My.Settings.installpath
        attxt.Text = My.Settings.accessToken
        cttxt.Text = My.Settings.clientToken
        usernametxt.Text = My.Settings.currentUser
        useridtxt.Text = My.Settings.userID
        javapathtxt.Text = My.Settings.JavaPath
        SelectedGameVersion.Items.Clear()

        For Each Dir As String In Directory.GetDirectories(appData & "\.minecraft\versions")
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            If dirInfo.Name.Contains("forge") Then
                SelectedGameVersion.Items.Add(dirInfo.Name)
                SelectedGameVersion.SelectedItem = dirInfo.Name
            End If
        Next
    End Sub

    Private Sub settings_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        MsgBox("Hilfe!")
    End Sub

    Private Sub installpathbtn_Click(sender As Object, e As EventArgs) Handles installpathbtn.Click
        MainWindow.FolderBrowserDialog1.ShowDialog()
        My.Settings.installpath = MainWindow.FolderBrowserDialog1.SelectedPath
        installpathtxt.Text = My.Settings.installpath

    End Sub

    Private Sub jsonresult_Click(sender As Object, e As EventArgs) Handles jsonresult.Click
        MsgBox(My.Settings.resultJson.ToString)
    End Sub

    Private Sub Xmxtxt_Leave(sender As Object, e As EventArgs) Handles Xmxtxt.Leave
        If Xmxtxt.Text < "4096" Then
            MsgBox("Es wird nicht empfohlen, Symphonia mit weniger als 4 Gigabyte zugewiesenem Arbeitsspeicher zu starten. Das Spiel wird nicht flüssig laufen!", vbInformation, "Zu wenig Arbeitsspeicher zugewiesen")
        End If
    End Sub

    Private Sub javapathbtn_Click(sender As Object, e As EventArgs) Handles javapathbtn.Click
        OpenFileDialog1.ShowDialog()
        javapathtxt.Text = OpenFileDialog1.FileName
    End Sub
End Class