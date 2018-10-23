Imports MySql.Data.MySqlClient
Imports Gecko
Public Class idle
    Dim MysqlConn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim alamiertstatus As New Boolean
    Dim rs As New Resizer


    Private Sub idle_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Settings.bottom_text
        If My.Settings.devmod = True Then
            devmod.Show()
        End If
        Label3.Text = DateTime.Now.ToString("HH:mm:ss")
        If My.Settings.token = False Then
            token.Show()
            Me.Hide()
        Else
            If My.Settings.token = True Then
                My.Settings.token = True
            End If

        End If
        einsatz1melde.Text = My.Settings.Einsatz1Stufe
        einsatz1ort.Text = My.Settings.Einsatz1Ort
        einsatz1stufe.Text = My.Settings.Einsatz1Text

        einsatz2melde.Text = My.Settings.Einsatz2Stufe
        einsatz2ort.Text = My.Settings.einsatz2ort
        einsatz2stufe.Text = My.Settings.Einsatz2Text
        Label2.Text = DateTime.Now.ToString("dd.MM.yyyy")
        My.Settings.alamiert = False
        einsatz_tab.Show()
        Timer1.Start()
        If My.Settings.einsatzstufe = 1 Then
            einsatz1stufe.Text = "B1"
            einsatz2stufe.Text = "B1"
            PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
            einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
            einsatz2stufe.BackColor = Color.FromArgb(30, 30, 30)
        Else
            If My.Settings.einsatzstufe = 2 Then
                einsatz1stufe.Text = "B2"
                einsatz2stufe.Text = "B2"
                einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
                einsatz2stufe.BackColor = Color.FromArgb(224, 55, 55)
                PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
            Else
                If My.Settings.einsatzstufe = 3 Then
                    einsatz1stufe.Text = "B3"
                    einsatz2stufe.Text = "B3"
                    einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
                    einsatz2stufe.BackColor = Color.FromArgb(224, 55, 55)
                    PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
                Else
                    If My.Settings.einsatzstufe = 4 Then
                        einsatz1stufe.Text = "B4"
                        einsatz2stufe.Text = "B4"
                        einsatz1stufe.BackColor = Color.FromArgb(224, 55, 55)
                        einsatz2stufe.BackColor = Color.FromArgb(224, 55, 55)
                        PictureBox2.BackColor = Color.FromArgb(224, 55, 55)
                    Else
                        If My.Settings.einsatzstufe = 5 Then
                            einsatz1stufe.Text = "T1"
                            einsatz2stufe.Text = "T1"
                            einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                            einsatz2stufe.BackColor = Color.FromArgb(65, 65, 230)
                        Else
                            If My.Settings.einsatzstufe = 6 Then
                                einsatz1stufe.Text = "T2"
                                einsatz2stufe.Text = "T2"
                                einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                                einsatz2stufe.BackColor = Color.FromArgb(65, 65, 230)
                            Else
                                If My.Settings.einsatzstufe = 7 Then
                                    einsatz1stufe.Text = "T3"
                                    einsatz2stufe.Text = "T3"
                                    einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                                    einsatz2stufe.BackColor = Color.FromArgb(65, 65, 230)
                                Else
                                    If My.Settings.einsatzstufe = 8 Then
                                        einsatz1stufe.Text = "T4"
                                        einsatz2stufe.Text = "T4"
                                        einsatz1stufe.BackColor = Color.FromArgb(65, 65, 230)
                                        einsatz2stufe.BackColor = Color.FromArgb(65, 65, 230)
                                    Else
                                        If My.Settings.einsatzstufe = 9 Then
                                            einsatz1stufe.Text = "S1"
                                            einsatz2stufe.Text = "S1"
                                            einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                            einsatz2stufe.BackColor = Color.FromArgb(95, 251, 95)
                                        Else
                                            If My.Settings.einsatzstufe = 10 Then
                                                einsatz1stufe.Text = "S2"
                                                einsatz2stufe.Text = "S2"
                                                einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                                einsatz2stufe.BackColor = Color.FromArgb(95, 251, 95)
                                            Else
                                                If My.Settings.einsatzstufe = 11 Then
                                                    einsatz1stufe.Text = "S3"
                                                    einsatz2stufe.Text = "S3"
                                                    einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                                    einsatz2stufe.BackColor = Color.FromArgb(95, 251, 95)
                                                Else
                                                    If My.Settings.einsatzstufe = 12 Then
                                                        einsatz1stufe.Text = "S4"
                                                        einsatz2stufe.Text = "S4"
                                                        einsatz1stufe.BackColor = Color.FromArgb(95, 251, 95)
                                                        einsatz2stufe.BackColor = Color.FromArgb(95, 251, 95)
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Settings.letze_einsätze = False Then
            Panel1.Visible = False
        Else
            If My.Settings.letze_einsätze = True Then
                Panel1.Visible = True
            End If
        End If
        If My.Settings.letze_einsätze = False Then
            WebBrowser1.Visible = True
        Else
            If My.Settings.letze_einsätze = True Then
                WebBrowser1.Visible = False
            End If
        End If
        If alamiertstatus = True Then
            test_alarm_tool.Show()
        End If
        Label3.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        token.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        idle_load(e, e) 'Load everything in your form load event again
        My.Settings.Einsatz1Stufe = ""
        My.Settings.Einsatz2Stufe = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        alamiertstatus = True
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        test_alarm_tool.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        token.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)
        token.Show()
        Me.Hide()
    End Sub

    Private Sub idle_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        My.Settings.token_code = My.Settings.kontaktperson_vorname
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        My.Settings.token_code = My.Settings.tokenffbv
    End Sub

    Private Sub Label6_Click_2(sender As Object, e As EventArgs)
        verify.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Label6_Click_3(sender As Object, e As EventArgs)
        My.Settings.letze_einsätze = 0
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub einsatz2melde_Click(sender As Object, e As EventArgs) Handles einsatz2melde.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
