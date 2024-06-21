<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        view_btn = New Button()
        create_btn = New Button()
        Label1 = New Label()
        update_btn = New Button()
        search_btn = New Button()
        SuspendLayout()
        ' 
        ' view_btn
        ' 
        view_btn.Location = New Point(260, 139)
        view_btn.Name = "view_btn"
        view_btn.Size = New Size(290, 60)
        view_btn.TabIndex = 0
        view_btn.Text = "VIEW SUBMISSIONS (CTRL + V)"
        view_btn.UseVisualStyleBackColor = True
        ' 
        ' create_btn
        ' 
        create_btn.Location = New Point(260, 228)
        create_btn.Name = "create_btn"
        create_btn.Size = New Size(290, 61)
        create_btn.TabIndex = 1
        create_btn.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        create_btn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(260, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 20)
        Label1.TabIndex = 2
        Label1.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        ' 
        ' update_btn
        ' 
        update_btn.Location = New Point(260, 321)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(290, 56)
        update_btn.TabIndex = 3
        update_btn.Text = "EDIT SUBMISSIONS( CTRL + E)"
        update_btn.UseVisualStyleBackColor = True
        ' 
        ' search_btn
        ' 
        search_btn.Location = New Point(260, 414)
        search_btn.Name = "search_btn"
        search_btn.Size = New Size(290, 53)
        search_btn.TabIndex = 4
        search_btn.Text = "SEARCH SUBMISSION (CTRL + S)"
        search_btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 498)
        Controls.Add(search_btn)
        Controls.Add(update_btn)
        Controls.Add(Label1)
        Controls.Add(create_btn)
        Controls.Add(view_btn)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents view_btn As Button
    Friend WithEvents create_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents update_btn As Button
    Friend WithEvents search_btn As Button

End Class
