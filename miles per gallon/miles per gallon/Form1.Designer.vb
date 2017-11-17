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
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ButtCalculate = New System.Windows.Forms.Button()
        Me.ButtClear = New System.Windows.Forms.Button()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons of gas the car can hold:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it can be driven on a full tank:"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(345, 85)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(72, 20)
        Me.txtGallons.TabIndex = 2
        '
        'txtMileage
        '
        Me.txtMileage.Location = New System.Drawing.Point(345, 172)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(100, 20)
        Me.txtMileage.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Miles per gallon:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(342, 264)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 5
        '
        'ButtCalculate
        '
        Me.ButtCalculate.Location = New System.Drawing.Point(71, 367)
        Me.ButtCalculate.Name = "ButtCalculate"
        Me.ButtCalculate.Size = New System.Drawing.Size(75, 41)
        Me.ButtCalculate.TabIndex = 6
        Me.ButtCalculate.Text = "Calculate MPG"
        Me.ButtCalculate.UseVisualStyleBackColor = True
        '
        'ButtClear
        '
        Me.ButtClear.Location = New System.Drawing.Point(224, 366)
        Me.ButtClear.Name = "ButtClear"
        Me.ButtClear.Size = New System.Drawing.Size(75, 42)
        Me.ButtClear.TabIndex = 7
        Me.ButtClear.Text = "Clear"
        Me.ButtClear.UseVisualStyleBackColor = True
        '
        'ButtExit
        '
        Me.ButtExit.Location = New System.Drawing.Point(357, 367)
        Me.ButtExit.Name = "ButtExit"
        Me.ButtExit.Size = New System.Drawing.Size(75, 41)
        Me.ButtExit.TabIndex = 8
        Me.ButtExit.Text = "Exit"
        Me.ButtExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 461)
        Me.Controls.Add(Me.ButtExit)
        Me.Controls.Add(Me.ButtClear)
        Me.Controls.Add(Me.ButtCalculate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMileage)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtMileage As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents ButtCalculate As System.Windows.Forms.Button
    Friend WithEvents ButtClear As System.Windows.Forms.Button
    Friend WithEvents ButtExit As System.Windows.Forms.Button

End Class
