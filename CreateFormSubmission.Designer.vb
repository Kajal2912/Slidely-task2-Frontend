<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFormSubmission
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        btnStopwatch = New Button()
        btnSubmit = New Button()
        lblTimer = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithub = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 14F)
        txtName.Location = New Point(393, 105)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(366, 39)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 14F)
        txtEmail.Location = New Point(393, 174)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(366, 39)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Segoe UI", 14F)
        txtPhone.Location = New Point(393, 239)
        txtPhone.Margin = New Padding(3, 4, 3, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(366, 39)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithub
        ' 
        txtGithub.BorderStyle = BorderStyle.FixedSingle
        txtGithub.Font = New Font("Segoe UI", 14F)
        txtGithub.Location = New Point(393, 300)
        txtGithub.Margin = New Padding(3, 4, 3, 4)
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(366, 39)
        txtGithub.TabIndex = 3
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.Yellow
        btnStopwatch.FlatStyle = FlatStyle.Popup
        btnStopwatch.Font = New Font("Segoe UI", 14F)
        btnStopwatch.Location = New Point(253, 384)
        btnStopwatch.Margin = New Padding(3, 4, 3, 4)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(331, 45)
        btnStopwatch.TabIndex = 4
        btnStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Cyan
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Font = New Font("Segoe UI", 14F)
        btnSubmit.Location = New Point(311, 462)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(391, 53)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblTimesr
        ' 
        lblTimer.AutoSize = True
        lblTimer.Font = New Font("Segoe UI", 14.0F)
        lblTimer.Location = New Point(275, 399)
        lblTimer.Name = "lblTimestamp"
        lblTimer.Size = New Size(137, 32)
        lblTimer.TabIndex = 6
        lblTimer.Text = "Timer:"
        lblTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 14F)
        lblName.Location = New Point(253, 112)
        lblName.Name = "lblName"
        lblName.Size = New Size(83, 32)
        lblName.TabIndex = 6
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 14F)
        lblEmail.Location = New Point(253, 181)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(76, 32)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 14F)
        lblPhone.Location = New Point(253, 246)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(87, 32)
        lblPhone.TabIndex = 8
        lblPhone.Text = "Phone:"
        ' 
        ' lblGithub
        ' 
        lblGithub.AutoSize = True
        lblGithub.Font = New Font("Segoe UI", 14F)
        lblGithub.Location = New Point(253, 307)
        lblGithub.Name = "lblGithub"
        lblGithub.Size = New Size(94, 32)
        lblGithub.TabIndex = 9
        lblGithub.Text = "GitHub:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(289, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(440, 36)
        TextBox1.TabIndex = 10
        TextBox1.Text = "CREATE SUBMISSION FORM"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateFormSubmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(985, 582)
        Controls.Add(TextBox1)
        Controls.Add(lblGithub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateFormSubmission"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTimer As Label
End Class
