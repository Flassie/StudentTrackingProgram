<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.StudentsTab = New System.Windows.Forms.TabPage()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.StudentsDataView = New System.Windows.Forms.DataGridView()
        Me.LessonsTab = New System.Windows.Forms.TabPage()
        Me.NewLessonNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreateLessonButton = New System.Windows.Forms.Button()
        Me.LessonsSearchButton = New System.Windows.Forms.Button()
        Me.LessonsSearchBox = New System.Windows.Forms.TextBox()
        Me.LessonsDataView = New System.Windows.Forms.DataGridView()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Tabs.SuspendLayout()
        Me.StudentsTab.SuspendLayout()
        CType(Me.StudentsDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LessonsTab.SuspendLayout()
        CType(Me.LessonsDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.Controls.Add(Me.StudentsTab)
        Me.Tabs.Controls.Add(Me.LessonsTab)
        Me.Tabs.Location = New System.Drawing.Point(13, 41)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(777, 532)
        Me.Tabs.TabIndex = 0
        '
        'StudentsTab
        '
        Me.StudentsTab.Controls.Add(Me.DeleteButton)
        Me.StudentsTab.Controls.Add(Me.CreateButton)
        Me.StudentsTab.Controls.Add(Me.SearchButton)
        Me.StudentsTab.Controls.Add(Me.SearchTextBox)
        Me.StudentsTab.Controls.Add(Me.StudentsDataView)
        Me.StudentsTab.Location = New System.Drawing.Point(4, 22)
        Me.StudentsTab.Name = "StudentsTab"
        Me.StudentsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StudentsTab.Size = New System.Drawing.Size(769, 506)
        Me.StudentsTab.TabIndex = 0
        Me.StudentsTab.Text = "Students"
        Me.StudentsTab.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(3, 6)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(158, 23)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CreateButton
        '
        Me.CreateButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateButton.Location = New System.Drawing.Point(167, 6)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(599, 23)
        Me.CreateButton.TabIndex = 4
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton.Location = New System.Drawing.Point(666, 478)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 23)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.Location = New System.Drawing.Point(3, 480)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(657, 20)
        Me.SearchTextBox.TabIndex = 2
        '
        'StudentsDataView
        '
        Me.StudentsDataView.AllowUserToAddRows = False
        Me.StudentsDataView.AllowUserToDeleteRows = False
        Me.StudentsDataView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.StudentsDataView.Location = New System.Drawing.Point(3, 34)
        Me.StudentsDataView.Name = "StudentsDataView"
        Me.StudentsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentsDataView.Size = New System.Drawing.Size(763, 438)
        Me.StudentsDataView.TabIndex = 0
        '
        'LessonsTab
        '
        Me.LessonsTab.Controls.Add(Me.NewLessonNameTextBox)
        Me.LessonsTab.Controls.Add(Me.Label1)
        Me.LessonsTab.Controls.Add(Me.CreateLessonButton)
        Me.LessonsTab.Controls.Add(Me.LessonsSearchButton)
        Me.LessonsTab.Controls.Add(Me.LessonsSearchBox)
        Me.LessonsTab.Controls.Add(Me.LessonsDataView)
        Me.LessonsTab.Location = New System.Drawing.Point(4, 22)
        Me.LessonsTab.Name = "LessonsTab"
        Me.LessonsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LessonsTab.Size = New System.Drawing.Size(769, 506)
        Me.LessonsTab.TabIndex = 1
        Me.LessonsTab.Text = "Lessons"
        Me.LessonsTab.UseVisualStyleBackColor = True
        '
        'NewLessonNameTextBox
        '
        Me.NewLessonNameTextBox.Location = New System.Drawing.Point(88, 7)
        Me.NewLessonNameTextBox.Name = "NewLessonNameTextBox"
        Me.NewLessonNameTextBox.Size = New System.Drawing.Size(423, 20)
        Me.NewLessonNameTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Lesson Name:"
        '
        'CreateLessonButton
        '
        Me.CreateLessonButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateLessonButton.Location = New System.Drawing.Point(517, 5)
        Me.CreateLessonButton.Name = "CreateLessonButton"
        Me.CreateLessonButton.Size = New System.Drawing.Size(249, 23)
        Me.CreateLessonButton.TabIndex = 9
        Me.CreateLessonButton.Text = "Add"
        Me.CreateLessonButton.UseVisualStyleBackColor = True
        '
        'LessonsSearchButton
        '
        Me.LessonsSearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LessonsSearchButton.Location = New System.Drawing.Point(666, 505)
        Me.LessonsSearchButton.Name = "LessonsSearchButton"
        Me.LessonsSearchButton.Size = New System.Drawing.Size(100, 23)
        Me.LessonsSearchButton.TabIndex = 8
        Me.LessonsSearchButton.Text = "Search"
        Me.LessonsSearchButton.UseVisualStyleBackColor = True
        '
        'LessonsSearchBox
        '
        Me.LessonsSearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LessonsSearchBox.Location = New System.Drawing.Point(3, 507)
        Me.LessonsSearchBox.Name = "LessonsSearchBox"
        Me.LessonsSearchBox.Size = New System.Drawing.Size(657, 20)
        Me.LessonsSearchBox.TabIndex = 7
        '
        'LessonsDataView
        '
        Me.LessonsDataView.AllowUserToAddRows = False
        Me.LessonsDataView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LessonsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LessonsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LessonsDataView.Location = New System.Drawing.Point(3, 33)
        Me.LessonsDataView.Name = "LessonsDataView"
        Me.LessonsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LessonsDataView.Size = New System.Drawing.Size(763, 466)
        Me.LessonsDataView.TabIndex = 6
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(715, 12)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 1
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 585)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.Tabs)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.Tabs.ResumeLayout(False)
        Me.StudentsTab.ResumeLayout(False)
        Me.StudentsTab.PerformLayout()
        CType(Me.StudentsDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LessonsTab.ResumeLayout(False)
        Me.LessonsTab.PerformLayout()
        CType(Me.LessonsDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents StudentsTab As TabPage
    Friend WithEvents LessonsTab As TabPage
    Friend WithEvents StudentsDataView As DataGridView
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CreateLessonButton As Button
    Friend WithEvents LessonsSearchButton As Button
    Friend WithEvents LessonsSearchBox As TextBox
    Friend WithEvents LessonsDataView As DataGridView
    Friend WithEvents NewLessonNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutButton As Button
End Class
