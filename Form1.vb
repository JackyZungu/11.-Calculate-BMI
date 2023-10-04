Imports System.Security

Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim H As Double ' declaration of variable
        Dim W As Double
        Dim BMI As Double

        H = Val(txtHeight.Text)
        W = Val(txtWeight.Text)
        BMI = W / (H) ^ 2 ' BMI FORMULA

        txtBMI.Text = BMI

        If BMI < 18 Then
            txtComment.Text = "You are underweight"

        ElseIf 18 <= BMI And BMI < 26 Then

            txtComment.Text = "Your weigt is normal"

        Else

            txtComment.Text = "You are overweight"

        End If
        Me.BackColor = Color.DarkViolet


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Coral
        CenterToParent()
    End Sub
End Class
