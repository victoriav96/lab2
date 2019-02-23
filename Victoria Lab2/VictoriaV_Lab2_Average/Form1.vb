'Name: Victoria Valdron'
'Lab 2 - Average Numbers'
'NETD 2202-01'
'2019-02-08'

Option Strict On

Public Class frmMain
    'variables'
    Dim course(5) As Double
    Dim average As Double



    Const TOTAL_COURSES As Integer = 6
    Const MAX_GRADE As Integer = 100
    Const MIN_GRADE As Integer = 0


    'validate user input'
    Private Function Valid(ByVal userInput As String, ByRef control As TextBox) As Double
        Dim grade As Double


        If Not Double.TryParse(userInput, grade) Then
            ThrowError("Input must be numeric, try again.", control)
            Return Nothing

        ElseIf grade < MIN_GRADE Or grade > MAX_GRADE Then
            ThrowError("Error! Grades can only be between 0 and 100.", control)
            Return Nothing

        Else

            Return grade

        End If

    End Function

    'throw error message and change focus back to the control in question'
    Private Sub ThrowError(ByVal message As String, ByRef control As TextBox)
        'outputs error messages to the bottom textbox'
        txtErrors.Text = message

        control.Select()

        control.SelectAll()


    End Sub
    'function for the letter that corrisponds to the user input (grade)'
    Private Sub DispLGrade(ByVal grade As Double, ByRef control As Label)

        Select Case grade
            Case 90 To 100
                control.Text = "A+"
            Case 85 To 89
                control.Text = "A"
            Case 80 To 84
                control.Text = "A-"
            Case 77 To 79
                control.Text = "B+"
            Case 73 To 76
                control.Text = "B"
            Case 70 To 72
                control.Text = "B-"
            Case 67 To 69
                control.Text = "C+"
            Case 63 To 66
                control.Text = "C"
            Case 60 To 62
                control.Text = "C-"
            Case 57 To 59
                control.Text = "D+"
            Case 53 To 56
                control.Text = "D"
            Case 50 To 52
                control.Text = "D-"
            Case 0 To 49
                control.Text = "F"

        End Select

    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click


        average = Math.Round(course.Sum / 6, 1)

        lblSemesterNum.Text = average.ToString

        DispLGrade(average, lblSemesterLetter)



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtCourse1.Clear()
        txtCourse2.Clear()
        txtCourse3.Clear()
        txtCourse4.Clear()
        txtCourse5.Clear()
        txtCourse6.Clear()
        lblSemesterNum.Text = ""
        lblOutput1.Text = ""
        lblOutput2.Text = ""
        lblOutput3.Text = ""
        lblOutput4.Text = ""
        lblOutput5.Text = ""
        lblOutput6.Text = ""
        lblSemesterLetter.Text = ""




    End Sub

    Private Sub txtCourse1_Leave(sender As Object, e As EventArgs) Handles txtCourse1.Leave
        Dim grade As Double = Valid(txtCourse1.Text, txtCourse1)
        'checks to see if the grade variable has nothing stored in it. If there is, we want to place it into the 'grade' array'
        If Not IsNothing(grade) Then
            course(0) = grade

            DispLGrade(grade, lblOutput1)
        End If

    End Sub

    Private Sub txtCourse2_Leave(sender As Object, e As EventArgs) Handles txtCourse2.Leave
        Dim grade As Double = Valid(txtCourse2.Text, txtCourse2)
        'checks to see if the grade variable has nothing stored in it. If there is, we want to place it into the 'grade' array'
        If Not IsNothing(grade) Then
            course(1) = grade

            DispLGrade(grade, lblOutput2)
        End If
    End Sub

    Private Sub txtCourse3_Leave(sender As Object, e As EventArgs) Handles txtCourse3.Leave
        Dim grade As Double = Valid(txtCourse3.Text, txtCourse3)
        'checks to see if the grade variable has nothing stored in it. If there is, we want to place it into the 'grade' array'
        If Not IsNothing(grade) Then
            course(2) = grade

            DispLGrade(grade, lblOutput3)
        End If
    End Sub

    Private Sub txtCourse4_Leave(sender As Object, e As EventArgs) Handles txtCourse4.Leave
        Dim grade As Double = Valid(txtCourse4.Text, txtCourse4)
        'checks to see if the grade variable has nothing stored in it. If there is, we want to place it into the 'grade' array'
        If Not IsNothing(grade) Then
            course(3) = grade

            DispLGrade(grade, lblOutput4)
        End If
    End Sub

    Private Sub txtCourse5_Leave(sender As Object, e As EventArgs) Handles txtCourse5.Leave
        Dim grade As Double = Valid(txtCourse5.Text, txtCourse5)
        'checks to see if the grade variable has nothing stored in it. If there is, we want to place it into the 'grade' array'
        If Not IsNothing(grade) Then
            course(4) = grade

            DispLGrade(grade, lblOutput5)
        End If
    End Sub

    Private Sub txtCourse6_Leave(sender As Object, e As EventArgs) Handles txtCourse6.Leave
        Dim grade As Double = Valid(txtCourse6.Text, txtCourse6)
        'checks to see if the grade variable has nothing stored in it. If there is, we want to place it into the 'grade' array'
        If Not IsNothing(grade) Then
            course(5) = grade

            DispLGrade(grade, lblOutput6)
        End If
    End Sub


End Class
