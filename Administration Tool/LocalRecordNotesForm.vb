Imports System.Data.OleDb

Public Class LocalRecordNotesForm
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub LocalRecordNotesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i = LocalRecordsForm.DgvLocalRecords.CurrentRow.Index
        Dim rpname = LocalRecordsForm.DgvLocalRecords.Item("RP Name", i).Value
        Dim steamid = LocalRecordsForm.DgvLocalRecords.Item("SteamID", i).Value

        LblRecord.Text = "You are viewing the record of: " & rpname & " (" & steamid & ")."

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim i = LocalRecordsForm.DgvLocalRecords.CurrentRow.Index

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DivRPUserRecords.accdb"
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "UPDATE [Table1] SET [Notes] = '" & Me.TxtNotes.Text.Replace("'", "") & "' WHERE [ID] = " & LocalRecordsForm.DgvLocalRecords.Item("ID", i).Value
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            LocalRecordsForm.Table1TableAdapter.Fill(LocalRecordsForm.DivRPUserRecordsDataSet1.Table1)
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        LocalRecordsForm.Table1TableAdapter.Fill(LocalRecordsForm.DivRPUserRecordsDataSet1.Table1)

        Me.Close()
    End Sub

    Private Sub BtnWipe_Click(sender As Object, e As EventArgs) Handles BtnWipe.Click
        If MsgBox("This will permanently remove the record. Are you sure?", vbYesNo) = vbNo Then
        Else

            Me.TxtNotes.Text = String.Empty

            Dim i = LocalRecordsForm.DgvLocalRecords.CurrentRow.Index

            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DivRPUserRecords.accdb"
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim str As String
            str = "UPDATE [Table1] SET [Notes] = '" & Me.TxtNotes.Text & "' WHERE [ID] = " & LocalRecordsForm.DgvLocalRecords.Item("ID", i).Value
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                LocalRecordsForm.Table1TableAdapter.Fill(LocalRecordsForm.DivRPUserRecordsDataSet1.Table1)
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            LocalRecordsForm.Table1TableAdapter.Fill(LocalRecordsForm.DivRPUserRecordsDataSet1.Table1)

            Me.TxtNotes.Text = String.Empty

            Me.Close()

        End If
    End Sub
End Class