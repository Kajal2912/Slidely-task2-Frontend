Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class ViewFormSubmission
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0
    Private isEditMode As Boolean = False ' Track edit mode

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissionsAsync()
    End Sub

    Private Async Sub LoadSubmissionsAsync()
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/api/submissions")
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                    If submissions.Count > 0 Then
                        DisplaySubmission(currentIndex)
                    Else
                        MessageBox.Show("No submissions found.")
                    End If
                Else
                    MessageBox.Show($"Failed to load submissions. Status code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 And index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGitHub.Text = submission.github
        End If
    End Sub

    Private Sub ToggleEditMode()
        If isEditMode Then
            ' Disable editing
            txtName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtPhone.ReadOnly = True
            txtGitHub.ReadOnly = True
            btnEdit.Text = "Edit"
        Else
            ' Enable editing
            txtName.ReadOnly = False
            txtEmail.ReadOnly = False
            txtPhone.ReadOnly = False
            txtGitHub.ReadOnly = False
            btnEdit.Text = "Save"
        End If
        isEditMode = Not isEditMode
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ToggleEditMode()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub
End Class

