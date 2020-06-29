<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnAPISearch = New System.Windows.Forms.Button()
        Me.LblAPI = New System.Windows.Forms.Label()
        Me.TxtAPI = New System.Windows.Forms.TextBox()
        Me.BtnBansSearch = New System.Windows.Forms.Button()
        Me.LblBans = New System.Windows.Forms.Label()
        Me.TxtBans = New System.Windows.Forms.TextBox()
        Me.BtnAltsSearch = New System.Windows.Forms.Button()
        Me.LblAlts = New System.Windows.Forms.Label()
        Me.TxtAlts = New System.Windows.Forms.TextBox()
        Me.BtnSteamRepSearch = New System.Windows.Forms.Button()
        Me.BtnForumsSearch = New System.Windows.Forms.Button()
        Me.LblForums = New System.Windows.Forms.Label()
        Me.LblSteamRep = New System.Windows.Forms.Label()
        Me.TxtSteamRep = New System.Windows.Forms.TextBox()
        Me.TxtForums = New System.Windows.Forms.TextBox()
        Me.BtnGoogleSearch = New System.Windows.Forms.Button()
        Me.LblGoogle = New System.Windows.Forms.Label()
        Me.TxtGoogle = New System.Windows.Forms.TextBox()
        Me.CurrentUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivRPUserRecordsDataSet = New Administration_Tool.DivRPUserRecordsDataSet()
        Me.BtnAlts = New System.Windows.Forms.Button()
        Me.BtnBans = New System.Windows.Forms.Button()
        Me.BtnForums = New System.Windows.Forms.Button()
        Me.BtnUserRecords = New System.Windows.Forms.Button()
        Me.BtnNotes = New System.Windows.Forms.Button()
        Me.BtnVaporwave = New System.Windows.Forms.Button()
        Me.Btn420 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnTextFaces = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnHandbook = New System.Windows.Forms.Button()
        Me.BtnStaff = New System.Windows.Forms.Button()
        Me.BtnStaffActivity = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblWelcomeBack = New System.Windows.Forms.Label()
        Me.CurrentUsersTableAdapter = New Administration_Tool.DivRPUserRecordsDataSetTableAdapters.CurrentUsersTableAdapter()
        Me.BtnGlobalRecords = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CurrentUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivRPUserRecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnAPISearch)
        Me.GroupBox3.Controls.Add(Me.LblAPI)
        Me.GroupBox3.Controls.Add(Me.TxtAPI)
        Me.GroupBox3.Controls.Add(Me.BtnBansSearch)
        Me.GroupBox3.Controls.Add(Me.LblBans)
        Me.GroupBox3.Controls.Add(Me.TxtBans)
        Me.GroupBox3.Controls.Add(Me.BtnAltsSearch)
        Me.GroupBox3.Controls.Add(Me.LblAlts)
        Me.GroupBox3.Controls.Add(Me.TxtAlts)
        Me.GroupBox3.Controls.Add(Me.BtnSteamRepSearch)
        Me.GroupBox3.Controls.Add(Me.BtnForumsSearch)
        Me.GroupBox3.Controls.Add(Me.LblForums)
        Me.GroupBox3.Controls.Add(Me.LblSteamRep)
        Me.GroupBox3.Controls.Add(Me.TxtSteamRep)
        Me.GroupBox3.Controls.Add(Me.TxtForums)
        Me.GroupBox3.Controls.Add(Me.BtnGoogleSearch)
        Me.GroupBox3.Controls.Add(Me.LblGoogle)
        Me.GroupBox3.Controls.Add(Me.TxtGoogle)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 270)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Administration"
        '
        'BtnAPISearch
        '
        Me.BtnAPISearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnAPISearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnAPISearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAPISearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAPISearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.BtnAPISearch.ForeColor = System.Drawing.Color.White
        Me.BtnAPISearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAPISearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAPISearch.Location = New System.Drawing.Point(368, 237)
        Me.BtnAPISearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAPISearch.Name = "BtnAPISearch"
        Me.BtnAPISearch.Size = New System.Drawing.Size(80, 26)
        Me.BtnAPISearch.TabIndex = 17
        Me.BtnAPISearch.Text = "Search"
        Me.BtnAPISearch.UseVisualStyleBackColor = False
        '
        'LblAPI
        '
        Me.LblAPI.AutoSize = True
        Me.LblAPI.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.LblAPI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAPI.Location = New System.Drawing.Point(6, 224)
        Me.LblAPI.Name = "LblAPI"
        Me.LblAPI.Size = New System.Drawing.Size(145, 16)
        Me.LblAPI.TabIndex = 16
        Me.LblAPI.Text = "Get PlayerAPI with SteamID"
        '
        'TxtAPI
        '
        Me.TxtAPI.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAPI.ForeColor = System.Drawing.Color.White
        Me.TxtAPI.Location = New System.Drawing.Point(6, 241)
        Me.TxtAPI.MaxLength = 20
        Me.TxtAPI.Name = "TxtAPI"
        Me.TxtAPI.Size = New System.Drawing.Size(359, 20)
        Me.TxtAPI.TabIndex = 15
        '
        'BtnBansSearch
        '
        Me.BtnBansSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnBansSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnBansSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnBansSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBansSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.BtnBansSearch.ForeColor = System.Drawing.Color.White
        Me.BtnBansSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBansSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnBansSearch.Location = New System.Drawing.Point(368, 197)
        Me.BtnBansSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnBansSearch.Name = "BtnBansSearch"
        Me.BtnBansSearch.Size = New System.Drawing.Size(80, 26)
        Me.BtnBansSearch.TabIndex = 14
        Me.BtnBansSearch.Text = "Search"
        Me.BtnBansSearch.UseVisualStyleBackColor = False
        '
        'LblBans
        '
        Me.LblBans.AutoSize = True
        Me.LblBans.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.LblBans.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblBans.Location = New System.Drawing.Point(6, 184)
        Me.LblBans.Name = "LblBans"
        Me.LblBans.Size = New System.Drawing.Size(188, 16)
        Me.LblBans.TabIndex = 13
        Me.LblBans.Text = "Check SteamID / Username for Bans"
        '
        'TxtBans
        '
        Me.TxtBans.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtBans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBans.ForeColor = System.Drawing.Color.White
        Me.TxtBans.Location = New System.Drawing.Point(6, 201)
        Me.TxtBans.MaxLength = 100
        Me.TxtBans.Name = "TxtBans"
        Me.TxtBans.Size = New System.Drawing.Size(359, 20)
        Me.TxtBans.TabIndex = 12
        '
        'BtnAltsSearch
        '
        Me.BtnAltsSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnAltsSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnAltsSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAltsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAltsSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.BtnAltsSearch.ForeColor = System.Drawing.Color.White
        Me.BtnAltsSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAltsSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAltsSearch.Location = New System.Drawing.Point(368, 155)
        Me.BtnAltsSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAltsSearch.Name = "BtnAltsSearch"
        Me.BtnAltsSearch.Size = New System.Drawing.Size(80, 26)
        Me.BtnAltsSearch.TabIndex = 11
        Me.BtnAltsSearch.Text = "Search"
        Me.BtnAltsSearch.UseVisualStyleBackColor = False
        '
        'LblAlts
        '
        Me.LblAlts.AutoSize = True
        Me.LblAlts.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.LblAlts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAlts.Location = New System.Drawing.Point(6, 142)
        Me.LblAlts.Name = "LblAlts"
        Me.LblAlts.Size = New System.Drawing.Size(121, 16)
        Me.LblAlts.TabIndex = 10
        Me.LblAlts.Text = "Check SteamID for Alts"
        '
        'TxtAlts
        '
        Me.TxtAlts.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtAlts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAlts.ForeColor = System.Drawing.Color.White
        Me.TxtAlts.Location = New System.Drawing.Point(6, 159)
        Me.TxtAlts.MaxLength = 20
        Me.TxtAlts.Name = "TxtAlts"
        Me.TxtAlts.Size = New System.Drawing.Size(359, 20)
        Me.TxtAlts.TabIndex = 9
        '
        'BtnSteamRepSearch
        '
        Me.BtnSteamRepSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnSteamRepSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSteamRepSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnSteamRepSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSteamRepSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.BtnSteamRepSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSteamRepSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSteamRepSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSteamRepSearch.Location = New System.Drawing.Point(368, 31)
        Me.BtnSteamRepSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSteamRepSearch.Name = "BtnSteamRepSearch"
        Me.BtnSteamRepSearch.Size = New System.Drawing.Size(80, 26)
        Me.BtnSteamRepSearch.TabIndex = 8
        Me.BtnSteamRepSearch.Text = "Search"
        Me.BtnSteamRepSearch.UseVisualStyleBackColor = False
        '
        'BtnForumsSearch
        '
        Me.BtnForumsSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnForumsSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnForumsSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnForumsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnForumsSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.BtnForumsSearch.ForeColor = System.Drawing.Color.White
        Me.BtnForumsSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnForumsSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnForumsSearch.Location = New System.Drawing.Point(368, 115)
        Me.BtnForumsSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnForumsSearch.Name = "BtnForumsSearch"
        Me.BtnForumsSearch.Size = New System.Drawing.Size(80, 26)
        Me.BtnForumsSearch.TabIndex = 5
        Me.BtnForumsSearch.Text = "Search"
        Me.BtnForumsSearch.UseVisualStyleBackColor = False
        '
        'LblForums
        '
        Me.LblForums.AutoSize = True
        Me.LblForums.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.LblForums.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblForums.Location = New System.Drawing.Point(6, 100)
        Me.LblForums.Name = "LblForums"
        Me.LblForums.Size = New System.Drawing.Size(101, 16)
        Me.LblForums.TabIndex = 4
        Me.LblForums.Text = "Search the Forums"
        '
        'LblSteamRep
        '
        Me.LblSteamRep.AutoSize = True
        Me.LblSteamRep.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.LblSteamRep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSteamRep.Location = New System.Drawing.Point(6, 16)
        Me.LblSteamRep.Name = "LblSteamRep"
        Me.LblSteamRep.Size = New System.Drawing.Size(95, 16)
        Me.LblSteamRep.TabIndex = 7
        Me.LblSteamRep.Text = "SteamRep Lookup"
        '
        'TxtSteamRep
        '
        Me.TxtSteamRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtSteamRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSteamRep.ForeColor = System.Drawing.Color.White
        Me.TxtSteamRep.Location = New System.Drawing.Point(6, 35)
        Me.TxtSteamRep.MaxLength = 20
        Me.TxtSteamRep.Name = "TxtSteamRep"
        Me.TxtSteamRep.Size = New System.Drawing.Size(359, 20)
        Me.TxtSteamRep.TabIndex = 6
        '
        'TxtForums
        '
        Me.TxtForums.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtForums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtForums.ForeColor = System.Drawing.Color.White
        Me.TxtForums.Location = New System.Drawing.Point(6, 119)
        Me.TxtForums.MaxLength = 100
        Me.TxtForums.Name = "TxtForums"
        Me.TxtForums.Size = New System.Drawing.Size(359, 20)
        Me.TxtForums.TabIndex = 3
        '
        'BtnGoogleSearch
        '
        Me.BtnGoogleSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnGoogleSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnGoogleSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnGoogleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGoogleSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.BtnGoogleSearch.ForeColor = System.Drawing.Color.White
        Me.BtnGoogleSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGoogleSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnGoogleSearch.Location = New System.Drawing.Point(368, 73)
        Me.BtnGoogleSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGoogleSearch.Name = "BtnGoogleSearch"
        Me.BtnGoogleSearch.Size = New System.Drawing.Size(80, 26)
        Me.BtnGoogleSearch.TabIndex = 2
        Me.BtnGoogleSearch.Text = "Search"
        Me.BtnGoogleSearch.UseVisualStyleBackColor = False
        '
        'LblGoogle
        '
        Me.LblGoogle.AutoSize = True
        Me.LblGoogle.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.LblGoogle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblGoogle.Location = New System.Drawing.Point(6, 58)
        Me.LblGoogle.Name = "LblGoogle"
        Me.LblGoogle.Size = New System.Drawing.Size(140, 16)
        Me.LblGoogle.TabIndex = 1
        Me.LblGoogle.Text = "Search Google for SteamID"
        '
        'TxtGoogle
        '
        Me.TxtGoogle.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtGoogle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGoogle.ForeColor = System.Drawing.Color.White
        Me.TxtGoogle.Location = New System.Drawing.Point(6, 77)
        Me.TxtGoogle.MaxLength = 20
        Me.TxtGoogle.Name = "TxtGoogle"
        Me.TxtGoogle.Size = New System.Drawing.Size(359, 20)
        Me.TxtGoogle.TabIndex = 0
        '
        'CurrentUsersBindingSource
        '
        Me.CurrentUsersBindingSource.DataMember = "CurrentUsers"
        Me.CurrentUsersBindingSource.DataSource = Me.DivRPUserRecordsDataSet
        '
        'DivRPUserRecordsDataSet
        '
        Me.DivRPUserRecordsDataSet.DataSetName = "DivRPUserRecordsDataSet"
        Me.DivRPUserRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAlts
        '
        Me.BtnAlts.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnAlts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnAlts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAlts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlts.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAlts.ForeColor = System.Drawing.Color.White
        Me.BtnAlts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAlts.Location = New System.Drawing.Point(112, 19)
        Me.BtnAlts.Name = "BtnAlts"
        Me.BtnAlts.Size = New System.Drawing.Size(100, 35)
        Me.BtnAlts.TabIndex = 3
        Me.BtnAlts.Text = "Alts"
        Me.BtnAlts.UseVisualStyleBackColor = False
        '
        'BtnBans
        '
        Me.BtnBans.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnBans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnBans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnBans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBans.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBans.ForeColor = System.Drawing.Color.White
        Me.BtnBans.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnBans.Location = New System.Drawing.Point(6, 60)
        Me.BtnBans.Name = "BtnBans"
        Me.BtnBans.Size = New System.Drawing.Size(100, 35)
        Me.BtnBans.TabIndex = 1
        Me.BtnBans.Text = "Bans"
        Me.BtnBans.UseVisualStyleBackColor = False
        '
        'BtnForums
        '
        Me.BtnForums.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnForums.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnForums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnForums.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnForums.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnForums.ForeColor = System.Drawing.Color.White
        Me.BtnForums.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnForums.Location = New System.Drawing.Point(6, 19)
        Me.BtnForums.Name = "BtnForums"
        Me.BtnForums.Size = New System.Drawing.Size(100, 35)
        Me.BtnForums.TabIndex = 0
        Me.BtnForums.Text = "Forums"
        Me.BtnForums.UseVisualStyleBackColor = False
        '
        'BtnUserRecords
        '
        Me.BtnUserRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnUserRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnUserRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnUserRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserRecords.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUserRecords.ForeColor = System.Drawing.Color.White
        Me.BtnUserRecords.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnUserRecords.Location = New System.Drawing.Point(6, 60)
        Me.BtnUserRecords.Name = "BtnUserRecords"
        Me.BtnUserRecords.Size = New System.Drawing.Size(100, 35)
        Me.BtnUserRecords.TabIndex = 3
        Me.BtnUserRecords.Text = "Local Records"
        Me.BtnUserRecords.UseVisualStyleBackColor = False
        '
        'BtnNotes
        '
        Me.BtnNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotes.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNotes.ForeColor = System.Drawing.Color.White
        Me.BtnNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNotes.Location = New System.Drawing.Point(6, 19)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(100, 35)
        Me.BtnNotes.TabIndex = 2
        Me.BtnNotes.Text = "Notes"
        Me.BtnNotes.UseVisualStyleBackColor = False
        '
        'BtnVaporwave
        '
        Me.BtnVaporwave.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnVaporwave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnVaporwave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnVaporwave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVaporwave.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVaporwave.ForeColor = System.Drawing.Color.White
        Me.BtnVaporwave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnVaporwave.Location = New System.Drawing.Point(6, 101)
        Me.BtnVaporwave.Name = "BtnVaporwave"
        Me.BtnVaporwave.Size = New System.Drawing.Size(100, 35)
        Me.BtnVaporwave.TabIndex = 4
        Me.BtnVaporwave.Text = "Zalgo Text"
        Me.BtnVaporwave.UseVisualStyleBackColor = False
        '
        'Btn420
        '
        Me.Btn420.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn420.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Btn420.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Btn420.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn420.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Btn420.ForeColor = System.Drawing.Color.White
        Me.Btn420.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn420.Location = New System.Drawing.Point(6, 61)
        Me.Btn420.Name = "Btn420"
        Me.Btn420.Size = New System.Drawing.Size(100, 35)
        Me.Btn420.TabIndex = 3
        Me.Btn420.Text = "420"
        Me.Btn420.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox4.Controls.Add(Me.BtnVaporwave)
        Me.GroupBox4.Controls.Add(Me.Btn420)
        Me.GroupBox4.Controls.Add(Me.BtnTextFaces)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(236, 308)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 142)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fun Stuff"
        '
        'BtnTextFaces
        '
        Me.BtnTextFaces.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnTextFaces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnTextFaces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnTextFaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTextFaces.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTextFaces.ForeColor = System.Drawing.Color.White
        Me.BtnTextFaces.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnTextFaces.Location = New System.Drawing.Point(6, 19)
        Me.BtnTextFaces.Name = "BtnTextFaces"
        Me.BtnTextFaces.Size = New System.Drawing.Size(100, 35)
        Me.BtnTextFaces.TabIndex = 2
        Me.BtnTextFaces.Text = "Text Faces"
        Me.BtnTextFaces.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnHandbook)
        Me.GroupBox2.Controls.Add(Me.BtnStaff)
        Me.GroupBox2.Controls.Add(Me.BtnAlts)
        Me.GroupBox2.Controls.Add(Me.BtnStaffActivity)
        Me.GroupBox2.Controls.Add(Me.BtnBans)
        Me.GroupBox2.Controls.Add(Me.BtnForums)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 142)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Useful Links"
        '
        'BtnHandbook
        '
        Me.BtnHandbook.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnHandbook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnHandbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnHandbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHandbook.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHandbook.ForeColor = System.Drawing.Color.White
        Me.BtnHandbook.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnHandbook.Location = New System.Drawing.Point(112, 101)
        Me.BtnHandbook.Name = "BtnHandbook"
        Me.BtnHandbook.Size = New System.Drawing.Size(100, 35)
        Me.BtnHandbook.TabIndex = 5
        Me.BtnHandbook.Text = "Handbook"
        Me.BtnHandbook.UseVisualStyleBackColor = False
        '
        'BtnStaff
        '
        Me.BtnStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStaff.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnStaff.ForeColor = System.Drawing.Color.White
        Me.BtnStaff.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnStaff.Location = New System.Drawing.Point(112, 60)
        Me.BtnStaff.Name = "BtnStaff"
        Me.BtnStaff.Size = New System.Drawing.Size(100, 35)
        Me.BtnStaff.TabIndex = 4
        Me.BtnStaff.Text = "Staff"
        Me.BtnStaff.UseVisualStyleBackColor = False
        '
        'BtnStaffActivity
        '
        Me.BtnStaffActivity.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnStaffActivity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnStaffActivity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnStaffActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStaffActivity.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnStaffActivity.ForeColor = System.Drawing.Color.White
        Me.BtnStaffActivity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnStaffActivity.Location = New System.Drawing.Point(6, 101)
        Me.BtnStaffActivity.Name = "BtnStaffActivity"
        Me.BtnStaffActivity.Size = New System.Drawing.Size(100, 35)
        Me.BtnStaffActivity.TabIndex = 2
        Me.BtnStaffActivity.Text = "Staff Activity"
        Me.BtnStaffActivity.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.BtnGlobalRecords)
        Me.GroupBox1.Controls.Add(Me.BtnUserRecords)
        Me.GroupBox1.Controls.Add(Me.BtnNotes)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(354, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 142)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'LblWelcomeBack
        '
        Me.LblWelcomeBack.AutoSize = True
        Me.LblWelcomeBack.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcomeBack.ForeColor = System.Drawing.Color.LightGray
        Me.LblWelcomeBack.Location = New System.Drawing.Point(9, 9)
        Me.LblWelcomeBack.Name = "LblWelcomeBack"
        Me.LblWelcomeBack.Size = New System.Drawing.Size(143, 16)
        Me.LblWelcomeBack.TabIndex = 9
        Me.LblWelcomeBack.Text = "Welcome back, @UI_NAME."
        '
        'CurrentUsersTableAdapter
        '
        Me.CurrentUsersTableAdapter.ClearBeforeFill = True
        '
        'BtnGlobalRecords
        '
        Me.BtnGlobalRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnGlobalRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnGlobalRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnGlobalRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGlobalRecords.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGlobalRecords.ForeColor = System.Drawing.Color.White
        Me.BtnGlobalRecords.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnGlobalRecords.Location = New System.Drawing.Point(6, 101)
        Me.BtnGlobalRecords.Name = "BtnGlobalRecords"
        Me.BtnGlobalRecords.Size = New System.Drawing.Size(100, 35)
        Me.BtnGlobalRecords.TabIndex = 4
        Me.BtnGlobalRecords.Text = "Global Records"
        Me.BtnGlobalRecords.UseVisualStyleBackColor = False
        Me.BtnGlobalRecords.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(478, 462)
        Me.Controls.Add(Me.LblWelcomeBack)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divinity Roleplay Administration Tool"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CurrentUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivRPUserRecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnBansSearch As Button
    Friend WithEvents LblBans As Label
    Friend WithEvents TxtBans As TextBox
    Friend WithEvents BtnAltsSearch As Button
    Friend WithEvents LblAlts As Label
    Friend WithEvents TxtAlts As TextBox
    Friend WithEvents BtnSteamRepSearch As Button
    Friend WithEvents BtnForumsSearch As Button
    Friend WithEvents LblForums As Label
    Friend WithEvents LblSteamRep As Label
    Friend WithEvents TxtSteamRep As TextBox
    Friend WithEvents TxtForums As TextBox
    Friend WithEvents BtnGoogleSearch As Button
    Friend WithEvents LblGoogle As Label
    Friend WithEvents TxtGoogle As TextBox
    Friend WithEvents BtnAlts As Button
    Friend WithEvents BtnBans As Button
    Friend WithEvents BtnForums As Button
    Friend WithEvents BtnUserRecords As Button
    Friend WithEvents BtnNotes As Button
    Friend WithEvents BtnVaporwave As Button
    Friend WithEvents Btn420 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnTextFaces As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnStaffActivity As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblWelcomeBack As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DivRPUserRecordsDataSet As DivRPUserRecordsDataSet
    Friend WithEvents CurrentUsersBindingSource As BindingSource
    Friend WithEvents CurrentUsersTableAdapter As DivRPUserRecordsDataSetTableAdapters.CurrentUsersTableAdapter
    Friend WithEvents BtnAPISearch As Button
    Friend WithEvents LblAPI As Label
    Friend WithEvents TxtAPI As TextBox
    Friend WithEvents BtnHandbook As Button
    Friend WithEvents BtnStaff As Button
    Friend WithEvents BtnGlobalRecords As Button
End Class
