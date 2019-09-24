<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentPregunta
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PreguntaLabel1 = New System.Windows.Forms.Label()
        Me.tiempoLabel1 = New System.Windows.Forms.Label()
        Me.TipoPreguntaLabel1 = New System.Windows.Forms.Label()
        Me.pregunta1Button1 = New System.Windows.Forms.Button()
        Me.Pregunta2Button2 = New System.Windows.Forms.Button()
        Me.pregunta3Button3 = New System.Windows.Forms.Button()
        Me.pregunta4Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PreguntaLabel1)
        Me.Panel1.Controls.Add(Me.tiempoLabel1)
        Me.Panel1.Controls.Add(Me.TipoPreguntaLabel1)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 117)
        Me.Panel1.TabIndex = 0
        '
        'PreguntaLabel1
        '
        Me.PreguntaLabel1.AutoSize = True
        Me.PreguntaLabel1.Location = New System.Drawing.Point(3, 55)
        Me.PreguntaLabel1.Name = "PreguntaLabel1"
        Me.PreguntaLabel1.Size = New System.Drawing.Size(87, 13)
        Me.PreguntaLabel1.TabIndex = 2
        Me.PreguntaLabel1.Text = "Muestrapregunta"
        '
        'tiempoLabel1
        '
        Me.tiempoLabel1.AutoSize = True
        Me.tiempoLabel1.Location = New System.Drawing.Point(373, 4)
        Me.tiempoLabel1.Name = "tiempoLabel1"
        Me.tiempoLabel1.Size = New System.Drawing.Size(42, 13)
        Me.tiempoLabel1.TabIndex = 1
        Me.tiempoLabel1.Text = "Tiempo"
        '
        'TipoPreguntaLabel1
        '
        Me.TipoPreguntaLabel1.AutoSize = True
        Me.TipoPreguntaLabel1.Location = New System.Drawing.Point(147, 0)
        Me.TipoPreguntaLabel1.Name = "TipoPreguntaLabel1"
        Me.TipoPreguntaLabel1.Size = New System.Drawing.Size(118, 13)
        Me.TipoPreguntaLabel1.TabIndex = 0
        Me.TipoPreguntaLabel1.Text = "CambiaSegunCategoria"
        '
        'pregunta1Button1
        '
        Me.pregunta1Button1.Location = New System.Drawing.Point(13, 188)
        Me.pregunta1Button1.Name = "pregunta1Button1"
        Me.pregunta1Button1.Size = New System.Drawing.Size(415, 32)
        Me.pregunta1Button1.TabIndex = 1
        Me.pregunta1Button1.Text = "pregunta1"
        Me.pregunta1Button1.UseVisualStyleBackColor = True
        '
        'Pregunta2Button2
        '
        Me.Pregunta2Button2.Location = New System.Drawing.Point(13, 240)
        Me.Pregunta2Button2.Name = "Pregunta2Button2"
        Me.Pregunta2Button2.Size = New System.Drawing.Size(415, 32)
        Me.Pregunta2Button2.TabIndex = 2
        Me.Pregunta2Button2.Text = "pregunta2"
        Me.Pregunta2Button2.UseVisualStyleBackColor = True
        '
        'pregunta3Button3
        '
        Me.pregunta3Button3.Location = New System.Drawing.Point(13, 290)
        Me.pregunta3Button3.Name = "pregunta3Button3"
        Me.pregunta3Button3.Size = New System.Drawing.Size(415, 32)
        Me.pregunta3Button3.TabIndex = 3
        Me.pregunta3Button3.Text = "pregunta3"
        Me.pregunta3Button3.UseVisualStyleBackColor = True
        '
        'pregunta4Button4
        '
        Me.pregunta4Button4.Location = New System.Drawing.Point(13, 341)
        Me.pregunta4Button4.Name = "pregunta4Button4"
        Me.pregunta4Button4.Size = New System.Drawing.Size(415, 32)
        Me.pregunta4Button4.TabIndex = 4
        Me.pregunta4Button4.Text = "pregunta4"
        Me.pregunta4Button4.UseVisualStyleBackColor = True
        '
        'VentPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 454)
        Me.Controls.Add(Me.pregunta4Button4)
        Me.Controls.Add(Me.pregunta3Button3)
        Me.Controls.Add(Me.Pregunta2Button2)
        Me.Controls.Add(Me.pregunta1Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentPregunta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tiempoLabel1 As Label
    Friend WithEvents TipoPreguntaLabel1 As Label
    Friend WithEvents PreguntaLabel1 As Label
    Friend WithEvents pregunta1Button1 As Button
    Friend WithEvents Pregunta2Button2 As Button
    Friend WithEvents pregunta3Button3 As Button
    Friend WithEvents pregunta4Button4 As Button
End Class
