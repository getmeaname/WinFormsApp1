<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopWatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(133, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(432, 32)
        Label1.TabIndex = 0
        Label1.Text = "Arun, Slidely Task 2 - View Submissions"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(3, 398)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 32)
        Label6.TabIndex = 5
        Label6.Text = "StopWatch Time"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(3, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 32)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(3, 287)
        Label5.Name = "Label5"
        Label5.Size = New Size(248, 32)
        Label5.TabIndex = 4
        Label5.Text = "Github Link For Task 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(3, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 32)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 32)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(txtName, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 1)
        TableLayoutPanel1.Controls.Add(Label5, 0, 3)
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(Label6, 0, 4)
        TableLayoutPanel1.Controls.Add(txtEmail, 1, 1)
        TableLayoutPanel1.Controls.Add(txtPhone, 1, 2)
        TableLayoutPanel1.Controls.Add(txtGitHubLink, 1, 3)
        TableLayoutPanel1.Controls.Add(txtStopWatchTime, 1, 4)
        TableLayoutPanel1.Location = New Point(66, 75)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45.9459457F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 54.0540543F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 102.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 111.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 94.0F))
        TableLayoutPanel1.Size = New Size(535, 493)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(270, 3)
        txtName.Name = "txtName"
        txtName.Size = New Size(262, 39)
        txtName.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(270, 88)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(262, 39)
        txtEmail.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhone.Location = New Point(270, 188)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(262, 39)
        txtPhone.TabIndex = 10
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtGitHubLink.Location = New Point(270, 290)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(262, 39)
        txtGitHubLink.TabIndex = 11
        ' 
        ' txtStopWatchTime
        ' 
        txtStopWatchTime.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtStopWatchTime.Location = New Point(270, 401)
        txtStopWatchTime.Name = "txtStopWatchTime"
        txtStopWatchTime.Size = New Size(262, 39)
        txtStopWatchTime.TabIndex = 12
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Khaki
        btnPrevious.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrevious.Location = New Point(27, 583)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(300, 57)
        btnPrevious.TabIndex = 6
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SkyBlue
        btnNext.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnNext.Location = New Point(343, 583)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(323, 57)
        btnNext.TabIndex = 7
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.IndianRed
        btnDelete.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(27, 668)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(300, 59)
        btnDelete.TabIndex = 8
        btnDelete.Text = "DELETE (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.LightSalmon
        btnEdit.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.Location = New Point(343, 668)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(323, 59)
        btnEdit.TabIndex = 9
        btnEdit.Text = "UPDATE (CTRL + U)"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(698, 745)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopWatchTime As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
