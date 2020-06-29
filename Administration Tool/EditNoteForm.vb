Public Class EditNoteForm
    Private Sub EditNoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEdit.Text = TempNotesForm.LstNotes.SelectedItem.ToString.Remove(0, 11)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim index As Integer = TempNotesForm.LstNotes.SelectedIndex

        TempNotesForm.LstNotes.Items.RemoveAt(index)
        TempNotesForm.LstNotes.Items.Insert(index, "[" & TimeString & "]* " & TxtEdit.Text)
        TxtEdit.Text = String.Empty
        Me.Close()
    End Sub
    Private Sub TxtEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BtnConfirm.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class