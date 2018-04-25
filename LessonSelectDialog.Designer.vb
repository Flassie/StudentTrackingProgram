<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LessonSelectDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CancelActionButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.LessonsList = New System.Windows.Forms.ListBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelActionButton
        '
        Me.CancelActionButton.Location = New System.Drawing.Point(13, 354)
        Me.CancelActionButton.Name = "CancelActionButton"
        Me.CancelActionButton.Size = New System.Drawing.Size(372, 23)
        Me.CancelActionButton.TabIndex = 1
        Me.CancelActionButton.Text = "Cancel"
        Me.CancelActionButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(13, 384)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(372, 23)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'LessonsList
        '
        Me.LessonsList.FormattingEnabled = True
        Me.LessonsList.Location = New System.Drawing.Point(13, 39)
        Me.LessonsList.Name = "LessonsList"
        Me.LessonsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LessonsList.Size = New System.Drawing.Size(372, 303)
        Me.LessonsList.TabIndex = 3
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(62, 12)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(323, 20)
        Me.SearchTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search:"
        '
        'LessonSelectDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.LessonsList)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.CancelActionButton)
        Me.Name = "LessonSelectDialog"
        Me.Text = "LessonSelectDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelActionButton As Button
    Friend WithEvents OkButton As Button
    Friend WithEvents LessonsList As ListBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
