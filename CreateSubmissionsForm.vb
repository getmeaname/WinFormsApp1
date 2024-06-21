Imports WinFormsApp1.ApiClient

Public Class CreateSubmissionsForm
    Private stopwatchTimer As Timer
    Private stopwatchTime As TimeSpan
    Private stopwatchRunning As Boolean

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatchTimer = New Timer()
        stopwatchTimer.Interval = 1000 ' 1 second
        AddHandler stopwatchTimer.Tick, AddressOf StopwatchTick

        ' Ensure the form handles key events
        Me.KeyPreview = True
    End Sub

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatchRunning Then
            stopwatchTimer.Stop()
            btnStartStopwatch.Text = "Start Stopwatch"
        Else
            stopwatchTimer.Start()
            btnStartStopwatch.Text = "Pause Stopwatch"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub StopwatchTick(sender As Object, e As EventArgs)
        stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
        lblStopwatchTime.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Prepare the submission data
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHubLink.Text,
            .StopwatchTime = stopwatchTime.ToString("hh\:mm\:ss")
        }

        ' Call the backend API to submit the form
        SubmitForm(submission)

        ' Clear the form fields
        ClearForm()
    End Sub

    Private Async Sub SubmitForm(submission As Submission)
        Try
            Dim success = Await ApiClient.SubmitAsync(submission)
            If success Then
                MessageBox.Show("Submission successful!")
                ClearForm()
            Else
                MessageBox.Show("Error submitting the form.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error submitting the form: {ex.Message}")
        End Try
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGitHubLink.Clear()
        lblStopwatchTime.Text = "00:00:00"
        stopwatchTime = TimeSpan.Zero
        stopwatchRunning = False
        btnStartStopwatch.Text = "Start Stopwatch"
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        End If
    End Sub

End Class
