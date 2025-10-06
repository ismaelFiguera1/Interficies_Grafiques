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
        Suma = New Button()
        Surt = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Suma
        ' 
        Suma.Location = New Point(48, 34)
        Suma.Name = "Suma"
        Suma.Size = New Size(150, 46)
        Suma.TabIndex = 0
        Suma.Text = "Suma"
        Suma.UseVisualStyleBackColor = True
        ' 
        ' Surt
        ' 
        Surt.Location = New Point(48, 148)
        Surt.Name = "Surt"
        Surt.Size = New Size(150, 46)
        Surt.TabIndex = 1
        Surt.Text = "Sortir"
        Surt.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(320, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 32)
        Label1.TabIndex = 2
        Label1.Text = "Numero 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(320, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 32)
        Label2.TabIndex = 3
        Label2.Text = "Numero 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(320, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 32)
        Label3.TabIndex = 4
        Label3.Text = "Resultat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(629, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 32)
        Label4.TabIndex = 5
        Label4.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(629, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 32)
        Label5.TabIndex = 6
        Label5.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(629, 279)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 32)
        Label6.TabIndex = 7
        Label6.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(569, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(154, 32)
        Label7.TabIndex = 8
        Label7.Text = "______________"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Surt)
        Controls.Add(Suma)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Suma As Button
    Friend WithEvents Surt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

End Class
