﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(34, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(382, 37)
        Label1.TabIndex = 0
        Label1.Text = "Quan es va arrivar a la lluna?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Neil_Armstrong_pose
        PictureBox1.Location = New Point(536, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(210, 258)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(34, 273)
        Label2.Name = "Label2"
        Label2.Size = New Size(432, 28)
        Label2.TabIndex = 2
        Label2.Text = "Neil Armstrong va arrivar el 20 de Juliol de 1969"
        Label2.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(192, 369)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Solucio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(592, 369)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "Sortir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
