Public Class verify
    Private Sub activated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.token_code = My.Settings.kontaktperson_vorname Then
            Label2.Text = "Guten Tag, Lucas Heilinger!"
        Else
            If My.Settings.token_code = My.Settings.tokenffbv Then
                Label2.Text = "Guten Tag, Oliver Kratochwill!"
            End If
        End If
        Timer1.Enabled = True
        Timer1.Interval = 4001
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Image = My.Resources.no_animated
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        idle.Show()
    End Sub
End Class