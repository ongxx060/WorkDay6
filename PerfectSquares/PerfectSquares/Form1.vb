Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim a As Integer

        Do While (a <= 10)
            lstResult.Items.Add("number is" & a ^ 2)
            a = a + 1
        Loop

    End Sub

    Private Sub lstResult_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstResult.SelectedIndexChanged

    End Sub
End Class
