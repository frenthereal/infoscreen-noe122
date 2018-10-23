Public Class msgbox
    Private Sub msgbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        text.Text = My.Settings.msgbox_text
        My.Settings.msgbox_text = ""
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        admin.Close()
        idle.Show()
        Me.Close()
    End Sub
End Class