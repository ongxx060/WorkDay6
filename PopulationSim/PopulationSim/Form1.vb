Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim curYear As Integer
        Dim curPop As Double

        curYear = 2012
        curPop = 7000

        Do While (curPop > 6)
            curPop = curPop / 2
            curYear -= 50

        Loop

        MessageBox.Show("The year is " & curYear, "Error")

    End Sub
End Class
