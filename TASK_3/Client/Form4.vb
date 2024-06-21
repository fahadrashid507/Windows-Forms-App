Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form4

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.U
                    update_btn.PerformClick()
                    e.Handled = True


            End Select
        End If
    End Sub
    Private Async Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click


        Dim idx As String = index.Text
        Dim name As String = full_name.Text
        Dim gmail As String = email.Text
        Dim contact As String = phone_no.Text
        Dim gLink As String = github_link.Text

        Dim updateData As New With {
            Key .index = idx,
            Key .name = name,
            Key .email = gmail,
            Key .phone = contact,
            Key .github_link = gLink
        }

        Dim json As String = JsonConvert.SerializeObject(updateData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response = Await client.PostAsync("http://localhost:3000/update", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Update successful! Changes will be reflected after app is restarted")
                Me.Close()

            Else
                MessageBox.Show("Update failed!")
            End If
        End Using
    End Sub
End Class