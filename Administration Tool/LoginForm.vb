Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class LoginForm

    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        TxtName.Select()
        MainForm.Enabled = False
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        MainForm.Close()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TxtName.Text = String.Empty Then
            MsgBox("Please enter a username.")
        Else
            Dim Answer As DialogResult = MessageBox.Show("You will only be asked for your username once. Are you sure?",
        "Username Confirmation", MessageBoxButtons.YesNo)
            Select Case Answer
                Case vbYes

                    Dim outFile As IO.StreamWriter = IO.File.CreateText("Username.txt")
                    outFile.WriteLine(TxtName.Text.ToString)
                    outFile.Close()

                    Dim connString As String = "Data Source=administration.database.windows.net;Initial Catalog=DivRPUserRecords;Persist Security Info=True;User ID=Ghost;Password='t~9LvV4G$!L)""{R'"
                    myConnection.ConnectionString = connString
                    myConnection.Open()
                    Dim str As String
                    str = "INSERT INTO CurrentUsers([Username],[Online]) VALUES (@Username,1)"
                    Dim cmd As SqlCommand = New SqlCommand(str, myConnection)
                    cmd.Parameters.AddWithValue("@Username", CType(TxtName.Text, String))

                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        myConnection.Close()
                        MainForm.CurrentUsersTableAdapter.Fill(MainForm.DivRPUserRecordsDataSet.CurrentUsers)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    MainForm.Enabled = True
                    Me.Close()

                Case vbNo

                Case Else

            End Select
        End If
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnSubmit.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IO.File.Exists("Username.txt") <> True Then
            MainForm.Close()
        End If
    End Sub
End Class