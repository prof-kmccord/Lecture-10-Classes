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
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        btnAddStudent = New Button()
        lblFullName = New Label()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(333, 252)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(117, 23)
        txtFirstName.TabIndex = 0
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(333, 281)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(117, 23)
        txtLastName.TabIndex = 1
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Location = New Point(333, 310)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(117, 23)
        btnAddStudent.TabIndex = 2
        btnAddStudent.Text = "Name Button"
        btnAddStudent.UseVisualStyleBackColor = True
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(333, 348)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(41, 15)
        lblFullName.TabIndex = 3
        lblFullName.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblFullName)
        Controls.Add(btnAddStudent)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents lblFullName As Label
End Class
