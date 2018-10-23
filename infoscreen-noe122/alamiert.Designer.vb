<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class alamiert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alamiert))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ORT = New System.Windows.Forms.Label()
        Me.ART = New System.Windows.Forms.Label()
        Me.STUFE = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gasse = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ORT
        '
        Me.ORT.AutoSize = True
        Me.ORT.BackColor = System.Drawing.Color.Transparent
        Me.ORT.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.ORT.ForeColor = System.Drawing.Color.White
        Me.ORT.Location = New System.Drawing.Point(45, 209)
        Me.ORT.Name = "ORT"
        Me.ORT.Size = New System.Drawing.Size(125, 45)
        Me.ORT.TabIndex = 13
        Me.ORT.Text = "$ORT"
        '
        'ART
        '
        Me.ART.AutoSize = True
        Me.ART.BackColor = System.Drawing.Color.Transparent
        Me.ART.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.ART.ForeColor = System.Drawing.Color.White
        Me.ART.Location = New System.Drawing.Point(173, 40)
        Me.ART.Name = "ART"
        Me.ART.Size = New System.Drawing.Size(388, 61)
        Me.ART.TabIndex = 12
        Me.ART.Text = "$EINSATZART"
        '
        'STUFE
        '
        Me.STUFE.AutoSize = True
        Me.STUFE.BackColor = System.Drawing.Color.Transparent
        Me.STUFE.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.STUFE.ForeColor = System.Drawing.Color.Transparent
        Me.STUFE.Location = New System.Drawing.Point(32, 32)
        Me.STUFE.Name = "STUFE"
        Me.STUFE.Size = New System.Drawing.Size(135, 89)
        Me.STUFE.TabIndex = 11
        Me.STUFE.Text = "$S"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 40.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1508, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 61)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "BV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1681, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Freiwillige Feuerwehr Bad Vöslau"
        '
        'gasse
        '
        Me.gasse.AutoSize = True
        Me.gasse.BackColor = System.Drawing.Color.Transparent
        Me.gasse.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.gasse.ForeColor = System.Drawing.Color.White
        Me.gasse.Location = New System.Drawing.Point(44, 164)
        Me.gasse.Name = "gasse"
        Me.gasse.Size = New System.Drawing.Size(181, 45)
        Me.gasse.TabIndex = 19
        Me.gasse.Text = "$GASSE"
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.info.ForeColor = System.Drawing.Color.White
        Me.info.Location = New System.Drawing.Point(47, 324)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(110, 36)
        Me.info.TabIndex = 20
        Me.info.Text = "$INFO"
        '
        'Timer2
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1681, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "BFKDO Presseteam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(45, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 45)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "$ABSCHNITT"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.infoscreen_noe122.My.Resources.Resources.male_user
        Me.PictureBox7.Location = New System.Drawing.Point(12, 935)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PictureBox6.Location = New System.Drawing.Point(1670, 68)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(238, 50)
        Me.PictureBox6.TabIndex = 21
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(1670, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(238, 50)
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(1483, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Location = New System.Drawing.Point(1657, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(263, 1080)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(21, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 121)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(82, 953)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(109, 953)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(97, 953)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 17.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1727, 1048)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "$UHRZEIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1694, 1025)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 46)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "$UHRZEIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1461, 1025)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 46)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "$DATUM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 17.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(12, 1041)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1301, 26)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "WASTL Infoscreen 3.2 | Powered by FF Krems | A. Suppan, S. Spanninger, E. Bachmay" &
    "er, G. Urschler | www.feuerwehr-krems.at"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1015)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1657, 65)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'alamiert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.gasse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ORT)
        Me.Controls.Add(Me.ART)
        Me.Controls.Add(Me.STUFE)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "alamiert"
        Me.Text = "- INFOSCREEN -"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ORT As Label
    Friend WithEvents ART As Label
    Friend WithEvents STUFE As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gasse As Label
    Friend WithEvents info As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
