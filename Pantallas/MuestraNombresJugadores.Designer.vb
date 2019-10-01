<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MuestraNombresJugadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MuestraNombresJugadores))
        Me.NombreJugador1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreJugador2 = New System.Windows.Forms.Label()
        Me.empezarButton1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEntretenimiento1 = New System.Windows.Forms.Button()
        Me.BtnGeografia2 = New System.Windows.Forms.Button()
        Me.BtnCiencia2 = New System.Windows.Forms.Button()
        Me.BtnHistoria1 = New System.Windows.Forms.Button()
        Me.BtnHistoria2 = New System.Windows.Forms.Button()
        Me.BtnCiencia1 = New System.Windows.Forms.Button()
        Me.BtnDeportes2 = New System.Windows.Forms.Button()
        Me.BtnGeografia1 = New System.Windows.Forms.Button()
        Me.BtnArte2 = New System.Windows.Forms.Button()
        Me.BtnArte1 = New System.Windows.Forms.Button()
        Me.BtnEntretenimiento2 = New System.Windows.Forms.Button()
        Me.BtnDeportes1 = New System.Windows.Forms.Button()
        Me.picBoxRuleta = New System.Windows.Forms.PictureBox()
        Me.TVueltas = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picBoxRuleta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreJugador1
        '
        Me.NombreJugador1.AutoSize = True
        Me.NombreJugador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreJugador1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.NombreJugador1.Location = New System.Drawing.Point(37, 22)
        Me.NombreJugador1.Name = "NombreJugador1"
        Me.NombreJugador1.Size = New System.Drawing.Size(108, 20)
        Me.NombreJugador1.TabIndex = 0
        Me.NombreJugador1.Text = "Muestrajug1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VS"
        '
        'NombreJugador2
        '
        Me.NombreJugador2.AutoSize = True
        Me.NombreJugador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreJugador2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.NombreJugador2.Location = New System.Drawing.Point(387, 22)
        Me.NombreJugador2.Name = "NombreJugador2"
        Me.NombreJugador2.Size = New System.Drawing.Size(108, 20)
        Me.NombreJugador2.TabIndex = 2
        Me.NombreJugador2.Text = "Muestrajug2"
        '
        'empezarButton1
        '
        Me.empezarButton1.Location = New System.Drawing.Point(230, 674)
        Me.empezarButton1.Name = "empezarButton1"
        Me.empezarButton1.Size = New System.Drawing.Size(75, 23)
        Me.empezarButton1.TabIndex = 3
        Me.empezarButton1.Text = "Empezar"
        Me.empezarButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnEntretenimiento1)
        Me.Panel1.Controls.Add(Me.BtnGeografia2)
        Me.Panel1.Controls.Add(Me.NombreJugador1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnCiencia2)
        Me.Panel1.Controls.Add(Me.BtnHistoria1)
        Me.Panel1.Controls.Add(Me.BtnHistoria2)
        Me.Panel1.Controls.Add(Me.BtnCiencia1)
        Me.Panel1.Controls.Add(Me.BtnDeportes2)
        Me.Panel1.Controls.Add(Me.BtnGeografia1)
        Me.Panel1.Controls.Add(Me.BtnArte2)
        Me.Panel1.Controls.Add(Me.BtnArte1)
        Me.Panel1.Controls.Add(Me.BtnEntretenimiento2)
        Me.Panel1.Controls.Add(Me.NombreJugador2)
        Me.Panel1.Controls.Add(Me.BtnDeportes1)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 145)
        Me.Panel1.TabIndex = 4
        '
        'BtnEntretenimiento1
        '
        Me.BtnEntretenimiento1.Enabled = False
        Me.BtnEntretenimiento1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEntretenimiento1.FlatAppearance.BorderSize = 0
        Me.BtnEntretenimiento1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnEntretenimiento1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnEntretenimiento1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntretenimiento1.Image = CType(resources.GetObject("BtnEntretenimiento1.Image"), System.Drawing.Image)
        Me.BtnEntretenimiento1.Location = New System.Drawing.Point(3, 83)
        Me.BtnEntretenimiento1.Name = "BtnEntretenimiento1"
        Me.BtnEntretenimiento1.Size = New System.Drawing.Size(32, 36)
        Me.BtnEntretenimiento1.TabIndex = 18
        Me.BtnEntretenimiento1.UseVisualStyleBackColor = True
        '
        'BtnGeografia2
        '
        Me.BtnGeografia2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnGeografia2.FlatAppearance.BorderSize = 0
        Me.BtnGeografia2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGeografia2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnGeografia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGeografia2.Image = CType(resources.GetObject("BtnGeografia2.Image"), System.Drawing.Image)
        Me.BtnGeografia2.Location = New System.Drawing.Point(311, 85)
        Me.BtnGeografia2.Name = "BtnGeografia2"
        Me.BtnGeografia2.Size = New System.Drawing.Size(32, 32)
        Me.BtnGeografia2.TabIndex = 10
        Me.BtnGeografia2.UseVisualStyleBackColor = True
        '
        'BtnCiencia2
        '
        Me.BtnCiencia2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCiencia2.FlatAppearance.BorderSize = 0
        Me.BtnCiencia2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnCiencia2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnCiencia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCiencia2.Image = CType(resources.GetObject("BtnCiencia2.Image"), System.Drawing.Image)
        Me.BtnCiencia2.Location = New System.Drawing.Point(349, 69)
        Me.BtnCiencia2.Name = "BtnCiencia2"
        Me.BtnCiencia2.Size = New System.Drawing.Size(32, 50)
        Me.BtnCiencia2.TabIndex = 12
        Me.BtnCiencia2.UseVisualStyleBackColor = True
        '
        'BtnHistoria1
        '
        Me.BtnHistoria1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnHistoria1.FlatAppearance.BorderSize = 0
        Me.BtnHistoria1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnHistoria1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnHistoria1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistoria1.Image = CType(resources.GetObject("BtnHistoria1.Image"), System.Drawing.Image)
        Me.BtnHistoria1.Location = New System.Drawing.Point(118, 74)
        Me.BtnHistoria1.Name = "BtnHistoria1"
        Me.BtnHistoria1.Size = New System.Drawing.Size(32, 45)
        Me.BtnHistoria1.TabIndex = 8
        Me.BtnHistoria1.UseVisualStyleBackColor = True
        '
        'BtnHistoria2
        '
        Me.BtnHistoria2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnHistoria2.FlatAppearance.BorderSize = 0
        Me.BtnHistoria2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnHistoria2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnHistoria2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistoria2.Image = CType(resources.GetObject("BtnHistoria2.Image"), System.Drawing.Image)
        Me.BtnHistoria2.Location = New System.Drawing.Point(387, 71)
        Me.BtnHistoria2.Name = "BtnHistoria2"
        Me.BtnHistoria2.Size = New System.Drawing.Size(32, 45)
        Me.BtnHistoria2.TabIndex = 13
        Me.BtnHistoria2.UseVisualStyleBackColor = True
        '
        'BtnCiencia1
        '
        Me.BtnCiencia1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCiencia1.FlatAppearance.BorderSize = 0
        Me.BtnCiencia1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnCiencia1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnCiencia1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCiencia1.Image = CType(resources.GetObject("BtnCiencia1.Image"), System.Drawing.Image)
        Me.BtnCiencia1.Location = New System.Drawing.Point(156, 69)
        Me.BtnCiencia1.Name = "BtnCiencia1"
        Me.BtnCiencia1.Size = New System.Drawing.Size(32, 50)
        Me.BtnCiencia1.TabIndex = 9
        Me.BtnCiencia1.UseVisualStyleBackColor = True
        '
        'BtnDeportes2
        '
        Me.BtnDeportes2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDeportes2.FlatAppearance.BorderSize = 0
        Me.BtnDeportes2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnDeportes2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnDeportes2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeportes2.Image = CType(resources.GetObject("BtnDeportes2.Image"), System.Drawing.Image)
        Me.BtnDeportes2.Location = New System.Drawing.Point(425, 69)
        Me.BtnDeportes2.Name = "BtnDeportes2"
        Me.BtnDeportes2.Size = New System.Drawing.Size(32, 48)
        Me.BtnDeportes2.TabIndex = 14
        Me.BtnDeportes2.UseVisualStyleBackColor = True
        '
        'BtnGeografia1
        '
        Me.BtnGeografia1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnGeografia1.FlatAppearance.BorderSize = 0
        Me.BtnGeografia1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGeografia1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnGeografia1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGeografia1.ForeColor = System.Drawing.Color.Transparent
        Me.BtnGeografia1.Image = CType(resources.GetObject("BtnGeografia1.Image"), System.Drawing.Image)
        Me.BtnGeografia1.Location = New System.Drawing.Point(194, 83)
        Me.BtnGeografia1.Name = "BtnGeografia1"
        Me.BtnGeografia1.Size = New System.Drawing.Size(32, 32)
        Me.BtnGeografia1.TabIndex = 11
        Me.BtnGeografia1.UseVisualStyleBackColor = True
        '
        'BtnArte2
        '
        Me.BtnArte2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnArte2.FlatAppearance.BorderSize = 0
        Me.BtnArte2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnArte2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnArte2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArte2.Image = CType(resources.GetObject("BtnArte2.Image"), System.Drawing.Image)
        Me.BtnArte2.Location = New System.Drawing.Point(463, 67)
        Me.BtnArte2.Name = "BtnArte2"
        Me.BtnArte2.Size = New System.Drawing.Size(32, 50)
        Me.BtnArte2.TabIndex = 15
        Me.BtnArte2.UseVisualStyleBackColor = True
        '
        'BtnArte1
        '
        Me.BtnArte1.Enabled = False
        Me.BtnArte1.FlatAppearance.BorderSize = 0
        Me.BtnArte1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnArte1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnArte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArte1.Image = CType(resources.GetObject("BtnArte1.Image"), System.Drawing.Image)
        Me.BtnArte1.Location = New System.Drawing.Point(41, 69)
        Me.BtnArte1.Name = "BtnArte1"
        Me.BtnArte1.Size = New System.Drawing.Size(33, 50)
        Me.BtnArte1.TabIndex = 6
        Me.BtnArte1.UseVisualStyleBackColor = True
        '
        'BtnEntretenimiento2
        '
        Me.BtnEntretenimiento2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEntretenimiento2.FlatAppearance.BorderSize = 0
        Me.BtnEntretenimiento2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnEntretenimiento2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnEntretenimiento2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntretenimiento2.Image = CType(resources.GetObject("BtnEntretenimiento2.Image"), System.Drawing.Image)
        Me.BtnEntretenimiento2.Location = New System.Drawing.Point(501, 81)
        Me.BtnEntretenimiento2.Name = "BtnEntretenimiento2"
        Me.BtnEntretenimiento2.Size = New System.Drawing.Size(32, 36)
        Me.BtnEntretenimiento2.TabIndex = 16
        Me.BtnEntretenimiento2.UseVisualStyleBackColor = True
        '
        'BtnDeportes1
        '
        Me.BtnDeportes1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDeportes1.FlatAppearance.BorderSize = 0
        Me.BtnDeportes1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnDeportes1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnDeportes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeportes1.Image = CType(resources.GetObject("BtnDeportes1.Image"), System.Drawing.Image)
        Me.BtnDeportes1.Location = New System.Drawing.Point(80, 71)
        Me.BtnDeportes1.Name = "BtnDeportes1"
        Me.BtnDeportes1.Size = New System.Drawing.Size(32, 48)
        Me.BtnDeportes1.TabIndex = 7
        Me.BtnDeportes1.UseVisualStyleBackColor = True
        '
        'picBoxRuleta
        '
        Me.picBoxRuleta.BackColor = System.Drawing.Color.Transparent
        Me.picBoxRuleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBoxRuleta.Image = Global.PreguntadosPC.My.Resources.Resources.Ruletaarte
        Me.picBoxRuleta.Location = New System.Drawing.Point(53, 206)
        Me.picBoxRuleta.Name = "picBoxRuleta"
        Me.picBoxRuleta.Size = New System.Drawing.Size(454, 442)
        Me.picBoxRuleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxRuleta.TabIndex = 6
        Me.picBoxRuleta.TabStop = False
        '
        'TVueltas
        '
        Me.TVueltas.Interval = 1
        '
        'MuestraNombresJugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 806)
        Me.Controls.Add(Me.picBoxRuleta)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.empezarButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MuestraNombresJugadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MuestraNombresJugadores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBoxRuleta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NombreJugador1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreJugador2 As Label
    Friend WithEvents empezarButton1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnGeografia2 As Button
    Friend WithEvents BtnCiencia2 As Button
    Friend WithEvents BtnHistoria2 As Button
    Friend WithEvents BtnDeportes2 As Button
    Friend WithEvents BtnArte2 As Button
    Friend WithEvents BtnEntretenimiento2 As Button
    Friend WithEvents BtnArte1 As Button
    Friend WithEvents BtnGeografia1 As Button
    Friend WithEvents BtnDeportes1 As Button
    Friend WithEvents BtnHistoria1 As Button
    Friend WithEvents BtnCiencia1 As Button
    Friend WithEvents BtnEntretenimiento1 As Button
    Friend WithEvents picBoxRuleta As PictureBox
    Friend WithEvents TVueltas As Timer
End Class
