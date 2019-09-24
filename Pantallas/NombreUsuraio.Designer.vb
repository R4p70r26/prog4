<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NombreUsuraio
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
        Me.Jugardor1 = New System.Windows.Forms.TextBox()
        Me.Jugador2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JugarAhoraButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Jugardor1
        '
        Me.Jugardor1.Location = New System.Drawing.Point(179, 84)
        Me.Jugardor1.Name = "Jugardor1"
        Me.Jugardor1.Size = New System.Drawing.Size(195, 20)
        Me.Jugardor1.TabIndex = 0
        '
        'Jugador2
        '
        Me.Jugador2.Location = New System.Drawing.Point(179, 199)
        Me.Jugador2.Name = "Jugador2"
        Me.Jugador2.Size = New System.Drawing.Size(195, 20)
        Me.Jugador2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Jugador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Jugador 2"
        '
        'JugarAhoraButton1
        '
        Me.JugarAhoraButton1.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources._0A6
        Me.JugarAhoraButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JugarAhoraButton1.Location = New System.Drawing.Point(138, 392)
        Me.JugarAhoraButton1.Name = "JugarAhoraButton1"
        Me.JugarAhoraButton1.Size = New System.Drawing.Size(260, 60)
        Me.JugarAhoraButton1.TabIndex = 6
        Me.JugarAhoraButton1.UseVisualStyleBackColor = True
        '
        'NombreUsuraio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 501)
        Me.Controls.Add(Me.JugarAhoraButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Jugador2)
        Me.Controls.Add(Me.Jugardor1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NombreUsuraio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digite nombre usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Jugardor1 As TextBox
    Friend WithEvents Jugador2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents JugarAhoraButton1 As Button
End Class
