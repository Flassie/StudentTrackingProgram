Public Class StudentInfo
    Private ID As Integer

    Public Sub New(id As Integer)
        InitializeComponent()
        Me.ID = id

        UpdateValues()
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

    Private Sub UpdateValues()
        Dim result = DB.GetDataTable("SELECT * FROM Students WHERE [No] = " & Me.ID)
        Dim rows = result.Rows
        Dim row = rows.Item(0)

        NameTextBox.Text = row.Item("Name")
        SurnameTextBox.Text = row.Item("Surname")
        NoTextBox.Text = row.Item("No")

        LessonsDataView.DataSource =
            DB.GetDataTable("SELECT Lessons.ID, Lessons.Name, Marks.First, Marks.Second, Marks.Final FROM Marks 
            RIGHT JOIN Lessons ON Lessons.ID = Marks.Lesson_ID 
            WHERE Lessons.ID IN (SELECT Lesson FROM StudentsLessons WHERE Student = " & Me.ID & ") AND Marks.Student_ID = " & Me.ID)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateValues()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim result = DB.ExecuteNonQuery("UPDATE Students SET [No] = " & NoTextBox.Text & ", [Name] = '" & NameTextBox.Text & "', [Surname] = '" & SurnameTextBox.Text & "' WHERE [No] = " & ID)
        If result = True Then
            Me.ID = Integer.Parse(NoTextBox.Text)
            MessageBox.Show("Saved")
        End If
    End Sub

    Private Sub AddLessonButton_Click(sender As Object, e As EventArgs) Handles AddLessonButton.Click
        Using form = New LessonSelectDialog(Me.ID)
            Dim isUpdate = (form.ShowDialog() = DialogResult.OK)
            If isUpdate Then
                Dim newLessons = form.SelectedLessonsIDs()

                For Each lesson As Integer In newLessons
                    DB.ExecuteNonQuery("INSERT INTO StudentsLessons (Student, Lesson) VALUES (" & Me.ID & "," & lesson & ")")
                    DB.ExecuteNonQuery("INSERT INTO [Marks] ([Student_ID], [Lesson_ID], [First], [Second], [Final]) VALUES (" & Me.ID & ", " & lesson & ", 0, 0, 0)")
                Next

                UpdateValues()
            End If
        End Using
    End Sub

    Private Sub LessonsDataView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles LessonsDataView.UserDeletingRow
        Dim lessonID As Integer = e.Row.Cells.Item("ID").Value
        DB.ExecuteNonQuery("DELETE * FROM StudentsLessons WHERE Lesson = " & lessonID)
        DB.ExecuteNonQuery("DELETE * FROM [Marks] WHERE [Lesson_ID] = " & lessonID & " AND [Student_ID] = " & Me.ID)
    End Sub

    Private Sub LessonsDataView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles LessonsDataView.CellEndEdit
        Dim row = LessonsDataView.Rows.Item(e.RowIndex)
        Dim id = row.Cells.Item("ID").Value
        Dim first As String = row.Cells.Item("First").Value.ToString()
        Dim second As String = row.Cells.Item("Second").Value.ToString()

        If String.IsNullOrEmpty(first) Then
            row.Cells.Item("First").Value = "0"
            first = 0
        End If

        If String.IsNullOrEmpty(second) Then
            row.Cells.Item("Second").Value = "0"
            second = 0
        End If

        first = Integer.Parse(first)
        second = Integer.Parse(second)

        Dim final As Integer = first * 0.4 + second * 0.6

        row.Cells.Item("Final").Value = final

        DB.ExecuteNonQuery("UPDATE [Marks] SET [First] = " & first & ", [Second] = " & second & ", [Final] = " & final & " WHERE Student_ID = " & Me.ID & " AND Lesson_ID = " & id)
    End Sub

    Private Sub LessonsDataView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LessonsDataView.CellBeginEdit
        e.Cancel = e.ColumnIndex < 2 Or LessonsDataView.ColumnCount - 1 = e.ColumnIndex
    End Sub

    Private Sub LessonsDataView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles LessonsDataView.CellValidating
        If e.ColumnIndex < 2 Or LessonsDataView.ColumnCount - 1 = e.ColumnIndex Then Return

        Dim value = e.FormattedValue.ToString()
        Dim result As Integer
        If Not Integer.TryParse(value, result) Then
            LessonsDataView.Rows.Item(e.RowIndex).ErrorText = "Value should be integer"
            e.Cancel = True
        ElseIf result < 0 Or result > 100 Then
            LessonsDataView.Rows.Item(e.RowIndex).ErrorText = "Value should be bigger or equal than 0 and less or equal than 100"
            e.Cancel = True
        End If
    End Sub
End Class