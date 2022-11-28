Public Class formCliente

    Dim nombreCorrecto As Boolean
    Dim apellidoCorrecto As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles formClienteSguienteButton.Click
        dniCliente = TextBox1.Text()
        Me.Hide()
        sanguches.Show()

    End Sub

    Private Sub inputNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputNombre.TextChanged
        If inputNombre.Text() <> "" Then
            nombreIngresado = inputNombre.Text()
            nombreCorrecto = True
        End If

        If apellidoCorrecto And nombreCorrecto Then
            formClienteSguienteButton.Enabled() = True
        End If
        If TextBox1.Enabled And TextBox1.Text <> "" Then
            formClienteSguienteButton.Enabled() = False
        End If
    End Sub

    Private Sub inputApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputApellido.TextChanged
        If inputApellido.Text() <> "" Then
            apellidoIngresado = inputApellido.Text()
            apellidoCorrecto = True
        End If

        If apellidoCorrecto And nombreCorrecto Then
            formClienteSguienteButton.Enabled() = True
        End If
        If TextBox1.Enabled And TextBox1.Text <> "" Then
            formClienteSguienteButton.Enabled() = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked() Then
            TextBox1.Enabled() = True
        End If
        If CheckBox1.Checked() = False Then
            TextBox1.Enabled() = False
            'Ahora mismo el dni no se almacena, hacer que se almacene en una variable global
        End If
        If TextBox1.Enabled And TextBox1.Text = "" Then
            formClienteSguienteButton.Enabled() = False
        Else
            formClienteSguienteButton.Enabled() = True

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text() <> "" Then
            dni = True
            formClienteSguienteButton.Enabled() = True
        Else
            dni = False
            formClienteSguienteButton.Enabled() = False
        End If
        dniCliente = TextBox1.Text()


    End Sub

    Private Sub formCliente_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub formCliente_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'TextBox1.Text() = ""
        CheckBox1.Checked() = False
    End Sub
End Class
