Public Class alamiert
    Dim nowdate As Date
    Dim currenttimezone As TimeZone = TimeZone.CurrentTimeZone
    Private Sub alamiert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.Text = My.Settings.bottom_text
        Label3.Text = DateTime.Now.ToString("HH:mm:ss")
        Label8.Text = My.Settings.accept
        Label9.Text = My.Settings.denied
        If My.Settings.statusffbv = 1 Then
            PictureBox5.BackColor = Color.Gray
            Label5.BackColor = Color.Gray
        Else
            If My.Settings.statusffbv = 2 Then
                PictureBox5.BackColor = Color.Yellow
                Label5.BackColor = Color.Yellow
            Else
                If My.Settings.statusffbv = 3 Then
                    PictureBox5.BackColor = Color.Red
                    Label5.BackColor = Color.Red
                Else
                    If My.Settings.statusffbv = 4 Then
                        PictureBox5.BackColor = Color.FromArgb(75, 237, 75)
                        Label5.BackColor = Color.FromArgb(75, 237, 75)
                    End If
                End If
            End If
            If My.Settings.pressestatus = 1 Then
                PictureBox5.BackColor = Color.Gray
                Label5.BackColor = Color.Gray
            Else
                If My.Settings.pressestatus = 2 Then
                    PictureBox5.BackColor = Color.Yellow
                    Label5.BackColor = Color.Yellow
                Else
                    If My.Settings.pressestatus = 3 Then
                        PictureBox5.BackColor = Color.Red
                        Label5.BackColor = Color.Red
                    Else
                        If My.Settings.pressestatus = 4 Then
                            PictureBox5.BackColor = Color.FromArgb(75, 237, 75)
                            Label5.BackColor = Color.FromArgb(75, 237, 75)
                        End If
                    End If
                End If
            End If
        End If

        Timer1.Start()
        Timer2.Start()
        Timer2.Interval = 5000
        ART.Text = My.Settings.alarmart
        ORT.Text = My.Settings.ort
        gasse.Text = My.Settings.straße
        info.Text = My.Settings.infos
        Label7.Text = "Abschnitt: " & My.Settings.abschnitt
        Label2.Text = DateTime.Now.ToString("dd.MM.yyyy")
        If My.Settings.einsatzstufe = 1 Then
            STUFE.Text = "B1"
            PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
            STUFE.BackColor = Color.FromArgb(224, 55, 55)
        Else
            If My.Settings.einsatzstufe = 2 Then
                STUFE.Text = "B2"
                STUFE.BackColor = Color.FromArgb(224, 55, 55)
                PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
            Else
                If My.Settings.einsatzstufe = 3 Then
                    STUFE.Text = "B3"
                    STUFE.BackColor = Color.FromArgb(224, 55, 55)
                    PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
                Else
                    If My.Settings.einsatzstufe = 4 Then
                        STUFE.Text = "B4"
                        STUFE.BackColor = Color.FromArgb(224, 55, 55)
                        PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
                    Else
                        If My.Settings.einsatzstufe = 5 Then
                            STUFE.Text = "T1"
                            STUFE.BackColor = Color.FromArgb(65, 65, 230)
                            PictureBox2.BackColor = Color.FromArgb(65, 65, 230)
                        Else
                            If My.Settings.einsatzstufe = 6 Then
                                STUFE.Text = "T2"
                                STUFE.BackColor = Color.FromArgb(65, 65, 230)
                                PictureBox2.BackColor = Color.FromArgb(65, 65, 230)
                            Else
                                If My.Settings.einsatzstufe = 7 Then
                                    STUFE.Text = "T3"
                                    STUFE.BackColor = Color.FromArgb(65, 65, 230)
                                    PictureBox2.BackColor = Color.FromArgb(65, 65, 230)
                                Else
                                    If My.Settings.einsatzstufe = 8 Then
                                        STUFE.Text = "T4"
                                        STUFE.BackColor = Color.FromArgb(65, 65, 230)
                                        PictureBox2.BackColor = Color.FromArgb(65, 65, 230)
                                    Else
                                        If My.Settings.einsatzstufe = 9 Then
                                            STUFE.Text = "S1"
                                            STUFE.BackColor = Color.FromArgb(95, 251, 95)
                                            PictureBox2.BackColor = Color.FromArgb(95, 251, 95)
                                        Else
                                            If My.Settings.einsatzstufe = 10 Then
                                                STUFE.Text = "S2"
                                                STUFE.BackColor = Color.FromArgb(95, 251, 95)
                                                PictureBox2.BackColor = Color.FromArgb(95, 251, 95)
                                            Else
                                                If My.Settings.einsatzstufe = 11 Then
                                                    STUFE.Text = "S3"
                                                    STUFE.BackColor = Color.FromArgb(95, 251, 95)
                                                    PictureBox2.BackColor = Color.FromArgb(95, 251, 95)
                                                Else
                                                    If My.Settings.einsatzstufe = 12 Then
                                                        STUFE.Text = "S4"
                                                        STUFE.BackColor = Color.FromArgb(95, 251, 95)
                                                        PictureBox2.BackColor = Color.FromArgb(95, 251, 95)
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("HH:mm:ss")
        If My.Settings.alamiert = False Then
            idle.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        alamiert_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub ART_Click(sender As Object, e As EventArgs) Handles ART.Click

    End Sub
End Class