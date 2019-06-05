<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLVL2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picT6 = New System.Windows.Forms.PictureBox()
        Me.picT4 = New System.Windows.Forms.PictureBox()
        Me.picB1 = New System.Windows.Forms.PictureBox()
        Me.picB5 = New System.Windows.Forms.PictureBox()
        Me.picB3 = New System.Windows.Forms.PictureBox()
        Me.picB6 = New System.Windows.Forms.PictureBox()
        Me.picB4 = New System.Windows.Forms.PictureBox()
        Me.picT2 = New System.Windows.Forms.PictureBox()
        Me.picT5 = New System.Windows.Forms.PictureBox()
        Me.picT3 = New System.Windows.Forms.PictureBox()
        Me.picB2 = New System.Windows.Forms.PictureBox()
        Me.picT1 = New System.Windows.Forms.PictureBox()
        Me.picShip = New System.Windows.Forms.PictureBox()
        Me.timerL = New System.Windows.Forms.Timer(Me.components)
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picT6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picT6
        '
        Me.picT6.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT6.Location = New System.Drawing.Point(612, 47)
        Me.picT6.Name = "picT6"
        Me.picT6.Size = New System.Drawing.Size(51, 42)
        Me.picT6.TabIndex = 59
        Me.picT6.TabStop = False
        '
        'picT4
        '
        Me.picT4.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT4.Location = New System.Drawing.Point(436, 47)
        Me.picT4.Name = "picT4"
        Me.picT4.Size = New System.Drawing.Size(51, 42)
        Me.picT4.TabIndex = 58
        Me.picT4.TabStop = False
        '
        'picB1
        '
        Me.picB1.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB1.Location = New System.Drawing.Point(172, 113)
        Me.picB1.Name = "picB1"
        Me.picB1.Size = New System.Drawing.Size(51, 42)
        Me.picB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB1.TabIndex = 57
        Me.picB1.TabStop = False
        '
        'picB5
        '
        Me.picB5.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB5.Location = New System.Drawing.Point(521, 113)
        Me.picB5.Name = "picB5"
        Me.picB5.Size = New System.Drawing.Size(51, 42)
        Me.picB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB5.TabIndex = 56
        Me.picB5.TabStop = False
        '
        'picB3
        '
        Me.picB3.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB3.Location = New System.Drawing.Point(350, 113)
        Me.picB3.Name = "picB3"
        Me.picB3.Size = New System.Drawing.Size(51, 42)
        Me.picB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB3.TabIndex = 55
        Me.picB3.TabStop = False
        '
        'picB6
        '
        Me.picB6.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB6.Location = New System.Drawing.Point(612, 113)
        Me.picB6.Name = "picB6"
        Me.picB6.Size = New System.Drawing.Size(51, 42)
        Me.picB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB6.TabIndex = 54
        Me.picB6.TabStop = False
        '
        'picB4
        '
        Me.picB4.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB4.Location = New System.Drawing.Point(436, 113)
        Me.picB4.Name = "picB4"
        Me.picB4.Size = New System.Drawing.Size(51, 42)
        Me.picB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB4.TabIndex = 53
        Me.picB4.TabStop = False
        '
        'picT2
        '
        Me.picT2.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT2.Location = New System.Drawing.Point(258, 47)
        Me.picT2.Name = "picT2"
        Me.picT2.Size = New System.Drawing.Size(51, 42)
        Me.picT2.TabIndex = 52
        Me.picT2.TabStop = False
        '
        'picT5
        '
        Me.picT5.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT5.Location = New System.Drawing.Point(521, 47)
        Me.picT5.Name = "picT5"
        Me.picT5.Size = New System.Drawing.Size(51, 42)
        Me.picT5.TabIndex = 51
        Me.picT5.TabStop = False
        '
        'picT3
        '
        Me.picT3.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT3.Location = New System.Drawing.Point(350, 47)
        Me.picT3.Name = "picT3"
        Me.picT3.Size = New System.Drawing.Size(51, 42)
        Me.picT3.TabIndex = 50
        Me.picT3.TabStop = False
        '
        'picB2
        '
        Me.picB2.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB2.Location = New System.Drawing.Point(258, 113)
        Me.picB2.Name = "picB2"
        Me.picB2.Size = New System.Drawing.Size(51, 42)
        Me.picB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB2.TabIndex = 49
        Me.picB2.TabStop = False
        '
        'picT1
        '
        Me.picT1.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT1.Location = New System.Drawing.Point(172, 47)
        Me.picT1.Name = "picT1"
        Me.picT1.Size = New System.Drawing.Size(51, 42)
        Me.picT1.TabIndex = 48
        Me.picT1.TabStop = False
        '
        'picShip
        '
        Me.picShip.Image = Global.Final_Project.My.Resources.Resources.ship1
        Me.picShip.Location = New System.Drawing.Point(393, 618)
        Me.picShip.Name = "picShip"
        Me.picShip.Size = New System.Drawing.Size(35, 60)
        Me.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShip.TabIndex = 60
        Me.picShip.TabStop = False
        '
        'timerL
        '
        Me.timerL.Enabled = True
        Me.timerL.Interval = 1000
        '
        'lblLeft
        '
        Me.lblLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLeft.Location = New System.Drawing.Point(-2, -2)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(10, 692)
        Me.lblLeft.TabIndex = 61
        '
        'lblRight
        '
        Me.lblRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRight.Location = New System.Drawing.Point(804, -2)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(10, 692)
        Me.lblRight.TabIndex = 62
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 24)
        Me.MenuStrip1.TabIndex = 87
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.CloseGameToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'CloseGameToolStripMenuItem
        '
        Me.CloseGameToolStripMenuItem.Name = "CloseGameToolStripMenuItem"
        Me.CloseGameToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CloseGameToolStripMenuItem.Text = "Close Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Score :"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(367, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(10, 13)
        Me.lblScore.TabIndex = 89
        Me.lblScore.Text = "."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Project.My.Resources.Resources.laser
        Me.PictureBox1.Location = New System.Drawing.Point(408, 609)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 16)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'frmLVL2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 690)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.picShip)
        Me.Controls.Add(Me.picT6)
        Me.Controls.Add(Me.picT4)
        Me.Controls.Add(Me.picB1)
        Me.Controls.Add(Me.picB5)
        Me.Controls.Add(Me.picB3)
        Me.Controls.Add(Me.picB6)
        Me.Controls.Add(Me.picB4)
        Me.Controls.Add(Me.picT2)
        Me.Controls.Add(Me.picT5)
        Me.Controls.Add(Me.picT3)
        Me.Controls.Add(Me.picB2)
        Me.Controls.Add(Me.picT1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLVL2"
        Me.Text = "Space Invaders | Level 2"
        CType(Me.picT6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picT6 As PictureBox
    Friend WithEvents picT4 As PictureBox
    Friend WithEvents picB1 As PictureBox
    Friend WithEvents picB5 As PictureBox
    Friend WithEvents picB3 As PictureBox
    Friend WithEvents picB6 As PictureBox
    Friend WithEvents picB4 As PictureBox
    Friend WithEvents picT2 As PictureBox
    Friend WithEvents picT5 As PictureBox
    Friend WithEvents picT3 As PictureBox
    Friend WithEvents picB2 As PictureBox
    Friend WithEvents picT1 As PictureBox
    Friend WithEvents picShip As PictureBox
    Friend WithEvents timerL As Timer
    Friend WithEvents lblLeft As Label
    Friend WithEvents lblRight As Label
    Friend WithEvents timer As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
