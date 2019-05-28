<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLifeCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.picLaser = New System.Windows.Forms.PictureBox()
        Me.picT1 = New System.Windows.Forms.PictureBox()
        Me.picShip = New System.Windows.Forms.PictureBox()
        Me.timerL = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip.SuspendLayout()
        CType(Me.picLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lives :"
        '
        'lblLifeCount
        '
        Me.lblLifeCount.AutoSize = True
        Me.lblLifeCount.Location = New System.Drawing.Point(58, 24)
        Me.lblLifeCount.Name = "lblLifeCount"
        Me.lblLifeCount.Size = New System.Drawing.Size(10, 13)
        Me.lblLifeCount.TabIndex = 1
        Me.lblLifeCount.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(590, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Score :"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(637, 24)
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
        Me.menuStrip.Size = New System.Drawing.Size(667, 24)
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
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(16, 319)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(39, 13)
        Me.lblTest.TabIndex = 20
        Me.lblTest.Text = "Label3"
        '
        'lblRight
        '
        Me.lblRight.Location = New System.Drawing.Point(654, 0)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(13, 496)
        Me.lblRight.TabIndex = 21
        '
        'lblLeft
        '
        Me.lblLeft.Location = New System.Drawing.Point(0, 0)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(10, 496)
        Me.lblLeft.TabIndex = 22
        '
        'picLaser
        '
        Me.picLaser.Image = Global.Final_Project.My.Resources.Resources.laser
        Me.picLaser.Location = New System.Drawing.Point(357, 399)
        Me.picLaser.Name = "picLaser"
        Me.picLaser.Size = New System.Drawing.Size(5, 16)
        Me.picLaser.TabIndex = 23
        Me.picLaser.TabStop = False
        '
        'picT1
        '
        Me.picT1.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picT1.Location = New System.Drawing.Point(341, 77)
        Me.picT1.Name = "picT1"
        Me.picT1.Size = New System.Drawing.Size(51, 42)
        Me.picT1.TabIndex = 19
        Me.picT1.TabStop = False
        '
        'picShip
        '
        Me.picShip.Image = Global.Final_Project.My.Resources.Resources.ship1
        Me.picShip.Location = New System.Drawing.Point(341, 421)
        Me.picShip.Name = "picShip"
        Me.picShip.Size = New System.Drawing.Size(35, 60)
        Me.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShip.TabIndex = 10
        Me.picShip.TabStop = False
        '
        'timerL
        '
        Me.timerL.Enabled = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 493)
        Me.Controls.Add(Me.picLaser)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.picT1)
        Me.Controls.Add(Me.picShip)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLifeCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "Form2"
        Me.Text = "Space Invaders"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        CType(Me.picLaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLifeCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picShip As PictureBox
    Friend WithEvents picT1 As PictureBox
    Friend WithEvents lblTest As Label
    Friend WithEvents lblRight As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents picLaser As PictureBox
    Friend WithEvents timerL As Timer
End Class
