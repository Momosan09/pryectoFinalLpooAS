Public Class baseDatos

    Private Sub baseDatos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        DataGridView1.Rows.Add(nombreIngresado, apellidoIngresado, precioN, precio)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        seleccion.Show()
    End Sub
End Class