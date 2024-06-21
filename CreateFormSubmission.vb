Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateFormSubmission
    Private submissionId As String = Nothing
    Private timer As New Timer()
    Private elapsedTime As TimeSpan = TimeSpan.Zero
    Private isTimerRunning As Boolean = False

    Public Sub New(Optional submission As Submission = Nothing)
        InitializeComponent()

        If submission IsNot Nothing Then
            submissionId = submission.id
            lblName.Text = submission.name
            lblEmail.Text = submission.email
            lblPhone.Text = submission.phone
            lblGithub.Text = submission.github
            Text = "Edit Submission"
            btnSubmit.Text = "Update"
        Else
            Text = "Create Submission"
            btnSubmit.Text = "Submit"
        End If

        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000 ' Timer tick every 1 second
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize Timer
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        lblTimer.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If isTimerRunning Then
            timer.Stop()
            btnStopwatch.Text = "Resume Timer"
        Else
            timer.Start()
            btnStopwatch.Text = "Pause Timer"
        End If
        isTimerRunning = Not isTimerRunning
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github = txtGithub.Text
        }

        Dim success As Boolean
        If submissionId Is Nothing Then
            success = Await SaveSubmissionAsync(submission)
        Else
            submission.id = submissionId
            success = Await UpdateSubmissionAsync(submission)
        End If

        If success Then
            MessageBox.Show("Submission saved successfully!")
            Me.Close()
            Dim newForm As New CreateFormSubmission()
            newForm.Show()
        Else
            MessageBox.Show("Failed to save submission.")
        End If
    End Sub

    Private Async Function SaveSubmissionAsync(submission As Submission) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                Dim json As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/api/submissions", content)
                Return response.IsSuccessStatusCode
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
            Return False
        End Try
    End Function

    Private Async Function UpdateSubmissionAsync(submission As Submission) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                Dim json As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/api/submissions/{submission.id}", content)
                Return response.IsSuccessStatusCode
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
            Return False
        End Try
    End Function
End Class

' Submission class to match backend model
Public Class Submission
    Public Property id As String
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github As String
    Public Property timestamp As DateTime
End Class