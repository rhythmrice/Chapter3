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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxNightlyCharge = New System.Windows.Forms.TextBox()
        Me.TextBoxNights = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxMisc = New System.Windows.Forms.TextBox()
        Me.TextBoxTelephone = New System.Windows.Forms.TextBox()
        Me.TextBoxRoomService = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelSubtotal = New System.Windows.Forms.Label()
        Me.LabelTax = New System.Windows.Forms.Label()
        Me.LabelTotalCharges = New System.Windows.Forms.Label()
        Me.LabelAditionalCharges = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelRoomChanges = New System.Windows.Forms.Label()
        Me.ButtCalculate = New System.Windows.Forms.Button()
        Me.ButtClear = New System.Windows.Forms.Button()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.LabelTodaysDate = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highlander Hotel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxNightlyCharge)
        Me.GroupBox1.Controls.Add(Me.TextBoxNights)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(133, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 127)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room information"
        '
        'TextBoxNightlyCharge
        '
        Me.TextBoxNightlyCharge.Location = New System.Drawing.Point(91, 78)
        Me.TextBoxNightlyCharge.Name = "TextBoxNightlyCharge"
        Me.TextBoxNightlyCharge.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxNightlyCharge.TabIndex = 3
        '
        'TextBoxNights
        '
        Me.TextBoxNights.Location = New System.Drawing.Point(91, 37)
        Me.TextBoxNights.Name = "TextBoxNights"
        Me.TextBoxNights.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxNights.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nightly Charge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nights:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBoxMisc)
        Me.GroupBox2.Controls.Add(Me.TextBoxTelephone)
        Me.GroupBox2.Controls.Add(Me.TextBoxRoomService)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 127)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Charges"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Misc:"
        '
        'TextBoxMisc
        '
        Me.TextBoxMisc.Location = New System.Drawing.Point(158, 78)
        Me.TextBoxMisc.Name = "TextBoxMisc"
        Me.TextBoxMisc.Size = New System.Drawing.Size(116, 20)
        Me.TextBoxMisc.TabIndex = 4
        '
        'TextBoxTelephone
        '
        Me.TextBoxTelephone.Location = New System.Drawing.Point(158, 56)
        Me.TextBoxTelephone.Name = "TextBoxTelephone"
        Me.TextBoxTelephone.Size = New System.Drawing.Size(116, 20)
        Me.TextBoxTelephone.TabIndex = 3
        '
        'TextBoxRoomService
        '
        Me.TextBoxRoomService.Location = New System.Drawing.Point(158, 34)
        Me.TextBoxRoomService.Name = "TextBoxRoomService"
        Me.TextBoxRoomService.Size = New System.Drawing.Size(116, 20)
        Me.TextBoxRoomService.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Telephone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Room Service:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(258, 147)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(230, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Today's Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Room Charges:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Additional Charges:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Subtotal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Tax:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Charges:"
        '
        'LabelSubtotal
        '
        Me.LabelSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelSubtotal.Location = New System.Drawing.Point(135, 104)
        Me.LabelSubtotal.Name = "LabelSubtotal"
        Me.LabelSubtotal.Size = New System.Drawing.Size(222, 13)
        Me.LabelSubtotal.TabIndex = 7
        '
        'LabelTax
        '
        Me.LabelTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTax.Location = New System.Drawing.Point(135, 137)
        Me.LabelTax.Name = "LabelTax"
        Me.LabelTax.Size = New System.Drawing.Size(222, 13)
        Me.LabelTax.TabIndex = 8
        '
        'LabelTotalCharges
        '
        Me.LabelTotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotalCharges.Location = New System.Drawing.Point(135, 170)
        Me.LabelTotalCharges.Name = "LabelTotalCharges"
        Me.LabelTotalCharges.Size = New System.Drawing.Size(222, 16)
        Me.LabelTotalCharges.TabIndex = 9
        '
        'LabelAditionalCharges
        '
        Me.LabelAditionalCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelAditionalCharges.Location = New System.Drawing.Point(135, 72)
        Me.LabelAditionalCharges.Name = "LabelAditionalCharges"
        Me.LabelAditionalCharges.Size = New System.Drawing.Size(222, 14)
        Me.LabelAditionalCharges.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelRoomChanges)
        Me.GroupBox3.Controls.Add(Me.LabelAditionalCharges)
        Me.GroupBox3.Controls.Add(Me.LabelTotalCharges)
        Me.GroupBox3.Controls.Add(Me.LabelTax)
        Me.GroupBox3.Controls.Add(Me.LabelSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(261, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 215)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total charges"
        '
        'LabelRoomChanges
        '
        Me.LabelRoomChanges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelRoomChanges.Location = New System.Drawing.Point(135, 40)
        Me.LabelRoomChanges.Name = "LabelRoomChanges"
        Me.LabelRoomChanges.Size = New System.Drawing.Size(222, 14)
        Me.LabelRoomChanges.TabIndex = 11
        '
        'ButtCalculate
        '
        Me.ButtCalculate.Location = New System.Drawing.Point(79, 588)
        Me.ButtCalculate.Name = "ButtCalculate"
        Me.ButtCalculate.Size = New System.Drawing.Size(142, 23)
        Me.ButtCalculate.TabIndex = 6
        Me.ButtCalculate.Text = "Calculate Changes"
        Me.ButtCalculate.UseVisualStyleBackColor = True
        '
        'ButtClear
        '
        Me.ButtClear.Location = New System.Drawing.Point(275, 588)
        Me.ButtClear.Name = "ButtClear"
        Me.ButtClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtClear.TabIndex = 7
        Me.ButtClear.Text = "Clear"
        Me.ButtClear.UseVisualStyleBackColor = True
        '
        'ButtExit
        '
        Me.ButtExit.Location = New System.Drawing.Point(407, 588)
        Me.ButtExit.Name = "ButtExit"
        Me.ButtExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtExit.TabIndex = 8
        Me.ButtExit.Text = "Exit"
        Me.ButtExit.UseVisualStyleBackColor = True
        '
        'LabelTodaysDate
        '
        Me.LabelTodaysDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTodaysDate.Location = New System.Drawing.Point(326, 112)
        Me.LabelTodaysDate.Name = "LabelTodaysDate"
        Me.LabelTodaysDate.Size = New System.Drawing.Size(100, 23)
        Me.LabelTodaysDate.TabIndex = 9
        '
        'LabelTime
        '
        Me.LabelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTime.Location = New System.Drawing.Point(326, 146)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(100, 23)
        Me.LabelTime.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 628)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelTodaysDate)
        Me.Controls.Add(Me.ButtExit)
        Me.Controls.Add(Me.ButtClear)
        Me.Controls.Add(Me.ButtCalculate)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNights As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRoomService As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMisc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelSubtotal As System.Windows.Forms.Label
    Friend WithEvents LabelTax As System.Windows.Forms.Label
    Friend WithEvents LabelTotalCharges As System.Windows.Forms.Label
    Friend WithEvents LabelAditionalCharges As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelRoomChanges As System.Windows.Forms.Label
    Friend WithEvents ButtCalculate As System.Windows.Forms.Button
    Friend WithEvents ButtClear As System.Windows.Forms.Button
    Friend WithEvents ButtExit As System.Windows.Forms.Button
    Friend WithEvents LabelTodaysDate As System.Windows.Forms.Label
    Friend WithEvents LabelTime As System.Windows.Forms.Label

End Class
