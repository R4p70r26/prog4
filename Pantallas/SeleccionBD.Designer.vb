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
        Me.AccessButton1 = New System.Windows.Forms.Button()
        Me.sqlButton2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AccessButton1
        '
        Me.AccessButton1.Location = New System.Drawing.Point(174, 106)
        Me.AccessButton1.Name = "AccessButton1"
        Me.AccessButton1.Size = New System.Drawing.Size(119, 23)
        Me.AccessButton1.TabIndex = 0
        Me.AccessButton1.Text = "Base datos Access"
        Me.AccessButton1.UseVisualStyleBackColor = True
        '
        'sqlButton2
        '
        Me.sqlButton2.Location = New System.Drawing.Point(174, 201)
        Me.sqlButton2.Name = "sqlButton2"
        Me.sqlButton2.Size = New System.Drawing.Size(119, 23)
        Me.sqlButton2.TabIndex = 1
        Me.sqlButton2.Text = "Base datos SQL"
        Me.sqlButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione tipo de base de datos que desea utilizar"
        '
        'SeleccionBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 501)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sqlButton2)
        Me.Controls.Add(Me.AccessButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeleccionBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion Base Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccessButton1 As Button
    Friend WithEvents sqlButton2 As Button
    Friend WithEvents Label1 As Label
End Class
