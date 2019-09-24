<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuJuego
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
        Me.jugarButton1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarNombresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'jugarButton1
        '
        Me.jugarButton1.Location = New System.Drawing.Point(178, 208)
        Me.jugarButton1.Name = "jugarButton1"
        Me.jugarButton1.Size = New System.Drawing.Size(75, 23)
        Me.jugarButton1.TabIndex = 0
        Me.jugarButton1.Text = "Jugar"
        Me.jugarButton1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(440, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarBaseDeDatosToolStripMenuItem, Me.CambiarNombresToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CambiarBaseDeDatosToolStripMenuItem
        '
        Me.CambiarBaseDeDatosToolStripMenuItem.Name = "CambiarBaseDeDatosToolStripMenuItem"
        Me.CambiarBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CambiarBaseDeDatosToolStripMenuItem.Text = "Cambiar Base de Datos"
        '
        'CambiarNombresToolStripMenuItem
        '
        Me.CambiarNombresToolStripMenuItem.Name = "CambiarNombresToolStripMenuItem"
        Me.CambiarNombresToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CambiarNombresToolStripMenuItem.Text = "Cambiar Nombres"
        '
        'MenuJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 454)
        Me.Controls.Add(Me.jugarButton1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuJuego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jugarButton1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarBaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarNombresToolStripMenuItem As ToolStripMenuItem
End Class
