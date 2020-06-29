<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocalRecordNotesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocalRecordNotesForm))
        Me.NotesGroupbox = New System.Windows.Forms.GroupBox()
        Me.TxtNotes = New System.Windows.Forms.RichTextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnWipe = New System.Windows.Forms.Button()
        Me.LblRecord = New System.Windows.Forms.Label()
        Me.NotesGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotesGroupbox
        '
        Me.NotesGroupbox.Controls.Add(Me.TxtNotes)
        Me.NotesGroupbox.Controls.Add(Me.BtnSave)
        Me.NotesGroupbox.Controls.Add(Me.BtnWipe)
        Me.NotesGroupbox.ForeColor = System.Drawing.Color.White
        Me.NotesGroupbox.Location = New System.Drawing.Point(14, 29)
        Me.NotesGroupbox.Name = "NotesGroupbox"
        Me.NotesGroupbox.Size = New System.Drawing.Size(762, 521)
        Me.NotesGroupbox.TabIndex = 7
        Me.NotesGroupbox.TabStop = False
        Me.NotesGroupbox.Text = "Record Notes"
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtNotes.ForeColor = System.Drawing.Color.White
        Me.TxtNotes.Location = New System.Drawing.Point(7, 20)
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(749, 454)
        Me.TxtNotes.TabIndex = 7
        Me.TxtNotes.Text = ""
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
        'LblRecord
        '
        Me.LblRecord.AutoSize = True
        Me.LblRecord.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecord.ForeColor = System.Drawing.Color.LightGray
        Me.LblRecord.Location = New System.Drawing.Point(11, 10)
        Me.LblRecord.Name = "LblRecord"
        Me.LblRecord.Size = New System.Drawing.Size(212, 16)
        Me.LblRecord.TabIndex = 6
        Me.LblRecord.Text = "You are viewing the record of: null (null)"
        '
        'LocalRecordNotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 561)
        Me.Controls.Add(Me.NotesGroupbox)
        Me.Controls.Add(Me.LblRecord)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LocalRecordNotesForm"
        Me.Text = "Local Notes"
        Me.NotesGroupbox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotesGroupbox As GroupBox
    Friend WithEvents TxtNotes As RichTextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnWipe As Button
    Friend WithEvents LblRecord As Label
End Class
