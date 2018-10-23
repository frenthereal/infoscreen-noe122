<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class idle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(idle))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.einsatz1stufe = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.einsatz1melde = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.einsatz1ort = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.einsatz2stufe = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.einsatz2melde = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.einsatz2ort = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 17.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 1042)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1301, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WASTL Infoscreen 3.2 | Powered by FF Krems | A. Suppan, S. Spanninger, E. Bachmay" &
    "er, G. Urschler | www.feuerwehr-krems.at"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 27.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1500, 1030)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "$DATUM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 27.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1716, 1030)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "$UHRZEIT"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1015)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1920, 65)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1867, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ADMIN"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.einsatz1stufe)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.einsatz1melde)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.einsatz1ort)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.einsatz2stufe)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.einsatz2melde)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.einsatz2ort)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 1015)
        Me.Panel1.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(195, 549)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(599, 61)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "TUS- od. Infranet-Alarm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(32, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(409, 61)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Letzte Einsätze:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(204, 904)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(221, 32)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "2540 Bad Vöslau"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(195, 844)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(599, 61)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "TUS- od. Infranet-Alarm"
        '
        'einsatz1stufe
        '
        Me.einsatz1stufe.AutoSize = True
        Me.einsatz1stufe.BackColor = System.Drawing.Color.Red
        Me.einsatz1stufe.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.einsatz1stufe.ForeColor = System.Drawing.Color.Transparent
        Me.einsatz1stufe.Location = New System.Drawing.Point(54, 116)
        Me.einsatz1stufe.Name = "einsatz1stufe"
        Me.einsatz1stufe.Size = New System.Drawing.Size(135, 89)
        Me.einsatz1stufe.TabIndex = 6
        Me.einsatz1stufe.Text = "B1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Red
        Me.Label19.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(54, 854)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(135, 89)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "B1"
        '
        'einsatz1melde
        '
        Me.einsatz1melde.AutoSize = True
        Me.einsatz1melde.BackColor = System.Drawing.Color.Transparent
        Me.einsatz1melde.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.einsatz1melde.ForeColor = System.Drawing.Color.White
        Me.einsatz1melde.Location = New System.Drawing.Point(195, 106)
        Me.einsatz1melde.Name = "einsatz1melde"
        Me.einsatz1melde.Size = New System.Drawing.Size(311, 61)
        Me.einsatz1melde.TabIndex = 7
        Me.einsatz1melde.Text = "$EINSATZ1"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Red
        Me.PictureBox6.Location = New System.Drawing.Point(43, 844)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'einsatz1ort
        '
        Me.einsatz1ort.AutoSize = True
        Me.einsatz1ort.BackColor = System.Drawing.Color.Transparent
        Me.einsatz1ort.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.einsatz1ort.ForeColor = System.Drawing.Color.White
        Me.einsatz1ort.Location = New System.Drawing.Point(204, 166)
        Me.einsatz1ort.Name = "einsatz1ort"
        Me.einsatz1ort.Size = New System.Drawing.Size(229, 32)
        Me.einsatz1ort.TabIndex = 8
        Me.einsatz1ort.Text = "$EINSATZ1_ORT"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(204, 754)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(221, 32)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "2540 Bad Vöslau"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(195, 694)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(599, 61)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "TUS- od. Infranet-Alarm"
        '
        'einsatz2stufe
        '
        Me.einsatz2stufe.AutoSize = True
        Me.einsatz2stufe.BackColor = System.Drawing.Color.Red
        Me.einsatz2stufe.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.einsatz2stufe.ForeColor = System.Drawing.Color.Transparent
        Me.einsatz2stufe.Location = New System.Drawing.Point(54, 266)
        Me.einsatz2stufe.Name = "einsatz2stufe"
        Me.einsatz2stufe.Size = New System.Drawing.Size(135, 89)
        Me.einsatz2stufe.TabIndex = 10
        Me.einsatz2stufe.Text = "B1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.Label22.ForeColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(54, 704)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(135, 89)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "B1"
        '
        'einsatz2melde
        '
        Me.einsatz2melde.AutoSize = True
        Me.einsatz2melde.BackColor = System.Drawing.Color.Transparent
        Me.einsatz2melde.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.einsatz2melde.ForeColor = System.Drawing.Color.White
        Me.einsatz2melde.Location = New System.Drawing.Point(195, 256)
        Me.einsatz2melde.Name = "einsatz2melde"
        Me.einsatz2melde.Size = New System.Drawing.Size(599, 61)
        Me.einsatz2melde.TabIndex = 11
        Me.einsatz2melde.Text = "TUS- od. Infranet-Alarm"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Red
        Me.PictureBox7.Location = New System.Drawing.Point(43, 694)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox7.TabIndex = 21
        Me.PictureBox7.TabStop = False
        '
        'einsatz2ort
        '
        Me.einsatz2ort.AutoSize = True
        Me.einsatz2ort.BackColor = System.Drawing.Color.Transparent
        Me.einsatz2ort.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.einsatz2ort.ForeColor = System.Drawing.Color.White
        Me.einsatz2ort.Location = New System.Drawing.Point(204, 316)
        Me.einsatz2ort.Name = "einsatz2ort"
        Me.einsatz2ort.Size = New System.Drawing.Size(221, 32)
        Me.einsatz2ort.TabIndex = 12
        Me.einsatz2ort.Text = "2540 Bad Vöslau"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(204, 609)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(221, 32)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "2540 Bad Vöslau"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Red
        Me.Label16.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(54, 409)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 89)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "B1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Red
        Me.Label13.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(54, 559)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 89)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "B1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(195, 399)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(599, 61)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "TUS- od. Infranet-Alarm"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(43, 549)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(204, 459)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(221, 32)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "2540 Bad Vöslau"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Location = New System.Drawing.Point(43, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Red
        Me.PictureBox3.Location = New System.Drawing.Point(43, 256)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Red
        Me.PictureBox5.Location = New System.Drawing.Point(43, 399)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(803, 26)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1105, 983)
        Me.WebBrowser1.TabIndex = 31
        Me.WebBrowser1.Url = New System.Uri("https://www.feuerwehr-krems.at/CodePages/Wastl/wastlmain/ShowOverview.asp", System.UriKind.Absolute)
        '
        'idle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "idle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "- INFOSCREEN -"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents einsatz1stufe As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents einsatz1melde As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents einsatz1ort As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents einsatz2stufe As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents einsatz2melde As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents einsatz2ort As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
