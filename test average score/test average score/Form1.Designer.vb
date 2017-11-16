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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelAverage = New System.Windows.Forms.Label()
        Me.TextBoxScore5 = New System.Windows.Forms.TextBox()
        Me.TextBoxScore4 = New System.Windows.Forms.TextBox()
        Me.TextBoxScore3 = New System.Windows.Forms.TextBox()
        Me.TextBoxScore2 = New System.Windows.Forms.TextBox()
        Me.TextBoxScore1 = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text Score 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Text Score 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Text Score 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Text Score 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Text Score 5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Average"
        '
        'LabelAverage
        '
        Me.LabelAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAverage.Location = New System.Drawing.Point(292, 313)
        Me.LabelAverage.Name = "LabelAverage"
        Me.LabelAverage.Size = New System.Drawing.Size(100, 23)
        Me.LabelAverage.TabIndex = 6
        '
        'TextBoxScore5
        '
        Me.TextBoxScore5.Location = New System.Drawing.Point(295, 231)
        Me.TextBoxScore5.Name = "TextBoxScore5"
        Me.TextBoxScore5.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxScore5.TabIndex = 7
        '
        'TextBoxScore4
        '
        Me.TextBoxScore4.Location = New System.Drawing.Point(295, 187)
        Me.TextBoxScore4.Name = "TextBoxScore4"
        Me.TextBoxScore4.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxScore4.TabIndex = 8
        '
        'TextBoxScore3
        '
        Me.TextBoxScore3.Location = New System.Drawing.Point(295, 147)
        Me.TextBoxScore3.Name = "TextBoxScore3"
        Me.TextBoxScore3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxScore3.TabIndex = 9
        '
        'TextBoxScore2
        '
        Me.TextBoxScore2.Location = New System.Drawing.Point(295, 97)
        Me.TextBoxScore2.Name = "TextBoxScore2"
        Me.TextBoxScore2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxScore2.TabIndex = 10
        '
        'TextBoxScore1
        '
        Me.TextBoxScore1.Location = New System.Drawing.Point(295, 42)
        Me.TextBoxScore1.Name = "TextBoxScore1"
        Me.TextBoxScore1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxScore1.TabIndex = 11
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(90, 433)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(75, 43)
        Me.ButtonCalculate.TabIndex = 12
        Me.ButtonCalculate.Text = "Calculate Average"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(254, 433)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 43)
        Me.ButtonClear.TabIndex = 13
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(414, 433)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 43)
        Me.ButtonExit.TabIndex = 14
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 530)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.TextBoxScore1)
        Me.Controls.Add(Me.TextBoxScore2)
        Me.Controls.Add(Me.TextBoxScore3)
        Me.Controls.Add(Me.TextBoxScore4)
        Me.Controls.Add(Me.TextBoxScore5)
        Me.Controls.Add(Me.LabelAverage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelAverage As System.Windows.Forms.Label
    Friend WithEvents TextBoxScore5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScore4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScore3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScore2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScore1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCalculate As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button

End Class
