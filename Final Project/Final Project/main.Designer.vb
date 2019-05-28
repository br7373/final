<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picB2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picB5 = New System.Windows.Forms.PictureBox()
        Me.picB1 = New System.Windows.Forms.PictureBox()
        Me.picB3 = New System.Windows.Forms.PictureBox()
        Me.picB6 = New System.Windows.Forms.PictureBox()
        Me.picB4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(101, 144)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(144, 53)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(148, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Space Invaders"
        '
        'btnHow
        '
        Me.btnHow.Location = New System.Drawing.Point(251, 144)
        Me.btnHow.Name = "btnHow"
        Me.btnHow.Size = New System.Drawing.Size(144, 53)
        Me.btnHow.TabIndex = 2
        Me.btnHow.Text = "How to Play"
        Me.btnHow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(204, 203)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 32)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picB2
        '
        Me.picB2.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picB2.Location = New System.Drawing.Point(127, 276)
        Me.picB2.Name = "picB2"
        Me.picB2.Size = New System.Drawing.Size(51, 42)
        Me.picB2.TabIndex = 29
        Me.picB2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.PictureBox3.Location = New System.Drawing.Point(127, 343)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "= 10 Points"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 31)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "= 30 Points"
        '
        'picB5
        '
        Me.picB5.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB5.Location = New System.Drawing.Point(340, 192)
        Me.picB5.Name = "picB5"
        Me.picB5.Size = New System.Drawing.Size(51, 42)
        Me.picB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB5.TabIndex = 37
        Me.picB5.TabStop = False
        '
        'picB1
        '
        Me.picB1.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB1.Location = New System.Drawing.Point(32, 192)
        Me.picB1.Name = "picB1"
        Me.picB1.Size = New System.Drawing.Size(51, 42)
        Me.picB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB1.TabIndex = 36
        Me.picB1.TabStop = False
        '
        'picB3
        '
        Me.picB3.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.picB3.Location = New System.Drawing.Point(187, 192)
        Me.picB3.Name = "picB3"
        Me.picB3.Size = New System.Drawing.Size(51, 42)
        Me.picB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB3.TabIndex = 35
        Me.picB3.TabStop = False
        '
        'picB6
        '
        Me.picB6.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picB6.Location = New System.Drawing.Point(415, 192)
        Me.picB6.Name = "picB6"
        Me.picB6.Size = New System.Drawing.Size(51, 42)
        Me.picB6.TabIndex = 34
        Me.picB6.TabStop = False
        '
        'picB4
        '
        Me.picB4.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.picB4.Location = New System.Drawing.Point(263, 192)
        Me.picB4.Name = "picB4"
        Me.picB4.Size = New System.Drawing.Size(51, 42)
        Me.picB4.TabIndex = 33
        Me.picB4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Project.My.Resources.Resources.invader
        Me.PictureBox1.Location = New System.Drawing.Point(111, 192)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 42)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(498, 426)
        Me.Controls.Add(Me.picB5)
        Me.Controls.Add(Me.picB1)
        Me.Controls.Add(Me.picB3)
        Me.Controls.Add(Me.picB6)
        Me.Controls.Add(Me.picB4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picB2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "main"
        Me.Text = "Space Invaders"
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHow As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picB2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents picB5 As PictureBox
    Friend WithEvents picB1 As PictureBox
    Friend WithEvents picB3 As PictureBox
    Friend WithEvents picB6 As PictureBox
    Friend WithEvents picB4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
