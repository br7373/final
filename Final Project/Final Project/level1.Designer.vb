<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLVL1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.tmrLaser = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblSec = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.picB4 = New System.Windows.Forms.PictureBox()
        Me.picB6 = New System.Windows.Forms.PictureBox()
        Me.picB5 = New System.Windows.Forms.PictureBox()
        Me.picT5 = New System.Windows.Forms.PictureBox()
        Me.picT6 = New System.Windows.Forms.PictureBox()
        Me.picT4 = New System.Windows.Forms.PictureBox()
        Me.picB1 = New System.Windows.Forms.PictureBox()
        Me.picB3 = New System.Windows.Forms.PictureBox()
        Me.picT2 = New System.Windows.Forms.PictureBox()
        Me.picT3 = New System.Windows.Forms.PictureBox()
        Me.picB2 = New System.Windows.Forms.PictureBox()
        Me.picT1 = New System.Windows.Forms.PictureBox()
        Me.picShip = New System.Windows.Forms.PictureBox()
        Me.menuStrip.SuspendLayout()
        CType(Me.picB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Score :"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(372, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(10, 13)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "."
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(840, 24)
        Me.menuStrip.TabIndex = 4
        Me.menuStrip.Text = "MenuStrip1"
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
        'lblRight
        '
        Me.lblRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRight.Location = New System.Drawing.Point(830, 24)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(10, 591)
        Me.lblRight.TabIndex = 21
        '
        'lblLeft
        '
        Me.lblLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLeft.Location = New System.Drawing.Point(0, 24)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(10, 591)
        Me.lblLeft.TabIndex = 22
        '
        'tmrLaser
        '
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(488, 9)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(13, 13)
        Me.lblSec.TabIndex = 47
        Me.lblSec.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Time :"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(460, 9)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(13, 13)
        Me.lblMin.TabIndex = 48
        Me.lblMin.Text = "0"
        '
        'picB4
        '
        Me.picB4.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB4.Location = New System.Drawing.Point(457, 141)
        Me.picB4.Name = "picB4"
        Me.picB4.Size = New System.Drawing.Size(51, 42)
        Me.picB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB4.TabIndex = 54
        Me.picB4.TabStop = False
        '
        'picB6
        '
        Me.picB6.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB6.Location = New System.Drawing.Point(661, 141)
        Me.picB6.Name = "picB6"
        Me.picB6.Size = New System.Drawing.Size(51, 42)
        Me.picB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB6.TabIndex = 53
        Me.picB6.TabStop = False
        '
        'picB5
        '
        Me.picB5.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB5.Location = New System.Drawing.Point(559, 141)
        Me.picB5.Name = "picB5"
        Me.picB5.Size = New System.Drawing.Size(51, 42)
        Me.picB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB5.TabIndex = 52
        Me.picB5.TabStop = False
        '
        'picT5
        '
        Me.picT5.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT5.Location = New System.Drawing.Point(559, 67)
        Me.picT5.Name = "picT5"
        Me.picT5.Size = New System.Drawing.Size(51, 42)
        Me.picT5.TabIndex = 51
        Me.picT5.TabStop = False
        '
        'picT6
        '
        Me.picT6.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT6.Location = New System.Drawing.Point(661, 67)
        Me.picT6.Name = "picT6"
        Me.picT6.Size = New System.Drawing.Size(51, 42)
        Me.picT6.TabIndex = 50
        Me.picT6.TabStop = False
        '
        'picT4
        '
        Me.picT4.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT4.Location = New System.Drawing.Point(457, 67)
        Me.picT4.Name = "picT4"
        Me.picT4.Size = New System.Drawing.Size(51, 42)
        Me.picT4.TabIndex = 49
        Me.picT4.TabStop = False
        '
        'picB1
        '
        Me.picB1.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB1.Location = New System.Drawing.Point(150, 141)
        Me.picB1.Name = "picB1"
        Me.picB1.Size = New System.Drawing.Size(51, 42)
        Me.picB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB1.TabIndex = 45
        Me.picB1.TabStop = False
        '
        'picB3
        '
        Me.picB3.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB3.Location = New System.Drawing.Point(354, 141)
        Me.picB3.Name = "picB3"
        Me.picB3.Size = New System.Drawing.Size(51, 42)
        Me.picB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB3.TabIndex = 43
        Me.picB3.TabStop = False
        '
        'picT2
        '
        Me.picT2.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT2.Location = New System.Drawing.Point(252, 67)
        Me.picT2.Name = "picT2"
        Me.picT2.Size = New System.Drawing.Size(51, 42)
        Me.picT2.TabIndex = 40
        Me.picT2.TabStop = False
        '
        'picT3
        '
        Me.picT3.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT3.Location = New System.Drawing.Point(354, 67)
        Me.picT3.Name = "picT3"
        Me.picT3.Size = New System.Drawing.Size(51, 42)
        Me.picT3.TabIndex = 38
        Me.picT3.TabStop = False
        '
        'picB2
        '
        Me.picB2.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB2.Location = New System.Drawing.Point(252, 141)
        Me.picB2.Name = "picB2"
        Me.picB2.Size = New System.Drawing.Size(51, 42)
        Me.picB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB2.TabIndex = 37
        Me.picB2.TabStop = False
        '
        'picT1
        '
        Me.picT1.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT1.Location = New System.Drawing.Point(150, 67)
        Me.picT1.Name = "picT1"
        Me.picT1.Size = New System.Drawing.Size(51, 42)
        Me.picT1.TabIndex = 19
        Me.picT1.TabStop = False
        '
        'picShip
        '
        Me.picShip.Image = Global.Final_Project.My.Resources.Resources.ship1
        Me.picShip.Location = New System.Drawing.Point(415, 541)
        Me.picShip.Name = "picShip"
        Me.picShip.Size = New System.Drawing.Size(35, 60)
        Me.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShip.TabIndex = 10
        Me.picShip.TabStop = False
        '
        'frmLVL1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 613)
        Me.Controls.Add(Me.picB4)
        Me.Controls.Add(Me.picB6)
        Me.Controls.Add(Me.picB5)
        Me.Controls.Add(Me.picT5)
        Me.Controls.Add(Me.picT6)
        Me.Controls.Add(Me.picT4)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picB1)
        Me.Controls.Add(Me.picB3)
        Me.Controls.Add(Me.picT2)
        Me.Controls.Add(Me.picT3)
        Me.Controls.Add(Me.picB2)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.picT1)
        Me.Controls.Add(Me.picShip)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.menuStrip)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmLVL1"
        Me.Text = "Space Invaders | Level 1"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        CType(Me.picB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picShip As PictureBox
    Friend WithEvents picT1 As PictureBox
    Friend WithEvents lblRight As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents picB2 As PictureBox
    Friend WithEvents picT3 As PictureBox
    Friend WithEvents picT2 As PictureBox
    Friend WithEvents picB3 As PictureBox
    Friend WithEvents picB1 As PictureBox
    Friend WithEvents tmrLaser As Timer
    Friend WithEvents tmrTime As Timer
    Friend WithEvents lblSec As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents picT5 As PictureBox
    Friend WithEvents picT6 As PictureBox
    Friend WithEvents picT4 As PictureBox
    Friend WithEvents picB4 As PictureBox
    Friend WithEvents picB6 As PictureBox
    Friend WithEvents picB5 As PictureBox
End Class
