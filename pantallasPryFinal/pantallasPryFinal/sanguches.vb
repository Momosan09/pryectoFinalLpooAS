Public Class sanguches


    Public ultimo As String

    Private Sub sanguches_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Label3.Text() = "Nombre : " + nombreIngresado
        Label4.Text() = "Apellido : " + apellidoIngresado
        Label10.Text() = "DNI : " + dniCliente

        If dni Then
            efectivo.Enabled() = True
            debito.Enabled() = True
            credito.Enabled() = True
        Else
            debito.Enabled() = False
            credito.Enabled() = False
        End If
    End Sub

    Private Sub sanguches_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        precio = 0
        precioN = 0
        efectivo.Checked() = False
        debito.Checked() = False
        credito.Checked() = False
        ListBox2.Items.Clear()



    End Sub

    Private Sub sanguches_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ListView1.Bounds = New Rectangle(New Point(10, 10), New Size(300, 200))
        'ListView1.GridLines = True


        ListBox1.Items.Add(sanguche1Nombre)
        ListBox1.Items.Add(sanguche2Nombre)
        ListBox1.Items.Add(sanguche3Nombre)
        ListBox1.Items.Add(sanguche4Nombre)
        ListBox1.Items.Add(sanguche5Nombre)

        Label3.Text() = "Nombre : " + nombreIngresado
        Label4.Text() = "Apellido : " + apellidoIngresado
        Label10.Text() = "DNI : " + dniCliente

        efectivo.Enabled() = True
        debito.Enabled() = False
        credito.Enabled() = False

        If efectivo.Checked() = False And debito.Checked() = False And credito.Checked() = False Then
            Button2.Enabled() = False
        Else
            Button2.Enabled() = True
        End If

        If dni Then
            efectivo.Enabled() = True
            debito.Enabled() = True
            credito.Enabled() = True
        Else
            debito.Enabled() = False
            credito.Enabled() = False
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label2.Text() = "Selected " + ListBox1.Text()
        ListBox2.Items.Add(ListBox1.Text)

        If ListBox1.Text() = "Lomi Lomi Morti Morti" Then
            precio = precio + 200
            ultimo = ListBox1.Text()

        End If
        If ListBox1.Text() = "La atomica" Then
            precio = precio + 300
            ultimo = ListBox1.Text()
        End If
        If ListBox1.Text() = "La gorda" Then
            precio = precio + 400
            ultimo = ListBox1.Text()
        End If
        If ListBox1.Text() = "Otra ronda" Then
            precio = precio + 500
            ultimo = ListBox1.Text()
        End If
        If ListBox1.Text() = "El engorroso" Then
            precio = precio + 600
            ultimo = ListBox1.Text()
        End If

        precioN = precio
        Label7.Text = "$ " & precio
        Label9.Text = "$ " & precioN


    End Sub

    Private Sub efectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efectivo.CheckedChanged
        metodoPago = "efectivo"
        precio = precioN
        precio = precio - (precio * 10) / 100
        Label7.Text = "$ " & precio
        Label9.Text = "$ " & precioN
        precio = precioN

        If efectivo.Checked() = False And debito.Checked() = False And credito.Checked() = False Then
            Button2.Enabled() = False
        Else
            Button2.Enabled() = True
        End If


    End Sub

    Private Sub debito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles debito.CheckedChanged
        metodoPago = "debito"
        precio = precioN
        precio = precio + (precio * 5) / 100
        Label7.Text = "$ " & precio
        Label9.Text = "$ " & precioN
        precio = precioN

        If efectivo.Checked() = False And debito.Checked() = False And credito.Checked() = False Then
            Button2.Enabled() = False
        Else
            Button2.Enabled() = True
        End If


    End Sub

    Private Sub credito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles credito.CheckedChanged
        metodoPago = "credito"
        precio = precioN
        precio = precio + (precio * 7) / 100
        Label7.Text = "$ " & precio
        Label9.Text = "$ " & precioN

        precio = precioN

        If efectivo.Checked() = False And debito.Checked() = False And credito.Checked() = False Then
            Button2.Enabled() = False
        Else
            Button2.Enabled() = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        precio = 0
        precioN = 0

        efectivo.Checked() = False
        debito.Checked() = False
        credito.Checked() = False
        ListBox2.Items.Clear()
        Label7.Text = "$ " & precio
        Label9.Text = "$ " & precioN

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        formCliente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        seleccion.Show()
    End Sub

End Class