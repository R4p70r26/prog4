﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentEntretenimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EntretenimpersonajePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnOpcion4 = New System.Windows.Forms.Button()
        Me.BtnOpcion3 = New System.Windows.Forms.Button()
        Me.BtnOpcion2 = New System.Windows.Forms.Button()
        Me.BtnOpcion1 = New System.Windows.Forms.Button()
        Me.TextoPregunta = New System.Windows.Forms.RichTextBox()
        CType(Me.EntretenimpersonajePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EntretenimpersonajePictureBox1
        '
        Me.EntretenimpersonajePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EntretenimpersonajePictureBox1.Image = Global.PreguntadosPC.My.Resources.Resources.Preguntas
        Me.EntretenimpersonajePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.EntretenimpersonajePictureBox1.Name = "EntretenimpersonajePictureBox1"
        Me.EntretenimpersonajePictureBox1.Size = New System.Drawing.Size(560, 501)
        Me.EntretenimpersonajePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EntretenimpersonajePictureBox1.TabIndex = 2
        Me.EntretenimpersonajePictureBox1.TabStop = False
        '
        'BtnOpcion4
        '
        Me.BtnOpcion4.BackColor = System.Drawing.Color.White
        Me.BtnOpcion4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion4.Location = New System.Drawing.Point(12, 406)
        Me.BtnOpcion4.Name = "BtnOpcion4"
        Me.BtnOpcion4.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion4.TabIndex = 14
        Me.BtnOpcion4.Text = "Button4"
        Me.BtnOpcion4.UseVisualStyleBackColor = False
        '
        'BtnOpcion3
        '
        Me.BtnOpcion3.BackColor = System.Drawing.Color.White
        Me.BtnOpcion3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion3.Location = New System.Drawing.Point(12, 362)
        Me.BtnOpcion3.Name = "BtnOpcion3"
        Me.BtnOpcion3.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion3.TabIndex = 13
        Me.BtnOpcion3.Text = "Button3"
        Me.BtnOpcion3.UseVisualStyleBackColor = False
        '
        'BtnOpcion2
        '
        Me.BtnOpcion2.BackColor = System.Drawing.Color.White
        Me.BtnOpcion2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion2.Location = New System.Drawing.Point(12, 318)
        Me.BtnOpcion2.Name = "BtnOpcion2"
        Me.BtnOpcion2.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion2.TabIndex = 12
        Me.BtnOpcion2.Text = "Button2"
        Me.BtnOpcion2.UseVisualStyleBackColor = False
        '
        'BtnOpcion1
        '
        Me.BtnOpcion1.BackColor = System.Drawing.Color.White
        Me.BtnOpcion1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion1.Location = New System.Drawing.Point(12, 274)
        Me.BtnOpcion1.Name = "BtnOpcion1"
        Me.BtnOpcion1.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion1.TabIndex = 11
        Me.BtnOpcion1.Text = "Button1"
        Me.BtnOpcion1.UseVisualStyleBackColor = False
        '
        'TextoPregunta
        '
        Me.TextoPregunta.BackColor = System.Drawing.Color.White
        Me.TextoPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoPregunta.Location = New System.Drawing.Point(28, 69)
        Me.TextoPregunta.Name = "TextoPregunta"
        Me.TextoPregunta.ReadOnly = True
        Me.TextoPregunta.Size = New System.Drawing.Size(494, 135)
        Me.TextoPregunta.TabIndex = 10
        Me.TextoPregunta.Text = ""
        '
        'VentEntretenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 501)
        Me.Controls.Add(Me.BtnOpcion4)
        Me.Controls.Add(Me.BtnOpcion3)
        Me.Controls.Add(Me.BtnOpcion2)
        Me.Controls.Add(Me.BtnOpcion1)
        Me.Controls.Add(Me.TextoPregunta)
        Me.Controls.Add(Me.EntretenimpersonajePictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentEntretenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entretenimiento"
        CType(Me.EntretenimpersonajePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EntretenimpersonajePictureBox1 As PictureBox
    Friend WithEvents BtnOpcion4 As Button
    Friend WithEvents BtnOpcion3 As Button
    Friend WithEvents BtnOpcion2 As Button
    Friend WithEvents BtnOpcion1 As Button
    Friend WithEvents TextoPregunta As RichTextBox
End Class
