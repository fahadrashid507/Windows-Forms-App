<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        index = New TextBox()
        full_name = New TextBox()
        email = New TextBox()
        phone_no = New TextBox()
        github_link = New TextBox()
        Label6 = New Label()
        update_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(230, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 0
        Label1.Text = "Index"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(230, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(230, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(230, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(230, 285)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 4
        Label5.Text = "Github link"
        ' 
        ' index
        ' 
        index.Location = New Point(433, 86)
        index.Name = "index"
        index.Size = New Size(202, 27)
        index.TabIndex = 5
        ' 
        ' full_name
        ' 
        full_name.Location = New Point(433, 136)
        full_name.Name = "full_name"
        full_name.Size = New Size(202, 27)
        full_name.TabIndex = 6
        ' 
        ' email
        ' 
        email.Location = New Point(433, 186)
        email.Name = "email"
        email.Size = New Size(202, 27)
        email.TabIndex = 7
        ' 
        ' phone_no
        ' 
        phone_no.Location = New Point(433, 240)
        phone_no.Name = "phone_no"
        phone_no.Size = New Size(202, 27)
        phone_no.TabIndex = 8
        ' 
        ' github_link
        ' 
        github_link.Location = New Point(433, 285)
        github_link.Name = "github_link"
        github_link.Size = New Size(202, 27)
        github_link.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(322, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 20)
        Label6.TabIndex = 10
        Label6.Text = "Update by index"
        ' 
        ' update_btn
        ' 
        update_btn.Location = New Point(302, 370)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(193, 45)
        update_btn.TabIndex = 11
        update_btn.Text = "UPDATE (CTRL + U)"
        update_btn.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(update_btn)
        Controls.Add(Label6)
        Controls.Add(github_link)
        Controls.Add(phone_no)
        Controls.Add(email)
        Controls.Add(full_name)
        Controls.Add(index)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents index As TextBox
    Friend WithEvents full_name As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents phone_no As TextBox
    Friend WithEvents github_link As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents update_btn As Button
End Class
