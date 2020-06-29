<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlobalPlayerRecordsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GlobalPlayerRecordsForm))
        Me.RecordsGroupbox = New System.Windows.Forms.GroupBox()
        Me.DgvGlobalUserRecords = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SteamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForumName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HighestKnownPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Profile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivRPUserRecordsDataSet = New Administration_Tool.DivRPUserRecordsDataSet()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearchbar = New System.Windows.Forms.TextBox()
        Me.NotesGroupbox = New System.Windows.Forms.GroupBox()
        Me.BtnProfile = New System.Windows.Forms.Button()
        Me.BtnNotes = New System.Windows.Forms.Button()
        Me.ToolsGroupbox = New System.Windows.Forms.GroupBox()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.UserRecordsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GlobalRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GlobalRecordsTableAdapter = New Administration_Tool.DivRPUserRecordsDataSetTableAdapters.GlobalRecordsTableAdapter()
        Me.RecordsGroupbox.SuspendLayout()
        CType(Me.DgvGlobalUserRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivRPUserRecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotesGroupbox.SuspendLayout()
        Me.ToolsGroupbox.SuspendLayout()
        CType(Me.UserRecordsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlobalRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecordsGroupbox
        '
        Me.RecordsGroupbox.Controls.Add(Me.DgvGlobalUserRecords)
        Me.RecordsGroupbox.Controls.Add(Me.BtnSearch)
        Me.RecordsGroupbox.Controls.Add(Me.TxtSearchbar)
        Me.RecordsGroupbox.ForeColor = System.Drawing.Color.White
        Me.RecordsGroupbox.Location = New System.Drawing.Point(12, 12)
        Me.RecordsGroupbox.Name = "RecordsGroupbox"
        Me.RecordsGroupbox.Size = New System.Drawing.Size(760, 537)
        Me.RecordsGroupbox.TabIndex = 0
        Me.RecordsGroupbox.TabStop = False
        Me.RecordsGroupbox.Text = "Global Player Records"
        '
        'DgvGlobalUserRecords
        '
        Me.DgvGlobalUserRecords.AllowUserToAddRows = False
        Me.DgvGlobalUserRecords.AllowUserToDeleteRows = False
        Me.DgvGlobalUserRecords.AutoGenerateColumns = False
        Me.DgvGlobalUserRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvGlobalUserRecords.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DgvGlobalUserRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvGlobalUserRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.SteamID, Me.RPName, Me.ForumName, Me.Nickname, Me.HighestKnownPosition, Me.Notes, Me.Profile})
        Me.DgvGlobalUserRecords.DataSource = Me.GlobalRecordsBindingSource
        Me.DgvGlobalUserRecords.GridColor = System.Drawing.Color.Black
        Me.DgvGlobalUserRecords.Location = New System.Drawing.Point(7, 49)
        Me.DgvGlobalUserRecords.Name = "DgvGlobalUserRecords"
        Me.DgvGlobalUserRecords.ReadOnly = True
        Me.DgvGlobalUserRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvGlobalUserRecords.Size = New System.Drawing.Size(747, 482)
        Me.DgvGlobalUserRecords.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'SteamID
        '
        Me.SteamID.DataPropertyName = "SteamID"
        Me.SteamID.HeaderText = "SteamID"
        Me.SteamID.Name = "SteamID"
        Me.SteamID.ReadOnly = True
        Me.SteamID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'RPName
        '
        Me.RPName.DataPropertyName = "RP Name"
        Me.RPName.HeaderText = "RP Name"
        Me.RPName.Name = "RPName"
        Me.RPName.ReadOnly = True
        Me.RPName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ForumName
        '
        Me.ForumName.DataPropertyName = "Forum Name"
        Me.ForumName.HeaderText = "Forum Name"
        Me.ForumName.Name = "ForumName"
        Me.ForumName.ReadOnly = True
        Me.ForumName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Nickname
        '
        Me.Nickname.DataPropertyName = "Nickname"
        Me.Nickname.HeaderText = "Nickname"
        Me.Nickname.Name = "Nickname"
        Me.Nickname.ReadOnly = True
        Me.Nickname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'HighestKnownPosition
        '
        Me.HighestKnownPosition.DataPropertyName = "Highest Known Position"
        Me.HighestKnownPosition.HeaderText = "Highest Known Position"
        Me.HighestKnownPosition.Name = "HighestKnownPosition"
        Me.HighestKnownPosition.ReadOnly = True
        Me.HighestKnownPosition.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Visible = False
        '
        'Profile
        '
        Me.Profile.DataPropertyName = "Profile"
        Me.Profile.HeaderText = "Profile"
        Me.Profile.Name = "Profile"
        Me.Profile.ReadOnly = True
        Me.Profile.Visible = False
        '
        'UserRecordsBindingSource
        '
        Me.UserRecordsBindingSource.DataMember = "UserRecords"
        Me.UserRecordsBindingSource.DataSource = Me.DivRPUserRecordsDataSet
        '
        'DivRPUserRecordsDataSet
        '
        Me.DivRPUserRecordsDataSet.DataSetName = "DivRPUserRecordsDataSet"
        Me.DivRPUserRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSearch.Location = New System.Drawing.Point(632, 16)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(121, 30)
        Me.BtnSearch.TabIndex = 0
        Me.BtnSearch.Text = "Search for SteamID"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxtSearchbar
        '
        Me.TxtSearchbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtSearchbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchbar.ForeColor = System.Drawing.Color.White
        Me.TxtSearchbar.Location = New System.Drawing.Point(6, 22)
        Me.TxtSearchbar.MaxLength = 20
        Me.TxtSearchbar.Name = "TxtSearchbar"
        Me.TxtSearchbar.Size = New System.Drawing.Size(623, 20)
        Me.TxtSearchbar.TabIndex = 0
        '
        'NotesGroupbox
        '
        Me.NotesGroupbox.Controls.Add(Me.BtnProfile)
        Me.NotesGroupbox.Controls.Add(Me.BtnNotes)
        Me.NotesGroupbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NotesGroupbox.ForeColor = System.Drawing.Color.White
        Me.NotesGroupbox.Location = New System.Drawing.Point(482, 555)
        Me.NotesGroupbox.Name = "NotesGroupbox"
        Me.NotesGroupbox.Size = New System.Drawing.Size(290, 60)
        Me.NotesGroupbox.TabIndex = 14
        Me.NotesGroupbox.TabStop = False
        Me.NotesGroupbox.Text = "Record Information"
        '
        'BtnProfile
        '
        Me.BtnProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnProfile.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProfile.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.ForeColor = System.Drawing.Color.White
        Me.BtnProfile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnProfile.Location = New System.Drawing.Point(6, 19)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Size = New System.Drawing.Size(136, 35)
        Me.BtnProfile.TabIndex = 15
        Me.BtnProfile.Text = "View Profile"
        Me.BtnProfile.UseVisualStyleBackColor = False
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
        Me.BtnNotes.Location = New System.Drawing.Point(148, 19)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(136, 35)
        Me.BtnNotes.TabIndex = 14
        Me.BtnNotes.Text = "View Notes"
        Me.BtnNotes.UseVisualStyleBackColor = False
        '
        'ToolsGroupbox
        '
        Me.ToolsGroupbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolsGroupbox.Controls.Add(Me.BtnNew)
        Me.ToolsGroupbox.Controls.Add(Me.BtnEdit)
        Me.ToolsGroupbox.Controls.Add(Me.BtnDelete)
        Me.ToolsGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolsGroupbox.ForeColor = System.Drawing.Color.White
        Me.ToolsGroupbox.Location = New System.Drawing.Point(12, 555)
        Me.ToolsGroupbox.Name = "ToolsGroupbox"
        Me.ToolsGroupbox.Size = New System.Drawing.Size(464, 60)
        Me.ToolsGroupbox.TabIndex = 13
        Me.ToolsGroupbox.TabStop = False
        Me.ToolsGroupbox.Text = "Record Tools"
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
        Me.BtnEdit.Location = New System.Drawing.Point(252, 20)
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
        Me.BtnDelete.Location = New System.Drawing.Point(358, 19)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 35)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete Record"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'UserRecordsBindingSource1
        '
        Me.UserRecordsBindingSource1.DataMember = "UserRecords"
        Me.UserRecordsBindingSource1.DataSource = Me.DivRPUserRecordsDataSet
        '
        'GlobalRecordsBindingSource
        '
        Me.GlobalRecordsBindingSource.DataMember = "GlobalRecords"
        Me.GlobalRecordsBindingSource.DataSource = Me.DivRPUserRecordsDataSet
        '
        'GlobalRecordsTableAdapter
        '
        Me.GlobalRecordsTableAdapter.ClearBeforeFill = True
        '
        'GlobalPlayerRecordsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 627)
        Me.Controls.Add(Me.NotesGroupbox)
        Me.Controls.Add(Me.ToolsGroupbox)
        Me.Controls.Add(Me.RecordsGroupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GlobalPlayerRecordsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global Player Records"
        Me.RecordsGroupbox.ResumeLayout(False)
        Me.RecordsGroupbox.PerformLayout()
        CType(Me.DgvGlobalUserRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivRPUserRecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotesGroupbox.ResumeLayout(False)
        Me.ToolsGroupbox.ResumeLayout(False)
        CType(Me.GlobalRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RecordsGroupbox As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearchbar As TextBox
    Friend WithEvents NotesGroupbox As GroupBox
    Friend WithEvents BtnNotes As Button
    Friend WithEvents ToolsGroupbox As GroupBox
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SteamIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RPNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ForumNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HighestKnownPositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DivRPUserRecordsDataSet As DivRPUserRecordsDataSet
    Friend WithEvents UserRecordsBindingSource As BindingSource
    Friend WithEvents UserRecordsBindingSource1 As BindingSource
    Friend WithEvents DgvGlobalUserRecords As DataGridView
    Friend WithEvents BtnProfile As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents SteamID As DataGridViewTextBoxColumn
    Friend WithEvents RPName As DataGridViewTextBoxColumn
    Friend WithEvents ForumName As DataGridViewTextBoxColumn
    Friend WithEvents Nickname As DataGridViewTextBoxColumn
    Friend WithEvents HighestKnownPosition As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents Profile As DataGridViewTextBoxColumn
    Friend WithEvents GlobalRecordsBindingSource As BindingSource
    Friend WithEvents GlobalRecordsTableAdapter As DivRPUserRecordsDataSetTableAdapters.GlobalRecordsTableAdapter
End Class
