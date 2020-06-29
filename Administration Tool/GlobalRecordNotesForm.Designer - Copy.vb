<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlobalRecordNotesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GlobalRecordNotesForm))
        Me.RecordNotesGroupbox = New System.Windows.Forms.GroupBox()
        Me.RtxtNotes = New System.Windows.Forms.RichTextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnWipe = New System.Windows.Forms.Button()
        Me.TxtRecordName = New System.Windows.Forms.Label()
        Me.RecordNotesGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecordNotesGroupbox
        '
        Me.RecordNotesGroupbox.Controls.Add(Me.RtxtNotes)
        Me.RecordNotesGroupbox.Controls.Add(Me.BtnSave)
        Me.RecordNotesGroupbox.Controls.Add(Me.BtnWipe)
        Me.RecordNotesGroupbox.ForeColor = System.Drawing.Color.White
        Me.RecordNotesGroupbox.Location = New System.Drawing.Point(12, 28)
        Me.RecordNotesGroupbox.Name = "RecordNotesGroupbox"
        Me.RecordNotesGroupbox.Size = New System.Drawing.Size(762, 521)
        Me.RecordNotesGroupbox.TabIndex = 7
        Me.RecordNotesGroupbox.TabStop = False
        Me.RecordNotesGroupbox.Text = "Record Notes"
        '
        'RtxtNotes
        '
        Me.RtxtNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RtxtNotes.ForeColor = System.Drawing.Color.White
        Me.RtxtNotes.Location = New System.Drawing.Point(7, 20)
        Me.RtxtNotes.Name = "RtxtNotes"
        Me.RtxtNotes.Size = New System.Drawing.Size(749, 454)
        Me.RtxtNotes.TabIndex = 7
        Me.RtxtNotes.Text = ""
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(656, 480)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 35)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnWipe
        '
        Me.BtnWipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnWipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnWipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnWipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWipe.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWipe.ForeColor = System.Drawing.Color.White
        Me.BtnWipe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnWipe.Location = New System.Drawing.Point(6, 480)
        Me.BtnWipe.Name = "BtnWipe"
        Me.BtnWipe.Size = New System.Drawing.Size(100, 35)
        Me.BtnWipe.TabIndex = 5
        Me.BtnWipe.Text = "Wipe Notes"
        Me.BtnWipe.UseVisualStyleBackColor = False
        '
        'TxtRecordName
        '
        Me.TxtRecordName.AutoSize = True
        Me.TxtRecordName.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecordName.ForeColor = System.Drawing.Color.LightGray
        Me.TxtRecordName.Location = New System.Drawing.Point(9, 9)
        Me.TxtRecordName.Name = "TxtRecordName"
        Me.TxtRecordName.Size = New System.Drawing.Size(247, 16)
        Me.TxtRecordName.TabIndex = 6
        Me.TxtRecordName.Text = "You are viewing the global record of: null (null)"
        '
        'GlobalRecordNotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 561)
        Me.Controls.Add(Me.RecordNotesGroupbox)
        Me.Controls.Add(Me.TxtRecordName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GlobalRecordNotesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global Record Notes of: null (null)"
        Me.RecordNotesGroupbox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecordNotesGroupbox As GroupBox
    Friend WithEvents RtxtNotes As RichTextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnWipe As Button
    Friend WithEvents TxtRecordName As Label
End Class
