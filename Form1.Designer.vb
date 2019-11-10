<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.playbtn = New System.Windows.Forms.Button()
        Me.versionlbl = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.installpathtxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.filenamelbl = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources._2019_11_06_14_08_39
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(641, 255)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'playbtn
        '
        Me.playbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.playbtn.BackColor = System.Drawing.Color.ForestGreen
        Me.playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.playbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbtn.ForeColor = System.Drawing.Color.White
        Me.playbtn.Location = New System.Drawing.Point(215, 383)
        Me.playbtn.Name = "playbtn"
        Me.playbtn.Size = New System.Drawing.Size(211, 54)
        Me.playbtn.TabIndex = 1
        Me.playbtn.Text = "Installieren"
        Me.playbtn.UseVisualStyleBackColor = False
        '
        'versionlbl
        '
        Me.versionlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.versionlbl.AutoSize = True
        Me.versionlbl.BackColor = System.Drawing.Color.Transparent
        Me.versionlbl.Location = New System.Drawing.Point(585, 10)
        Me.versionlbl.Name = "versionlbl"
        Me.versionlbl.Size = New System.Drawing.Size(44, 13)
        Me.versionlbl.TabIndex = 3
        Me.versionlbl.Text = "#.#.#.#"
        Me.versionlbl.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(197, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "©2019 Onkelz-Freak1993 / Gingolingoo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.nether_brick
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.versionlbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 32)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Installationspfad:"
        '
        'installpathtxt
        '
        Me.installpathtxt.Location = New System.Drawing.Point(104, 267)
        Me.installpathtxt.Name = "installpathtxt"
        Me.installpathtxt.ReadOnly = True
        Me.installpathtxt.Size = New System.Drawing.Size(416, 20)
        Me.installpathtxt.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(526, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Durchsuchen..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'progress
        '
        Me.progress.Location = New System.Drawing.Point(15, 350)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(614, 23)
        Me.progress.TabIndex = 11
        '
        'filenamelbl
        '
        Me.filenamelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filenamelbl.BackColor = System.Drawing.Color.Transparent
        Me.filenamelbl.Location = New System.Drawing.Point(15, 324)
        Me.filenamelbl.Name = "filenamelbl"
        Me.filenamelbl.Size = New System.Drawing.Size(614, 23)
        Me.filenamelbl.TabIndex = 14
        Me.filenamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Wähle den Installationsordner für RiseThyColony aus oder lege ihn an:"
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ApplicationData
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(104, 293)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Java x64 installieren"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(231, 293)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "Forge installieren"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.planks_big_oak
        Me.ClientSize = New System.Drawing.Size(641, 448)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.filenamelbl)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.installpathtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiseThyColony Installer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents playbtn As Button
    Friend WithEvents versionlbl As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents installpathtxt As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents progress As ProgressBar
    Friend WithEvents filenamelbl As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
