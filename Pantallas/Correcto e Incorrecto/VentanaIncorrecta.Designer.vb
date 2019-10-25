<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaIncorrecta
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
        Me.Pregunta = New System.Windows.Forms.RichTextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Btn_Continuar = New System.Windows.Forms.Button()
        Me.BtnCompartir = New System.Windows.Forms.Button()
        Me.cienciapersonajePictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.cienciapersonajePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pregunta
        '
        Me.Pregunta.BackColor = System.Drawing.Color.White
        Me.Pregunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pregunta.Location = New System.Drawing.Point(25, 136)
        Me.Pregunta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pregunta.Name = "Pregunta"
        Me.Pregunta.ReadOnly = True
        Me.Pregunta.Size = New System.Drawing.Size(750, 308)
        Me.Pregunta.TabIndex = 28
        Me.Pregunta.Text = ""
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LinkLabel2.Location = New System.Drawing.Point(453, 599)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(125, 22)
        Me.LinkLabel2.TabIndex = 27
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Reportar Error"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LinkLabel1.Location = New System.Drawing.Point(249, 599)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(116, 22)
        Me.LinkLabel1.TabIndex = 26
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Pregunta"
        '
        'Btn_Continuar
        '
        Me.Btn_Continuar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Continuar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Continuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Continuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Continuar.Location = New System.Drawing.Point(83, 674)
        Me.Btn_Continuar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Continuar.Name = "Btn_Continuar"
        Me.Btn_Continuar.Size = New System.Drawing.Size(610, 61)
        Me.Btn_Continuar.TabIndex = 25
        Me.Btn_Continuar.Text = "Continuar"
        Me.Btn_Continuar.UseVisualStyleBackColor = False
        '
        'BtnCompartir
        '
        Me.BtnCompartir.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnCompartir.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnCompartir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCompartir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompartir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCompartir.Location = New System.Drawing.Point(196, 510)
        Me.BtnCompartir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCompartir.Name = "BtnCompartir"
        Me.BtnCompartir.Size = New System.Drawing.Size(420, 57)
        Me.BtnCompartir.TabIndex = 24
        Me.BtnCompartir.Text = "¡Compartir preguntas!"
        Me.BtnCompartir.UseVisualStyleBackColor = False
        '
        'cienciapersonajePictureBox1
        '
        Me.cienciapersonajePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cienciapersonajePictureBox1.Image = Global.PreguntadosPC.My.Resources.Resources.Pregunta
        Me.cienciapersonajePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.cienciapersonajePictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cienciapersonajePictureBox1.Name = "cienciapersonajePictureBox1"
        Me.cienciapersonajePictureBox1.Size = New System.Drawing.Size(800, 837)
        Me.cienciapersonajePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cienciapersonajePictureBox1.TabIndex = 23
        Me.cienciapersonajePictureBox1.TabStop = False
        '
        'VentanaIncorrecta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 837)
        Me.Controls.Add(Me.Pregunta)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Btn_Continuar)
        Me.Controls.Add(Me.BtnCompartir)
        Me.Controls.Add(Me.cienciapersonajePictureBox1)
        Me.Name = "VentanaIncorrecta"
        Me.Text = "VentanaIncorrecta"
        CType(Me.cienciapersonajePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pregunta As RichTextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Btn_Continuar As Button
    Friend WithEvents BtnCompartir As Button
    Friend WithEvents cienciapersonajePictureBox1 As PictureBox
End Class
