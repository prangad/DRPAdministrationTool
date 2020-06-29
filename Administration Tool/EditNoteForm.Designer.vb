<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditNoteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditNoteForm))
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.TxtEdit = New System.Windows.Forms.TextBox()
        Me.LblEdit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancel.Location = New System.Drawing.Point(16, 63)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 35)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirm.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnConfirm.Location = New System.Drawing.Point(472, 63)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(100, 35)
        Me.BtnConfirm.TabIndex = 7
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'TxtEdit
        '
        Me.TxtEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdit.ForeColor = System.Drawing.Color.White
        Me.TxtEdit.Location = New System.Drawing.Point(16, 32)
        Me.TxtEdit.Name = "TxtEdit"
        Me.TxtEdit.Size = New System.Drawing.Size(556, 20)
        Me.TxtEdit.TabIndex = 6
        '
        'LblEdit
        '
        Me.LblEdit.AutoSize = True
        Me.LblEdit.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdit.ForeColor = System.Drawing.Color.White
        Me.LblEdit.Location = New System.Drawing.Point(13, 12)
        Me.LblEdit.Name = "LblEdit"
        Me.LblEdit.Size = New System.Drawing.Size(224, 16)
        Me.LblEdit.TabIndex = 5
        Me.LblEdit.Text = "What would you like to change the note to?"
        '
        'EditNoteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 111)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.TxtEdit)
        Me.Controls.Add(Me.LblEdit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditNoteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Note"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents TxtEdit As TextBox
    Friend WithEvents LblEdit As Label
End Class
