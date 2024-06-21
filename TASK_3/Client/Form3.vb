Imports MSXML2
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics
Public Class Form3

    Private stopwatch As New Stopwatch()
    Private WithEvents stopwatchTimer As New Timer()

    Private Const BASE_URL As String = "http://localhost:3000" ' Adjust port if needed

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ' Initialize form load settings if needed
        stopwatchTimer.Interval = 1000 ' Set the interval to 1 second (1000 milliseconds)
        stopwatchTimer.Enabled = False ' Ensure the timer is initially disabled
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    toggle_btn.PerformClick()
                    e.Handled = True
                Case Keys.S
                    submit_btn.PerformClick()
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click


        Dim fullName As String = full_name.Text
        Dim mail As String = email.Text
        Dim contact As String = phone_no.Text
        Dim glink As String = github_link.Text
        Dim timer As String = time.Text

        ' debugging to check the value of timer
        'MessageBox.Show($"Timer value: {timer}")

        Dim success As Boolean = ApiPost("/submit", $"{{""name"":""{fullName}"",""email"":""{mail}"",""phone"":""{contact}"",""github_link"":""{glink}"", ""stopwatch"":""{timer}""}}")
        If success Then
            MessageBox.Show("Submission successful")
            ClearForm()

        Else
            MessageBox.Show("Submission failed")
        End If
    End Sub

    Private Function ApiPost(endpoint As String, jsonData As String) As Boolean
        Dim http As New XMLHTTP60
        Dim url As String = BASE_URL & endpoint

        Try
            http.open("POST", url, False)
            http.setRequestHeader("Content-Type", "application/json")
            http.send(jsonData)

            If http.status = 200 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub toggle_btn_Click(sender As Object, e As EventArgs) Handles toggle_btn.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            stopwatchTimer.Stop()
        Else
            stopwatch.Start()
            stopwatchTimer.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        time.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub stopwatchTimer_Tick(sender As Object, e As EventArgs) Handles stopwatchTimer.Tick
        UpdateStopwatchLabel()
    End Sub

    Private Sub ClearForm()
        full_name.Clear()
        email.Clear()
        phone_no.Clear()
        github_link.Clear()
        stopwatch.Reset()
        stopwatchTimer.Stop()
        UpdateStopwatchLabel()
    End Sub

End Class