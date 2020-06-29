Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class EditGlobalRecordForm

    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection

    Private Sub NewGlobalRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow.Index

        TxtSteamID.Text = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("SteamID", i).Value, String)
        TxtRPName.Text = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("RPName", i).Value, String)
        TxtForumName.Text = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("ForumName", i).Value, String)
        TxtNickname.Text = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("Nickname", i).Value, String)
        CboHighestKnownPosition.Text = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("HighestKnownPosition", i).Value, String)
        TxtProfile.Text = CType(GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("Profile", i).Value, String)
        TxtSteamID.Select()

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TxtSteamID.Text() = String.Empty Then
            MsgBox("The SteamID field may not be empty.")
        Else
            If TxtProfile.Text.Contains("https://thedivinityrp.net/forum/member") Or TxtProfile.Text = String.Empty Then
                Dim i As Integer = GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow.Index

                Dim connString As String = "Data Source=administration.database.windows.net;Initial Catalog=DivRPUserRecords;Persist Security Info=True;User ID=Ghost;Password='t~9LvV4G$!L)""{R'"
                myConnection.ConnectionString = connString
                myConnection.Open()
                Dim str As String
                str = "UPDATE GlobalRecords SET [SteamID] = @SteamID, [RP Name] = @RPName, [Forum Name] = @ForumName, [Nickname] = @Nickname, [Highest Known Position] = @HighestKnownPosition, [Profile] = @Profile WHERE ID=" & GlobalPlayerRecordsForm.DgvGlobalUserRecords.Item("ID", i).Value
                Dim cmd As SqlCommand = New SqlCommand(str, myConnection)
                cmd.Parameters.AddWithValue("@SteamID", CType(TxtSteamID.Text, String))
                cmd.Parameters.AddWithValue("@RPName", CType(TxtRPName.Text, String))
                cmd.Parameters.AddWithValue("@ForumName", CType(TxtForumName.Text, String))
                cmd.Parameters.AddWithValue("@Nickname", CType(TxtNickname.Text, String))
                cmd.Parameters.AddWithValue("@HighestKnownPosition", CType(CboHighestKnownPosition.Text, String))
                cmd.Parameters.AddWithValue("@Profile", CType(TxtProfile.Text, String))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    TxtSteamID.Clear()
                    TxtRPName.Clear()
                    TxtForumName.Clear()
                    TxtNickname.Clear()
                    GlobalPlayerRecordsForm.GlobalRecordsTableAdapter.Fill(GlobalPlayerRecordsForm.DivRPUserRecordsDataSet.GlobalRecords)
                    If IsNothing(GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow) = False Then
                        GlobalPlayerRecordsForm.DgvGlobalUserRecords.CurrentRow.Selected = True
                    End If
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("A valid forum profile URL must be used.")
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    '*******************************************************************************************************************************************
    'ENTER ORDER
    '*******************************************************************************************************************************************

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
    '*******************************************************************************************************************************************
End Class