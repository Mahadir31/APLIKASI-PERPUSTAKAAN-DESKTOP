Imports System.Runtime.Serialization

Public Class SplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value += 1
        Label4.Text = Convert.ToString(ProgressBar1.Value) + "%"
        If ProgressBar1.Value = 10 Then
            Label8.Text = "Loading."
        ElseIf ProgressBar1.Value = 20 Then
            Label8.Text = "Loading.."
        ElseIf ProgressBar1.Value = 30 Then
            Label8.Text = "Please Wait For The Configuratin"
        ElseIf ProgressBar1.Value = 40 Then
            Label8.Text = "Please Wait For The Configuratin"
        ElseIf ProgressBar1.Value = 50 Then
            Label8.Text = "Please Wait For The Configuratin"
        ElseIf ProgressBar1.Value = 60 Then
            Label8.Text = "Loading.."
        ElseIf ProgressBar1.Value = 70 Then
            Label8.Text = "Loading..."
        ElseIf ProgressBar1.Value = 80 Then
            Label8.Text = "Connection To Database"
        ElseIf ProgressBar1.Value = 90 Then
            Label8.Text = "Success"

        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            FormMenuUtama.ShowDialog()
        End If
    End Sub
End Class