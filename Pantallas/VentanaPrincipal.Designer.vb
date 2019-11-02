<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaPrincipal))
        Me.JugarAhoraButton1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'JugarAhoraButton1
        '
        Me.JugarAhoraButton1.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources._0A6
        Me.JugarAhoraButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JugarAhoraButton1.Location = New System.Drawing.Point(131, 441)
        Me.JugarAhoraButton1.Name = "JugarAhoraButton1"
        Me.JugarAhoraButton1.Size = New System.Drawing.Size(260, 60)
        Me.JugarAhoraButton1.TabIndex = 0
        Me.JugarAhoraButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(131, 590)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar Preguntas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(556, 745)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.JugarAhoraButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentanaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preguntados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents JugarAhoraButton1 As Button
    Friend WithEvents Button1 As Button
End Class
