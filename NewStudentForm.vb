Public Class NewStudentForm
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim n = NameTextBox.Text
        Dim s = SurnameTextBox.Text
        Dim no = NoTextBox.Text

        Dim isSuccess =
            DB.ExecuteNonQuery("INSERT INTO Students ([No], [Name], [Surname]) VALUES(" & no & ", '" & n & "','" & s & "')")

        If isSuccess Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub CancelActionButton_Click(sender As Object, e As EventArgs) Handles CancelActionButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress
        e.Handled = BlockKey(e.KeyChar)
    End Sub

    Private Sub SurnameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SurnameTextBox.KeyPress
        e.Handled = BlockKey(e.KeyChar)
    End Sub

    Private Sub NoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NoTextBox.KeyPress
        e.Handled = BlockKey(e.KeyChar, True)
    End Sub

    Private Function BlockKey(key As Char, Optional numberRequired As Boolean = False) As Boolean
        Return key <> ChrW(Keys.Back) And
            ((numberRequired And Not Char.IsNumber(key)) Or
            (Not numberRequired And Char.IsNumber(key)))
    End Function
End Class