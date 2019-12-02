Public Class VentDuelo
    Private Sub BtnCorona_Click(sender As Object, e As EventArgs) Handles BtnCorona.Click

        VentCorona.Show()
        Me.Close()
    End Sub

    Private Sub BtnDuelo_Click(sender As Object, e As EventArgs) Handles BtnDuelo.Click
        DueloSeleccionPers.Show()
        Me.Close()

    End Sub



End Class