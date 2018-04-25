Public Class LessonSelectDialog
    Public Class LessonListItem
        Public ID As Integer
        Public Name As String

        Public Sub New(id As Integer, name As String)
            Me.ID = id
            Me.Name = name
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Name
        End Function
    End Class

    Dim StudentID As Integer

    Public Sub New(studentID As Integer)
        InitializeComponent()

        Me.StudentID = studentID

        UpdateLessonsList()
    End Sub

    Private Sub CancelActionButton_Click(sender As Object, e As EventArgs) Handles CancelActionButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub UpdateLessonsList(Optional nameSearch As String = Nothing)
        LessonsList.Items.Clear()

        Dim lessons As DataRowCollection

        If nameSearch <> Nothing Then
            nameSearch = nameSearch.Trim()
        End If

        If nameSearch = Nothing Or nameSearch = "" Then
            lessons = GetDataTable("SELECT * FROM [Lessons] WHERE [ID] NOT IN
                                        (SELECT [Lesson] FROM [StudentsLessons] WHERE [Student] = " & Me.StudentID & ")").Rows
        Else
            lessons = DB.GetDataTable("SELECT * FROM [Lessons] WHERE [ID] NOT IN
                                        (SELECT [Lesson] FROM [StudentsLessons] WHERE [Student] = " & Me.StudentID & ")
                                        AND Name LIKE '%" & nameSearch & "%'").Rows
        End If

        For Each row As DataRow In lessons
            Dim id = row.Item("ID")
            Dim name = row.Item("Name")
            LessonsList.Items.Add(New LessonListItem(id, name))
        Next
    End Sub

    Public Function SelectedLessonsIDs() As IEnumerable(Of Integer)
        Dim ret = New List(Of Integer)

        For Each item As LessonListItem In LessonsList.SelectedItems
            ret.Add(item.ID)
        Next

        Return ret
    End Function

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        UpdateLessonsList(SearchTextBox.Text)
    End Sub
End Class