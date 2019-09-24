<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ruleta
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
        Me.roundLabel1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.jugador1Label1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jugador2Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'roundLabel1
        '
        Me.roundLabel1.AutoSize = True
        Me.roundLabel1.Location = New System.Drawing.Point(173, 9)
        Me.roundLabel1.Name = "roundLabel1"
        Me.roundLabel1.Size = New System.Drawing.Size(65, 13)
        Me.roundLabel1.TabIndex = 0
        Me.roundLabel1.Text = "Round 0/25"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.jugador2Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.jugador1Label1)
        Me.Panel1.Controls.Add(Me.roundLabel1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 103)
        Me.Panel1.TabIndex = 1
        '
        'jugador1Label1
        '
        Me.jugador1Label1.AutoSize = True
        Me.jugador1Label1.Location = New System.Drawing.Point(37, 53)
        Me.jugador1Label1.Name = "jugador1Label1"
        Me.jugador1Label1.Size = New System.Drawing.Size(65, 13)
        Me.jugador1Label1.TabIndex = 1
        Me.jugador1Label1.Text = "Muestrajug1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VS"
        '
        'jugador2Label2
        '
        Me.jugador2Label2.AutoSize = True
        Me.jugador2Label2.Location = New System.Drawing.Point(307, 53)
        Me.jugador2Label2.Name = "jugador2Label2"
        Me.jugador2Label2.Size = New System.Drawing.Size(65, 13)
        Me.jugador2Label2.TabIndex = 3
        Me.jugador2Label2.Text = "Muestrajug2"
        '
        'Ruleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 454)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ruleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ruleta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents roundLabel1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents jugador2Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents jugador1Label1 As Label
End Class
