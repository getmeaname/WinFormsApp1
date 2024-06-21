Imports WinFormsApp1.ApiClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form handles key events
        Me.KeyPreview = True
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionsForm()
        createSubmissionForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission_Click(sender, e)
        End If
    End Sub

End Class
