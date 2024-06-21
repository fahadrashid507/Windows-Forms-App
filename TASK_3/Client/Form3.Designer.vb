<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        full_name = New TextBox()
        email = New TextBox()
        phone_no = New TextBox()
        github_link = New TextBox()
        time = New Label()
        toggle_btn = New Button()
        submit_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(236, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(301, 20)
        Label1.TabIndex = 0
        Label1.Text = "John Doe, Slidely Task 2 - Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(117, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(117, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(114, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(114, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 4
        Label5.Text = "Github Link For Task 2"
        ' 
        ' full_name
        ' 
        full_name.Location = New Point(285, 84)
        full_name.Name = "full_name"
        full_name.Size = New Size(290, 27)
        full_name.TabIndex = 5
        ' 
        ' email
        ' 
        email.Location = New Point(285, 128)
        email.Name = "email"
        email.Size = New Size(290, 27)
        email.TabIndex = 6
        ' 
        ' phone_no
        ' 
        phone_no.Location = New Point(285, 174)
        phone_no.Name = "phone_no"
        phone_no.Size = New Size(290, 27)
        phone_no.TabIndex = 7
        ' 
        ' github_link
        ' 
        github_link.Location = New Point(285, 226)
        github_link.Name = "github_link"
        github_link.Size = New Size(290, 27)
        github_link.TabIndex = 8
        ' 
        ' time
        ' 
        time.AutoSize = True
        time.Location = New Point(448, 297)
        time.Name = "time"
        time.Size = New Size(63, 20)
        time.TabIndex = 9
        time.Text = "00:00:00"
        ' 
        ' toggle_btn
        ' 
        toggle_btn.Location = New Point(117, 293)
        toggle_btn.Name = "toggle_btn"
        toggle_btn.Size = New Size(245, 29)
        toggle_btn.TabIndex = 10
        toggle_btn.Text = "TOGGLE STOPWATCH (CTRL + T)"
        toggle_btn.UseVisualStyleBackColor = True
        ' 
        ' submit_btn
        ' 
        submit_btn.Location = New Point(236, 371)
        submit_btn.Name = "submit_btn"
        submit_btn.Size = New Size(275, 39)
        submit_btn.TabIndex = 11
        submit_btn.Text = "SUBMIT (CTRL + S)"
        submit_btn.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(submit_btn)
        Controls.Add(toggle_btn)
        Controls.Add(time)
        Controls.Add(github_link)
        Controls.Add(phone_no)
        Controls.Add(email)
        Controls.Add(full_name)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents full_name As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents phone_no As TextBox
    Friend WithEvents github_link As TextBox
    Friend WithEvents time As Label
    Friend WithEvents toggle_btn As Button
    Friend WithEvents submit_btn As Button
End Class
