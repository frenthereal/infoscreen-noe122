Public Class devmod
    Private Sub devmod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.new_log_string = True Then
            My.Settings.new_log_string = False
            RichTextBox1.Text += Environment.NewLine + My.Settings.new_log
        End If
    End Sub

    Private Sub devmod_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        RichTextBox1.Clear()
        My.Settings.new_log = ""
    End Sub
End Class