Public Class einsatz_tab
    Private Sub COMINGSOONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMINGSOONToolStripMenuItem.Click

    End Sub

    Private Sub AlamierungsmaskeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlamierungsmaskeToolStripMenuItem.Click
        My.Settings.einsatzmaske_aktiv = True
        emergency.MdiParent = Me
        emergency.Show()
    End Sub

    Private Sub KartenmanagmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KartenmanagmentToolStripMenuItem.Click
        karte.Show()
        karte.MdiParent = Me
    End Sub

    Private Sub einsatz_tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
    End Sub

    Private Sub AbwesenheitsbildschirmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbwesenheitsbildschirmToolStripMenuItem.Click
        Me.Close()

        idle.Hide()
        busy.Show()
    End Sub

    Private Sub MobileEditionGrisuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobileEditionGrisuToolStripMenuItem.Click
        mobile_beta.Show()

    End Sub
End Class