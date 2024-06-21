Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ApiClient
    Private Shared ReadOnly httpClient As HttpClient = New HttpClient()
    Private Const BaseUrl As String = "http://localhost:3000"

    Public Shared Async Function PingAsync() As Task(Of Boolean)
        Dim response = Await httpClient.GetAsync($"{BaseUrl}/ping")
        Return response.IsSuccessStatusCode
    End Function

    Public Shared Async Function SubmitAsync(submission As Submission) As Task(Of Boolean)
        Dim content = New FormUrlEncodedContent(New Dictionary(Of String, String) From {
            {"name", submission.Name},
            {"email", submission.Email},
            {"phone", submission.Phone},
            {"githubLink", submission.GitHubLink},
            {"stopwatchTime", submission.StopwatchTime}
        })

        Dim response = Await httpClient.PostAsync($"{BaseUrl}/submit", content)
        Return response.IsSuccessStatusCode
    End Function

    Public Shared Async Function ReadAsync(index As Integer) As Task(Of Submission)
        Dim response = Await httpClient.GetAsync($"{BaseUrl}/read?index={index}")
        If response.IsSuccessStatusCode Then
            Dim submissionJson = Await response.Content.ReadAsStringAsync()
            Return JsonConvert.DeserializeObject(Of Submission)(submissionJson)
        Else
            Throw New Exception($"Error reading submission at index {index}: {response.StatusCode}")
        End If
    End Function

    Public Shared Async Function ReadAllAsync() As Task(Of List(Of Submission))
        Dim response = Await httpClient.GetAsync($"{BaseUrl}/submissions")
        If response.IsSuccessStatusCode Then
            Dim submissionsJson = Await response.Content.ReadAsStringAsync()
            Return JsonConvert.DeserializeObject(Of List(Of Submission))(submissionsJson)
        Else
            Throw New Exception("Error fetching all submissions: " & response.StatusCode)
        End If
    End Function

    Public Shared Async Function UpdateAsync(index As Integer, submission As Submission) As Task(Of Boolean)
        Dim content = New FormUrlEncodedContent(New Dictionary(Of String, String) From {
        {"index", index.ToString()},
        {"name", submission.Name},
        {"email", submission.Email},
        {"phone", submission.Phone},
        {"githubLink", submission.GitHubLink},
        {"stopwatchTime", submission.StopwatchTime}
    })

        Dim response = Await httpClient.PutAsync($"{BaseUrl}/update", content)
        Return response.IsSuccessStatusCode
    End Function

    Public Shared Async Function DeleteAsync(index As Integer) As Task(Of Boolean)
        Dim response = Await httpClient.DeleteAsync($"{BaseUrl}/delete?index={index}")
        Return response.IsSuccessStatusCode
    End Function

End Class
