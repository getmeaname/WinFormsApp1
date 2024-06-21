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
        Label1 = New Label()
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(289, 59)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(434, 32)
        Label1.TabIndex = 0
        Label1.Text = "Arun, Slidely Task 2 - Slidely Forms App"
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Khaki
        btnViewSubmissions.Location = New Point(75, 153)
        btnViewSubmissions.Margin = New Padding(4, 3, 4, 3)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(856, 112)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "VIEW SUBMISSION (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = Color.SkyBlue
        btnCreateNewSubmission.Location = New Point(75, 347)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(856, 113)
        btnCreateNewSubmission.TabIndex = 2
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 545)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button

End Class
