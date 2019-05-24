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
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.picB2.Location = New System.Drawing.Point(63, 275)
        Me.picB2.Name = "picB2"
        Me.picB2.Size = New System.Drawing.Size(51, 42)
        Me.picB2.TabIndex = 29
        Me.picB2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Final_Project.My.Resources.Resources.invader2
        Me.PictureBox3.Location = New System.Drawing.Point(63, 342)
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
        Me.Label2.Location = New System.Drawing.Point(136, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "= 10 Points"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 31)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "= 30 Points"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(498, 426)
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
End Class
