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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.playbtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.usernamelbl = New System.Windows.Forms.ToolStripMenuItem()
        Me.versionlbl = New System.Windows.Forms.ToolStripMenuItem()
        Me.filenamelbl = New System.Windows.Forms.LinkLabel()
        Me.consolebtn = New System.Windows.Forms.Button()
        Me.trayicon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.showtsmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.consoletsmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.dividertsmenu = New System.Windows.Forms.ToolStripSeparator()
        Me.closetsmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.repairbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BenutzerWechselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'playbtn
        '
        Me.playbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.playbtn.BackColor = System.Drawing.Color.ForestGreen
        Me.playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.playbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbtn.ForeColor = System.Drawing.Color.White
        Me.playbtn.Image = Global.Symphonia_Installer.My.Resources.Resources.book_writable
        Me.playbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.playbtn.Location = New System.Drawing.Point(207, 302)
        Me.playbtn.Name = "playbtn"
        Me.playbtn.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.playbtn.Size = New System.Drawing.Size(227, 54)
        Me.playbtn.TabIndex = 1
        Me.playbtn.Text = "Installieren"
        Me.playbtn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.nether_brick
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 32)
        Me.Panel1.TabIndex = 7
        '
        'progress
        '
        Me.progress.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.progress.Location = New System.Drawing.Point(22, 284)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(600, 12)
        Me.progress.TabIndex = 11
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Wähle den Installationsordner für RiseThyColony aus oder lege ihn an:"
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ApplicationData
        '
        'progresslbl
        '
        Me.progresslbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.progresslbl.BackColor = System.Drawing.Color.Transparent
        Me.progresslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progresslbl.Location = New System.Drawing.Point(427, 259)
        Me.progresslbl.Name = "progresslbl"
        Me.progresslbl.Size = New System.Drawing.Size(195, 22)
        Me.progresslbl.TabIndex = 18
        Me.progresslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.tlcorner
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 241)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.trcorner
        Me.PictureBox3.Location = New System.Drawing.Point(629, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.blcorner
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 328)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.brcorner
        Me.PictureBox5.Location = New System.Drawing.Point(629, 328)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.topbar
        Me.PictureBox6.Location = New System.Drawing.Point(11, 241)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(619, 13)
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.bottombar
        Me.PictureBox7.Location = New System.Drawing.Point(11, 328)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(619, 13)
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.leftbar
        Me.PictureBox8.Location = New System.Drawing.Point(-1, 253)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(13, 75)
        Me.PictureBox8.TabIndex = 25
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.rightbar
        Me.PictureBox9.Location = New System.Drawing.Point(629, 253)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(13, 75)
        Me.PictureBox9.TabIndex = 26
        Me.PictureBox9.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources._2019_12_31_14_57_20
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 254)
        Me.Panel2.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(11, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(619, 208)
        Me.Panel4.TabIndex = 24
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.usernamelbl, Me.versionlbl})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(641, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'usernamelbl
        '
        Me.usernamelbl.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BenutzerWechselnToolStripMenuItem, Me.ToolStripMenuItem1, Me.BeendenToolStripMenuItem})
        Me.usernamelbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(105, 20)
        Me.usernamelbl.Text = "Eingeloggt als ..."
        '
        'versionlbl
        '
        Me.versionlbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.versionlbl.Enabled = False
        Me.versionlbl.Name = "versionlbl"
        Me.versionlbl.Size = New System.Drawing.Size(56, 20)
        Me.versionlbl.Text = "#.#.#.#"
        '
        'filenamelbl
        '
        Me.filenamelbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.filenamelbl.BackColor = System.Drawing.Color.Transparent
        Me.filenamelbl.LinkColor = System.Drawing.Color.White
        Me.filenamelbl.Location = New System.Drawing.Point(19, 259)
        Me.filenamelbl.Name = "filenamelbl"
        Me.filenamelbl.Size = New System.Drawing.Size(415, 22)
        Me.filenamelbl.TabIndex = 30
        Me.filenamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'consolebtn
        '
        Me.consolebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.consolebtn.BackColor = System.Drawing.Color.Black
        Me.consolebtn.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.planks_spruce
        Me.consolebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.consolebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consolebtn.ForeColor = System.Drawing.Color.White
        Me.consolebtn.Image = Global.Symphonia_Installer.My.Resources.Resources.icons8_console_16
        Me.consolebtn.Location = New System.Drawing.Point(54, 302)
        Me.consolebtn.Name = "consolebtn"
        Me.consolebtn.Size = New System.Drawing.Size(26, 23)
        Me.consolebtn.TabIndex = 31
        Me.consolebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.consolebtn.UseVisualStyleBackColor = False
        Me.consolebtn.Visible = False
        '
        'trayicon
        '
        Me.trayicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.trayicon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.trayicon.Icon = CType(resources.GetObject("trayicon.Icon"), System.Drawing.Icon)
        Me.trayicon.Text = "Symphonia Installer"
        Me.trayicon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showtsmenu, Me.consoletsmenu, Me.dividertsmenu, Me.closetsmenu})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 76)
        '
        'showtsmenu
        '
        Me.showtsmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showtsmenu.Name = "showtsmenu"
        Me.showtsmenu.Size = New System.Drawing.Size(173, 22)
        Me.showtsmenu.Text = "Programm zeigen"
        Me.showtsmenu.Visible = False
        '
        'consoletsmenu
        '
        Me.consoletsmenu.Image = Global.Symphonia_Installer.My.Resources.Resources.icons8_console_16
        Me.consoletsmenu.Name = "consoletsmenu"
        Me.consoletsmenu.Size = New System.Drawing.Size(173, 22)
        Me.consoletsmenu.Text = "Konsole"
        Me.consoletsmenu.Visible = False
        '
        'dividertsmenu
        '
        Me.dividertsmenu.Name = "dividertsmenu"
        Me.dividertsmenu.Size = New System.Drawing.Size(170, 6)
        Me.dividertsmenu.Visible = False
        '
        'closetsmenu
        '
        Me.closetsmenu.Name = "closetsmenu"
        Me.closetsmenu.Size = New System.Drawing.Size(173, 22)
        Me.closetsmenu.Text = "Beenden"
        '
        'repairbtn
        '
        Me.repairbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.repairbtn.BackColor = System.Drawing.Color.Black
        Me.repairbtn.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.planks_spruce
        Me.repairbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.repairbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repairbtn.ForeColor = System.Drawing.Color.White
        Me.repairbtn.Location = New System.Drawing.Point(517, 302)
        Me.repairbtn.Name = "repairbtn"
        Me.repairbtn.Size = New System.Drawing.Size(105, 23)
        Me.repairbtn.TabIndex = 33
        Me.repairbtn.Text = "Reparieren"
        Me.repairbtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.planks_spruce
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Symphonia_Installer.My.Resources.Resources.cog_16x16
        Me.Button1.Location = New System.Drawing.Point(22, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BenutzerWechselnToolStripMenuItem
        '
        Me.BenutzerWechselnToolStripMenuItem.Name = "BenutzerWechselnToolStripMenuItem"
        Me.BenutzerWechselnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BenutzerWechselnToolStripMenuItem.Text = "Benutzer wechseln"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Symphonia_Installer.My.Resources.Resources.bgpanel
        Me.ClientSize = New System.Drawing.Size(641, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.repairbtn)
        Me.Controls.Add(Me.consolebtn)
        Me.Controls.Add(Me.filenamelbl)
        Me.Controls.Add(Me.progresslbl)
        Me.Controls.Add(Me.playbtn)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Symphonia Launcher"
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
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents playbtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents filenamelbl As LinkLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents consolebtn As Button
    Friend WithEvents trayicon As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents showtsmenu As ToolStripMenuItem
    Friend WithEvents closetsmenu As ToolStripMenuItem
    Friend WithEvents consoletsmenu As ToolStripMenuItem
    Friend WithEvents dividertsmenu As ToolStripSeparator
    Friend WithEvents repairbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents usernamelbl As ToolStripMenuItem
    Friend WithEvents versionlbl As ToolStripMenuItem
    Friend WithEvents BenutzerWechselnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
End Class
