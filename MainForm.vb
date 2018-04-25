Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateStudents()
        UpdateLessons()
    End Sub

    ' Students Tab
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Using editForm As New NewStudentForm()
            Dim result = editForm.ShowDialog()
            If result <> DialogResult.OK Then
                Return
            End If

            UpdateStudents()
        End Using
    End Sub

    Private Sub StudentsDataView_SelectionChanged(sender As Object, e As EventArgs) Handles StudentsDataView.SelectionChanged
        DeleteButton.Enabled = StudentsDataView.SelectedRows.Count() > 0
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        For Each row As DataGridViewRow In StudentsDataView.SelectedRows
            Dim id As Integer = row.Cells.Item("ID").Value

            Dim isError = DB.ExecuteNonQuery("DELETE * FROM Students WHERE No = " & id) <> True
            If isError Then MessageBox.Show("Error while deleting row")
        Next

        UpdateStudents()
    End Sub

    Private Sub UpdateStudents(Optional filter As String = Nothing)
        If filter <> Nothing Then
            filter = filter.Trim()
        End If

        If filter = Nothing Or filter = "" Then
            StudentsDataView.DataSource = DB.GetDataTable("SELECT * FROM Students")
            Return
        End If

        Dim isNumeric = filter Like "[0-9]+"

        MessageBox.Show("FILTER: " & filter & "\n isNumeric: " & isNumeric)
        If isNumeric Then
            StudentsDataView.DataSource =
                DB.GetDataTable("SELECT * FROM Students WHERE ID=" & filter & " OR No = " & filter)
        Else
            Dim isSearchByLesson = filter.StartsWith("[") And filter.EndsWith("]")
            If isSearchByLesson Then
                Dim lesson = filter.Replace("[", "").Replace("]", "")

                StudentsDataView.DataSource =
                    DB.GetDataTable("SELECT * FROM [Students] WHERE [No] IN
                                        (SELECT [Student] FROM [StudentsLessons] WHERE [Lesson] IN
                                            (SELECT [ID] FROM [Lessons] WHERE [Name] LIKE '%" & lesson & "%'))")
            Else
                StudentsDataView.DataSource =
                    DB.GetDataTable("SELECT * FROM [Students] WHERE [Name] LIKE '%" & filter & "%' OR [Surname] LIKE'%" & filter & "%'")
            End If
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        UpdateStudents(SearchTextBox.Text)
    End Sub

    Private Sub StudentsDataView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDataView.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim id As Integer = StudentsDataView.Rows.Item(e.RowIndex).Cells().Item("No").Value
        Using form As New StudentInfo(id)
            form.ShowDialog()
            UpdateStudents()
        End Using
    End Sub

    ' LESSONS TAB
    Private Sub UpdateLessons(Optional filter As String = Nothing)
        If filter <> Nothing Then
            filter = filter.Trim()
        End If

        If filter = Nothing Or filter = "" Then
            LessonsDataView.DataSource = DB.GetDataTable("SELECT * FROM [Lessons]")
            Return
        End If

        Dim isNumeric = filter Like "[0-9]+"
        If isNumeric Then
            LessonsDataView.DataSource =
                DB.GetDataTable("SELECT * FROM [Lessons] WHERE ID=" & filter)
        Else
            LessonsDataView.DataSource =
                DB.GetDataTable("SELECT * FROM [Lessons] WHERE [Name] LIKE '%" & filter & "%'")
        End If
    End Sub

    Private Sub DeleteLessonButton_Click(sender As Object, e As EventArgs)
        For Each row As DataGridViewRow In LessonsDataView.SelectedRows
            Dim id As Integer = row.Cells.Item("ID").Value

            Dim isError = DB.ExecuteNonQuery("DELETE * FROM [Lessons] WHERE [ID] = " & id) <> True
            If isError Then MessageBox.Show("Error while deleting row")
        Next

        UpdateLessons()
    End Sub

    Private Sub CreateLessonButton_Click(sender As Object, e As EventArgs) Handles CreateLessonButton.Click
        Dim name = NewLessonNameTextBox.Text
        Dim result = DB.ExecuteNonQuery("INSERT INTO Lessons ([Name]) VALUES('" & name & "')")
        NewLessonNameTextBox.Text = ""
        If result <> True Then MessageBox.Show("Error while creating lesson")
        UpdateLessons()
    End Sub

    Private Sub NewLessonNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewLessonNameTextBox.KeyPress
        If NewLessonNameTextBox.Text.Trim = "" Then
            Return
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            CreateLessonButton.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub LessonsDataView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LessonsDataView.CellBeginEdit
        If e.ColumnIndex = 0 Then e.Cancel = True
    End Sub

    Private Sub LessonsDataView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles LessonsDataView.CellEndEdit
        Dim row = LessonsDataView.Rows.Item(e.RowIndex)
        Dim lessonID = row.Cells.Item("ID").Value
        Dim lessonName = row.Cells.Item("Name").Value

        Dim result = DB.ExecuteNonQuery("UPDATE [Lessons] SET [Name] = '" & lessonName & "' WHERE [ID] = " & lessonID)
    End Sub

    Private Sub LessonsDataView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles LessonsDataView.UserDeletingRow
        e.Cancel = (MessageBox.Show("Are you sure?", "Deleting", MessageBoxButtons.YesNo) <> DialogResult.Yes)
        If e.Cancel = False Then
            Dim lessonID = e.Row.Cells.Item("ID").Value
            DB.ExecuteNonQuery("DELETE * FROM [Lessons] WHERE ID = " & lessonID)
        End If
    End Sub

    Private Sub LessonsSearchButton_Click(sender As Object, e As EventArgs) Handles LessonsSearchButton.Click
        UpdateLessons(LessonsSearchBox.Text)
    End Sub

    Private Sub LessonsDataView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LessonsDataView.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim lessonName = LessonsDataView.Rows.Item(e.RowIndex).Cells.Item("Name").Value
        Tabs.SelectTab(StudentsTab)
        SearchTextBox.Text = "[" & lessonName & "]"
        SearchButton.PerformClick()
    End Sub

    ' Other
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        My.Settings.IsRemember = False

        LoginForm.Show()
        Me.Close()
    End Sub
End Class