Public Class console
    Private Sub console_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class