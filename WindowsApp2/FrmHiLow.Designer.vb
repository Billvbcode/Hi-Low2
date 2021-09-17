<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHiLow
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
        Me.LblGuess = New System.Windows.Forms.Label()
        Me.TxtGuess = New System.Windows.Forms.TextBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHi = New System.Windows.Forms.Label()
        Me.LblAns = New System.Windows.Forms.Label()
        Me.LblLow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblGuess
        '
        Me.LblGuess.AutoSize = True
        Me.LblGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuess.Location = New System.Drawing.Point(242, 88)
        Me.LblGuess.Name = "LblGuess"
        Me.LblGuess.Size = New System.Drawing.Size(63, 20)
        Me.LblGuess.TabIndex = 18
        Me.LblGuess.Text = "Label4"
        '
        'TxtGuess
        '
        Me.TxtGuess.Location = New System.Drawing.Point(63, 88)
        Me.TxtGuess.Name = "TxtGuess"
        Me.TxtGuess.Size = New System.Drawing.Size(144, 20)
        Me.TxtGuess.TabIndex = 17
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(17, 127)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 16
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Ans"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Low"
        '
        'LblHi
        '
        Me.LblHi.AutoSize = True
        Me.LblHi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHi.Location = New System.Drawing.Point(253, 61)
        Me.LblHi.Name = "LblHi"
        Me.LblHi.Size = New System.Drawing.Size(29, 20)
        Me.LblHi.TabIndex = 12
        Me.LblHi.Text = "25"
        '
        'LblAns
        '
        Me.LblAns.AutoSize = True
        Me.LblAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAns.Location = New System.Drawing.Point(120, 61)
        Me.LblAns.Name = "LblAns"
        Me.LblAns.Size = New System.Drawing.Size(19, 20)
        Me.LblAns.TabIndex = 11
        Me.LblAns.Text = "?"
        '
        'LblLow
        '
        Me.LblLow.AutoSize = True
        Me.LblLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLow.Location = New System.Drawing.Point(37, 61)
        Me.LblLow.Name = "LblLow"
        Me.LblLow.Size = New System.Drawing.Size(19, 20)
        Me.LblLow.TabIndex = 10
        Me.LblLow.Text = "0"
        '
        'FrmHiLow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 450)
        Me.Controls.Add(Me.LblGuess)
        Me.Controls.Add(Me.TxtGuess)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblHi)
        Me.Controls.Add(Me.LblAns)
        Me.Controls.Add(Me.LblLow)
        Me.Name = "FrmHiLow"
        Me.Text = "FrmHiLow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblGuess As Label
    Friend WithEvents TxtGuess As TextBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblHi As Label
    Friend WithEvents LblAns As Label
    Friend WithEvents LblLow As Label
End Class
