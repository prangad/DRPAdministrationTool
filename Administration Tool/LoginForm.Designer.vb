<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.LblIntro2 = New System.Windows.Forms.Label()
        Me.LblIntro3 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblIntro
        '
        Me.LblIntro.AutoSize = True
        Me.LblIntro.ForeColor = System.Drawing.Color.White
        Me.LblIntro.Location = New System.Drawing.Point(20, 9)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(243, 13)
        Me.LblIntro.TabIndex = 0
        Me.LblIntro.Text = "Thanks for using the DivRP administration tool. :^)"
        Me.LblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIntro2
        '
        Me.LblIntro2.AutoSize = True
        Me.LblIntro2.ForeColor = System.Drawing.Color.White
        Me.LblIntro2.Location = New System.Drawing.Point(26, 22)
        Me.LblIntro2.Name = "LblIntro2"
        Me.LblIntro2.Size = New System.Drawing.Size(230, 13)
        Me.LblIntro2.TabIndex = 1
        Me.LblIntro2.Text = "Please let me know if you find any bugs/issues."
        Me.LblIntro2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIntro3
        '
        Me.LblIntro3.AutoSize = True
        Me.LblIntro3.ForeColor = System.Drawing.Color.White
        Me.LblIntro3.Location = New System.Drawing.Point(87, 35)
        Me.LblIntro3.Name = "LblIntro3"
        Me.LblIntro3.Size = New System.Drawing.Size(108, 13)
        Me.LblIntro3.TabIndex = 2
        Me.LblIntro3.Text = "Now... Who are you?"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtName.ForeColor = System.Drawing.Color.White
        Me.TxtName.Location = New System.Drawing.Point(12, 51)
        Me.TxtName.MaxLength = 30
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(260, 20)
        Me.TxtName.TabIndex = 3
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancel.Location = New System.Drawing.Point(12, 77)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 32)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSubmit.Location = New System.Drawing.Point(172, 77)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(100, 32)
        Me.BtnSubmit.TabIndex = 5
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 121)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblIntro3)
        Me.Controls.Add(Me.LblIntro2)
        Me.Controls.Add(Me.LblIntro)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIntro As Label
    Friend WithEvents LblIntro2 As Label
    Friend WithEvents LblIntro3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSubmit As Button
End Class
