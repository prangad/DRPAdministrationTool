Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class GlobalPlayerRecordsForm

    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection

    Private Sub GlobalPlayerRecordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DivRPUserRecordsDataSet.GlobalRecords' table. You can move, or remove it, as needed.
        Me.GlobalRecordsTableAdapter.Fill(Me.DivRPUserRecordsDataSet.GlobalRecords)
        Me.DgvGlobalUserRecords.DefaultCellStyle.ForeColor = Color.Black
        If IsNothing(DgvGlobalUserRecords.CurrentRow) = False Then
            Me.DgvGlobalUserRecords.CurrentRow.Selected = True
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        NewGlobalRecordForm.Show()
    End Sub

    Private Sub DgvGlobalUserRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvGlobalUserRecords.CellClick
        Dim i = DgvGlobalUserRecords.CurrentRow
        i.Selected = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If IsNothing(DgvGlobalUserRecords.CurrentRow) Or DgvGlobalUserRecords.CurrentRow.Index < 0 Then

            MsgBox("Please select the record you would like to delete.")

        Else

            If MsgBox("This will permanently delete the record. Are you sure?", vbYesNo) = vbNo Then



            Else

                Dim i As Integer = DgvGlobalUserRecords.CurrentRow.Index

                Dim connString As String = "Data Source=administration.database.windows.net;Initial Catalog=DivRPUserRecords;Persist Security Info=True;User ID=Ghost;Password='t~9LvV4G$!L)""{R'"
                myConnection.ConnectionString = connString
                myConnection.Open()
                Dim str As String
                str = "DELETE FROM GlobalRecords WHERE ID=" & DgvGlobalUserRecords.Item("ID", i).Value
                Dim cmd As SqlCommand = New SqlCommand(str, myConnection)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Me.GlobalRecordsTableAdapter.Fill(Me.DivRPUserRecordsDataSet.GlobalRecords)
                    If IsNothing(DgvGlobalUserRecords.CurrentRow) = False Then
                        Me.DgvGlobalUserRecords.CurrentRow.Selected = True
                    End If
                    myConnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If IsNothing(Me.DgvGlobalUserRecords.CurrentRow) Then
            MsgBox("Please select the record you would like to edit.")
        Else
            EditGlobalRecordForm.Show()
        End If
    End Sub

    Private Sub BtnNotes_Click(sender As Object, e As EventArgs) Handles BtnNotes.Click
        If IsNothing(Me.DgvGlobalUserRecords.CurrentRow) Then
            MsgBox("Please select the record you would like to view.")
        Else
            GlobalRecordNotesForm.Show()
        End If
    End Sub

    Private Sub TxtSearchbar_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchbar.TextChanged
        Dim search As String = TxtSearchbar.Text

        If search.Contains("STEAM_") Then

            UserRecordsBindingSource.Filter = String.Format("SteamID LIKE '%{0}%'", TxtSearchbar.Text)

        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim search As String = TxtSearchbar.Text

        If search.Contains("STEAM_") Then

            UserRecordsBindingSource.Filter = String.Format("SteamID LIKE '%{0}%'", TxtSearchbar.Text)
        Else
            MsgBox("Please use SteamID format.")
        End If
    End Sub

    Private Sub TxtSearchbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearchbar.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnSearch.PerformClick()
        End If
    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        Dim i As Integer = Me.DgvGlobalUserRecords.CurrentRow.Index
        Dim URL = Me.DgvGlobalUserRecords.Item("Profile", i).Value.ToString
        If IsNothing(i) Then
            MsgBox("Please select the record you would like to view the profile for.")
        Else
            If URL = String.Empty Then
                MsgBox("This record does not have a profile linked.")
            Else
                Process.Start(URL)
            End If
        End If
    End Sub
End Class
