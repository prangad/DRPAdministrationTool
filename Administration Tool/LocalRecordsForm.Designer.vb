<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocalRecordsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocalRecordsForm))
        Me.NotesGroupbox = New System.Windows.Forms.GroupBox()
        Me.BtnNotes = New System.Windows.Forms.Button()
        Me.RecordsGroupbox = New System.Windows.Forms.GroupBox()
        Me.DgvLocalRecords = New System.Windows.Forms.DataGridView()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivRPUserRecordsDataSet1 = New Administration_Tool.DivRPUserRecordsDataSet1()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.ToolsGroupbox = New System.Windows.Forms.GroupBox()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SteamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1TableAdapter = New Administration_Tool.DivRPUserRecordsDataSet1TableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New Administration_Tool.DivRPUserRecordsDataSet1TableAdapters.TableAdapterManager()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SteamIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForumNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HighestKnownPositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesGroupbox.SuspendLayout()
        Me.RecordsGroupbox.SuspendLayout()
        CType(Me.DgvLocalRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivRPUserRecordsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolsGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotesGroupbox
        '
        Me.NotesGroupbox.Controls.Add(Me.BtnNotes)
        Me.NotesGroupbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NotesGroupbox.ForeColor = System.Drawing.Color.White
        Me.NotesGroupbox.Location = New System.Drawing.Point(624, 489)
        Me.NotesGroupbox.Name = "NotesGroupbox"
        Me.NotesGroupbox.Size = New System.Drawing.Size(148, 60)
        Me.NotesGroupbox.TabIndex = 15
        Me.NotesGroupbox.TabStop = False
        Me.NotesGroupbox.Text = "Notes"
        '
        'BtnNotes
        '
        Me.BtnNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnNotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotes.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotes.ForeColor = System.Drawing.Color.White
        Me.BtnNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNotes.Location = New System.Drawing.Point(6, 19)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(136, 35)
        Me.BtnNotes.TabIndex = 14
        Me.BtnNotes.Text = "View Notes"
        Me.BtnNotes.UseVisualStyleBackColor = False
        '
        'RecordsGroupbox
        '
        Me.RecordsGroupbox.Controls.Add(Me.DgvLocalRecords)
        Me.RecordsGroupbox.Controls.Add(Me.BtnSearch)
        Me.RecordsGroupbox.Controls.Add(Me.TxtSearch)
        Me.RecordsGroupbox.ForeColor = System.Drawing.Color.White
        Me.RecordsGroupbox.Location = New System.Drawing.Point(12, 12)
        Me.RecordsGroupbox.Name = "RecordsGroupbox"
        Me.RecordsGroupbox.Size = New System.Drawing.Size(760, 471)
        Me.RecordsGroupbox.TabIndex = 13
        Me.RecordsGroupbox.TabStop = False
        Me.RecordsGroupbox.Text = "Local Records"
        '
        'DgvLocalRecords
        '
        Me.DgvLocalRecords.AllowUserToAddRows = False
        Me.DgvLocalRecords.AllowUserToDeleteRows = False
        Me.DgvLocalRecords.AllowUserToResizeColumns = False
        Me.DgvLocalRecords.AllowUserToResizeRows = False
        Me.DgvLocalRecords.AutoGenerateColumns = False
        Me.DgvLocalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLocalRecords.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DgvLocalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvLocalRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SteamIDDataGridViewTextBoxColumn, Me.RPNameDataGridViewTextBoxColumn, Me.ForumNameDataGridViewTextBoxColumn, Me.NicknameDataGridViewTextBoxColumn, Me.HighestKnownPositionDataGridViewTextBoxColumn, Me.Notes})
        Me.DgvLocalRecords.DataSource = Me.Table1BindingSource
        Me.DgvLocalRecords.GridColor = System.Drawing.Color.Black
        Me.DgvLocalRecords.Location = New System.Drawing.Point(7, 47)
        Me.DgvLocalRecords.Name = "DgvLocalRecords"
        Me.DgvLocalRecords.ReadOnly = True
        Me.DgvLocalRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvLocalRecords.Size = New System.Drawing.Size(747, 418)
        Me.DgvLocalRecords.TabIndex = 10
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.DivRPUserRecordsDataSet1
        '
        'DivRPUserRecordsDataSet1
        '
        Me.DivRPUserRecordsDataSet1.DataSetName = "DivRPUserRecordsDataSet1"
        Me.DivRPUserRecordsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSearch.Location = New System.Drawing.Point(618, 18)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(136, 26)
        Me.BtnSearch.TabIndex = 9
        Me.BtnSearch.Text = "Search for SteamID"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.ForeColor = System.Drawing.Color.White
        Me.TxtSearch.Location = New System.Drawing.Point(6, 20)
        Me.TxtSearch.MaxLength = 20
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(609, 20)
        Me.TxtSearch.TabIndex = 3
        '
        'ToolsGroupbox
        '
        Me.ToolsGroupbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolsGroupbox.Controls.Add(Me.BtnNew)
        Me.ToolsGroupbox.Controls.Add(Me.BtnEdit)
        Me.ToolsGroupbox.Controls.Add(Me.BtnDelete)
        Me.ToolsGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsGroupbox.ForeColor = System.Drawing.Color.White
        Me.ToolsGroupbox.Location = New System.Drawing.Point(12, 489)
        Me.ToolsGroupbox.Name = "ToolsGroupbox"
        Me.ToolsGroupbox.Size = New System.Drawing.Size(606, 60)
        Me.ToolsGroupbox.TabIndex = 14
        Me.ToolsGroupbox.TabStop = False
        Me.ToolsGroupbox.Text = "Tools"
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNew.Location = New System.Drawing.Point(7, 18)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(100, 35)
        Me.BtnNew.TabIndex = 13
        Me.BtnNew.Text = "New Record"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEdit.Location = New System.Drawing.Point(394, 19)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(100, 35)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "Edit Record"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDelete.Location = New System.Drawing.Point(500, 19)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 35)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete Record"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'SteamID
        '
        Me.SteamID.DataPropertyName = "SteamID"
        Me.SteamID.HeaderText = "SteamID"
        Me.SteamID.Name = "SteamID"
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SteamID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SteamID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Administration_Tool.DivRPUserRecordsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'SteamIDDataGridViewTextBoxColumn
        '
        Me.SteamIDDataGridViewTextBoxColumn.DataPropertyName = "SteamID"
        Me.SteamIDDataGridViewTextBoxColumn.HeaderText = "SteamID"
        Me.SteamIDDataGridViewTextBoxColumn.Name = "SteamIDDataGridViewTextBoxColumn"
        Me.SteamIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RPNameDataGridViewTextBoxColumn
        '
        Me.RPNameDataGridViewTextBoxColumn.DataPropertyName = "RP Name"
        Me.RPNameDataGridViewTextBoxColumn.HeaderText = "RP Name"
        Me.RPNameDataGridViewTextBoxColumn.Name = "RPNameDataGridViewTextBoxColumn"
        Me.RPNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ForumNameDataGridViewTextBoxColumn
        '
        Me.ForumNameDataGridViewTextBoxColumn.DataPropertyName = "Forum Name"
        Me.ForumNameDataGridViewTextBoxColumn.HeaderText = "Forum Name"
        Me.ForumNameDataGridViewTextBoxColumn.Name = "ForumNameDataGridViewTextBoxColumn"
        Me.ForumNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NicknameDataGridViewTextBoxColumn
        '
        Me.NicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn.HeaderText = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn.Name = "NicknameDataGridViewTextBoxColumn"
        Me.NicknameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HighestKnownPositionDataGridViewTextBoxColumn
        '
        Me.HighestKnownPositionDataGridViewTextBoxColumn.DataPropertyName = "Highest Known Position"
        Me.HighestKnownPositionDataGridViewTextBoxColumn.HeaderText = "Highest Known Position"
        Me.HighestKnownPositionDataGridViewTextBoxColumn.Name = "HighestKnownPositionDataGridViewTextBoxColumn"
        Me.HighestKnownPositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Visible = False
        '
        'LocalRecordsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 561)
        Me.Controls.Add(Me.NotesGroupbox)
        Me.Controls.Add(Me.RecordsGroupbox)
        Me.Controls.Add(Me.ToolsGroupbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LocalRecordsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Local Records"
        Me.NotesGroupbox.ResumeLayout(False)
        Me.RecordsGroupbox.ResumeLayout(False)
        Me.RecordsGroupbox.PerformLayout()
        CType(Me.DgvLocalRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivRPUserRecordsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolsGroupbox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotesGroupbox As GroupBox
    Friend WithEvents BtnNotes As Button
    Friend WithEvents RecordsGroupbox As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents ToolsGroupbox As GroupBox
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents SteamID As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DgvLocalRecords As DataGridView
    Friend WithEvents DivRPUserRecordsDataSet1 As DivRPUserRecordsDataSet1
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As DivRPUserRecordsDataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As DivRPUserRecordsDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SteamIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RPNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ForumNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HighestKnownPositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
End Class
