<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentGeografia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentGeografia))
        Me.TextoPregunta = New System.Windows.Forms.RichTextBox()
        Me.BtnOpcion1 = New System.Windows.Forms.Button()
        Me.BtnOpcion2 = New System.Windows.Forms.Button()
        Me.BtnOpcion3 = New System.Windows.Forms.Button()
        Me.BtnOpcion4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ltiempo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pictiempofuera = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictiempofuera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextoPregunta
        '
        Me.TextoPregunta.BackColor = System.Drawing.Color.White
        Me.TextoPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoPregunta.Location = New System.Drawing.Point(26, 86)
        Me.TextoPregunta.Name = "TextoPregunta"
        Me.TextoPregunta.ReadOnly = True
        Me.TextoPregunta.Size = New System.Drawing.Size(500, 200)
        Me.TextoPregunta.TabIndex = 5
        Me.TextoPregunta.Text = ""
        '
        'BtnOpcion1
        '
        Me.BtnOpcion1.BackColor = System.Drawing.Color.White
        Me.BtnOpcion1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnOpcion1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BtnOpcion1.Location = New System.Drawing.Point(12, 344)
        Me.BtnOpcion1.Name = "BtnOpcion1"
        Me.BtnOpcion1.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion1.TabIndex = 6
        Me.BtnOpcion1.Text = "Button1"
        Me.BtnOpcion1.UseVisualStyleBackColor = False
        '
        'BtnOpcion2
        '
        Me.BtnOpcion2.BackColor = System.Drawing.Color.White
        Me.BtnOpcion2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnOpcion2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BtnOpcion2.Location = New System.Drawing.Point(12, 392)
        Me.BtnOpcion2.Name = "BtnOpcion2"
        Me.BtnOpcion2.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion2.TabIndex = 7
        Me.BtnOpcion2.Text = "Button2"
        Me.BtnOpcion2.UseVisualStyleBackColor = False
        '
        'BtnOpcion3
        '
        Me.BtnOpcion3.BackColor = System.Drawing.Color.White
        Me.BtnOpcion3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnOpcion3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BtnOpcion3.Location = New System.Drawing.Point(12, 440)
        Me.BtnOpcion3.Name = "BtnOpcion3"
        Me.BtnOpcion3.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion3.TabIndex = 8
        Me.BtnOpcion3.Text = "Button3"
        Me.BtnOpcion3.UseVisualStyleBackColor = False
        '
        'BtnOpcion4
        '
        Me.BtnOpcion4.BackColor = System.Drawing.Color.White
        Me.BtnOpcion4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnOpcion4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpcion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnOpcion4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BtnOpcion4.Location = New System.Drawing.Point(12, 488)
        Me.BtnOpcion4.Name = "BtnOpcion4"
        Me.BtnOpcion4.Size = New System.Drawing.Size(536, 42)
        Me.BtnOpcion4.TabIndex = 9
        Me.BtnOpcion4.Text = "Button4"
        Me.BtnOpcion4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PreguntadosPC.My.Resources.Resources.Pregunta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 749)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Ltiempo
        '
        Me.Ltiempo.AutoSize = True
        Me.Ltiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltiempo.Location = New System.Drawing.Point(505, 13)
        Me.Ltiempo.Name = "Ltiempo"
        Me.Ltiempo.Size = New System.Drawing.Size(0, 26)
        Me.Ltiempo.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'pictiempofuera
        '
        Me.pictiempofuera.BackColor = System.Drawing.Color.Transparent
        Me.pictiempofuera.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources.text_timeup__1_
        Me.pictiempofuera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictiempofuera.Enabled = False
        Me.pictiempofuera.Location = New System.Drawing.Point(68, 139)
        Me.pictiempofuera.Name = "pictiempofuera"
        Me.pictiempofuera.Size = New System.Drawing.Size(428, 117)
        Me.pictiempofuera.TabIndex = 20
        Me.pictiempofuera.TabStop = False
        '
        'VentGeografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(560, 749)
        Me.Controls.Add(Me.pictiempofuera)
        Me.Controls.Add(Me.Ltiempo)
        Me.Controls.Add(Me.BtnOpcion4)
        Me.Controls.Add(Me.BtnOpcion3)
        Me.Controls.Add(Me.BtnOpcion2)
        Me.Controls.Add(Me.BtnOpcion1)
        Me.Controls.Add(Me.TextoPregunta)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentGeografia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geografia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictiempofuera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextoPregunta As RichTextBox
    Friend WithEvents BtnOpcion1 As Button
    Friend WithEvents BtnOpcion2 As Button
    Friend WithEvents BtnOpcion3 As Button
    Friend WithEvents BtnOpcion4 As Button
    Friend WithEvents Ltiempo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pictiempofuera As PictureBox
End Class
