Public Class mobile_beta
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub mobile_beta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Refresh()

        If My.Settings.token_code = My.Settings.tokenffbv Then
            Label1.Text = "BN " & My.Settings.emergency_numberduoble
        Else
            If My.Settings.token_code = My.Settings.kontaktperson_vorname Then
                Label1.Text = "HL " & My.Settings.emergency_numberduoble
            End If
        End If
        Timer1.Start()
        info.Text = My.Settings.infos
        Label3.Text = My.Settings.straße
        Label4.Text = My.Settings.ort
        Label5.Text = System.DateTime.Now.AddDays(6).ToString("dd.MM.yyyy") & TimeOfDay.ToString(" h:mm:ss")
        Label2.Text = My.Settings.alarmart
        If My.Settings.einsatzstufe = 1 Then
            einsatz1stufe.Text = "B1"
            PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
            einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
        Else
            If My.Settings.einsatzstufe = 2 Then
                einsatz1stufe.Text = "B2"
                einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
                PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
            Else
                If My.Settings.einsatzstufe = 3 Then
                    einsatz1stufe.Text = "B3"
                    einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
                    PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
                Else
                    If My.Settings.einsatzstufe = 4 Then
                        einsatz1stufe.Text = "B4"
                        einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
                        PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
                    Else
                        If My.Settings.einsatzstufe = 5 Then
                            einsatz1stufe.Text = "T1"
                            einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                        Else
                            If My.Settings.einsatzstufe = 6 Then
                                einsatz1stufe.Text = "T2"
                                einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                            Else
                                If My.Settings.einsatzstufe = 7 Then
                                    einsatz1stufe.Text = "T3"
                                    einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                                Else
                                    If My.Settings.einsatzstufe = 8 Then
                                        einsatz1stufe.Text = "T4"
                                        einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                                    Else
                                        If My.Settings.einsatzstufe = 9 Then
                                            einsatz1stufe.Text = "S1"
                                            einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                        Else
                                            If My.Settings.einsatzstufe = 10 Then
                                                einsatz1stufe.Text = "S2"
                                                einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                            Else
                                                If My.Settings.einsatzstufe = 11 Then
                                                    einsatz1stufe.Text = "S3"
                                                    einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                                Else
                                                    If My.Settings.einsatzstufe = 12 Then
                                                        einsatz1stufe.Text = "S4"
                                                        einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.grisu_refresh = True Then
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            mobile_beta_Load(e, e) 'Load everything in your form load event again
            My.Settings.grisu_refresh = False
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.accept = +1
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.denied = +1
        Me.Close()
    End Sub
End Class