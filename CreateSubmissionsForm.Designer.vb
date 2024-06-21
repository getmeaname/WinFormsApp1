<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionsForm
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        btnStartStopwatch = New Button()
        lblStopwatchTime = New TextBox()
        btnSubmit = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(147, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(356, 28)
        Label1.TabIndex = 0
        Label1.Text = "Arun, Slidely task 2 - Create Submission"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(Label5, 0, 3)
        TableLayoutPanel1.Controls.Add(Label3, 0, 1)
        TableLayoutPanel1.Controls.Add(txtName, 1, 0)
        TableLayoutPanel1.Controls.Add(txtEmail, 1, 1)
        TableLayoutPanel1.Controls.Add(txtGitHubLink, 1, 3)
        TableLayoutPanel1.Controls.Add(txtPhone, 1, 2)
        TableLayoutPanel1.Location = New Point(57, 69)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 76.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 79.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(525, 294)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 0
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(3, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 28)
        Label3.TabIndex = 1
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(3, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 28)
        Label4.TabIndex = 2
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(3, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(203, 28)
        Label5.TabIndex = 3
        Label5.Text = "Github Link For Task 2"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(265, 3)
        txtName.Name = "txtName"
        txtName.Size = New Size(257, 34)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(265, 72)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(257, 34)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhone.Location = New Point(265, 141)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(257, 34)
        txtPhone.TabIndex = 6
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtGitHubLink.Location = New Point(265, 217)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(257, 34)
        txtGitHubLink.TabIndex = 7
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.BackColor = Color.Khaki
        btnStartStopwatch.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnStartStopwatch.Location = New Point(57, 389)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(326, 42)
        btnStartStopwatch.TabIndex = 2
        btnStartStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStartStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStopwatchTime.Location = New Point(401, 394)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.ReadOnly = True
        lblStopwatchTime.Size = New Size(172, 34)
        lblStopwatchTime.TabIndex = 3
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SkyBlue
        btnSubmit.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubmit.Location = New Point(147, 464)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(336, 55)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(668, 565)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnStartStopwatch)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label1)
        Name = "CreateSubmissionsForm"
        Text = "CreateNewSubmissions"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents lblStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
End Class
