<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.playbtn = New System.Windows.Forms.Button()
        Me.versionlbl = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.installpathtxt = New System.Windows.Forms.TextBox()
        Me.installpathbtn = New System.Windows.Forms.Button()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.progresslbl = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.optionsstrip = New System.Windows.Forms.ToolStrip()
        Me.javachkbtn = New System.Windows.Forms.ToolStripButton()
        Me.forgechkbtn = New System.Windows.Forms.ToolStripButton()
        Me.musicchkbtn = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.filenamelbl = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.optionsstrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'playbtn
        '
        Me.playbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.playbtn.BackColor = System.Drawing.Color.ForestGreen
        Me.playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.playbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbtn.ForeColor = System.Drawing.Color.White
        Me.playbtn.Image = Global.RiseThyColony_Installer.My.Resources.Resources.book_writable
        Me.playbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.playbtn.Location = New System.Drawing.Point(207, 384)
        Me.playbtn.Name = "playbtn"
        Me.playbtn.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.playbtn.Size = New System.Drawing.Size(227, 54)
        Me.playbtn.TabIndex = 1
        Me.playbtn.Text = "Installieren"
        Me.playbtn.UseVisualStyleBackColor = False
        '
        'versionlbl
        '
        Me.versionlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.versionlbl.BackColor = System.Drawing.Color.Transparent
        Me.versionlbl.Location = New System.Drawing.Point(440, 14)
        Me.versionlbl.Name = "versionlbl"
        Me.versionlbl.Size = New System.Drawing.Size(198, 13)
        Me.versionlbl.TabIndex = 3
        Me.versionlbl.Text = "#.#.#.#"
        Me.versionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(2, 14)
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
        Me.Label1.Location = New System.Drawing.Point(19, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Installationspfad:"
        '
        'installpathtxt
        '
        Me.installpathtxt.Location = New System.Drawing.Point(111, 267)
        Me.installpathtxt.Name = "installpathtxt"
        Me.installpathtxt.ReadOnly = True
        Me.installpathtxt.Size = New System.Drawing.Size(409, 20)
        Me.installpathtxt.TabIndex = 9
        '
        'installpathbtn
        '
        Me.installpathbtn.BackColor = System.Drawing.Color.Black
        Me.installpathbtn.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.planks_spruce
        Me.installpathbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.installpathbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installpathbtn.ForeColor = System.Drawing.Color.White
        Me.installpathbtn.Location = New System.Drawing.Point(526, 265)
        Me.installpathbtn.Name = "installpathbtn"
        Me.installpathbtn.Size = New System.Drawing.Size(96, 23)
        Me.installpathbtn.TabIndex = 10
        Me.installpathbtn.Text = "Durchsuchen..."
        Me.installpathbtn.UseVisualStyleBackColor = False
        '
        'progress
        '
        Me.progress.Location = New System.Drawing.Point(22, 350)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(600, 23)
        Me.progress.TabIndex = 11
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Wähle den Installationsordner für RiseThyColony aus oder lege ihn an:"
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ApplicationData
        '
        'progresslbl
        '
        Me.progresslbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progresslbl.BackColor = System.Drawing.Color.Transparent
        Me.progresslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progresslbl.Location = New System.Drawing.Point(427, 325)
        Me.progresslbl.Name = "progresslbl"
        Me.progresslbl.Size = New System.Drawing.Size(195, 22)
        Me.progresslbl.TabIndex = 18
        Me.progresslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.tlcorner
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 241)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.trcorner
        Me.PictureBox3.Location = New System.Drawing.Point(629, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.blcorner
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 410)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.brcorner
        Me.PictureBox5.Location = New System.Drawing.Point(629, 410)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.topbar
        Me.PictureBox6.Location = New System.Drawing.Point(11, 241)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(619, 13)
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.bottombar
        Me.PictureBox7.Location = New System.Drawing.Point(11, 410)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(619, 13)
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.leftbar
        Me.PictureBox8.Location = New System.Drawing.Point(-1, 253)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(13, 157)
        Me.PictureBox8.TabIndex = 25
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.rightbar
        Me.PictureBox9.Location = New System.Drawing.Point(629, 253)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(13, 157)
        Me.PictureBox9.TabIndex = 26
        Me.PictureBox9.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources._2019_11_06_14_08_39
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 254)
        Me.Panel2.TabIndex = 27
        '
        'optionsstrip
        '
        Me.optionsstrip.AutoSize = False
        Me.optionsstrip.BackColor = System.Drawing.Color.Transparent
        Me.optionsstrip.Dock = System.Windows.Forms.DockStyle.None
        Me.optionsstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.optionsstrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.optionsstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.javachkbtn, Me.forgechkbtn, Me.musicchkbtn})
        Me.optionsstrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.optionsstrip.Location = New System.Drawing.Point(111, 290)
        Me.optionsstrip.Name = "optionsstrip"
        Me.optionsstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.optionsstrip.Size = New System.Drawing.Size(511, 37)
        Me.optionsstrip.TabIndex = 28
        Me.optionsstrip.Text = "Optionen"
        '
        'javachkbtn
        '
        Me.javachkbtn.Image = Global.RiseThyColony_Installer.My.Resources.Resources.dye_powder_brown
        Me.javachkbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.javachkbtn.Name = "javachkbtn"
        Me.javachkbtn.Size = New System.Drawing.Size(146, 36)
        Me.javachkbtn.Text = "Java x64 installieren"
        '
        'forgechkbtn
        '
        Me.forgechkbtn.Image = Global.RiseThyColony_Installer.My.Resources.Resources.iron_ingot
        Me.forgechkbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.forgechkbtn.Name = "forgechkbtn"
        Me.forgechkbtn.Size = New System.Drawing.Size(133, 36)
        Me.forgechkbtn.Text = "Forge installieren"
        '
        'musicchkbtn
        '
        Me.musicchkbtn.Image = Global.RiseThyColony_Installer.My.Resources.Resources.record_13
        Me.musicchkbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.musicchkbtn.Name = "musicchkbtn"
        Me.musicchkbtn.Size = New System.Drawing.Size(135, 36)
        Me.musicchkbtn.Text = "Musik installieren"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Location = New System.Drawing.Point(619, 290)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 45)
        Me.Panel3.TabIndex = 29
        '
        'filenamelbl
        '
        Me.filenamelbl.BackColor = System.Drawing.Color.Transparent
        Me.filenamelbl.LinkColor = System.Drawing.Color.White
        Me.filenamelbl.Location = New System.Drawing.Point(19, 325)
        Me.filenamelbl.Name = "filenamelbl"
        Me.filenamelbl.Size = New System.Drawing.Size(415, 22)
        Me.filenamelbl.TabIndex = 30
        Me.filenamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RiseThyColony_Installer.My.Resources.Resources.bgpanel
        Me.ClientSize = New System.Drawing.Size(641, 448)
        Me.Controls.Add(Me.filenamelbl)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.progresslbl)
        Me.Controls.Add(Me.optionsstrip)
        Me.Controls.Add(Me.playbtn)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.installpathbtn)
        Me.Controls.Add(Me.installpathtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiseThyColony Installer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.optionsstrip.ResumeLayout(False)
        Me.optionsstrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents playbtn As Button
    Friend WithEvents versionlbl As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents installpathtxt As TextBox
    Friend WithEvents installpathbtn As Button
    Friend WithEvents progress As ProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents progresslbl As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents optionsstrip As ToolStrip
    Friend WithEvents forgechkbtn As ToolStripButton
    Friend WithEvents javachkbtn As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents filenamelbl As LinkLabel
    Friend WithEvents musicchkbtn As ToolStripButton
End Class
