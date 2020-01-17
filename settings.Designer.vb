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
        Me.SelectedGameVersion = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Xmxtxt = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Xmstxt = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.javapathbtn = New System.Windows.Forms.Button()
        Me.javapathtxt = New System.Windows.Forms.TextBox()
        Me.gameversionlbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.debugtab = New System.Windows.Forms.TabPage()
        Me.jsonresult = New System.Windows.Forms.Button()
        Me.useridtxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.cttxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.attxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.AppOptions.SuspendLayout()
        Me.JavaOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Xmxtxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xmstxt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.JavaOptions.Controls.Add(Me.SelectedGameVersion)
        Me.JavaOptions.Controls.Add(Me.GroupBox1)
        Me.JavaOptions.Controls.Add(Me.javapathbtn)
        Me.JavaOptions.Controls.Add(Me.javapathtxt)
        Me.JavaOptions.Controls.Add(Me.gameversionlbl)
        Me.JavaOptions.Controls.Add(Me.Label2)
        Me.JavaOptions.Location = New System.Drawing.Point(4, 22)
        Me.JavaOptions.Name = "JavaOptions"
        Me.JavaOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.JavaOptions.Size = New System.Drawing.Size(484, 235)
        Me.JavaOptions.TabIndex = 1
        Me.JavaOptions.Text = "Java-Einstellungen"
        Me.JavaOptions.UseVisualStyleBackColor = True
        '
        'SelectedGameVersion
        '
        Me.SelectedGameVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectedGameVersion.FormattingEnabled = True
        Me.SelectedGameVersion.Location = New System.Drawing.Point(81, 37)
        Me.SelectedGameVersion.Name = "SelectedGameVersion"
        Me.SelectedGameVersion.Size = New System.Drawing.Size(295, 21)
        Me.SelectedGameVersion.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 165)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Java-Parameter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Xmxtxt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Xmstxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 76)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Zugewiesener Speicher"
        '
        'Xmxtxt
        '
        Me.Xmxtxt.Location = New System.Drawing.Point(91, 45)
        Me.Xmxtxt.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.Xmxtxt.Name = "Xmxtxt"
        Me.Xmxtxt.Size = New System.Drawing.Size(55, 20)
        Me.Xmxtxt.TabIndex = 19
        Me.Xmxtxt.Value = New Decimal(New Integer() {4096, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(152, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "MB"
        '
        'Xmstxt
        '
        Me.Xmstxt.Location = New System.Drawing.Point(91, 19)
        Me.Xmstxt.Maximum = New Decimal(New Integer() {2048, 0, 0, 0})
        Me.Xmstxt.Minimum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.Xmstxt.Name = "Xmstxt"
        Me.Xmstxt.Size = New System.Drawing.Size(55, 20)
        Me.Xmstxt.TabIndex = 20
        Me.Xmstxt.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Arbeitsspeicher:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Heap-Größe:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(152, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "MB"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(113, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(353, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Weitere Argumente:"
        '
        'javapathbtn
        '
        Me.javapathbtn.BackColor = System.Drawing.Color.Black
        Me.javapathbtn.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.planks_spruce
        Me.javapathbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.javapathbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.javapathbtn.ForeColor = System.Drawing.Color.White
        Me.javapathbtn.Location = New System.Drawing.Point(382, 6)
        Me.javapathbtn.Name = "javapathbtn"
        Me.javapathbtn.Size = New System.Drawing.Size(96, 23)
        Me.javapathbtn.TabIndex = 14
        Me.javapathbtn.Text = "Durchsuchen..."
        Me.javapathbtn.UseVisualStyleBackColor = False
        '
        'javapathtxt
        '
        Me.javapathtxt.Location = New System.Drawing.Point(81, 8)
        Me.javapathtxt.Name = "javapathtxt"
        Me.javapathtxt.ReadOnly = True
        Me.javapathtxt.Size = New System.Drawing.Size(295, 20)
        Me.javapathtxt.TabIndex = 1
        '
        'gameversionlbl
        '
        Me.gameversionlbl.AutoSize = True
        Me.gameversionlbl.Location = New System.Drawing.Point(8, 40)
        Me.gameversionlbl.Name = "gameversionlbl"
        Me.gameversionlbl.Size = New System.Drawing.Size(67, 13)
        Me.gameversionlbl.TabIndex = 0
        Me.gameversionlbl.Text = "Spielversion:"
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
        'jsonresult
        '
        Me.jsonresult.Location = New System.Drawing.Point(8, 201)
        Me.jsonresult.Name = "jsonresult"
        Me.jsonresult.Size = New System.Drawing.Size(153, 23)
        Me.jsonresult.TabIndex = 2
        Me.jsonresult.Text = "Mojang-Response anzeigen"
        Me.jsonresult.UseVisualStyleBackColor = True
        '
        'useridtxt
        '
        Me.useridtxt.Location = New System.Drawing.Point(90, 84)
        Me.useridtxt.Name = "useridtxt"
        Me.useridtxt.ReadOnly = True
        Me.useridtxt.Size = New System.Drawing.Size(388, 20)
        Me.useridtxt.TabIndex = 1
        '
        'usernametxt
        '
        Me.usernametxt.Location = New System.Drawing.Point(90, 58)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.ReadOnly = True
        Me.usernametxt.Size = New System.Drawing.Size(388, 20)
        Me.usernametxt.TabIndex = 1
        '
        'cttxt
        '
        Me.cttxt.Location = New System.Drawing.Point(90, 32)
        Me.cttxt.Name = "cttxt"
        Me.cttxt.ReadOnly = True
        Me.cttxt.Size = New System.Drawing.Size(388, 20)
        Me.cttxt.TabIndex = 1
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
        'attxt
        '
        Me.attxt.Location = New System.Drawing.Point(90, 6)
        Me.attxt.Name = "attxt"
        Me.attxt.ReadOnly = True
        Me.attxt.Size = New System.Drawing.Size(388, 20)
        Me.attxt.TabIndex = 1
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Client Token"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Xmxtxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xmstxt, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents javapathbtn As Button
    Friend WithEvents javapathtxt As TextBox
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
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Xmstxt As NumericUpDown
    Friend WithEvents Xmxtxt As NumericUpDown
    Friend WithEvents SelectedGameVersion As ComboBox
    Friend WithEvents gameversionlbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
End Class
