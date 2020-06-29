<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLocalRecordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditLocalRecordForm))
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.EditGroupbox = New System.Windows.Forms.GroupBox()
        Me.CboHighestKnownPosition = New System.Windows.Forms.ComboBox()
        Me.TxtSteamID = New System.Windows.Forms.TextBox()
        Me.LblHighestKnownPosition = New System.Windows.Forms.Label()
        Me.LblSteamID = New System.Windows.Forms.Label()
        Me.TxtNickname = New System.Windows.Forms.TextBox()
        Me.LblRPName = New System.Windows.Forms.Label()
        Me.LblNickname = New System.Windows.Forms.Label()
        Me.TxtRPName = New System.Windows.Forms.TextBox()
        Me.TxtForumName = New System.Windows.Forms.TextBox()
        Me.LblForumName = New System.Windows.Forms.Label()
        Me.EditGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancel.Location = New System.Drawing.Point(12, 252)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 35)
        Me.BtnCancel.TabIndex = 25
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSubmit.Location = New System.Drawing.Point(177, 252)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(100, 35)
        Me.BtnSubmit.TabIndex = 24
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'EditGroupbox
        '
        Me.EditGroupbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EditGroupbox.Controls.Add(Me.CboHighestKnownPosition)
        Me.EditGroupbox.Controls.Add(Me.TxtSteamID)
        Me.EditGroupbox.Controls.Add(Me.LblHighestKnownPosition)
        Me.EditGroupbox.Controls.Add(Me.LblSteamID)
        Me.EditGroupbox.Controls.Add(Me.TxtNickname)
        Me.EditGroupbox.Controls.Add(Me.LblRPName)
        Me.EditGroupbox.Controls.Add(Me.LblNickname)
        Me.EditGroupbox.Controls.Add(Me.TxtRPName)
        Me.EditGroupbox.Controls.Add(Me.TxtForumName)
        Me.EditGroupbox.Controls.Add(Me.LblForumName)
        Me.EditGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditGroupbox.ForeColor = System.Drawing.Color.White
        Me.EditGroupbox.Location = New System.Drawing.Point(12, 12)
        Me.EditGroupbox.Name = "EditGroupbox"
        Me.EditGroupbox.Size = New System.Drawing.Size(265, 234)
        Me.EditGroupbox.TabIndex = 26
        Me.EditGroupbox.TabStop = False
        Me.EditGroupbox.Text = "Edit Local Record"
        '
        'CboHighestKnownPosition
        '
        Me.CboHighestKnownPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CboHighestKnownPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboHighestKnownPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboHighestKnownPosition.ForeColor = System.Drawing.Color.White
        Me.CboHighestKnownPosition.FormattingEnabled = True
        Me.CboHighestKnownPosition.Items.AddRange(New Object() {"User", "Moderator", "Trial-Administrator", "Permanent Administrator", "Head Administrator", "Super Administrator", "Legend"})
        Me.CboHighestKnownPosition.Location = New System.Drawing.Point(9, 205)
        Me.CboHighestKnownPosition.Name = "CboHighestKnownPosition"
        Me.CboHighestKnownPosition.Size = New System.Drawing.Size(250, 21)
        Me.CboHighestKnownPosition.TabIndex = 19
        '
        'TxtSteamID
        '
        Me.TxtSteamID.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtSteamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSteamID.ForeColor = System.Drawing.Color.White
        Me.TxtSteamID.Location = New System.Drawing.Point(9, 35)
        Me.TxtSteamID.Name = "TxtSteamID"
        Me.TxtSteamID.Size = New System.Drawing.Size(250, 20)
        Me.TxtSteamID.TabIndex = 11
        '
        'LblHighestKnownPosition
        '
        Me.LblHighestKnownPosition.AutoSize = True
        Me.LblHighestKnownPosition.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHighestKnownPosition.Location = New System.Drawing.Point(6, 186)
        Me.LblHighestKnownPosition.Name = "LblHighestKnownPosition"
        Me.LblHighestKnownPosition.Size = New System.Drawing.Size(133, 16)
        Me.LblHighestKnownPosition.TabIndex = 18
        Me.LblHighestKnownPosition.Text = "Highest Known Position"
        '
        'LblSteamID
        '
        Me.LblSteamID.AutoSize = True
        Me.LblSteamID.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSteamID.Location = New System.Drawing.Point(6, 16)
        Me.LblSteamID.Name = "LblSteamID"
        Me.LblSteamID.Size = New System.Drawing.Size(50, 16)
        Me.LblSteamID.TabIndex = 10
        Me.LblSteamID.Text = "SteamID"
        '
        'TxtNickname
        '
        Me.TxtNickname.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNickname.ForeColor = System.Drawing.Color.White
        Me.TxtNickname.Location = New System.Drawing.Point(9, 163)
        Me.TxtNickname.Name = "TxtNickname"
        Me.TxtNickname.Size = New System.Drawing.Size(250, 20)
        Me.TxtNickname.TabIndex = 17
        '
        'LblRPName
        '
        Me.LblRPName.AutoSize = True
        Me.LblRPName.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRPName.Location = New System.Drawing.Point(6, 57)
        Me.LblRPName.Name = "LblRPName"
        Me.LblRPName.Size = New System.Drawing.Size(53, 16)
        Me.LblRPName.TabIndex = 12
        Me.LblRPName.Text = "RP Name"
        '
        'LblNickname
        '
        Me.LblNickname.AutoSize = True
        Me.LblNickname.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNickname.Location = New System.Drawing.Point(6, 143)
        Me.LblNickname.Name = "LblNickname"
        Me.LblNickname.Size = New System.Drawing.Size(61, 16)
        Me.LblNickname.TabIndex = 16
        Me.LblNickname.Text = "Nickname"
        '
        'TxtRPName
        '
        Me.TxtRPName.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtRPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRPName.ForeColor = System.Drawing.Color.White
        Me.TxtRPName.Location = New System.Drawing.Point(9, 77)
        Me.TxtRPName.Name = "TxtRPName"
        Me.TxtRPName.Size = New System.Drawing.Size(250, 20)
        Me.TxtRPName.TabIndex = 13
        '
        'TxtForumName
        '
        Me.TxtForumName.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TxtForumName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtForumName.ForeColor = System.Drawing.Color.White
        Me.TxtForumName.Location = New System.Drawing.Point(9, 120)
        Me.TxtForumName.Name = "TxtForumName"
        Me.TxtForumName.Size = New System.Drawing.Size(250, 20)
        Me.TxtForumName.TabIndex = 15
        '
        'LblForumName
        '
        Me.LblForumName.AutoSize = True
        Me.LblForumName.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblForumName.Location = New System.Drawing.Point(6, 100)
        Me.LblForumName.Name = "LblForumName"
        Me.LblForumName.Size = New System.Drawing.Size(73, 16)
        Me.LblForumName.TabIndex = 14
        Me.LblForumName.Text = "Forum Name"
        '
        'EditLocalRecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 299)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.EditGroupbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditLocalRecordForm"
        Me.Text = "Edit Local Record"
        Me.EditGroupbox.ResumeLayout(False)
        Me.EditGroupbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents EditGroupbox As GroupBox
    Friend WithEvents CboHighestKnownPosition As ComboBox
    Friend WithEvents TxtSteamID As TextBox
    Friend WithEvents LblHighestKnownPosition As Label
    Friend WithEvents LblSteamID As Label
    Friend WithEvents TxtNickname As TextBox
    Friend WithEvents LblRPName As Label
    Friend WithEvents LblNickname As Label
    Friend WithEvents TxtRPName As TextBox
    Friend WithEvents TxtForumName As TextBox
    Friend WithEvents LblForumName As Label
End Class
