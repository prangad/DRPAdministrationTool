Imports System.ComponentModel

Public Class TempNotesForm
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtAdd.Select()
        Me.Location = New Point(MainForm.Location.X + MainForm.Width, MainForm.Location.Y)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If LstNotes.SelectedIndex = -1 Then
            MsgBox("Please select the note you would like to edit.")
        Else
            EditNoteForm.Show()
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtAdd.Text = "" Then
            MsgBox("Please type the note you would like to add.")
        Else
            LstNotes.Items.Add("[" + TimeString + "] " + TxtAdd.Text)
            TxtAdd.Text = String.Empty
        End If
    End Sub

    Private Sub TxtAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAdd.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            BtnAdd.PerformClick()
            TxtAdd.Text = String.Empty
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If LstNotes.SelectedIndex <= -1 Then
            MsgBox("Please select the note you would like to remove.")
        Else
            LstNotes.Items.RemoveAt(LstNotes.SelectedIndex)
        End If
    End Sub

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles BtnClearAll.Click
        If MsgBox("This will clear all current notes. Are you sure?", vbYesNo) = vbYes Then
            LstNotes.Items.Clear()
        Else
        End If
    End Sub

    Private Sub TempNotesForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class