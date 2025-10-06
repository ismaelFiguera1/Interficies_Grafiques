Public Class Form1
    Private Sub Surt_Click(sender As Object, e As EventArgs) Handles Surt.Click
        Application.Exit()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles Suma.Click
        Dim entrada As String
        entrada = InputBox("Introdueix el 1r numero:", "Demanar numero")

        Dim entrada1 As String
        entrada1 = InputBox("Introdueix el 2n numero:", "Demanar numero")

        Dim resultat As Double = CDbl(entrada) + CDbl(entrada1)



        Label6.Text = resultat
        Label4.Text = entrada
        Label5.Text = entrada1
    End Sub
End Class
