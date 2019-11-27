<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeleccionBD))
        Me.AccessButton1 = New System.Windows.Forms.Button()
        Me.sqlButton2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AccessButton1
        '
        Me.AccessButton1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.AccessButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccessButton1.Location = New System.Drawing.Point(129, 160)
        Me.AccessButton1.Name = "AccessButton1"
        Me.AccessButton1.Size = New System.Drawing.Size(297, 73)
        Me.AccessButton1.TabIndex = 0
        Me.AccessButton1.Text = "Base datos Access"
        Me.AccessButton1.UseVisualStyleBackColor = False
        '
        'sqlButton2
        '
        Me.sqlButton2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.sqlButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sqlButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sqlButton2.Location = New System.Drawing.Point(129, 346)
        Me.sqlButton2.Name = "sqlButton2"
        Me.sqlButton2.Size = New System.Drawing.Size(297, 73)
        Me.sqlButton2.TabIndex = 1
        Me.sqlButton2.Text = "Base datos SQL"
        Me.sqlButton2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione tipo de base de datos que desea utilizar"
        '
        'SeleccionBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PreguntadosPC.My.Resources.Resources.WhatsApp_Image_2019_11_26_at_17_34_51
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sqlButton2)
        Me.Controls.Add(Me.AccessButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeleccionBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion base datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccessButton1 As Button
    Friend WithEvents sqlButton2 As Button
    Friend WithEvents Label1 As Label
End Class
