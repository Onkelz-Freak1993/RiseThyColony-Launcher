Imports System.ComponentModel

Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installpathtxt.Text = My.Settings.installpath
    End Sub

    Private Sub settings_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        MsgBox("Hilfe!")
    End Sub

    Private Sub installpathbtn_Click(sender As Object, e As EventArgs) Handles installpathbtn.Click
        MainWindow.FolderBrowserDialog1.ShowDialog()
        My.Settings.installpath = MainWindow.FolderBrowserDialog1.SelectedPath
        installpathtxt.Text = My.Settings.installpath
    End Sub
End Class