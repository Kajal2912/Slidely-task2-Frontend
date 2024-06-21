Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class MainFrame
    Private Sub BtnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewFormSubmission()
        viewForm.Show()
    End Sub

    Private Sub BtnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateFormSubmission()
        createForm.Show()
    End Sub

    Private Sub Heading_TextChanged(sender As Object, e As EventArgs) Handles Heading.TextChanged

    End Sub
End Class
