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
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Provar = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(66, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 0
        Button1.Text = "Iniciar Joc"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(619, 32)
        Label1.TabIndex = 1
        Label1.Text = "Introdueix un numero del 1 al 10 que creus que ha sortit"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(66, 233)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(619, 39)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(100, 363)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 32)
        Label2.TabIndex = 3
        Label2.Text = "Numero d'Intents"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(438, 352)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 32)
        Label3.TabIndex = 4
        Label3.Text = "0"
        ' 
        ' Provar
        ' 
        Provar.Location = New Point(536, 300)
        Provar.Name = "Provar"
        Provar.Size = New Size(150, 46)
        Provar.TabIndex = 5
        Provar.Text = "Provar"
        Provar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Provar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Provar As Button

End Class
