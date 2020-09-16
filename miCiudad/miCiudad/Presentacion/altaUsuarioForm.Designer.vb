<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAltaUsuario
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
        Me.tbxCi = New System.Windows.Forms.TextBox()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxContrasenia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxCi
        '
        Me.tbxCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCi.Location = New System.Drawing.Point(582, 148)
        Me.tbxCi.Name = "tbxCi"
        Me.tbxCi.Size = New System.Drawing.Size(145, 26)
        Me.tbxCi.TabIndex = 0
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(577, 124)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(33, 20)
        Me.lblCi.TabIndex = 2
        Me.lblCi.Text = "C.I."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(580, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'cbxTipoUsuario
        '
        Me.cbxTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoUsuario.FormattingEnabled = True
        Me.cbxTipoUsuario.Location = New System.Drawing.Point(328, 258)
        Me.cbxTipoUsuario.Name = "cbxTipoUsuario"
        Me.cbxTipoUsuario.Size = New System.Drawing.Size(145, 28)
        Me.cbxTipoUsuario.TabIndex = 14
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(583, 382)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 25)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.BackColor = System.Drawing.Color.Transparent
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(325, 80)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(65, 20)
        Me.lblApellido.TabIndex = 20
        Me.lblApellido.Text = "Apellido"
        '
        'tbxApellido
        '
        Me.tbxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxApellido.Location = New System.Drawing.Point(330, 103)
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(145, 26)
        Me.tbxApellido.TabIndex = 19
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(325, 158)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono.TabIndex = 24
        Me.lblTelefono.Text = "Telefono"
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTelefono.Location = New System.Drawing.Point(330, 181)
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.Size = New System.Drawing.Size(145, 26)
        Me.tbxTelefono.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(576, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Contraseña"
        '
        'tbxContrasenia
        '
        Me.tbxContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxContrasenia.Location = New System.Drawing.Point(581, 226)
        Me.tbxContrasenia.Name = "tbxContrasenia"
        Me.tbxContrasenia.Size = New System.Drawing.Size(145, 26)
        Me.tbxContrasenia.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tipo de usuario"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(328, 382)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 25)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tbxNombre
        '
        Me.tbxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNombre.Location = New System.Drawing.Point(97, 171)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(145, 26)
        Me.tbxNombre.TabIndex = 17
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(92, 148)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCorreo.Location = New System.Drawing.Point(97, 249)
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(145, 26)
        Me.tbxCorreo.TabIndex = 25
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(92, 226)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(57, 20)
        Me.lblCorreo.TabIndex = 26
        Me.lblCorreo.Text = "Correo"
        '
        'formAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxContrasenia)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.tbxTelefono)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.tbxApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cbxTipoUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.tbxCi)
        Me.Name = "formAltaUsuario"
        Me.Text = "Alta usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxCi As TextBox
    Friend WithEvents lblCi As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTipoUsuario As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblApellido As Label
    Friend WithEvents tbxApellido As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents tbxTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxContrasenia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents tbxCorreo As TextBox
    Friend WithEvents lblCorreo As Label
End Class
