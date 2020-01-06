<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AppOptions = New System.Windows.Forms.TabPage()
        Me.JavaOptions = New System.Windows.Forms.TabPage()
        Me.installpathbtn = New System.Windows.Forms.Button()
        Me.installpathtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.AppOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AppOptions)
        Me.TabControl1.Controls.Add(Me.JavaOptions)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(492, 261)
        Me.TabControl1.TabIndex = 0
        '
        'AppOptions
        '
        Me.AppOptions.Controls.Add(Me.installpathbtn)
        Me.AppOptions.Controls.Add(Me.installpathtxt)
        Me.AppOptions.Controls.Add(Me.Label1)
        Me.AppOptions.Location = New System.Drawing.Point(4, 22)
        Me.AppOptions.Name = "AppOptions"
        Me.AppOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.AppOptions.Size = New System.Drawing.Size(484, 235)
        Me.AppOptions.TabIndex = 0
        Me.AppOptions.Text = "Programm-Einstellungen"
        Me.AppOptions.UseVisualStyleBackColor = True
        '
        'JavaOptions
        '
        Me.JavaOptions.Location = New System.Drawing.Point(4, 22)
        Me.JavaOptions.Name = "JavaOptions"
        Me.JavaOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.JavaOptions.Size = New System.Drawing.Size(484, 235)
        Me.JavaOptions.TabIndex = 1
        Me.JavaOptions.Text = "Java-Einstellungen"
        Me.JavaOptions.UseVisualStyleBackColor = True
        '
        'installpathbtn
        '
        Me.installpathbtn.BackColor = System.Drawing.Color.Black
        Me.installpathbtn.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.planks_spruce
        Me.installpathbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.installpathbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installpathbtn.ForeColor = System.Drawing.Color.White
        Me.installpathbtn.Location = New System.Drawing.Point(382, 3)
        Me.installpathbtn.Name = "installpathbtn"
        Me.installpathbtn.Size = New System.Drawing.Size(96, 23)
        Me.installpathbtn.TabIndex = 13
        Me.installpathbtn.Text = "Durchsuchen..."
        Me.installpathbtn.UseVisualStyleBackColor = False
        '
        'installpathtxt
        '
        Me.installpathtxt.Location = New System.Drawing.Point(99, 5)
        Me.installpathtxt.Name = "installpathtxt"
        Me.installpathtxt.ReadOnly = True
        Me.installpathtxt.Size = New System.Drawing.Size(277, 20)
        Me.installpathtxt.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Installationspfad:"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 261)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.TabControl1.ResumeLayout(False)
        Me.AppOptions.ResumeLayout(False)
        Me.AppOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AppOptions As TabPage
    Friend WithEvents JavaOptions As TabPage
    Friend WithEvents installpathbtn As Button
    Friend WithEvents installpathtxt As TextBox
    Friend WithEvents Label1 As Label
End Class
