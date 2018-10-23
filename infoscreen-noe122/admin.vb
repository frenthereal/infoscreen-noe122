Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Settings.bottom_text
        TextBox1.Text = My.Settings.kontaktperson_vorname
        TextBox2.Text = My.Settings.kontaktperson_nachname
        TextBox3.Text = My.Settings.kontaktperson_email
        Timer1.Start()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Label2.Text = DateTime.Now.ToString("dd.MM.yyyy")
        Label3.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Close()
        idle.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        CheckBox4.Checked = False
        My.Settings.letze_einsätze = True
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox3.Checked = False
        My.Settings.letze_einsätze = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        passwort_change.Show()
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

        CheckBox8.Checked = False
        My.Settings.devmod = True
        My.Settings.msgbox_text = "Der Enwicklermodus wird beim nächsten Neustarten aktiv!"
        msgbox.Show()
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        CheckBox7.Checked = False
        My.Settings.devmod = False
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked

        My.Settings.kontaktperson_vorname = TextBox1.Text
        My.Settings.kontaktperson_nachname = TextBox2.Text
        My.Settings.kontaktperson_email = TextBox3.Text
        My.Settings.msgbox_text = "Die Daten wurden erfolgreich übernommen!"
        msgbox.Show()
        My.Settings.Save()
        Me.Close()
        idle.Show()
    End Sub
End Class