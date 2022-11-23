<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelApellido = New System.Windows.Forms.Label()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.inputApellido = New System.Windows.Forms.TextBox()
        Me.formClienteSguienteButton = New System.Windows.Forms.Button()
        Me.labelErrorApellifo = New System.Windows.Forms.Label()
        Me.labelErrorNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(52, 104)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 1
        Me.labelNombre.Text = "Nombre:"
        '
        'labelApellido
        '
        Me.labelApellido.AutoSize = True
        Me.labelApellido.Location = New System.Drawing.Point(52, 143)
        Me.labelApellido.Name = "labelApellido"
        Me.labelApellido.Size = New System.Drawing.Size(47, 13)
        Me.labelApellido.TabIndex = 2
        Me.labelApellido.Text = "Apellido:"
        '
        'inputNombre
        '
        Me.inputNombre.Location = New System.Drawing.Point(105, 101)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(100, 20)
        Me.inputNombre.TabIndex = 3
        '
        'inputApellido
        '
        Me.inputApellido.Location = New System.Drawing.Point(105, 140)
        Me.inputApellido.Name = "inputApellido"
        Me.inputApellido.Size = New System.Drawing.Size(100, 20)
        Me.inputApellido.TabIndex = 4
        '
        'formClienteSguienteButton
        '
        Me.formClienteSguienteButton.Enabled = False
        Me.formClienteSguienteButton.Location = New System.Drawing.Point(397, 426)
        Me.formClienteSguienteButton.Name = "formClienteSguienteButton"
        Me.formClienteSguienteButton.Size = New System.Drawing.Size(75, 23)
        Me.formClienteSguienteButton.TabIndex = 5
        Me.formClienteSguienteButton.Text = "&Siguiente"
        Me.formClienteSguienteButton.UseVisualStyleBackColor = True
        '
        'labelErrorApellifo
        '
        Me.labelErrorApellifo.AutoSize = True
        Me.labelErrorApellifo.ForeColor = System.Drawing.Color.Red
        Me.labelErrorApellifo.Location = New System.Drawing.Point(212, 143)
        Me.labelErrorApellifo.Name = "labelErrorApellifo"
        Me.labelErrorApellifo.Size = New System.Drawing.Size(95, 13)
        Me.labelErrorApellifo.TabIndex = 6
        Me.labelErrorApellifo.Text = "* labelErrorApellido"
        '
        'labelErrorNombre
        '
        Me.labelErrorNombre.AutoSize = True
        Me.labelErrorNombre.ForeColor = System.Drawing.Color.Red
        Me.labelErrorNombre.Location = New System.Drawing.Point(212, 101)
        Me.labelErrorNombre.Name = "labelErrorNombre"
        Me.labelErrorNombre.Size = New System.Drawing.Size(95, 13)
        Me.labelErrorNombre.TabIndex = 7
        Me.labelErrorNombre.Text = "* labelErrorNombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Paga con tarjeta?"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(199, 283)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "DNI"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(202, 240)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'formCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelErrorNombre)
        Me.Controls.Add(Me.labelErrorApellifo)
        Me.Controls.Add(Me.formClienteSguienteButton)
        Me.Controls.Add(Me.inputApellido)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.labelApellido)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formCliente"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents labelApellido As System.Windows.Forms.Label
    Friend WithEvents inputNombre As System.Windows.Forms.TextBox
    Friend WithEvents inputApellido As System.Windows.Forms.TextBox
    Friend WithEvents formClienteSguienteButton As System.Windows.Forms.Button
    Friend WithEvents labelErrorApellifo As System.Windows.Forms.Label
    Friend WithEvents labelErrorNombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
