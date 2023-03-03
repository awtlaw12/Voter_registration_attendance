Public Class Form1
    Private Sub btnCheckStatus_Click(sender As Object, e As EventArgs) Handles btnCheckStatus.Click
        Const VoteMsg As String = "You can vote."
        Const RegisterMsg As String = "You need to register before you can vote."
        Const TooYoungMsg As String = "You are too young to Vote."
        Dim Age As Integer
        Dim registered As String = String.Empty
        Integer.TryParse(txtAge.Text, Age)
        registered = txtRegistered.Text.ToUpper
        If Age >= 18 Then
            If registered = "Y" Then
                txtResults.Text = VoteMsg
            Else
                txtResults.Text = RegisterMsg
            End If
        Else
            txtResults.Text = TooYoungMsg
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Display a message box to confirm whether the user wants to exit
        Dim msgResponse As MsgBoxResult, Cancel
        msgResponse = MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "Confirm Exit")

        ' If the user clicks No, cancel the form closing event
        If msgResponse = vbNo Then
            Cancel = True
        ElseIf msgResponse = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
