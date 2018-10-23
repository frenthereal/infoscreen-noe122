Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class test_alarm_tool
    Private sDatabasePath As String = My.Settings.token_code & ".mdb"
    Private sTableName As String = My.Settings.token_code

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Datenbank_und_Tabelle_erstellen()
    End Sub

    Private Sub Datenbank_und_Tabelle_erstellen()
        Dim fi As New FileInfo(sDatabasePath)
        If fi.Exists Then
            If MessageBox.Show("Die Datenbank existiert bereits." &
      vbNewLine & "Sie können diese zunächst löschen, " &
      " wenn Sie sie neu erstellen wollen." & vbNewLine &
      "Soll die existierende DB wirklich gelöscht werden?",
      "DB jetzt löschen?",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Exclamation) =
      Windows.Forms.DialogResult.Yes Then

                File.Delete(My.Settings.token_code & ".mdb")

                MessageBox.Show("Die Access-Datenbank wurde gelöscht!",
        "Die DB wurde gelöscht!",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Exit Sub
            End If
        End If

        Dim catalog As Object
        catalog = CreateObject("ADOX.Catalog")
        catalog.create(
    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" &
    sDatabasePath)

        MessageBox.Show("Die Datenbank wurde neu erstellt",
    "Neue Access-Datenbank",
    MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim conn As OleDbConnection = New OleDbConnection(
    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" _
    & sDatabasePath)
        conn.Open()

        Dim sql As String = "CREATE TABLE " & sTableName & "(" &
  "ID COUNTER NOT NULL CONSTRAINT PK_ID_no PRIMARY KEY, " &
    "Alarmstufe      Varchar(50), " &
    "Meldebild      Varchar(50), " &
    "Straße          Varchar(50), " &
    "OrtPlz         Varchar(50), " &
    "Text        Varchar(50), " &
    ")"

        Dim cmd As OleDbCommand = New OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Die neue Datenbank" & vbNewLine &
    sDatabasePath & vbNewLine & vbNewLine &
    "mit der Tabelle" & vbNewLine &
    sTableName & vbNewLine & vbNewLine &
    "wurde erfolgreich erstellt!",
    "Erfolgreich erstellt: DB und Tabelle",
    MessageBoxButtons.OK, MessageBoxIcon.Information)

        Process.Start(My.Settings.token_code & ".mdb")
    End Sub
End Class
