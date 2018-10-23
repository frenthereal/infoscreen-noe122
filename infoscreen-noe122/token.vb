Public Class token
    Private Sub token_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.tokenffbv Then
            My.Settings.token_code = My.Settings.tokenffbv
            verify.Show()
            My.Settings.token = True

            Me.Close()
            My.Settings.Save()
        Else
            If TextBox1.Text = My.Settings.kontaktperson_vorname Then
                My.Settings.token_code = My.Settings.kontaktperson_vorname
                verify.Show()
                My.Settings.token = True

                Me.Close()
                My.Settings.Save()
            End If
        End If
    End Sub
End Class