Imports System.Data.OleDb

Public Class NewLocalRecordForm
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSteamID.Select()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DivRPUserRecords.accdb"
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into Table1([SteamID],[RP Name],[Forum Name],[Nickname],[Highest Known Position]) Values (?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("SteamID", CType(TxtSteamID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("RP Name", CType(TxtRPName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Forum Name", CType(TxtForumName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Nickname", CType(TxtNickname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Highest Known Position", CType(CboHighestKnownPosition.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TxtSteamID.Clear()
            TxtRPName.Clear()
            TxtForumName.Clear()
            TxtNickname.Clear()
            CboHighestKnownPosition.Text = String.Empty
            LocalRecordsForm.Table1TableAdapter.Fill(LocalRecordsForm.DivRPUserRecordsDataSet1.Table1)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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