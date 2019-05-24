<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNextLVL = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Congratulations!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(413, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Would you Like to Continue to the Next Level?"
        '
        'btnNextLVL
        '
        Me.btnNextLVL.Location = New System.Drawing.Point(190, 186)
        Me.btnNextLVL.Name = "btnNextLVL"
        Me.btnNextLVL.Size = New System.Drawing.Size(75, 45)
        Me.btnNextLVL.TabIndex = 2
        Me.btnNextLVL.Text = "Yes"
        Me.btnNextLVL.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(296, 186)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 45)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "No (quit)"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 314)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNextLVL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Congratulations!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNextLVL As Button
    Friend WithEvents btnQuit As Button
End Class
