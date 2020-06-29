Imports System.Data.OleDb

Public Class EditLocalRecordForm
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSteamID.Select()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim i = LocalRecordsForm.DgvLocalRecords.CurrentRow.Index

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DivRPUserRecords.accdb"
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "UPDATE [Table1] SET [SteamID] = '" & Me.TxtSteamID.Text & "',[RP Name] = '" & Me.TxtRPName.Text & "',[Forum Name] = '" & Me.TxtForumName.Text & "',[Nickname] = '" & Me.TxtNickname.Text & "',[Highest Known Position] = '" & Me.CboHighestKnownPosition.Text & "' WHERE [ID] = " & LocalRecordsForm.DgvLocalRecords.Item("ID", i).Value
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

        TxtSteamID.Clear()
        TxtRPName.Clear()
        TxtForumName.Clear()
        TxtNickname.Clear()
        CboHighestKnownPosition.Text = String.Empty

        Me.Close()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtSteamID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSteamID.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            TxtRPName.Select()
        End If
    End Sub

    Private Sub TxtRPName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRPName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            TxtForumName.Select()
        End If
    End Sub

    Private Sub TxtForumName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtForumName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            TxtNickname.Select()
        End If
    End Sub

    Private Sub TxtNickname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNickname.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            CboHighestKnownPosition.Select()
        End If
    End Sub

    Private Sub CboHighestKnownPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboHighestKnownPosition.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnSubmit.PerformClick()
        End If
    End Sub
End Class