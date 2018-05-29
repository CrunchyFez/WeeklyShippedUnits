'**********************************************************************************/
'   Name:           Soban Farhan
'   Program:        WeeklyUnitShipped
'   Date:           5 Feb, 2018
'   Discription:    We are creating a program that will ask for user input for
'                   the ammount of units shipped in a day for a week and providing
'                   them with an overallAverage of units shipped
'
'\**********************************************************************************

Public Class frmWeeklyUnitShipped

    'Delaring all the boolean need for this program
    Dim firstData As Boolean = True
    Dim secondData As Boolean = False
    Dim thirdData As Boolean = False

    'Delaring all the constent need for this program
    Const MANIMUM_SHIPPED_UNITS As Double = 0
    Const MAXIMUM_SHIPPED_UNITS As Double = 1000
    Const NUMBER_OF_DAYS As Double = 7
    Const THREE_WEEK_DATA As Double = 21



    'Delaring all the string need for this program
    Dim UnitArray(0) As String
    Dim UnitInput As String = String.Empty

    'Delaring all the integers need for this program
    Dim ShippedUnits As Integer
    Dim unitStored As Integer
    Dim daysCounter As Integer = 1
    Dim dataEntry As Integer = 1

    'Delaring all the doubles need for this program
    Dim overallAverage As Double
    Dim averagePerEmployee As Double

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Using the variable to contain our input text 
        UnitInput = tbUnits.Text

        'Doing a validation if the value is integer
        If Not Integer.TryParse(UnitInput, ShippedUnits) Then

            'Error message
            MessageBox.Show("Please enter a number for units.")

            'Clear and ask for new input
            tbUnits.Clear()
            tbUnits.Focus()
            tbUnits.SelectionStart = 0

            'Doing a validation if the value is between 1 and 1000
        ElseIf (ShippedUnits < MANIMUM_SHIPPED_UNITS OrElse ShippedUnits > MAXIMUM_SHIPPED_UNITS) Then

            'Error message
            MessageBox.Show("Please enter a number between 0 and 1000")

            'Clear and ask for new input
            tbUnits.Clear()
            tbUnits.Focus()
        Else

            'Check if first set of data can be entered
            If (firstData = True) Then
                'Doing a loop for desire amount of input
                For unitStored As Integer = 0 To UnitArray.Length - 1

                    'Increasing our day counter by 1 every time
                    daysCounter = daysCounter + 1
                    dataEntry = dataEntry + 1

                    'Storing our array and outputting it to the user 
                    UnitArray(unitStored) = tbUnits.Text
                    tbUnitStored1.Text += UnitArray(unitStored).ToString & vbCrLf

                    'Clear the old text from user and asking them for the new one
                    tbUnits.Clear()
                    tbUnits.Focus()

                    'Showing which day's value they are about to enter
                    lbDays.Text = "Day " + daysCounter.ToString

                    'Storing all the entered values for later
                    averagePerEmployee = averagePerEmployee + UnitArray(unitStored)
                    overallAverage = overallAverage + UnitArray(unitStored)
                Next

                'Check if second set of data can be entered
            ElseIf (secondData = True) Then

                For unitStored As Integer = 0 To UnitArray.Length - 1

                    'Increasing our day counter by 1 every time
                    daysCounter = daysCounter + 1
                    dataEntry = dataEntry + 1

                    'Storing our array and outputting it to the user 
                    UnitArray(unitStored) = tbUnits.Text
                    tbUnitStored2.Text += UnitArray(unitStored).ToString & vbCrLf

                    'Clear the old text from user and asking them for the new one
                    tbUnits.Clear()
                    tbUnits.Focus()

                    'Showing which day's value they are about to enter
                    lbDays.Text = "Day " + daysCounter.ToString

                    'Storing all the entered values for later
                    averagePerEmployee = averagePerEmployee + UnitArray(unitStored)
                    overallAverage = overallAverage + UnitArray(unitStored)

                Next

                'Check if third set of data can be entered
            ElseIf (thirdData = True) Then

            For unitStored As Integer = 0 To UnitArray.Length - 1

                    'Increasing our day counter by 1 every time
                    daysCounter = daysCounter + 1
                    dataEntry = dataEntry + 1

                    'Storing our array and outputting it to the user 
                    UnitArray(unitStored) = tbUnits.Text
                    tbUnitStored3.Text += UnitArray(unitStored).ToString & vbCrLf

                    'Clear the old text from user and asking them for the new one
                    tbUnits.Clear()
                    tbUnits.Focus()

                    'Showing which day's value they are about to enter
                    lbDays.Text = "Day " + daysCounter.ToString

                    'Storing all the entered values for later
                    averagePerEmployee = averagePerEmployee + UnitArray(unitStored)
                    overallAverage = overallAverage + UnitArray(unitStored)

                Next

            End If

            If (dataEntry = 8) Then

                'Changing the label text to be regular or bold
                lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
                lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Bold)

                'Show average for 1st employee and reset it for next set of data
                averagePerEmployee = averagePerEmployee / NUMBER_OF_DAYS
                lbEmployeeAverage1.Text = "Average: " + averagePerEmployee.ToString("n2")
                averagePerEmployee = 0

                'Disable 1st and enable 2nd data entry section  
                firstData = False
                secondData = True

                'Reset day counter and the label
                lbDays.Text = "Day 1"
                daysCounter = 1


            ElseIf (dataEntry = 15) Then

                'Changing the label text to be regular or bold
                lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Regular)
                lbEmployee3.Font = New Font(lbEmployee3.Font, FontStyle.Bold)

                'Show average for 2nd employee and reset it for next set of data
                averagePerEmployee = averagePerEmployee / NUMBER_OF_DAYS
                lbEmployeeAverage2.Text = "Average: " + averagePerEmployee.ToString("n2")
                averagePerEmployee = 0

                'Disable 1st and 2nd and enable 3rd data entry section 
                firstData = False
                secondData = False
                thirdData = True

                'Reset day counter and the label
                lbDays.Text = "Day 1"
                daysCounter = 1

            ElseIf (dataEntry = 22) Then

                'Changing the label text to be regular 
                lbEmployee3.Font = New Font(lbEmployee3.Font, FontStyle.Regular)

                'Show average for 3rd employee with the overall average
                averagePerEmployee = averagePerEmployee / NUMBER_OF_DAYS
                lbEmployeeAverage3.Text = "Average: " + averagePerEmployee.ToString("n2")

                'Doing the overallAverage of the input and rounding it
                overallAverage = overallAverage / THREE_WEEK_DATA

                'Displaying the overallAverage to the user
                lbAverage.Text = "Average per day: " + overallAverage.ToString("n2")
                'Clearing the day label and unit input 
                lbDays.Text = "Done"
                tbUnits.Clear()

                'Disabling the Enter and unit input for any extra values
                tbUnits.Enabled = False
                btnEnter.Enabled = False

            Else
            End If


        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exit the form
        Application.Exit()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Changing the label text to be bold
        lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Bold)

        'Clear the values stored in the array and reseting the overallAverage of values
        Array.Clear(UnitArray, 0, UnitArray.Length)
        overallAverage = 0
        averagePerEmployee = 0

        ''Clearing the overallAverage text and unit input 
        tbUnits.Clear()
        lbAverage.Text = ""
        lbEmployeeAverage1.Text = ""
        lbEmployeeAverage2.Text = ""
        lbEmployeeAverage3.Text = ""

        'Enabling the locked input box and enter button
        tbUnits.Enabled = True
        btnEnter.Enabled = True

        'Enable 1st and disable 2nd and 3rd data entry section 
        firstData = True
        secondData = False
        thirdData = False

        'Resetting the day counter to 1
        daysCounter = 1
        dataEntry = 1
        lbDays.Text = "Day " + daysCounter.ToString

        'Clearing the values stored to be displayed to the user 
        tbUnitStored1.Clear()
        tbUnitStored2.Clear()
        tbUnitStored3.Clear()

        'Focus on input 
        tbUnits.Focus()

    End Sub
End Class
