<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrame
    Inherits System.Windows.Forms.Form

    'Form Overrides dispose To clean up the component list.
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        Heading = New TextBox()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnViewSubmissions.FlatStyle = FlatStyle.Popup
        btnViewSubmissions.Font = New Font("Segoe UI", 14F)
        btnViewSubmissions.Location = New Point(147, 154)
        btnViewSubmissions.Margin = New Padding(4, 5, 4, 5)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(406, 73)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.Cyan
        btnCreateSubmission.FlatStyle = FlatStyle.Popup
        btnCreateSubmission.Font = New Font("Segoe UI", 14F)
        btnCreateSubmission.Location = New Point(147, 283)
        btnCreateSubmission.Margin = New Padding(4, 5, 4, 5)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(406, 63)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission (ctrl + v)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Heading
        ' 
        Heading.BackColor = SystemColors.InactiveBorder
        Heading.BorderStyle = BorderStyle.None
        Heading.Font = New Font("Segoe UI", 16F)
        Heading.Location = New Point(72, 45)
        Heading.Name = "Heading"
        Heading.Size = New Size(568, 36)
        Heading.TabIndex = 2
        Heading.Text = "Kajal Thakur Slidely Task2"
        Heading.TextAlign = HorizontalAlignment.Center
        ' 
        ' MainFrame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(728, 525)
        Controls.Add(Heading)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Margin = New Padding(4, 5, 4, 5)
        Name = "MainFrame"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents Heading As TextBox

End Class
