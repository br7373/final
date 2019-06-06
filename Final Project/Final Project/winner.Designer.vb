<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winner
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
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.lstOpen = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblPrint
        '
        Me.lblPrint.AutoSize = True
        Me.lblPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrint.Location = New System.Drawing.Point(12, 68)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(82, 25)
        Me.lblPrint.TabIndex = 0
        Me.lblPrint.Text = ".............."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Click the button below to save your score and time!"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(17, 174)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 64)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(502, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 53)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(17, 393)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(78, 64)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lstOpen
        '
        Me.lstOpen.FormattingEnabled = True
        Me.lstOpen.Location = New System.Drawing.Point(154, 297)
        Me.lstOpen.Name = "lstOpen"
        Me.lstOpen.Size = New System.Drawing.Size(118, 160)
        Me.lstOpen.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'winner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 520)
        Me.Controls.Add(Me.lstOpen)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPrint)
        Me.Name = "winner"
        Me.Text = "winner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrint As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnOpen As Button
    Friend WithEvents lstOpen As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
