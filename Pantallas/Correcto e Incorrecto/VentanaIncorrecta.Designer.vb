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
        Me.Btn_Continuar = New System.Windows.Forms.Button()
        Me.cienciapersonajePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.cienciapersonajePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pregunta
        '
        Me.Pregunta.BackColor = System.Drawing.Color.White
        Me.Pregunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pregunta.Location = New System.Drawing.Point(29, 77)
        Me.Pregunta.Name = "Pregunta"
        Me.Pregunta.ReadOnly = True
        Me.Pregunta.Size = New System.Drawing.Size(500, 200)
        Me.Pregunta.TabIndex = 28
        Me.Pregunta.Text = ""
        '
        'Btn_Continuar
        '
        Me.Btn_Continuar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Continuar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Continuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Continuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Continuar.Location = New System.Drawing.Point(65, 428)
        Me.Btn_Continuar.Name = "Btn_Continuar"
        Me.Btn_Continuar.Size = New System.Drawing.Size(407, 40)
        Me.Btn_Continuar.TabIndex = 25
        Me.Btn_Continuar.Text = "Continuar"
        Me.Btn_Continuar.UseVisualStyleBackColor = False
        '
        'cienciapersonajePictureBox1
        '
        Me.cienciapersonajePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cienciapersonajePictureBox1.Image = Global.PreguntadosPC.My.Resources.Resources.Pregunta
        Me.cienciapersonajePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.cienciapersonajePictureBox1.Name = "cienciapersonajePictureBox1"
        Me.cienciapersonajePictureBox1.Size = New System.Drawing.Size(560, 733)
        Me.cienciapersonajePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cienciapersonajePictureBox1.TabIndex = 23
        Me.cienciapersonajePictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PreguntadosPC.My.Resources.Resources.text_incorrect__1_
        Me.PictureBox1.Location = New System.Drawing.Point(65, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(407, 81)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'VentanaIncorrecta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pregunta)
        Me.Controls.Add(Me.Btn_Continuar)
        Me.Controls.Add(Me.cienciapersonajePictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "VentanaIncorrecta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respuesta incorrecta"
        CType(Me.cienciapersonajePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pregunta As RichTextBox
    Friend WithEvents Btn_Continuar As Button
    Friend WithEvents cienciapersonajePictureBox1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
