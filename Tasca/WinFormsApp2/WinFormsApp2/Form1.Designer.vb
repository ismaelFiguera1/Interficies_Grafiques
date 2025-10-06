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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label1.Location = New Point(297, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 25)
        Label1.TabIndex = 0
        Label1.Text = "El meu primer formulari"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(263, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Escriu aqui"
        TextBox1.Size = New Size(280, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(263, 113)
        Button1.Name = "Button1"
        Button1.Size = New Size(280, 23)
        Button1.TabIndex = 2
        Button1.Text = "Mostrar el contingut de la caixa de text"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(263, 183)
        Button2.Name = "Button2"
        Button2.Size = New Size(280, 23)
        Button2.TabIndex = 3
        Button2.Text = "Canviar el color del formulari"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(263, 259)
        Button3.Name = "Button3"
        Button3.Size = New Size(280, 23)
        Button3.TabIndex = 4
        Button3.Text = "Canviar el color de lletra de la caixa de text"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
