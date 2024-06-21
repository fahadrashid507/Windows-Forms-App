Imports MSXML2
Imports Newtonsoft.Json
Public Class Form2
    ' Private Const BASE_URL As String = "http://localhost:3000" ' Adjust port if needed

    Private currentIndex As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmission(currentIndex)
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    prev_btn.PerformClick()
                    e.Handled = True
                Case Keys.N
                    nxt_btn.PerformClick()
                    e.Handled = True
                Case Keys.D
                    delete_btn.PerformClick()
                    e.Handled = True

            End Select
        End If
    End Sub

    Private Sub LoadSubmission(index As Integer)
        Dim http As New XMLHTTP60
        Dim url As String = $"http://localhost:3000/read/{index}"

        Try
            http.open("GET", url, False)
            http.send()

            If http.status = 200 Then
                Dim submissionJson As String = http.responseText
                Dim submission As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(submissionJson)
                DisplaySubmission(submission)
                currentIndex = index
            ElseIf http.status = 404 Then
                MessageBox.Show("No more submissions available.")
                ' Revert the index change
                If index > currentIndex Then
                    currentIndex = index - 1
                ElseIf index < currentIndex Then
                    currentIndex = index + 1
                End If
            Else
                MessageBox.Show($"Error {http.status}: {http.statusText}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplaySubmission(submission As Object)
        If submission IsNot Nothing Then
            full_name.Text = submission("name").ToString()
            email.Text = submission("email").ToString()
            phone_no.Text = submission("phone").ToString()
            github_link.Text = submission("github_link").ToString()
            stopwatch.Text = submission("stopwatch").ToString()
        Else
            MessageBox.Show("No submission to display.")

        End If
    End Sub

    Private Sub prev_btn_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        Else
            MessageBox.Show("No previous submissions to display.")
        End If
    End Sub

    Private Sub nxt_btn_Click(sender As Object, e As EventArgs) Handles nxt_btn.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        DeleteSubmission(currentIndex)
    End Sub


    Private Sub DeleteSubmission(index As Integer)
        Dim http As New XMLHTTP60
        Dim url As String = $"http://localhost:3000/delete/{index}"

        Try
            http.open("DELETE", url, False)
            http.send()

            If http.status = 200 Then
                MessageBox.Show("Deleted successfully. Changes will be reflected after app is restarted")
                Me.Close()
            Else
                MessageBox.Show($"Error {http.status}: {http.statusText}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub



End Class