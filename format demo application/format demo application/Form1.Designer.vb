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
        Me.LabelFormatted = New System.Windows.Forms.Label()
        Me.TextBoxEntersumthin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtNumber = New System.Windows.Forms.Button()
        Me.ButtShortdate = New System.Windows.Forms.Button()
        Me.ButtFixed = New System.Windows.Forms.Button()
        Me.ButtExponetial = New System.Windows.Forms.Button()
        Me.ButtCurrency = New System.Windows.Forms.Button()
        Me.ButtPercent = New System.Windows.Forms.Button()
        Me.ButtLongdate = New System.Windows.Forms.Button()
        Me.ButtShorttime = New System.Windows.Forms.Button()
        Me.ButtLongtime = New System.Windows.Forms.Button()
        Me.ButtFulldatetime = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number or date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Formatted:"
        '
        'LabelFormatted
        '
        Me.LabelFormatted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelFormatted.Location = New System.Drawing.Point(282, 141)
        Me.LabelFormatted.Name = "LabelFormatted"
        Me.LabelFormatted.Size = New System.Drawing.Size(265, 23)
        Me.LabelFormatted.TabIndex = 3
        '
        'TextBoxEntersumthin
        '
        Me.TextBoxEntersumthin.Location = New System.Drawing.Point(282, 61)
        Me.TextBoxEntersumthin.Name = "TextBoxEntersumthin"
        Me.TextBoxEntersumthin.Size = New System.Drawing.Size(265, 20)
        Me.TextBoxEntersumthin.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtFulldatetime)
        Me.GroupBox1.Controls.Add(Me.ButtLongtime)
        Me.GroupBox1.Controls.Add(Me.ButtShorttime)
        Me.GroupBox1.Controls.Add(Me.ButtLongdate)
        Me.GroupBox1.Controls.Add(Me.ButtPercent)
        Me.GroupBox1.Controls.Add(Me.ButtCurrency)
        Me.GroupBox1.Controls.Add(Me.ButtExponetial)
        Me.GroupBox1.Controls.Add(Me.ButtFixed)
        Me.GroupBox1.Controls.Add(Me.ButtShortdate)
        Me.GroupBox1.Controls.Add(Me.ButtNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(102, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 180)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'ButtNumber
        '
        Me.ButtNumber.Location = New System.Drawing.Point(6, 35)
        Me.ButtNumber.Name = "ButtNumber"
        Me.ButtNumber.Size = New System.Drawing.Size(140, 23)
        Me.ButtNumber.TabIndex = 0
        Me.ButtNumber.Text = "Number format (n)"
        Me.ButtNumber.UseVisualStyleBackColor = True
        '
        'ButtShortdate
        '
        Me.ButtShortdate.Location = New System.Drawing.Point(180, 35)
        Me.ButtShortdate.Name = "ButtShortdate"
        Me.ButtShortdate.Size = New System.Drawing.Size(137, 23)
        Me.ButtShortdate.TabIndex = 1
        Me.ButtShortdate.Text = "Short date (d)"
        Me.ButtShortdate.UseVisualStyleBackColor = True
        '
        'ButtFixed
        '
        Me.ButtFixed.Location = New System.Drawing.Point(6, 64)
        Me.ButtFixed.Name = "ButtFixed"
        Me.ButtFixed.Size = New System.Drawing.Size(141, 23)
        Me.ButtFixed.TabIndex = 2
        Me.ButtFixed.Text = "Fixed-point format (f)"
        Me.ButtFixed.UseVisualStyleBackColor = True
        '
        'ButtExponetial
        '
        Me.ButtExponetial.Location = New System.Drawing.Point(6, 94)
        Me.ButtExponetial.Name = "ButtExponetial"
        Me.ButtExponetial.Size = New System.Drawing.Size(141, 23)
        Me.ButtExponetial.TabIndex = 3
        Me.ButtExponetial.Text = "Exponetial format (e)"
        Me.ButtExponetial.UseVisualStyleBackColor = True
        '
        'ButtCurrency
        '
        Me.ButtCurrency.Location = New System.Drawing.Point(6, 123)
        Me.ButtCurrency.Name = "ButtCurrency"
        Me.ButtCurrency.Size = New System.Drawing.Size(140, 23)
        Me.ButtCurrency.TabIndex = 4
        Me.ButtCurrency.Text = "Currency format (c)"
        Me.ButtCurrency.UseVisualStyleBackColor = True
        '
        'ButtPercent
        '
        Me.ButtPercent.Location = New System.Drawing.Point(6, 151)
        Me.ButtPercent.Name = "ButtPercent"
        Me.ButtPercent.Size = New System.Drawing.Size(140, 23)
        Me.ButtPercent.TabIndex = 5
        Me.ButtPercent.Text = "Percent format (p)"
        Me.ButtPercent.UseVisualStyleBackColor = True
        '
        'ButtLongdate
        '
        Me.ButtLongdate.Location = New System.Drawing.Point(180, 64)
        Me.ButtLongdate.Name = "ButtLongdate"
        Me.ButtLongdate.Size = New System.Drawing.Size(137, 23)
        Me.ButtLongdate.TabIndex = 6
        Me.ButtLongdate.Text = "Long date (D)"
        Me.ButtLongdate.UseVisualStyleBackColor = True
        '
        'ButtShorttime
        '
        Me.ButtShorttime.Location = New System.Drawing.Point(180, 94)
        Me.ButtShorttime.Name = "ButtShorttime"
        Me.ButtShorttime.Size = New System.Drawing.Size(137, 23)
        Me.ButtShorttime.TabIndex = 7
        Me.ButtShorttime.Text = "Short time ( t)"
        Me.ButtShorttime.UseVisualStyleBackColor = True
        '
        'ButtLongtime
        '
        Me.ButtLongtime.Location = New System.Drawing.Point(180, 123)
        Me.ButtLongtime.Name = "ButtLongtime"
        Me.ButtLongtime.Size = New System.Drawing.Size(137, 23)
        Me.ButtLongtime.TabIndex = 8
        Me.ButtLongtime.Text = "Long time (T)"
        Me.ButtLongtime.UseVisualStyleBackColor = True
        '
        'ButtFulldatetime
        '
        Me.ButtFulldatetime.Location = New System.Drawing.Point(180, 151)
        Me.ButtFulldatetime.Name = "ButtFulldatetime"
        Me.ButtFulldatetime.Size = New System.Drawing.Size(137, 23)
        Me.ButtFulldatetime.TabIndex = 9
        Me.ButtFulldatetime.Text = "Full date/time (F)"
        Me.ButtFulldatetime.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 517)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxEntersumthin)
        Me.Controls.Add(Me.LabelFormatted)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelFormatted As System.Windows.Forms.Label
    Friend WithEvents TextBoxEntersumthin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtFulldatetime As System.Windows.Forms.Button
    Friend WithEvents ButtLongtime As System.Windows.Forms.Button
    Friend WithEvents ButtShorttime As System.Windows.Forms.Button
    Friend WithEvents ButtLongdate As System.Windows.Forms.Button
    Friend WithEvents ButtPercent As System.Windows.Forms.Button
    Friend WithEvents ButtCurrency As System.Windows.Forms.Button
    Friend WithEvents ButtExponetial As System.Windows.Forms.Button
    Friend WithEvents ButtFixed As System.Windows.Forms.Button
    Friend WithEvents ButtShortdate As System.Windows.Forms.Button
    Friend WithEvents ButtNumber As System.Windows.Forms.Button

End Class
