<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Tirar = New Button()
        Sortir = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Imatge = New PictureBox()
        Label4 = New Label()
        TiradesTotals = New Label()
        Win = New Label()
        numConteig = New Label()
        numWin = New Label()
        Calcul = New Button()
        CType(Imatge, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tirar
        ' 
        Tirar.Location = New Point(145, 77)
        Tirar.Margin = New Padding(6)
        Tirar.Name = "Tirar"
        Tirar.Size = New Size(139, 49)
        Tirar.TabIndex = 0
        Tirar.Text = "Tirar"
        Tirar.UseVisualStyleBackColor = True
        ' 
        ' Sortir
        ' 
        Sortir.Location = New Point(145, 318)
        Sortir.Margin = New Padding(6)
        Sortir.Name = "Sortir"
        Sortir.Size = New Size(139, 49)
        Sortir.TabIndex = 1
        Sortir.Text = "Sortir"
        Sortir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        Label1.Location = New Point(643, 94)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 89)
        Label1.TabIndex = 2
        Label1.Text = "0"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        Label2.Location = New Point(908, 94)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 89)
        Label2.TabIndex = 3
        Label2.Text = "0"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        Label3.Location = New Point(1170, 94)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 89)
        Label3.TabIndex = 4
        Label3.Text = "0"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Imatge
        ' 
        Imatge.Image = My.Resources.Resources.medalla
        Imatge.Location = New Point(696, 258)
        Imatge.Margin = New Padding(6)
        Imatge.Name = "Imatge"
        Imatge.Size = New Size(672, 599)
        Imatge.SizeMode = PictureBoxSizeMode.StretchImage
        Imatge.TabIndex = 5
        Imatge.TabStop = False
        Imatge.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 18F, FontStyle.Bold)
        Label4.ForeColor = Color.Purple
        Label4.Location = New Point(22, 612)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(452, 56)
        Label4.TabIndex = 6
        Label4.Text = "Escurabutxaques7"
        ' 
        ' TiradesTotals
        ' 
        TiradesTotals.AutoSize = True
        TiradesTotals.Location = New Point(43, 758)
        TiradesTotals.Name = "TiradesTotals"
        TiradesTotals.Size = New Size(150, 32)
        TiradesTotals.TabIndex = 7
        TiradesTotals.Text = "Cops Tirades"
        ' 
        ' Win
        ' 
        Win.AutoSize = True
        Win.Location = New Point(43, 844)
        Win.Name = "Win"
        Win.Size = New Size(225, 32)
        Win.TabIndex = 8
        Win.Text = "Vegades guanyades"
        ' 
        ' numConteig
        ' 
        numConteig.AutoSize = True
        numConteig.Location = New Point(322, 758)
        numConteig.Name = "numConteig"
        numConteig.Size = New Size(27, 32)
        numConteig.TabIndex = 9
        numConteig.Text = "0"
        ' 
        ' numWin
        ' 
        numWin.AutoSize = True
        numWin.Location = New Point(321, 844)
        numWin.Name = "numWin"
        numWin.Size = New Size(27, 32)
        numWin.TabIndex = 10
        numWin.Text = "0"
        ' 
        ' Calcul
        ' 
        Calcul.Location = New Point(145, 484)
        Calcul.Name = "Calcul"
        Calcul.Size = New Size(150, 46)
        Calcul.TabIndex = 11
        Calcul.Text = "Calcular %"
        Calcul.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(Calcul)
        Controls.Add(numWin)
        Controls.Add(numConteig)
        Controls.Add(Win)
        Controls.Add(TiradesTotals)
        Controls.Add(Label4)
        Controls.Add(Imatge)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Sortir)
        Controls.Add(Tirar)
        Margin = New Padding(6)
        Name = "Form1"
        Text = "Form1"
        CType(Imatge, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tirar As Button
    Friend WithEvents Sortir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Imatge As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TiradesTotals As Label
    Friend WithEvents Win As Label
    Friend WithEvents numConteig As Label
    Friend WithEvents numWin As Label
    Friend WithEvents Calcul As Button

End Class
