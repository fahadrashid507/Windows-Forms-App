<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        etr_email = New TextBox()
        search_btn = New Button()
        Label3 = New Label()
        full_name = New Label()
        Label5 = New Label()
        mail = New Label()
        Label7 = New Label()
        phone_no = New Label()
        Label9 = New Label()
        github_link = New Label()
        Label11 = New Label()
        stopwatch = New Label()
        Label13 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(124, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 0
        Label1.Text = "ENTER EMAIL ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(338, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 20)
        Label2.TabIndex = 1
        Label2.Text = "SEARCH BY EMAIL ID"
        ' 
        ' etr_email
        ' 
        etr_email.Location = New Point(289, 88)
        etr_email.Name = "etr_email"
        etr_email.Size = New Size(277, 27)
        etr_email.TabIndex = 2
        ' 
        ' search_btn
        ' 
        search_btn.Location = New Point(625, 85)
        search_btn.Name = "search_btn"
        search_btn.Size = New Size(145, 29)
        search_btn.TabIndex = 3
        search_btn.Text = "SEARCH"
        search_btn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(238, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 4
        Label3.Text = "NAME"
        ' 
        ' full_name
        ' 
        full_name.AutoSize = True
        full_name.Location = New Point(496, 194)
        full_name.Name = "full_name"
        full_name.Size = New Size(53, 20)
        full_name.TabIndex = 5
        full_name.Text = "Label4"
        full_name.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(238, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 20)
        Label5.TabIndex = 6
        Label5.Text = "EMAIL"
        ' 
        ' mail
        ' 
        mail.AutoSize = True
        mail.Location = New Point(496, 230)
        mail.Name = "mail"
        mail.Size = New Size(53, 20)
        mail.TabIndex = 7
        mail.Text = "Label6"
        mail.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(238, 271)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 20)
        Label7.TabIndex = 8
        Label7.Text = "PHONE NO."
        ' 
        ' phone_no
        ' 
        phone_no.AutoSize = True
        phone_no.Location = New Point(496, 271)
        phone_no.Name = "phone_no"
        phone_no.Size = New Size(53, 20)
        phone_no.TabIndex = 9
        phone_no.Text = "Label8"
        phone_no.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(238, 311)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 20)
        Label9.TabIndex = 10
        Label9.Text = "GITHUB LINK"
        ' 
        ' github_link
        ' 
        github_link.AutoSize = True
        github_link.Location = New Point(496, 311)
        github_link.Name = "github_link"
        github_link.Size = New Size(61, 20)
        github_link.TabIndex = 11
        github_link.Text = "Label10"
        github_link.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(238, 345)
        Label11.Name = "Label11"
        Label11.Size = New Size(92, 20)
        Label11.TabIndex = 12
        Label11.Text = "STOPWATCH"
        ' 
        ' stopwatch
        ' 
        stopwatch.AutoSize = True
        stopwatch.Location = New Point(496, 345)
        stopwatch.Name = "stopwatch"
        stopwatch.Size = New Size(61, 20)
        stopwatch.TabIndex = 13
        stopwatch.Text = "Label12"
        stopwatch.Visible = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(369, 139)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 20)
        Label13.TabIndex = 14
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label13)
        Controls.Add(stopwatch)
        Controls.Add(Label11)
        Controls.Add(github_link)
        Controls.Add(Label9)
        Controls.Add(phone_no)
        Controls.Add(Label7)
        Controls.Add(mail)
        Controls.Add(Label5)
        Controls.Add(full_name)
        Controls.Add(Label3)
        Controls.Add(search_btn)
        Controls.Add(etr_email)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents etr_email As TextBox
    Friend WithEvents search_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents full_name As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents mail As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents phone_no As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents github_link As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents stopwatch As Label
    Friend WithEvents Label13 As Label
End Class
