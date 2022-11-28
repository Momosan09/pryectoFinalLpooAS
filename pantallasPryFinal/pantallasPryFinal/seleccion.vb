Public Class seleccion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        formCliente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        baseDatos.Show()

    End Sub

    Private Sub seleccion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        precio = 0
        precioN = 0
        formCliente.inputApellido.Text = ""
        formCliente.inputNombre.Text = ""
    End Sub

    Private Sub seleccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class