Public Class passwort_change
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Das Passwort wurde erfolgreich geändert!")
        My.Settings.passwort = TextBox1.Text
        TextBox1.Text = My.Settings.passwort
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub passwort_change_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = My.Settings.passwort
    End Sub
End Class