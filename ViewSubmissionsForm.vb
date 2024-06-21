Imports WinFormsApp1.ApiClient

Public Class ViewSubmissionsForm

    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview to true to capture keystrokes
        Me.KeyPreview = True
        ' Call the backend API to fetch all submissions
        submissions = Await ApiClient.ReadAllAsync()

        ' Display the first submission
        If submissions.Count > 0 Then
            DisplaySubmission(submissions(0))
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If currentIndex < 0 OrElse currentIndex >= submissions.Count Then
            MessageBox.Show("No submission selected for editing.")
            Return
        End If

        Dim submission = submissions(currentIndex)
        submission.Name = txtName.Text
        submission.Email = txtEmail.Text
        submission.Phone = txtPhone.Text
        submission.GitHubLink = txtGitHubLink.Text
        submission.StopwatchTime = txtStopWatchTime.Text

        UpdateSubmission(currentIndex, submission)
    End Sub

    Private Async Sub UpdateSubmission(index As Integer, submission As Submission)
        Try
            Dim success = Await ApiClient.UpdateAsync(index, submission)
            If success Then
                MessageBox.Show("Submission updated successfully!")
            Else
                MessageBox.Show("Error updating submission.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error updating submission: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentIndex < 0 OrElse currentIndex >= submissions.Count Then
            MessageBox.Show("No submission selected for deletion.")
            Return
        End If

        DeleteSubmission(currentIndex)
    End Sub

    Private Async Sub DeleteSubmission(index As Integer)
        Try
            Dim success = Await ApiClient.DeleteAsync(index)
            If success Then
                MessageBox.Show("Submission deleted successfully!")
                submissions.RemoveAt(index)
                If submissions.Count > 0 Then
                    currentIndex = Math.Min(currentIndex, submissions.Count - 1)
                    DisplaySubmission(submissions(currentIndex))
                Else
                    ClearSubmissionDisplay()
                End If
            Else
                MessageBox.Show("Error deleting submission.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error deleting submission: {ex.Message}")
        End Try
    End Sub

    Private Sub ClearSubmissionDisplay()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGitHubLink.Clear()
        txtStopWatchTime.Clear()
    End Sub

    Private Sub DisplaySubmission(submission As Submission)
        ' Update the UI with the submission details
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGitHubLink.Text = submission.GitHubLink
        txtStopWatchTime.Text = submission.StopwatchTime
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.U Then
            btnEdit_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete_Click(sender, e)
        End If
    End Sub

End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class
