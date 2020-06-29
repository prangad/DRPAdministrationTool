<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempNotesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TempNotesForm))
        Me.NotesGroupbox = New System.Windows.Forms.GroupBox()
        Me.BtnClearAll = New System.Windows.Forms.Button()
        Me.LstNotes = New System.Windows.Forms.ListBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.AddNoteGroupbox = New System.Windows.Forms.GroupBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtAdd = New System.Windows.Forms.TextBox()
        Me.NotesGroupbox.SuspendLayout()
        Me.AddNoteGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotesGroupbox
        '
        Me.NotesGroupbox.Controls.Add(Me.BtnClearAll)
        Me.NotesGroupbox.Controls.Add(Me.LstNotes)
        Me.NotesGroupbox.Controls.Add(Me.BtnEdit)
        Me.NotesGroupbox.Controls.Add(Me.BtnRemove)
        Me.NotesGroupbox.ForeColor = System.Drawing.Color.White
        Me.NotesGroupbox.Location = New System.Drawing.Point(12, 67)
        Me.NotesGroupbox.Name = "NotesGroupbox"
        Me.NotesGroupbox.Size = New System.Drawing.Size(559, 383)
        Me.NotesGroupbox.TabIndex = 4
        Me.NotesGroupbox.TabStop = False
        Me.NotesGroupbox.Text = "Notes"
        '
        'BtnClearAll
        '
        Me.BtnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearAll.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearAll.ForeColor = System.Drawing.Color.White
        Me.BtnClearAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnClearAll.Location = New System.Drawing.Point(6, 342)
        Me.BtnClearAll.Name = "BtnClearAll"
        Me.BtnClearAll.Size = New System.Drawing.Size(100, 35)
        Me.BtnClearAll.TabIndex = 4
        Me.BtnClearAll.Text = "Clear All"
        Me.BtnClearAll.UseVisualStyleBackColor = False
        '
        'LstNotes
        '
        Me.LstNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.LstNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstNotes.ForeColor = System.Drawing.Color.White
        Me.LstNotes.FormattingEnabled = True
        Me.LstNotes.Location = New System.Drawing.Point(7, 20)
        Me.LstNotes.Name = "LstNotes"
        Me.LstNotes.Size = New System.Drawing.Size(546, 314)
        Me.LstNotes.TabIndex = 3
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEdit.Location = New System.Drawing.Point(347, 342)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(100, 35)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit Note"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.Color.White
        Me.BtnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRemove.Location = New System.Drawing.Point(453, 342)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(100, 35)
        Me.BtnRemove.TabIndex = 1
        Me.BtnRemove.Text = "Remove Note"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'AddNoteGroupbox
        '
        Me.AddNoteGroupbox.Controls.Add(Me.BtnAdd)
        Me.AddNoteGroupbox.Controls.Add(Me.TxtAdd)
        Me.AddNoteGroupbox.ForeColor = System.Drawing.Color.White
        Me.AddNoteGroupbox.Location = New System.Drawing.Point(13, 12)
        Me.AddNoteGroupbox.Name = "AddNoteGroupbox"
        Me.AddNoteGroupbox.Size = New System.Drawing.Size(559, 49)
        Me.AddNoteGroupbox.TabIndex = 3
        Me.AddNoteGroupbox.TabStop = False
        Me.AddNoteGroupbox.Text = "Add a Note"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAdd.Location = New System.Drawing.Point(473, 16)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(80, 26)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TxtAdd
        '
        Me.TxtAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdd.ForeColor = System.Drawing.Color.White
        Me.TxtAdd.Location = New System.Drawing.Point(6, 19)
        Me.TxtAdd.Name = "TxtAdd"
        Me.TxtAdd.Size = New System.Drawing.Size(464, 20)
        Me.TxtAdd.TabIndex = 0
        '
        'TempNotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 463)
        Me.Controls.Add(Me.NotesGroupbox)
        Me.Controls.Add(Me.AddNoteGroupbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TempNotesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temporary Notes"
        Me.NotesGroupbox.ResumeLayout(False)
        Me.AddNoteGroupbox.ResumeLayout(False)
        Me.AddNoteGroupbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotesGroupbox As GroupBox
    Friend WithEvents BtnClearAll As Button
    Friend WithEvents LstNotes As ListBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents AddNoteGroupbox As GroupBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtAdd As TextBox
End Class
