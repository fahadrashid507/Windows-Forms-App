Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq
Public Class Form5
    Private Async Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Dim email As String = etr_email.Text
        Dim user As JObject = Await GetUserByEmail(email)
        If user IsNot Nothing Then
            full_name.Text = user("name").ToString()
            mail.Text = user("email").ToString()
            phone_no.Text = user("phone").ToString()
            github_link.Text = user("github_link").ToString()
            stopwatch.Text = user("stopwatch").ToString()

            full_name.Visible = True
            mail.Visible = True
            phone_no.Visible = True
            github_link.Visible = True
            stopwatch.Visible = True
        Else
            MessageBox.Show("User not found.")
        End If
    End Sub

    Private Async Function GetUserByEmail(email As String) As Task(Of JObject)
        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/user/{email}")
        If response.IsSuccessStatusCode Then
            Dim content As String = Await response.Content.ReadAsStringAsync()
            Return JObject.Parse(content)
        Else
            Return Nothing
        End If
    End Function

End Class