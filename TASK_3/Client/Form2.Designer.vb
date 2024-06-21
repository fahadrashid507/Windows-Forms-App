<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        full_name = New Label()
        email = New Label()
        phone_no = New Label()
        github_link = New Label()
        stopwatch = New Label()
        prev_btn = New Button()
        nxt_btn = New Button()
        delete_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(234, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 20)
        Label1.TabIndex = 0
        Label1.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(228, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(228, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(225, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(225, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 4
        Label5.Text = "Github Link For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(225, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 20)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch Time"
        ' 
        ' full_name
        ' 
        full_name.AutoSize = True
        full_name.Location = New Point(477, 104)
        full_name.Name = "full_name"
        full_name.Size = New Size(53, 20)
        full_name.TabIndex = 6
        full_name.Text = "Label7"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.Location = New Point(477, 142)
        email.Name = "email"
        email.Size = New Size(53, 20)
        email.TabIndex = 7
        email.Text = "Label8"
        ' 
        ' phone_no
        ' 
        phone_no.AutoSize = True
        phone_no.Location = New Point(477, 182)
        phone_no.Name = "phone_no"
        phone_no.Size = New Size(53, 20)
        phone_no.TabIndex = 8
        phone_no.Text = "Label9"
        ' 
        ' github_link
        ' 
        github_link.AutoSize = True
        github_link.Location = New Point(477, 221)
        github_link.Name = "github_link"
        github_link.Size = New Size(61, 20)
        github_link.TabIndex = 9
        github_link.Text = "Label10"
        ' 
        ' stopwatch
        ' 
        stopwatch.AutoSize = True
        stopwatch.Location = New Point(477, 262)
        stopwatch.Name = "stopwatch"
        stopwatch.Size = New Size(61, 20)
        stopwatch.TabIndex = 10
        stopwatch.Text = "Label11"
        ' 
        ' prev_btn
        ' 
        prev_btn.Location = New Point(161, 342)
        prev_btn.Name = "prev_btn"
        prev_btn.Size = New Size(180, 29)
        prev_btn.TabIndex = 11
        prev_btn.Text = "PREVIOUS (CTRL + P)"
        prev_btn.UseVisualStyleBackColor = True
        ' 
        ' nxt_btn
        ' 
        nxt_btn.Location = New Point(448, 342)
        nxt_btn.Name = "nxt_btn"
        nxt_btn.Size = New Size(170, 29)
        nxt_btn.TabIndex = 12
        nxt_btn.Text = "NEXT (CTRL + N)"
        nxt_btn.UseVisualStyleBackColor = True
        ' 
        ' delete_btn
        ' 
        delete_btn.Location = New Point(295, 409)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(170, 29)
        delete_btn.TabIndex = 14
        delete_btn.Text = "DELETE (CTRL + D)"
        delete_btn.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(delete_btn)
        Controls.Add(nxt_btn)
        Controls.Add(prev_btn)
        Controls.Add(stopwatch)
        Controls.Add(github_link)
        Controls.Add(phone_no)
        Controls.Add(email)
        Controls.Add(full_name)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents full_name As Label
    Friend WithEvents email As Label
    Friend WithEvents phone_no As Label
    Friend WithEvents github_link As Label
    Friend WithEvents stopwatch As Label
    Friend WithEvents prev_btn As Button
    Friend WithEvents nxt_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
End Class
