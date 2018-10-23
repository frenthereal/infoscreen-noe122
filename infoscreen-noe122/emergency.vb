Imports Discord
Imports Discord.Commands
Imports Discord.Webhook
Public Class emergency
    Dim locked As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles starten.Click
        My.Settings.new_log_string = True
        My.Settings.new_log = DateTime.Now.ToString("dd/MM/yyyy ") & DateTime.Now.ToString(" HH:mm:ss ") & "Neuer Einsatz angelegt!"
        idle.Close()
        My.Settings.emergency_numberduoble = My.Settings.emergency_numberduoble + 1
        My.Settings.emergency_number = "BN " & My.Settings.emergency_numberduoble
        mobile_beta.Show()
        locked = True
        DataGridView1.Rows.Add(New String() {My.Settings.locking_erstellt})
        My.Settings.locking_is_erstellt = True
        TextBox5.Text = "ALAMIERT"
        Timer1.Start()
        My.Settings.locking_alarmstufen = System.DateTime.Now.AddDays(6).ToString("dd.MM.yyyy") & TimeOfDay.ToString(" h:mm") & " | Alarmstufenerhöhung!"
        My.Settings.locking_storniert = System.DateTime.Now.AddDays(6).ToString("dd.MM.yyyy") & TimeOfDay.ToString(" h:mm") & " | Einsatz wurde storniert!"
        My.Settings.alarmzeit_lockinginformationen = System.DateTime.Now.AddDays(6).ToString("dd.MM.yyyy") & TimeOfDay.ToString(" h:mm")
        My.Settings.locking_erstellt = System.DateTime.Now.AddDays(6).ToString("dd.MM.yyyy") & TimeOfDay.ToString(" h:mm") & " | Hier Florian Baden mit " & My.Settings.alarmart
        If My.Settings.einsatz1 = False Then
            My.Settings.einsatz1 = True
            My.Settings.Einsatz1Ort = My.Settings.ort
            My.Settings.Einsatz1Stufe = My.Settings.alarmart
            My.Settings.Einsatz1Text = My.Settings.einsatzstufe
        Else
            If My.Settings.einsatz1 = True Then
                My.Settings.einsatz2 = True
                My.Settings.einsatz2ort = My.Settings.ort
                My.Settings.Einsatz2Stufe = My.Settings.alarmart
                My.Settings.Einsatz2Text = My.Settings.einsatzstufe
            End If
        End If
        If My.Settings.einsatz1 = True And My.Settings.einsatz2 = True Then
            My.Settings.einsatz1 = False
            My.Settings.einsatz2 = False

        End If

        My.Settings.Save()
        starten.Enabled = False
        stoppen.Enabled = True
        My.Settings.alarmart = ComboBox2.Text
        My.Settings.ort = TextBox1.Text
        My.Settings.straße = TextBox2.Text
        My.Settings.abschnitt = TextBox4.Text
        My.Settings.infos = TextBox3.Text
        My.Settings.Save()
        My.Settings.alamiert = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles stoppen.Click
        My.Settings.new_log_string = True
        My.Settings.new_log = DateTime.Now.ToString("dd/MM/yyyy ") & DateTime.Now.ToString(" HH:mm:ss ") & "Einsatz wurde Storniert!"
        My.Settings.accept = 0
        My.Settings.denied = 0
        My.Settings.Einsatz1Ort = My.Settings.ort
        My.Settings.Einsatz1Stufe = My.Settings.alarmart
        My.Settings.Einsatz1Text = My.Settings.einsatzstufe

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        emergency_Load(e, e) 'Load everything in your form load event again
        TextBox5.Text = "NEU"
        DataGridView1.Rows.Add(New String() {My.Settings.locking_storniert})
        My.Settings.einsatzmaske_aktiv = False
        starten.Enabled = True
        stoppen.Enabled = False

        idle.Show()
        My.Settings.alamiert = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles b1.CheckedChanged
        b1.Checked = False
        My.Settings.einsatzstufe = 1
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles t1.CheckedChanged
        t1.Checked = False
        My.Settings.einsatzstufe = 5
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.new_log_string = True
        My.Settings.new_log = DateTime.Now.ToString("dd/MM/yyyy ") & DateTime.Now.ToString(" HH:mm:ss ") & "Einsatzdaten wurden aktualisiert!"
        mobile_beta.Close()
        My.Settings.grisu_refresh = True
        My.Settings.alarmart = ComboBox2.Text
        My.Settings.ort = TextBox1.Text
        My.Settings.straße = TextBox2.Text
        My.Settings.infos = TextBox3.Text
        My.Settings.Save()
    End Sub

    Private Sub emergency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        locked = False
        If locked = False Then
            CheckBox9.Enabled = False
        Else
            CheckBox9.Enabled = True
        End If
        My.Settings.einsatzmaske_aktiv = True
        stoppen.Enabled = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        status.Show()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles s1.CheckedChanged
        s1.Checked = False
        My.Settings.einsatzstufe = 9

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)
        My.Settings.KeineAlarmstufe = True
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.Checked = False
        My.Settings.statusffbv = 1
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox2.Checked = False
        My.Settings.statusffbv = 2
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox3.Checked = False
        My.Settings.statusffbv = 3
    End Sub

    Private Sub CheckBox4_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        CheckBox4.Checked = False
        My.Settings.statusffbv = 4
    End Sub

    Private Sub b2_CheckedChanged(sender As Object, e As EventArgs) Handles b2.CheckedChanged
        b2.Checked = False
        My.Settings.einsatzstufe = 2
    End Sub

    Private Sub b3_CheckedChanged(sender As Object, e As EventArgs) Handles b3.CheckedChanged
        b3.Checked = False
        My.Settings.einsatzstufe = 3
    End Sub

    Private Sub b4_CheckedChanged(sender As Object, e As EventArgs) Handles b4.CheckedChanged
        b4.Checked = False
        My.Settings.einsatzstufe = 4
    End Sub

    Private Sub t2_CheckedChanged(sender As Object, e As EventArgs) Handles t2.CheckedChanged
        t2.Checked = False
        My.Settings.einsatzstufe = 6
    End Sub

    Private Sub t3_CheckedChanged(sender As Object, e As EventArgs) Handles t3.CheckedChanged
        t3.Checked = False
        My.Settings.einsatzstufe = 7
    End Sub

    Private Sub t4_CheckedChanged(sender As Object, e As EventArgs) Handles t4.CheckedChanged
        t4.Checked = False
        My.Settings.einsatzstufe = 8
    End Sub

    Private Sub s2_CheckedChanged(sender As Object, e As EventArgs) Handles s2.CheckedChanged
        s2.Checked = False
        My.Settings.einsatzstufe = 10
    End Sub

    Private Sub s3_CheckedChanged(sender As Object, e As EventArgs) Handles s3.CheckedChanged
        s3.Checked = False
        My.Settings.einsatzstufe = 11
    End Sub

    Private Sub s4_CheckedChanged(sender As Object, e As EventArgs) Handles s4.CheckedChanged
        s4.Checked = False
        My.Settings.einsatzstufe = 12
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        CheckBox8.Checked = False
        My.Settings.pressestatus = 1
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        CheckBox7.Checked = False
        My.Settings.pressestatus = 2
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        CheckBox6.Checked = False
        My.Settings.pressestatus = 3
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        CheckBox5.Checked = False
        My.Settings.pressestatus = 4
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        DataGridView1.Rows.Add(New String() {My.Settings.locking_alarmstufen})
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.alamiert = True Then
            alamiert.Show()

        End If
        If TextBox2.Text = "Lang" Then
            street_help.Show()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class