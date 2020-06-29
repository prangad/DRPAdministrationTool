Imports System.Data.OleDb

Public Class LocalRecordsForm
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub LocalRecordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DivRPUserRecordsDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DivRPUserRecordsDataSet1.Table1)
        Me.DgvLocalRecords.DefaultCellStyle.ForeColor = Color.Black
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        NewLocalRecordForm.Show()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        If IsNothing(DgvLocalRecords.CurrentRow) Then

            MsgBox("Please select the record you would like to edit.")

        Else

            Dim i = DgvLocalRecords.CurrentRow.Index
            Dim id = DgvLocalRecords.Item("ID", i).Value
            Dim steamid = DgvLocalRecords.Item("SteamID", i).Value
            Dim rpname = DgvLocalRecords.Item("RPName", i).Value
            Dim forumname = DgvLocalRecords.Item("ForumName", i).Value
            Dim nickname = DgvLocalRecords.Item("Nickname", i).Value
            Dim highestknownposition = DgvLocalRecords.Item("HighestKnownPosition", i).Value

            EditLocalRecordForm.Show()

            EditLocalRecordForm.TxtSteamID.Text = steamid
            EditLocalRecordForm.TxtRPName.Text = rpname
            EditLocalRecordForm.TxtForumName.Text = forumname
            EditLocalRecordForm.TxtNickname.Text = nickname
            EditLocalRecordForm.CboHighestKnownPosition.Text = highestknownposition

        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If IsNothing(DgvLocalRecords.CurrentRow) Then

            MsgBox("Please select the record you would like to delete.")

        Else

            If MsgBox("This will permanently remove the record. Are you sure?", vbYesNo) = vbNo Then



            Else

                Dim i = DgvLocalRecords.CurrentRow.Index

                connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DivRPUserRecords.accdb"
                myConnection.ConnectionString = connString
                myConnection.Open()
                Dim str As String
                str = "DELETE FROM [Table1] WHERE [ID] = " & DgvLocalRecords.Item("ID", i).Value
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Table1TableAdapter.Fill(DivRPUserRecordsDataSet1.Table1)
                    myConnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Me.Table1TableAdapter.Fill(Me.DivRPUserRecordsDataSet1.Table1)

            End If

        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Dim search As String = TxtSearch.Text

        If search.Contains("STEAM_") Then

            Table1BindingSource.Filter = String.Format("SteamID LIKE '%{0}%'", TxtSearch.Text)
        Else
            MsgBox("Please use SteamID format.")
        End If
    End Sub

    Private Sub BtnNotes_Click(sender As Object, e As EventArgs) Handles BtnNotes.Click
        If IsNothing(DgvLocalRecords.CurrentRow) Then
            MsgBox("Please select the record you would like to view.")
        Else
            Dim i = DgvLocalRecords.CurrentRow.Index
            Dim notes = DgvLocalRecords.Item("Notes", i).Value
            LocalRecordNotesForm.Show()
            If IsDBNull(notes) Then
            Else
                LocalRecordNotesForm.TxtNotes.Text = notes
            End If
        End If
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnSearch.PerformClick()
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        If TxtSearch.Text() = String.Empty Then
            Table1BindingSource.Filter = String.Format("SteamID LIKE '%{0}%'", TxtSearch.Text)
        End If
    End Sub

    Private Sub DgvLocalRecords_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

        DgvLocalRecords.CurrentRow.Selected = True

        Dim i = DgvLocalRecords.CurrentRow.Index
        Dim id = DgvLocalRecords.Item("ID", i).Value
        Dim steamid = DgvLocalRecords.Item("SteamID", i).Value
        Dim rpname = DgvLocalRecords.Item("RPName", i).Value
        Dim forumname = DgvLocalRecords.Item("ForumName", i).Value
        Dim nickname = DgvLocalRecords.Item("Nickname", i).Value
        Dim highestknownposition = DgvLocalRecords.Item("HighestKnownPosition", i).Value

        If id <= 0 Or IsDBNull(steamid) Then

            MsgBox("That is not a valid record.")

        Else

            EditLocalRecordForm.Show()

            EditLocalRecordForm.TxtSteamID.Text = steamid
            EditLocalRecordForm.TxtRPName.Text = rpname
            EditLocalRecordForm.TxtForumName.Text = forumname
            EditLocalRecordForm.TxtNickname.Text = nickname
            EditLocalRecordForm.CboHighestKnownPosition.Text = highestknownposition

        End If
    End Sub

    Private Sub DgvLocalRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim i = DgvLocalRecords.CurrentRow
        i.Selected = True
    End Sub
End Class