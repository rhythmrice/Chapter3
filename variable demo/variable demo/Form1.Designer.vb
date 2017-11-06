<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Buttonshow = New System.Windows.Forms.Button()
        Me.Buttonclear = New System.Windows.Forms.Button()
        Me.Buttonexit = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your first name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "This is your full name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(270, 62)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(270, 141)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 4
        '
        'Buttonshow
        '
        Me.Buttonshow.Location = New System.Drawing.Point(86, 377)
        Me.Buttonshow.Name = "Buttonshow"
        Me.Buttonshow.Size = New System.Drawing.Size(75, 23)
        Me.Buttonshow.TabIndex = 6
        Me.Buttonshow.Text = "Show Name"
        Me.Buttonshow.UseVisualStyleBackColor = True
        '
        'Buttonclear
        '
        Me.Buttonclear.Location = New System.Drawing.Point(222, 377)
        Me.Buttonclear.Name = "Buttonclear"
        Me.Buttonclear.Size = New System.Drawing.Size(75, 23)
        Me.Buttonclear.TabIndex = 7
        Me.Buttonclear.Text = "Clear"
        Me.Buttonclear.UseVisualStyleBackColor = True
        '
        'Buttonexit
        '
        Me.Buttonexit.Location = New System.Drawing.Point(351, 377)
        Me.Buttonexit.Name = "Buttonexit"
        Me.Buttonexit.Size = New System.Drawing.Size(75, 23)
        Me.Buttonexit.TabIndex = 8
        Me.Buttonexit.Text = "Exit"
        Me.Buttonexit.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Location = New System.Drawing.Point(270, 266)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(100, 25)
        Me.lblFullName.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 466)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.Buttonexit)
        Me.Controls.Add(Me.Buttonclear)
        Me.Controls.Add(Me.Buttonshow)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Buttonshow As System.Windows.Forms.Button
    Friend WithEvents Buttonclear As System.Windows.Forms.Button
    Friend WithEvents Buttonexit As System.Windows.Forms.Button
    Friend WithEvents lblFullName As System.Windows.Forms.Label

End Class
