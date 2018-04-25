Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Fixed3D

        loginTextBox.Text = My.Settings.LastUser

        If My.Settings.IsRemember Then
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim login = loginTextBox.Text.ToLower()
        Dim password = loginTextBox.Text

        Dim isAccountFound = DB.RowsCount("SELECT * FROM Accounts WHERE Login = '" & login & "' AND Password = '" & password & "'") <> 0

        If isAccountFound <> True Then
            MessageBox.Show("Login or password is wrong")
            Return
        End If

        My.Settings.IsRemember = RememberCheckBox.Checked
        My.Settings.LastUser = login

        MainForm.Show()
        Me.Close()
    End Sub
End Class
