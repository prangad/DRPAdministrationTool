Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class GlobalRecordNotesForm

    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection

    Private Sub GlobalRecordNotesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i = GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow.Index
        Dim rpname As String = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("RPName", i).Value, String)
        Dim steamid As String = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("SteamID", i).Value, String)
        Dim notes = GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("Notes", i).Value

        TxtRecordName.Text = "You are viewing the global record of: " & rpname & " (" & steamid & ")."
        Me.Text = "Global record notes of: " & rpname & " (" & steamid & ")"

        If IsDBNull(notes) Then

        Else
            Me.RtxtNotes.Text = notes
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim i As Integer = GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow.Index

        Dim connString As String = "Data Source=administration.database.windows.net;Initial Catalog=DivRPUserRecords;Persist Security Info=True;User ID=Ghost;Password='t~9LvV4G$!L)""{R'"
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "UPDATE UserRecords SET [Notes] = @Notes WHERE ID=" & GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("ID", i).Value
        Dim cmd As SqlCommand = New SqlCommand(str, myConnection)
        cmd.Parameters.AddWithValue("@Notes", CType(RtxtNotes.Text, String))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            RtxtNotes.Clear()
            GlobalPlayerRecordsForm.GlobalRecordsTableAdapter.Fill(GlobalPlayerRecordsForm.DivRPUserRecordsDataSet.GlobalRecords)
            If IsNothing(GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow) = False Then
                GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow.Selected = True
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnWipe_Click(sender As Object, e As EventArgs) Handles BtnWipe.Click
        If MsgBox("This will permanently remove the record notes. Are you sure?", vbYesNo) = vbNo Then

        Else
            RtxtNotes.Text = String.Empty
            BtnSave.PerformClick()
        End If
    End Sub
End Class