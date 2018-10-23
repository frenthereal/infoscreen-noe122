Public Class busy

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Private Sub busy_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = DateTime.Now.ToString("HH:mm:ss")
        Label2.Text = DateTime.Now.ToString("dd/MM/yyyy")
        My.Settings.alamiert = False
        einsatz_tab.Show()
        Timer1.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        idle.Show()
        Me.Close()
    End Sub
End Class