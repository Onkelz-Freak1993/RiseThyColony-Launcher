Imports System.ComponentModel

Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installpathtxt.Text = My.Settings.installpath
        attxt.Text = My.Settings.accessToken
        cttxt.Text = My.Settings.clientToken
        usernametxt.Text = My.Settings.currentUser
        useridtxt.Text = My.Settings.userID
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
End Class