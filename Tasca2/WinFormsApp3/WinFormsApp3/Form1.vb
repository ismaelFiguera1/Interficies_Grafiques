Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1

    Dim numIntents As Integer = 3
    Dim rand As New Random()
    Dim numAleatori As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        numAleatori = rand.Next(1, 3)
        numIntents = 3
        Label3.Text = numIntents
    End Sub

    Private Sub Provar_Click(sender As Object, e As EventArgs) Handles Provar.Click

        If numAleatori = 0 Then
            MessageBox.Show("Tens que iniciar el joc")
            Application.Exit()
            Return
        End If


        If numAleatori = TextBox1.Text Then
            MessageBox.Show("L'has encertat")
            numIntents = 3
        Else
            numIntents = numIntents - 1
        End If
        Label3.Text = numIntents
        TextBox1.Text = ""
        If numIntents = 0 Then
            MessageBox.Show("Has arribat al limit d'intents")
            Application.Exit()
        End If


    End Sub



End Class
