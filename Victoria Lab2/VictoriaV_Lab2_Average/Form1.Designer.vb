<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtErrors = New System.Windows.Forms.TextBox()
        Me.lblSemesterNum = New System.Windows.Forms.Label()
        Me.lblSemesterLetter = New System.Windows.Forms.Label()
        Me.lblOutput6 = New System.Windows.Forms.Label()
        Me.lblOutput5 = New System.Windows.Forms.Label()
        Me.lblOutput4 = New System.Windows.Forms.Label()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.txtCourse6 = New System.Windows.Forms.TextBox()
        Me.txtCourse5 = New System.Windows.Forms.TextBox()
        Me.txtCourse4 = New System.Windows.Forms.TextBox()
        Me.txtCourse3 = New System.Windows.Forms.TextBox()
        Me.txtCourse2 = New System.Windows.Forms.TextBox()
        Me.txtCourse1 = New System.Windows.Forms.TextBox()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(321, 498)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 39)
        Me.btnExit.TabIndex = 49
        Me.btnExit.Text = "Exit"
        Me.ToolTip.SetToolTip(Me.btnExit, "Close Application?")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(181, 498)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 39)
        Me.btnReset.TabIndex = 48
        Me.btnReset.Text = "Reset"
        Me.ToolTip.SetToolTip(Me.btnReset, "Reset data for future entry.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(42, 498)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(120, 39)
        Me.btnCalc.TabIndex = 47
        Me.btnCalc.Text = "Calculate"
        Me.ToolTip.SetToolTip(Me.btnCalc, "Calculates average of grades.")
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtErrors
        '
        Me.txtErrors.AllowDrop = True
        Me.txtErrors.Enabled = False
        Me.txtErrors.Location = New System.Drawing.Point(42, 284)
        Me.txtErrors.Multiline = True
        Me.txtErrors.Name = "txtErrors"
        Me.txtErrors.ReadOnly = True
        Me.txtErrors.Size = New System.Drawing.Size(399, 181)
        Me.txtErrors.TabIndex = 46
        '
        'lblSemesterNum
        '
        Me.lblSemesterNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterNum.Location = New System.Drawing.Point(106, 240)
        Me.lblSemesterNum.Name = "lblSemesterNum"
        Me.lblSemesterNum.Size = New System.Drawing.Size(131, 22)
        Me.lblSemesterNum.TabIndex = 45
        Me.lblSemesterNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemesterLetter
        '
        Me.lblSemesterLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterLetter.Location = New System.Drawing.Point(290, 240)
        Me.lblSemesterLetter.Name = "lblSemesterLetter"
        Me.lblSemesterLetter.Size = New System.Drawing.Size(131, 22)
        Me.lblSemesterLetter.TabIndex = 44
        Me.lblSemesterLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput6
        '
        Me.lblOutput6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput6.Location = New System.Drawing.Point(290, 203)
        Me.lblOutput6.Name = "lblOutput6"
        Me.lblOutput6.Size = New System.Drawing.Size(131, 24)
        Me.lblOutput6.TabIndex = 43
        Me.lblOutput6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput5
        '
        Me.lblOutput5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput5.Location = New System.Drawing.Point(290, 161)
        Me.lblOutput5.Name = "lblOutput5"
        Me.lblOutput5.Size = New System.Drawing.Size(131, 22)
        Me.lblOutput5.TabIndex = 42
        Me.lblOutput5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput4
        '
        Me.lblOutput4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput4.Location = New System.Drawing.Point(290, 124)
        Me.lblOutput4.Name = "lblOutput4"
        Me.lblOutput4.Size = New System.Drawing.Size(131, 22)
        Me.lblOutput4.TabIndex = 41
        Me.lblOutput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput3
        '
        Me.lblOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput3.Location = New System.Drawing.Point(290, 86)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(131, 22)
        Me.lblOutput3.TabIndex = 40
        Me.lblOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput2
        '
        Me.lblOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput2.Location = New System.Drawing.Point(290, 51)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(131, 22)
        Me.lblOutput2.TabIndex = 39
        Me.lblOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput1
        '
        Me.lblOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput1.Location = New System.Drawing.Point(290, 8)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(131, 22)
        Me.lblOutput1.TabIndex = 38
        Me.lblOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(15, 240)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(72, 17)
        Me.lblSemester.TabIndex = 37
        Me.lblSemester.Text = "Semester:"
        '
        'txtCourse6
        '
        Me.txtCourse6.Location = New System.Drawing.Point(106, 201)
        Me.txtCourse6.Name = "txtCourse6"
        Me.txtCourse6.Size = New System.Drawing.Size(129, 22)
        Me.txtCourse6.TabIndex = 36
        Me.txtCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse5
        '
        Me.txtCourse5.Location = New System.Drawing.Point(106, 161)
        Me.txtCourse5.Name = "txtCourse5"
        Me.txtCourse5.Size = New System.Drawing.Size(127, 22)
        Me.txtCourse5.TabIndex = 35
        Me.txtCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse4
        '
        Me.txtCourse4.Location = New System.Drawing.Point(104, 120)
        Me.txtCourse4.Name = "txtCourse4"
        Me.txtCourse4.Size = New System.Drawing.Size(129, 22)
        Me.txtCourse4.TabIndex = 34
        Me.txtCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse3
        '
        Me.txtCourse3.Location = New System.Drawing.Point(104, 81)
        Me.txtCourse3.Name = "txtCourse3"
        Me.txtCourse3.Size = New System.Drawing.Size(130, 22)
        Me.txtCourse3.TabIndex = 33
        Me.txtCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse2
        '
        Me.txtCourse2.Location = New System.Drawing.Point(103, 47)
        Me.txtCourse2.Name = "txtCourse2"
        Me.txtCourse2.Size = New System.Drawing.Size(131, 22)
        Me.txtCourse2.TabIndex = 32
        Me.txtCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse1
        '
        Me.txtCourse1.Location = New System.Drawing.Point(103, 8)
        Me.txtCourse1.Name = "txtCourse1"
        Me.txtCourse1.Size = New System.Drawing.Size(131, 22)
        Me.txtCourse1.TabIndex = 31
        Me.txtCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourse6
        '
        Me.lblCourse6.AutoSize = True
        Me.lblCourse6.Location = New System.Drawing.Point(15, 201)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse6.TabIndex = 30
        Me.lblCourse6.Text = "Course 6:"
        '
        'lblCourse5
        '
        Me.lblCourse5.AutoSize = True
        Me.lblCourse5.Location = New System.Drawing.Point(15, 164)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse5.TabIndex = 29
        Me.lblCourse5.Text = "Course 5:"
        '
        'lblCourse4
        '
        Me.lblCourse4.AutoSize = True
        Me.lblCourse4.Location = New System.Drawing.Point(15, 123)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse4.TabIndex = 28
        Me.lblCourse4.Text = "Course 4:"
        '
        'lblCourse3
        '
        Me.lblCourse3.AutoSize = True
        Me.lblCourse3.Location = New System.Drawing.Point(15, 84)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse3.TabIndex = 27
        Me.lblCourse3.Text = "Course 3:"
        '
        'lblCourse2
        '
        Me.lblCourse2.AutoSize = True
        Me.lblCourse2.Location = New System.Drawing.Point(15, 47)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse2.TabIndex = 26
        Me.lblCourse2.Text = "Course 2:"
        '
        'lblCourse1
        '
        Me.lblCourse1.Location = New System.Drawing.Point(18, 11)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(69, 17)
        Me.lblCourse1.TabIndex = 25
        Me.lblCourse1.Text = "Course 1:"
        Me.lblCourse1.UseCompatibleTextRendering = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(479, 545)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtErrors)
        Me.Controls.Add(Me.lblSemesterNum)
        Me.Controls.Add(Me.lblSemesterLetter)
        Me.Controls.Add(Me.lblOutput6)
        Me.Controls.Add(Me.lblOutput5)
        Me.Controls.Add(Me.lblOutput4)
        Me.Controls.Add(Me.lblOutput3)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblOutput1)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.txtCourse6)
        Me.Controls.Add(Me.txtCourse5)
        Me.Controls.Add(Me.txtCourse4)
        Me.Controls.Add(Me.txtCourse3)
        Me.Controls.Add(Me.txtCourse2)
        Me.Controls.Add(Me.txtCourse1)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblCourse1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtErrors As TextBox
    Friend WithEvents lblSemesterNum As Label
    Friend WithEvents lblSemesterLetter As Label
    Friend WithEvents lblOutput6 As Label
    Friend WithEvents lblOutput5 As Label
    Friend WithEvents lblOutput4 As Label
    Friend WithEvents lblOutput3 As Label
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents lblOutput1 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents txtCourse6 As TextBox
    Friend WithEvents txtCourse5 As TextBox
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents ToolTip As ToolTip
End Class
