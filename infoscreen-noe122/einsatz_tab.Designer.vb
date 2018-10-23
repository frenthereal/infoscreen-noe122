<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class einsatz_tab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(einsatz_tab))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlamierungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlamierungsmaskeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusmaskeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMINGSOONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KartenmanagmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbwesenheitsbildschirmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MobileEditionGrisuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlamierungToolStripMenuItem, Me.COMINGSOONToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlamierungToolStripMenuItem
        '
        Me.AlamierungToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlamierungsmaskeToolStripMenuItem, Me.StatusmaskeToolStripMenuItem})
        Me.AlamierungToolStripMenuItem.Name = "AlamierungToolStripMenuItem"
        Me.AlamierungToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.AlamierungToolStripMenuItem.Text = "Einsatzmasken"
        '
        'AlamierungsmaskeToolStripMenuItem
        '
        Me.AlamierungsmaskeToolStripMenuItem.Name = "AlamierungsmaskeToolStripMenuItem"
        Me.AlamierungsmaskeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AlamierungsmaskeToolStripMenuItem.Text = "Alamierungsmaske"
        '
        'StatusmaskeToolStripMenuItem
        '
        Me.StatusmaskeToolStripMenuItem.Name = "StatusmaskeToolStripMenuItem"
        Me.StatusmaskeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.StatusmaskeToolStripMenuItem.Text = "Statusmaske"
        '
        'COMINGSOONToolStripMenuItem
        '
        Me.COMINGSOONToolStripMenuItem.Name = "COMINGSOONToolStripMenuItem"
        Me.COMINGSOONToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.COMINGSOONToolStripMenuItem.Text = " ! - COMING SOON - !"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KartenmanagmentToolStripMenuItem, Me.AbwesenheitsbildschirmToolStripMenuItem, Me.MobileEditionGrisuToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'KartenmanagmentToolStripMenuItem
        '
        Me.KartenmanagmentToolStripMenuItem.Name = "KartenmanagmentToolStripMenuItem"
        Me.KartenmanagmentToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.KartenmanagmentToolStripMenuItem.Text = "Kartenmanagment"
        '
        'AbwesenheitsbildschirmToolStripMenuItem
        '
        Me.AbwesenheitsbildschirmToolStripMenuItem.Name = "AbwesenheitsbildschirmToolStripMenuItem"
        Me.AbwesenheitsbildschirmToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AbwesenheitsbildschirmToolStripMenuItem.Text = "Abwesenheitsbildschirm"
        '
        'MobileEditionGrisuToolStripMenuItem
        '
        Me.MobileEditionGrisuToolStripMenuItem.Name = "MobileEditionGrisuToolStripMenuItem"
        Me.MobileEditionGrisuToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MobileEditionGrisuToolStripMenuItem.Text = "Mobile-Edition Grisu"
        '
        'einsatz_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "einsatz_tab"
        Me.Text = "Einsatz - Tab"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlamierungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMINGSOONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlamierungsmaskeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusmaskeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KartenmanagmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbwesenheitsbildschirmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MobileEditionGrisuToolStripMenuItem As ToolStripMenuItem
End Class
