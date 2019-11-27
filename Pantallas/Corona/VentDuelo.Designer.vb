<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentDuelo
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCorona = New System.Windows.Forms.Button()
        Me.BtnDuelo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PreguntadosPC.My.Resources.Resources.Corona_y_Duelo_Gif
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(549, 788)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnCorona
        '
        Me.BtnCorona.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCorona.Location = New System.Drawing.Point(105, 611)
        Me.BtnCorona.Name = "BtnCorona"
        Me.BtnCorona.Size = New System.Drawing.Size(138, 49)
        Me.BtnCorona.TabIndex = 1
        Me.BtnCorona.Text = "Corona"
        Me.BtnCorona.UseVisualStyleBackColor = False
        '
        'BtnDuelo
        '
        Me.BtnDuelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnDuelo.Location = New System.Drawing.Point(311, 611)
        Me.BtnDuelo.Name = "BtnDuelo"
        Me.BtnDuelo.Size = New System.Drawing.Size(138, 49)
        Me.BtnDuelo.TabIndex = 2
        Me.BtnDuelo.Text = "Duelo"
        Me.BtnDuelo.UseVisualStyleBackColor = False
        '
        'VentDuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(549, 788)
        Me.Controls.Add(Me.BtnDuelo)
        Me.Controls.Add(Me.BtnCorona)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentDuelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duelo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCorona As Button
    Friend WithEvents BtnDuelo As Button
End Class
