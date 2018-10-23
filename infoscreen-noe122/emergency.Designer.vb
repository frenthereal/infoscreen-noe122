<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class emergency
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(emergency))
        Me.starten = New System.Windows.Forms.Button()
        Me.stoppen = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Aktion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b4 = New System.Windows.Forms.CheckBox()
        Me.b1 = New System.Windows.Forms.CheckBox()
        Me.t1 = New System.Windows.Forms.CheckBox()
        Me.s1 = New System.Windows.Forms.CheckBox()
        Me.b2 = New System.Windows.Forms.CheckBox()
        Me.t2 = New System.Windows.Forms.CheckBox()
        Me.s2 = New System.Windows.Forms.CheckBox()
        Me.b3 = New System.Windows.Forms.CheckBox()
        Me.t3 = New System.Windows.Forms.CheckBox()
        Me.s3 = New System.Windows.Forms.CheckBox()
        Me.t4 = New System.Windows.Forms.CheckBox()
        Me.s4 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'starten
        '
        Me.starten.AutoSize = True
        Me.starten.BackColor = System.Drawing.Color.Yellow
        Me.starten.Location = New System.Drawing.Point(1001, 137)
        Me.starten.Name = "starten"
        Me.starten.Size = New System.Drawing.Size(153, 60)
        Me.starten.TabIndex = 7
        Me.starten.Text = "Einsatz erzeugen"
        Me.starten.UseVisualStyleBackColor = False
        '
        'stoppen
        '
        Me.stoppen.AutoSize = True
        Me.stoppen.BackColor = System.Drawing.Color.Yellow
        Me.stoppen.Location = New System.Drawing.Point(1160, 137)
        Me.stoppen.Name = "stoppen"
        Me.stoppen.Size = New System.Drawing.Size(153, 60)
        Me.stoppen.TabIndex = 8
        Me.stoppen.Text = "Stornieren"
        Me.stoppen.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(1319, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 60)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Aktualisieren"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(1296, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Statusübersicht"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(1001, 62)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 19)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Disponiert"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(1056, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Freiwillige Feuerwehr Bad Vöslau"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Yellow
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox2.Location = New System.Drawing.Point(1091, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(69, 19)
        Me.CheckBox2.TabIndex = 31
        Me.CheckBox2.Text = "Alamiert"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Red
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox3.Location = New System.Drawing.Point(1166, 62)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(84, 19)
        Me.CheckBox3.TabIndex = 32
        Me.CheckBox3.Text = "Ausgerückt"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox4.Location = New System.Drawing.Point(1256, 62)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(162, 19)
        Me.CheckBox4.TabIndex = 33
        Me.CheckBox4.Text = "Eingerückt / Einsatzbereit"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox5.Location = New System.Drawing.Point(1256, 112)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(162, 19)
        Me.CheckBox5.TabIndex = 38
        Me.CheckBox5.Text = "Eingerückt / Einsatzbereit"
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Red
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox6.Location = New System.Drawing.Point(1166, 112)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(84, 19)
        Me.CheckBox6.TabIndex = 37
        Me.CheckBox6.Text = "Ausgerückt"
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Yellow
        Me.CheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox7.Location = New System.Drawing.Point(1091, 112)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(69, 19)
        Me.CheckBox7.TabIndex = 36
        Me.CheckBox7.Text = "Alamiert"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(1114, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 25)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "BFKDO Presseteam"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox8.Location = New System.Drawing.Point(1001, 112)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(80, 19)
        Me.CheckBox8.TabIndex = 34
        Me.CheckBox8.Text = "Disponiert"
        Me.CheckBox8.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(434, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Status:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(484, 22)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(72, 20)
        Me.TextBox5.TabIndex = 13
        Me.TextBox5.Text = "NEU"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(434, 364)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(972, 197)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Locking-Informationen"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Aktion})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(966, 172)
        Me.DataGridView1.TabIndex = 1
        '
        'Aktion
        '
        Me.Aktion.HeaderText = "Aktion"
        Me.Aktion.Name = "Aktion"
        Me.Aktion.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 181)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Einsatzort"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(9, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Abschnitt:"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Yellow
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(91, 59)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(303, 26)
        Me.TextBox4.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ort/PLZ:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(91, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 26)
        Me.TextBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(9, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Einsatzort:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Yellow
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(91, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(303, 26)
        Me.TextBox2.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 390)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 171)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Weitere Informationen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(9, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Weitere Infos:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Yellow
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(114, 28)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(280, 118)
        Me.TextBox3.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.b4)
        Me.GroupBox1.Controls.Add(Me.b1)
        Me.GroupBox1.Controls.Add(Me.t1)
        Me.GroupBox1.Controls.Add(Me.s1)
        Me.GroupBox1.Controls.Add(Me.b2)
        Me.GroupBox1.Controls.Add(Me.t2)
        Me.GroupBox1.Controls.Add(Me.s2)
        Me.GroupBox1.Controls.Add(Me.b3)
        Me.GroupBox1.Controls.Add(Me.t3)
        Me.GroupBox1.Controls.Add(Me.s3)
        Me.GroupBox1.Controls.Add(Me.t4)
        Me.GroupBox1.Controls.Add(Me.s4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 147)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Meldebild / Alarmstufe"
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.BackColor = System.Drawing.Color.Yellow
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.CheckBox9.ForeColor = System.Drawing.Color.Black
        Me.CheckBox9.Location = New System.Drawing.Point(274, 22)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox9.TabIndex = 27
        Me.CheckBox9.Text = "Alarmstufenerhöhung"
        Me.CheckBox9.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Alarmstufe:"
        '
        'b4
        '
        Me.b4.AutoSize = True
        Me.b4.BackColor = System.Drawing.Color.Yellow
        Me.b4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.b4.Location = New System.Drawing.Point(229, 21)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(39, 19)
        Me.b4.TabIndex = 24
        Me.b4.Text = "B4"
        Me.b4.UseVisualStyleBackColor = False
        '
        'b1
        '
        Me.b1.AutoSize = True
        Me.b1.BackColor = System.Drawing.Color.Yellow
        Me.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.b1.Location = New System.Drawing.Point(94, 22)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(39, 19)
        Me.b1.TabIndex = 14
        Me.b1.Text = "B1"
        Me.b1.UseVisualStyleBackColor = False
        '
        't1
        '
        Me.t1.AutoSize = True
        Me.t1.BackColor = System.Drawing.Color.Yellow
        Me.t1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.t1.ForeColor = System.Drawing.Color.Black
        Me.t1.Location = New System.Drawing.Point(94, 45)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(38, 19)
        Me.t1.TabIndex = 15
        Me.t1.Text = "T1"
        Me.t1.UseVisualStyleBackColor = False
        '
        's1
        '
        Me.s1.AutoSize = True
        Me.s1.BackColor = System.Drawing.Color.Yellow
        Me.s1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.s1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Location = New System.Drawing.Point(94, 68)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(39, 19)
        Me.s1.TabIndex = 17
        Me.s1.Text = "S1"
        Me.s1.UseVisualStyleBackColor = False
        '
        'b2
        '
        Me.b2.AutoSize = True
        Me.b2.BackColor = System.Drawing.Color.Yellow
        Me.b2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.b2.Location = New System.Drawing.Point(139, 22)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(39, 19)
        Me.b2.TabIndex = 18
        Me.b2.Text = "B2"
        Me.b2.UseVisualStyleBackColor = False
        '
        't2
        '
        Me.t2.AutoSize = True
        Me.t2.BackColor = System.Drawing.Color.Yellow
        Me.t2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.t2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.t2.ForeColor = System.Drawing.Color.Black
        Me.t2.Location = New System.Drawing.Point(139, 45)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(38, 19)
        Me.t2.TabIndex = 19
        Me.t2.Text = "T2"
        Me.t2.UseVisualStyleBackColor = False
        '
        's2
        '
        Me.s2.AutoSize = True
        Me.s2.BackColor = System.Drawing.Color.Yellow
        Me.s2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.s2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.s2.ForeColor = System.Drawing.Color.Black
        Me.s2.Location = New System.Drawing.Point(139, 68)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(39, 19)
        Me.s2.TabIndex = 20
        Me.s2.Text = "S2"
        Me.s2.UseVisualStyleBackColor = False
        '
        'b3
        '
        Me.b3.AutoSize = True
        Me.b3.BackColor = System.Drawing.Color.Yellow
        Me.b3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.b3.Location = New System.Drawing.Point(184, 22)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(39, 19)
        Me.b3.TabIndex = 21
        Me.b3.Text = "B3"
        Me.b3.UseVisualStyleBackColor = False
        '
        't3
        '
        Me.t3.AutoSize = True
        Me.t3.BackColor = System.Drawing.Color.Yellow
        Me.t3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.t3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.t3.ForeColor = System.Drawing.Color.Black
        Me.t3.Location = New System.Drawing.Point(184, 45)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(38, 19)
        Me.t3.TabIndex = 22
        Me.t3.Text = "T3"
        Me.t3.UseVisualStyleBackColor = False
        '
        's3
        '
        Me.s3.AutoSize = True
        Me.s3.BackColor = System.Drawing.Color.Yellow
        Me.s3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.s3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.s3.ForeColor = System.Drawing.Color.Black
        Me.s3.Location = New System.Drawing.Point(184, 68)
        Me.s3.Name = "s3"
        Me.s3.Size = New System.Drawing.Size(39, 19)
        Me.s3.TabIndex = 23
        Me.s3.Text = "S3"
        Me.s3.UseVisualStyleBackColor = False
        '
        't4
        '
        Me.t4.AutoSize = True
        Me.t4.BackColor = System.Drawing.Color.Yellow
        Me.t4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.t4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.t4.ForeColor = System.Drawing.Color.Black
        Me.t4.Location = New System.Drawing.Point(229, 44)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(38, 19)
        Me.t4.TabIndex = 25
        Me.t4.Text = "T4"
        Me.t4.UseVisualStyleBackColor = False
        '
        's4
        '
        Me.s4.AutoSize = True
        Me.s4.BackColor = System.Drawing.Color.Yellow
        Me.s4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.s4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.s4.ForeColor = System.Drawing.Color.Black
        Me.s4.Location = New System.Drawing.Point(229, 68)
        Me.s4.Name = "s4"
        Me.s4.Size = New System.Drawing.Size(39, 19)
        Me.s4.TabIndex = 26
        Me.s4.Text = "S4"
        Me.s4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Meldebild:"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Yellow
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Autobahn - Fahrzeugbrand", "Bahndammbrand", "Brandverdacht", "Flurbrand", "Kaminbrand", "Kleinbrand", "Müllbehälterbrand", "TUS- od. Infranet-Alarm", "Überhitzter Ofen", "Fahrzeugbrand", "Kellerbrand", "Küchenbrand", "Trafobrand", "Waldbrand", "Wohnungsbrand", "Zimmerbrand", "Brand in kl. Gewerbebetrieb", "Dachstuhlbrand", "Geschäftsbrand", "Gewerbebetrieb - klein", "Scheunen- od. Schuppenbrand", "Wohnhausbrand", "Gewerbebetrieb - groß", "Industrieobjekt", "Landw. Objekt", "Autobahn - Ölspur", "Benzin- bzw. Ölaustritt", "Benzin- bzw. Ölspur beseitigen", "Gasaustritt bzw. -gebrechen", "Autobahn - Schadstoffeinsatz", "Chlorgasaustritt", "Kl. Gewässerschaden", "Öltreiben", "Örtl. Chemieunfall", "Chemieunfall m. größeren Umweltschäden", "Tankwagenunfall", "Auspumparbeiten", "Autobahn - Bergung", "Bootsbergung", "Eisstoß", "Fahrzeugbergung", "Hochwasser", "LKW-Bergung", "Motorradbergung", "Person(en) in Aufzug", "Personensuche", "Sturmschaden", "Taucheinsatz", "Technische Hilfeleistung", "Tierrettung", "Türöffnung", "Unwettereinsatz", "Verkehrsunfall", "Wassergebrechen", "Wasserversorgung", "Autobahn - Menschenrettung", "Menschenrettung (1 eingekl. Person)", "Person in Notlage", "VU mit 1 eingekl. Person", "Autobahn - Schwere Bergung", "Autobusunfall", "Eisenbahnunglück", "Menschenrettung (mehrere eingekl. Personen)", "Schiffsunglück", "VU mit mehreren eingekl. Personen"})
        Me.ComboBox2.Location = New System.Drawing.Point(79, 94)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(315, 28)
        Me.ComboBox2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 574)
        Me.Panel1.TabIndex = 43
        '
        'emergency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1418, 573)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.stoppen)
        Me.Controls.Add(Me.starten)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "emergency"
        Me.Text = "Einsatzmaske"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents starten As Button
    Friend WithEvents stoppen As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Aktion As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents b4 As CheckBox
    Friend WithEvents b1 As CheckBox
    Friend WithEvents t1 As CheckBox
    Friend WithEvents s1 As CheckBox
    Friend WithEvents b2 As CheckBox
    Friend WithEvents t2 As CheckBox
    Friend WithEvents s2 As CheckBox
    Friend WithEvents b3 As CheckBox
    Friend WithEvents t3 As CheckBox
    Friend WithEvents s3 As CheckBox
    Friend WithEvents t4 As CheckBox
    Friend WithEvents s4 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
