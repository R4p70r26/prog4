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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NombreUsuraio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JugarAhoraButton1 = New System.Windows.Forms.Button()
        Me.Jugador1 = New System.Windows.Forms.ComboBox()
        Me.Jugador2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(136, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre jugador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(136, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre jugador 2"
        '
        'JugarAhoraButton1
        '
        Me.JugarAhoraButton1.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources._0A6
        Me.JugarAhoraButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JugarAhoraButton1.Location = New System.Drawing.Point(163, 633)
        Me.JugarAhoraButton1.Name = "JugarAhoraButton1"
        Me.JugarAhoraButton1.Size = New System.Drawing.Size(260, 60)
        Me.JugarAhoraButton1.TabIndex = 6
        Me.JugarAhoraButton1.UseVisualStyleBackColor = True
        '
        'Jugador1
        '
        Me.Jugador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Jugador1.FormattingEnabled = True
        Me.Jugador1.Location = New System.Drawing.Point(142, 132)
        Me.Jugador1.Name = "Jugador1"
        Me.Jugador1.Size = New System.Drawing.Size(280, 21)
        Me.Jugador1.TabIndex = 7
        '
        'Jugador2
        '
        Me.Jugador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Jugador2.FormattingEnabled = True
        Me.Jugador2.Location = New System.Drawing.Point(141, 329)
        Me.Jugador2.Name = "Jugador2"
        Me.Jugador2.Size = New System.Drawing.Size(281, 21)
        Me.Jugador2.TabIndex = 7
        '
        'NombreUsuraio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources.WhatsApp_Image_2019_11_26_at_17_34_51
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 733)
        Me.Controls.Add(Me.Jugador2)
        Me.Controls.Add(Me.Jugador1)
        Me.Controls.Add(Me.JugarAhoraButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NombreUsuraio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digite nombre usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents JugarAhoraButton1 As Button
    Friend WithEvents Jugador1 As ComboBox
    Friend WithEvents Jugador2 As ComboBox
End Class
