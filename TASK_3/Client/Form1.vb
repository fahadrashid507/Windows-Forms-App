Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable the form to receive key events before the focused control
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    view_btn.PerformClick()
                    e.Handled = True
                Case Keys.N
                    create_btn.PerformClick()
                    e.Handled = True
                Case Keys.E
                    update_btn.PerformClick()
                    e.Handled = True
                Case Keys.S
                    search_btn.PerformClick()
                    e.Handled = True
            End Select
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles view_btn.Click
        'MessageBox.Show("Button 1 clicked!")
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles create_btn.Click
        'MessageBox.Show("Button 2 clicked!")
        Dim form3 As New Form3()
        form3.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim form4 As New Form4()
        form4.Show()
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Dim form5 As New Form5()
        form5.Show()
    End Sub
End Class
