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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCliente))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTE"
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.Location = New System.Drawing.Point(13, 153)
        Me.labelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(94, 23)
        Me.labelNombre.TabIndex = 1
        Me.labelNombre.Text = "Nombre:"
        '
        'labelApellido
        '
        Me.labelApellido.AutoSize = True
        Me.labelApellido.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelApellido.Location = New System.Drawing.Point(13, 205)
        Me.labelApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelApellido.Name = "labelApellido"
        Me.labelApellido.Size = New System.Drawing.Size(97, 23)
        Me.labelApellido.TabIndex = 2
        Me.labelApellido.Text = "Apellido:"
        '
        'inputNombre
        '
        Me.inputNombre.BackColor = System.Drawing.SystemColors.Info
        Me.inputNombre.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputNombre.Location = New System.Drawing.Point(114, 151)
        Me.inputNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(132, 31)
        Me.inputNombre.TabIndex = 3
        '
        'inputApellido
        '
        Me.inputApellido.BackColor = System.Drawing.SystemColors.Info
        Me.inputApellido.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputApellido.Location = New System.Drawing.Point(114, 197)
        Me.inputApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inputApellido.Name = "inputApellido"
        Me.inputApellido.Size = New System.Drawing.Size(132, 31)
        Me.inputApellido.TabIndex = 4
        '
        'formClienteSguienteButton
        '
        Me.formClienteSguienteButton.Enabled = False
        Me.formClienteSguienteButton.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formClienteSguienteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.formClienteSguienteButton.Location = New System.Drawing.Point(444, 461)
        Me.formClienteSguienteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.formClienteSguienteButton.Name = "formClienteSguienteButton"
        Me.formClienteSguienteButton.Size = New System.Drawing.Size(98, 29)
        Me.formClienteSguienteButton.TabIndex = 5
        Me.formClienteSguienteButton.Text = "&Siguiente"
        Me.formClienteSguienteButton.UseVisualStyleBackColor = True
        '
        'labelErrorApellifo
        '
        Me.labelErrorApellifo.AutoSize = True
        Me.labelErrorApellifo.ForeColor = System.Drawing.Color.Red
        Me.labelErrorApellifo.Location = New System.Drawing.Point(253, 205)
        Me.labelErrorApellifo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelErrorApellifo.Name = "labelErrorApellifo"
        Me.labelErrorApellifo.Size = New System.Drawing.Size(125, 16)
        Me.labelErrorApellifo.TabIndex = 6
        Me.labelErrorApellifo.Text = "* labelErrorApellido"
        '
        'labelErrorNombre
        '
        Me.labelErrorNombre.AutoSize = True
        Me.labelErrorNombre.ForeColor = System.Drawing.Color.Red
        Me.labelErrorNombre.Location = New System.Drawing.Point(254, 153)
        Me.labelErrorNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelErrorNombre.Name = "labelErrorNombre"
        Me.labelErrorNombre.Size = New System.Drawing.Size(124, 16)
        Me.labelErrorNombre.TabIndex = 7
        Me.labelErrorNombre.Text = "* labelErrorNombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(43, 312)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Paga con tarjeta?"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(151, 391)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 31)
        Me.TextBox1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 391)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "DNI:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(268, 317)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(385, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'formCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(636, 523)
        Me.Controls.Add(Me.PictureBox1)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "formCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
