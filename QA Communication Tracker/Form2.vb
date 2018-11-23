Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form3.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class