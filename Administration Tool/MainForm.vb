Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class MainForm

    '************************************************************************************************************************
    ' WaitForPageLoad Function
    '************************************************************************************************************************

    Private Property Pageready As Boolean = False

#Region "Page Loading Functions"

    Private Sub WaitForPageLoad()
        AddHandler BrowserForm.Browser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not Pageready
            Application.DoEvents()
        End While
        Pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If BrowserForm.Browser.ReadyState = WebBrowserReadyState.Complete Then
            Pageready = True
            RemoveHandler BrowserForm.Browser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

#End Region

    '************************************************************************************************************************

    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CurrentUsersTableAdapter.Fill(Me.DivRPUserRecordsDataSet.CurrentUsers)

        If IO.File.Exists("Username.txt") Then
            Dim inFile As IO.StreamReader = IO.File.OpenText("Username.txt")

            'Dim connString As String = "Data Source=administration.database.windows.net;Initial Catalog=DivRPUserRecords;Persist Security Info=True;User ID=Ghost;Password='t~9LvV4G$!L)""{R'"
            'myConnection.ConnectionString = connString
            'myConnection.Open()
            'Dim str As String
            'str = "UPDATE CurrentUsers SET Online = '1' WHERE Username = '" & inFile.ReadLine & "'"
            'Dim cmd As SqlCommand = New SqlCommand(str, myConnection)

            'Try
            '    cmd.ExecuteNonQuery()
            '    cmd.Dispose()
            '    myConnection.Close()
            '    Me.CurrentUsersTableAdapter.Fill(Me.DivRPUserRecordsDataSet.CurrentUsers)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            LblWelcomeBack.Text = "Welcome back, " & inFile.ReadLine & "."

        Else
            LoginForm.Show()
            Me.Hide()
        End If
    End Sub

    '************************************************************************************************************************
    ' BUTTON LINKS
    '************************************************************************************************************************

    Private Sub BtnForums_Click(sender As Object, e As EventArgs) Handles BtnForums.Click
        Process.Start("http://thedivinityrp.net/")
    End Sub

    Private Sub BtnBans_Click(sender As Object, e As EventArgs) Handles BtnBans.Click
        Process.Start("https://thedivinityrp.net/forum/bans.php")
    End Sub

    Private Sub BtnStaffActivity_Click(sender As Object, e As EventArgs) Handles BtnStaffActivity.Click
        Process.Start("https://thedivinityrp.net/forum/getadmins.php")
    End Sub

    Private Sub BtnAlts_Click(sender As Object, e As EventArgs) Handles BtnAlts.Click
        Process.Start("http://thedivinityrp.net/forum/alts.php")
    End Sub

    Private Sub BtnTextFaces_Click(sender As Object, e As EventArgs) Handles BtnTextFaces.Click
        Process.Start("https://textfac.es/")
    End Sub

    Private Sub Btn420_Click(sender As Object, e As EventArgs) Handles Btn420.Click
        Process.Start("http://420.moe/")
    End Sub

    Private Sub BtnVaporwave_Click(sender As Object, e As EventArgs) Handles BtnVaporwave.Click
        Process.Start("https://eeemo.net/")
    End Sub

    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaff.Click
        Process.Start("https://thedivinityrp.net/forum/staff.php")
    End Sub

    Private Sub BtnHandbook_Click(sender As Object, e As EventArgs) Handles BtnHandbook.Click
        Process.Start("https://thedivinityrp.net/forum/showthread.php?tid=397")
    End Sub
    '************************************************************************************************************************

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IO.File.Exists("Username.txt") Then
            Dim inFile As IO.StreamReader = IO.File.OpenText("Username.txt")

            Dim connString As String = "Data Source=administration.database.windows.net;Initial Catalog=DivRPUserRecords;Persist Security Info=True;User ID=Ghost;Password='t~9LvV4G$!L)""{R'"
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim str As String
            str = "UPDATE CurrentUsers SET Online = '0' WHERE Username = '" & inFile.ReadLine & "'"
            Dim cmd As SqlCommand = New SqlCommand(str, myConnection)

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                Me.CurrentUsersTableAdapter.Fill(Me.DivRPUserRecordsDataSet.CurrentUsers)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If
    End Sub

    Private Sub BtnGlobalRecords_Click(sender As Object, e As EventArgs) Handles BtnGlobalRecords.Click
        GlobalPlayerRecordsForm.Show()
    End Sub

    Private Sub BtnNotes_Click(sender As Object, e As EventArgs) Handles BtnNotes.Click
        TempNotesForm.Show()
    End Sub

    Private Sub BtnUserRecords_Click(sender As Object, e As EventArgs) Handles BtnUserRecords.Click
        LocalRecordsForm.Show()
    End Sub

    '************************************************************************************************************************
    ' Search buttons
    '************************************************************************************************************************

    Private Sub BtnSteamRepSearch_Click(sender As Object, e As EventArgs) Handles BtnSteamRepSearch.Click
        Dim text As String = TxtSteamRep.Text
        If text.Contains("STEAM_") Then
            BrowserForm.Browser.Navigate("http://steamrep.com/")
            WaitForPageLoad()
            BrowserForm.Browser.Document.GetElementById("findid").InnerText = text
            Dim allelements As HtmlElementCollection = BrowserForm.Browser.Document.All
            For Each webpageelement As HtmlElement In allelements
                If webpageelement.GetAttribute("value") = "Search" Then
                    webpageelement.InvokeMember("click")
                End If
            Next
            WaitForPageLoad()
            Dim strUrl As String
            strUrl = BrowserForm.Browser.Url.ToString()
            Process.Start(strUrl)
        Else
            MsgBox("Please use SteamID format.")
        End If
        TxtSteamRep.Text = String.Empty
    End Sub

    Private Sub BtnGoogleSearch_Click(sender As Object, e As EventArgs) Handles BtnGoogleSearch.Click
        Dim text As String = TxtGoogle.Text

        If text.Contains("STEAM_") Then

            Process.Start("https://www.google.com/#q=" & text)

        Else

            MsgBox("Please use SteamID format.")

        End If

        TxtGoogle.Text = String.Empty
    End Sub

    Private Sub BtnForumsSearch_Click(sender As Object, e As EventArgs) Handles BtnForumsSearch.Click
        BrowserForm.Browser.Navigate("http://thedivinityrp.net/forum/search.php")
        WaitForPageLoad()
        Dim allelements As HtmlElementCollection = BrowserForm.Browser.Document.All
        For Each webpageelement As HtmlElement In allelements
            If webpageelement.GetAttribute("name") = "keywords" Then
                webpageelement.InnerText = TxtForums.Text
            End If
            If webpageelement.GetAttribute("name") = "submit" Then
                webpageelement.InvokeMember("click")
            End If
        Next
        WaitForPageLoad()
        Dim strUrl As String
        strUrl = BrowserForm.Browser.Url.ToString()
        If strUrl = "https://thedivinityrp.net/forum/search.php" Then
            MsgBox("Your search parameters did not find any results on the forums.")
        ElseIf strUrl = "http://thedivinityrp.net/forum/search.php" Then
            MsgBox("Your search parameters did not find any results on the forums.")
        Else
            Process.Start(strUrl)
        End If
        TxtForums.Text = String.Empty
    End Sub

    Private Sub BtnAltsSearch_Click(sender As Object, e As EventArgs) Handles BtnAltsSearch.Click
        Dim text As String = TxtAlts.Text

        If text.Contains("STEAM_") Then
            Process.Start("http://thedivinityrp.net/forum/alts.php?filter=" & text)
        Else
            MsgBox("Please use SteamID format.")
        End If

        TxtAlts.Text = String.Empty
    End Sub

    Private Sub BtnBansSearch_Click(sender As Object, e As EventArgs) Handles BtnBansSearch.Click
        Dim text As String = TxtBans.Text
        Process.Start("http://thedivinityrp.net/forum/bans.php?search=" & text & "&type=1")
        TxtBans.Text = String.Empty
    End Sub

    Private Sub BtnAPISearch_Click(sender As Object, e As EventArgs) Handles BtnAPISearch.Click
        PlayerAPIForm.Close()
        PlayerAPIForm.Show()
    End Sub

    '************************************************************************************************************************

    '************************************************************************************************************************
    ' Enter in Textboxes
    '************************************************************************************************************************

    Private Sub TxtSteamRep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSteamRep.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnSteamRepSearch.PerformClick()
        End If
    End Sub

    Private Sub TxtGoogleSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGoogle.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGoogleSearch.PerformClick()
        End If
    End Sub

    Private Sub TxtForumsSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtForums.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnForumsSearch.PerformClick()
        End If
    End Sub

    Private Sub TxtAltsSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlts.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnAltsSearch.PerformClick()
        End If
    End Sub

    Private Sub TxtBansSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBans.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnBansSearch.PerformClick()
        End If
    End Sub

    Private Sub TxtAPI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAPI.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnAPISearch.PerformClick()
        End If
    End Sub
    '************************************************************************************************************************
End Class