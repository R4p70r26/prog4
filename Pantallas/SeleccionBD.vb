Public Class SeleccionBD
    Private Sub SeleccionBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'VentanaPrincipal.Hide() 'en el momento en que la ventana se carga se esconde la ventana principal

    End Sub

    Private Sub SeleccionBD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'VentanaPrincipal.Show() 'si esta ventana se cierra muestra la ventana principal

    End Sub

    Private Sub AccessButton1_Click(sender As Object, e As EventArgs) Handles AccessButton1.Click
        Try
            My.Forms.NombreUsuraio.Show()

            Me.Close() 'cierra la ventana
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SqlButton2_Click(sender As Object, e As EventArgs) Handles sqlButton2.Click
        Try
            My.Forms.NombreUsuraio.Show()

            Me.Close() 'cierra la ventana
        Catch ex As Exception

        End Try

    End Sub

End Class