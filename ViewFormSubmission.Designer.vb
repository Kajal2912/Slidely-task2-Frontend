<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFormSubmission
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHub = New Label()
        lblTimestamp = New Label()
        btnNext = New Button()
        btnPrevious = New Button()
        btnEdit = New Button()
        txtTimestamp = New TextBox()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 14.0F)
        lblName.Location = New Point(196, 86)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(83, 32)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 14.0F)
        lblEmail.Location = New Point(196, 149)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(76, 32)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 14.0F)
        lblPhone.Location = New Point(195, 216)
        lblPhone.Margin = New Padding(4, 0, 4, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(87, 32)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone:"
        ' 
        ' lblGitHub
        ' 
        lblGitHub.AutoSize = True
        lblGitHub.Font = New Font("Segoe UI", 14.0F)
        lblGitHub.Location = New Point(195, 292)
        lblGitHub.Margin = New Padding(4, 0, 4, 0)
        lblGitHub.Name = "lblGitHub"
        lblGitHub.Size = New Size(94, 32)
        lblGitHub.TabIndex = 3
        lblGitHub.Text = "GitHub:"
        ' 
        ' lblTimestamp
        ' 
        lblTimestamp.AutoSize = True
        lblTimestamp.Location = New Point(13, 173)
        lblTimestamp.Name = "lblTimestamp"
        lblTimestamp.Size = New Size(61, 13)
        lblTimestamp.TabIndex = 4
        lblTimestamp.Text = "Timestamp:"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Cyan
        btnNext.FlatStyle = FlatStyle.Popup
        btnNext.Font = New Font("Segoe UI", 14.0F)
        btnNext.Location = New Point(490, 447)
        btnNext.Margin = New Padding(4, 5, 4, 5)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(100, 47)
        btnNext.TabIndex = 4
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.FlatStyle = FlatStyle.Popup
        btnPrevious.Font = New Font("Segoe UI", 14.0F)
        btnPrevious.Location = New Point(196, 447)
        btnPrevious.Margin = New Padding(4, 5, 4, 5)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(131, 47)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous"
        btnPrevious.TextAlign = ContentAlignment.TopCenter
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Lime
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI", 14.0F)
        btnEdit.Location = New Point(490, 377)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(100, 44)
        btnEdit.TabIndex = 6
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' txtTimestamp
        ' 
        txtTimestamp.Location = New Point(80, 170)
        txtTimestamp.Name = "txtTimestamp"
        txtTimestamp.ReadOnly = True
        txtTimestamp.Size = New Size(192, 27)
        txtTimestamp.TabIndex = 9
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ControlLight
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 14.0F)
        txtName.Location = New Point(310, 79)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(280, 39)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ControlLight
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 14.0F)
        txtEmail.Location = New Point(310, 149)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(280, 39)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ControlLight
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Segoe UI", 14.0F)
        txtPhone.Location = New Point(310, 209)
        txtPhone.Margin = New Padding(4, 5, 4, 5)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(280, 39)
        txtPhone.TabIndex = 9
        ' 
        ' txtGitHub
        ' 
        txtGitHub.BackColor = SystemColors.ControlLight
        txtGitHub.BorderStyle = BorderStyle.FixedSingle
        txtGitHub.Font = New Font("Segoe UI", 14.0F)
        txtGitHub.Location = New Point(310, 285)
        txtGitHub.Margin = New Padding(4, 5, 4, 5)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.ReadOnly = True
        txtGitHub.Size = New Size(280, 39)
        txtGitHub.TabIndex = 10
        ' 
        ' ViewFormSubmission
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 548)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnEdit)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        Controls.Add(lblGitHub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ViewFormSubmission"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblGitHub As System.Windows.Forms.Label
    Friend WithEvents lblTimestamp As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGitHub As System.Windows.Forms.TextBox
    Friend WithEvents txtTimestamp As System.Windows.Forms.TextBox
End Class
