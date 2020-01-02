<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class console
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(console))
        Me.debuglbl = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogSpeichernUnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'debuglbl
        '
        Me.debuglbl.BackColor = System.Drawing.Color.Black
        Me.debuglbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.debuglbl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.debuglbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.debuglbl.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debuglbl.ForeColor = System.Drawing.Color.Gray
        Me.debuglbl.Location = New System.Drawing.Point(0, 24)
        Me.debuglbl.Margin = New System.Windows.Forms.Padding(6)
        Me.debuglbl.Name = "debuglbl"
        Me.debuglbl.ReadOnly = True
        Me.debuglbl.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.debuglbl.Size = New System.Drawing.Size(904, 487)
        Me.debuglbl.TabIndex = 1
        Me.debuglbl.Text = ""
        Me.debuglbl.ZoomFactor = 1.3!
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(904, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogSpeichernUnterToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DimGray
        Me.ToolStripMenuItem1.Image = Global.Symphonia_Installer.My.Resources.Resources.icons8_console_16
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem1.Text = "Menü"
        '
        'LogSpeichernUnterToolStripMenuItem
        '
        Me.LogSpeichernUnterToolStripMenuItem.Image = Global.Symphonia_Installer.My.Resources.Resources.save
        Me.LogSpeichernUnterToolStripMenuItem.Name = "LogSpeichernUnterToolStripMenuItem"
        Me.LogSpeichernUnterToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LogSpeichernUnterToolStripMenuItem.Text = "Log speichern unter..."
        '
        'console
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 511)
        Me.Controls.Add(Me.debuglbl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "console"
        Me.Text = "Konsole"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents debuglbl As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogSpeichernUnterToolStripMenuItem As ToolStripMenuItem
End Class
