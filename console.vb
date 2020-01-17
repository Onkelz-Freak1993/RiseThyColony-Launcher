Public Class console
    Private Sub console_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub LogSpeichernUnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogSpeichernUnterToolStripMenuItem.Click
        Try
            SaveFileDialog1.ShowDialog()
            debugcon.SaveFile(SaveFileDialog1.FileName)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class