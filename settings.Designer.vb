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
        Me.installpathbtn = New System.Windows.Forms.Button()
        Me.installpathtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JavaOptions = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.debugtab = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.attxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cttxt = New System.Windows.Forms.TextBox()
        Me.jsonresult = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.useridtxt = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.AppOptions.SuspendLayout()
        Me.JavaOptions.SuspendLayout()
        Me.debugtab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AppOptions)
        Me.TabControl1.Controls.Add(Me.JavaOptions)
        Me.TabControl1.Controls.Add(Me.debugtab)
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
        'installpathbtn
        '
        Me.installpathbtn.BackColor = System.Drawing.Color.Black
        Me.installpathbtn.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.planks_spruce
        Me.installpathbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.installpathbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installpathbtn.ForeColor = System.Drawing.Color.White
        Me.installpathbtn.Location = New System.Drawing.Point(382, 6)
        Me.installpathbtn.Name = "installpathbtn"
        Me.installpathbtn.Size = New System.Drawing.Size(96, 23)
        Me.installpathbtn.TabIndex = 13
        Me.installpathbtn.Text = "Durchsuchen..."
        Me.installpathbtn.UseVisualStyleBackColor = False
        '
        'installpathtxt
        '
        Me.installpathtxt.Location = New System.Drawing.Point(97, 8)
        Me.installpathtxt.Name = "installpathtxt"
        Me.installpathtxt.ReadOnly = True
        Me.installpathtxt.Size = New System.Drawing.Size(279, 20)
        Me.installpathtxt.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Installationspfad:"
        '
        'JavaOptions
        '
        Me.JavaOptions.Controls.Add(Me.Button1)
        Me.JavaOptions.Controls.Add(Me.TextBox1)
        Me.JavaOptions.Controls.Add(Me.Label2)
        Me.JavaOptions.Location = New System.Drawing.Point(4, 22)
        Me.JavaOptions.Name = "JavaOptions"
        Me.JavaOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.JavaOptions.Size = New System.Drawing.Size(484, 235)
        Me.JavaOptions.TabIndex = 1
        Me.JavaOptions.Text = "Java-Einstellungen"
        Me.JavaOptions.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Java-Pfad:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.planks_spruce
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(382, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Durchsuchen..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'debugtab
        '
        Me.debugtab.Controls.Add(Me.jsonresult)
        Me.debugtab.Controls.Add(Me.useridtxt)
        Me.debugtab.Controls.Add(Me.usernametxt)
        Me.debugtab.Controls.Add(Me.cttxt)
        Me.debugtab.Controls.Add(Me.Label6)
        Me.debugtab.Controls.Add(Me.attxt)
        Me.debugtab.Controls.Add(Me.Label5)
        Me.debugtab.Controls.Add(Me.Label4)
        Me.debugtab.Controls.Add(Me.Label3)
        Me.debugtab.Location = New System.Drawing.Point(4, 22)
        Me.debugtab.Name = "debugtab"
        Me.debugtab.Padding = New System.Windows.Forms.Padding(3)
        Me.debugtab.Size = New System.Drawing.Size(484, 235)
        Me.debugtab.TabIndex = 2
        Me.debugtab.Text = "Debug"
        Me.debugtab.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Access Token"
        '
        'attxt
        '
        Me.attxt.Location = New System.Drawing.Point(90, 6)
        Me.attxt.Name = "attxt"
        Me.attxt.ReadOnly = True
        Me.attxt.Size = New System.Drawing.Size(388, 20)
        Me.attxt.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Client Token"
        '
        'cttxt
        '
        Me.cttxt.Location = New System.Drawing.Point(90, 32)
        Me.cttxt.Name = "cttxt"
        Me.cttxt.ReadOnly = True
        Me.cttxt.Size = New System.Drawing.Size(388, 20)
        Me.cttxt.TabIndex = 1
        '
        'jsonresult
        '
        Me.jsonresult.Location = New System.Drawing.Point(8, 201)
        Me.jsonresult.Name = "jsonresult"
        Me.jsonresult.Size = New System.Drawing.Size(153, 23)
        Me.jsonresult.TabIndex = 2
        Me.jsonresult.Text = "Mojang-Response anzeigen"
        Me.jsonresult.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Username"
        '
        'usernametxt
        '
        Me.usernametxt.Location = New System.Drawing.Point(90, 58)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.ReadOnly = True
        Me.usernametxt.Size = New System.Drawing.Size(388, 20)
        Me.usernametxt.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "UserID"
        '
        'useridtxt
        '
        Me.useridtxt.Location = New System.Drawing.Point(90, 84)
        Me.useridtxt.Name = "useridtxt"
        Me.useridtxt.ReadOnly = True
        Me.useridtxt.Size = New System.Drawing.Size(388, 20)
        Me.useridtxt.TabIndex = 1
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
        Me.JavaOptions.ResumeLayout(False)
        Me.JavaOptions.PerformLayout()
        Me.debugtab.ResumeLayout(False)
        Me.debugtab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AppOptions As TabPage
    Friend WithEvents JavaOptions As TabPage
    Friend WithEvents installpathbtn As Button
    Friend WithEvents installpathtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents debugtab As TabPage
    Friend WithEvents cttxt As TextBox
    Friend WithEvents attxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents jsonresult As Button
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents useridtxt As TextBox
    Friend WithEvents Label6 As Label
End Class
