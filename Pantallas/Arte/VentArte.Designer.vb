<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentArte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnOpcion4 = New System.Windows.Forms.Button()
        Me.BtnOpcion3 = New System.Windows.Forms.Button()
        Me.BtnOpcion2 = New System.Windows.Forms.Button()
        Me.BtnOpcion1 = New System.Windows.Forms.Button()
        Me.TextoPregunta = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LTiempo = New System.Windows.Forms.Label()
        Me.pictiempofuera = New System.Windows.Forms.PictureBox()
        Me.artepersonajePictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictiempofuera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.artepersonajePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOpcion4
        '
        Me.BtnOpcion4.BackColor = System.Drawing.Color.White
        Me.BtnOpcion4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion4.Location = New System.Drawing.Point(18, 828)
        Me.BtnOpcion4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOpcion4.Name = "BtnOpcion4"
        Me.BtnOpcion4.Size = New System.Drawing.Size(804, 65)
        Me.BtnOpcion4.TabIndex = 14
        Me.BtnOpcion4.Text = "Button4"
        Me.BtnOpcion4.UseVisualStyleBackColor = False
        '
        'BtnOpcion3
        '
        Me.BtnOpcion3.BackColor = System.Drawing.Color.White
        Me.BtnOpcion3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion3.Location = New System.Drawing.Point(18, 738)
        Me.BtnOpcion3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOpcion3.Name = "BtnOpcion3"
        Me.BtnOpcion3.Size = New System.Drawing.Size(804, 65)
        Me.BtnOpcion3.TabIndex = 13
        Me.BtnOpcion3.Text = "Button3"
        Me.BtnOpcion3.UseVisualStyleBackColor = False
        '
        'BtnOpcion2
        '
        Me.BtnOpcion2.BackColor = System.Drawing.Color.White
        Me.BtnOpcion2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion2.Location = New System.Drawing.Point(18, 651)
        Me.BtnOpcion2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOpcion2.Name = "BtnOpcion2"
        Me.BtnOpcion2.Size = New System.Drawing.Size(804, 65)
        Me.BtnOpcion2.TabIndex = 12
        Me.BtnOpcion2.Text = "Button2"
        Me.BtnOpcion2.UseVisualStyleBackColor = False
        '
        'BtnOpcion1
        '
        Me.BtnOpcion1.BackColor = System.Drawing.Color.White
        Me.BtnOpcion1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion1.Location = New System.Drawing.Point(18, 563)
        Me.BtnOpcion1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOpcion1.Name = "BtnOpcion1"
        Me.BtnOpcion1.Size = New System.Drawing.Size(804, 65)
        Me.BtnOpcion1.TabIndex = 11
        Me.BtnOpcion1.Text = "Button1"
        Me.BtnOpcion1.UseVisualStyleBackColor = False
        '
        'TextoPregunta
        '
        Me.TextoPregunta.BackColor = System.Drawing.Color.White
        Me.TextoPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoPregunta.Location = New System.Drawing.Point(48, 154)
        Me.TextoPregunta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextoPregunta.Name = "TextoPregunta"
        Me.TextoPregunta.ReadOnly = True
        Me.TextoPregunta.Size = New System.Drawing.Size(750, 308)
        Me.TextoPregunta.TabIndex = 10
        Me.TextoPregunta.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LTiempo
        '
        Me.LTiempo.AutoSize = True
        Me.LTiempo.Location = New System.Drawing.Point(738, 20)
        Me.LTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTiempo.Name = "LTiempo"
        Me.LTiempo.Size = New System.Drawing.Size(0, 20)
        Me.LTiempo.TabIndex = 15
        '
        'pictiempofuera
        '
        Me.pictiempofuera.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources.text_timeup__1_
        Me.pictiempofuera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictiempofuera.Location = New System.Drawing.Point(96, 217)
        Me.pictiempofuera.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pictiempofuera.Name = "pictiempofuera"
        Me.pictiempofuera.Size = New System.Drawing.Size(642, 180)
        Me.pictiempofuera.TabIndex = 16
        Me.pictiempofuera.TabStop = False
        '
        'artepersonajePictureBox1
        '
        Me.artepersonajePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.artepersonajePictureBox1.Image = Global.PreguntadosPC.My.Resources.Resources.Pregunta
        Me.artepersonajePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.artepersonajePictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.artepersonajePictureBox1.Name = "artepersonajePictureBox1"
        Me.artepersonajePictureBox1.Size = New System.Drawing.Size(840, 1050)
        Me.artepersonajePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.artepersonajePictureBox1.TabIndex = 2
        Me.artepersonajePictureBox1.TabStop = False
        '
        'VentArte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 1050)
        Me.Controls.Add(Me.pictiempofuera)
        Me.Controls.Add(Me.LTiempo)
        Me.Controls.Add(Me.BtnOpcion4)
        Me.Controls.Add(Me.BtnOpcion3)
        Me.Controls.Add(Me.BtnOpcion2)
        Me.Controls.Add(Me.BtnOpcion1)
        Me.Controls.Add(Me.TextoPregunta)
        Me.Controls.Add(Me.artepersonajePictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentArte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arte"
        CType(Me.pictiempofuera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.artepersonajePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents artepersonajePictureBox1 As PictureBox
    Friend WithEvents BtnOpcion4 As Button
    Friend WithEvents BtnOpcion3 As Button
    Friend WithEvents BtnOpcion2 As Button
    Friend WithEvents BtnOpcion1 As Button
    Friend WithEvents TextoPregunta As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LTiempo As Label
    Friend WithEvents pictiempofuera As PictureBox
End Class
