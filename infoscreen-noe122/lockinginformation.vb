Public Class lockinginformation
    Private Sub lockinginformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hua As String
        hua = "test"
        Timer1.Start()
        Timer1.Interval = 1000
        DataGridView1.Rows.Add(New String() {My.Settings.alarmzeit_lockinginformationen})
        If My.Settings.locking_is_erstellt = True Then
            DataGridView1.Rows.Add(New String() {My.Settings.locking_erstellt})
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        lockinginformation_Load(e, e) 'Load everything in your form load event again
    End Sub
End Class