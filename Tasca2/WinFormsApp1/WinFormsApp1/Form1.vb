Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1

    Dim intCompteTotal As Integer = 0
    Dim intCompteGuanyades As Integer = 0

    Private Sub Sortir_Click(sender As Object, e As EventArgs) Handles Sortir.Click
        Application.Exit()
    End Sub

    Private Sub Tirar_Click(sender As Object, e As EventArgs) Handles Tirar.Click

        intCompteTotal = intCompteTotal + 1


        If Imatge.Visible Then
            Imatge.Visible = False
            Label1.Text = 0
            Label2.Text = 0
            Label3.Text = 0
        Else
            Dim rand As New Random()
            Dim numero As Integer = rand.Next(1, 11)
            Dim numero1 As Integer = rand.Next(1, 11)
            Dim numero2 As Integer = rand.Next(1, 11)

            Label1.Text = numero
            Label2.Text = numero1
            Label3.Text = numero2

            If numero = 7 Or numero1 = 7 Or numero2 = 7 Then
                Imatge.Visible = True
                intCompteGuanyades = intCompteGuanyades + 1
            End If




            'Label1.Text = ran

        End If

        numConteig.Text = intCompteTotal
        numWin.Text = intCompteGuanyades


    End Sub

    Private Sub Calcul_Click(sender As Object, e As EventArgs) Handles Calcul.Click
        Dim percentatge As Double = (intCompteGuanyades / intCompteTotal) * 100
        MessageBox.Show(percentatge)

    End Sub
End Class
