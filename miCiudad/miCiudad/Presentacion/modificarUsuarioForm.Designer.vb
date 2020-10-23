<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarUserForm
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
        Me.cbxTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.tbxContrasenia = New System.Windows.Forms.TextBox()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lbltipoUsuarioMOD = New System.Windows.Forms.Label()
        Me.lblContraseñaMOD = New System.Windows.Forms.Label()
        Me.lblCorreoMOD = New System.Windows.Forms.Label()
        Me.lblTelMOD = New System.Windows.Forms.Label()
        Me.lblApellidoMOD = New System.Windows.Forms.Label()
        Me.lblNombreMOD = New System.Windows.Forms.Label()
        Me.lblCIMOD = New System.Windows.Forms.Label()
        Me.tbxCi = New System.Windows.Forms.TextBox()
        Me.lblAltaUser = New System.Windows.Forms.Label()
        Me.btnCancelarMOD = New System.Windows.Forms.Button()
        Me.btnAceptarMOD = New System.Windows.Forms.Button()
        Me.tbxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxTipoUsuario
        '
        Me.cbxTipoUsuario.FormattingEnabled = True
        Me.cbxTipoUsuario.Items.AddRange(New Object() {"Adm", "Cliente"})
        Me.cbxTipoUsuario.Location = New System.Drawing.Point(367, 309)
        Me.cbxTipoUsuario.Name = "cbxTipoUsuario"
        Me.cbxTipoUsuario.Size = New System.Drawing.Size(100, 21)
        Me.cbxTipoUsuario.TabIndex = 28
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Location = New System.Drawing.Point(367, 215)
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.tbxTelefono.TabIndex = 27
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Location = New System.Drawing.Point(367, 247)
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(100, 20)
        Me.tbxCorreo.TabIndex = 26
        '
        'tbxContrasenia
        '
        Me.tbxContrasenia.Location = New System.Drawing.Point(367, 280)
        Me.tbxContrasenia.Name = "tbxContrasenia"
        Me.tbxContrasenia.Size = New System.Drawing.Size(100, 20)
        Me.tbxContrasenia.TabIndex = 25
        '
        'tbxApellido
        '
        Me.tbxApellido.Location = New System.Drawing.Point(367, 184)
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(100, 20)
        Me.tbxApellido.TabIndex = 24
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(367, 150)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombre.TabIndex = 23
        '
        'lbltipoUsuarioMOD
        '
        Me.lbltipoUsuarioMOD.AutoSize = True
        Me.lbltipoUsuarioMOD.Location = New System.Drawing.Point(275, 317)
        Me.lbltipoUsuarioMOD.Name = "lbltipoUsuarioMOD"
        Me.lbltipoUsuarioMOD.Size = New System.Drawing.Size(86, 13)
        Me.lbltipoUsuarioMOD.TabIndex = 22
        Me.lbltipoUsuarioMOD.Text = "Tipo de usuario :"
        '
        'lblContraseñaMOD
        '
        Me.lblContraseñaMOD.AutoSize = True
        Me.lblContraseñaMOD.Location = New System.Drawing.Point(280, 287)
        Me.lblContraseñaMOD.Name = "lblContraseñaMOD"
        Me.lblContraseñaMOD.Size = New System.Drawing.Size(67, 13)
        Me.lblContraseñaMOD.TabIndex = 21
        Me.lblContraseñaMOD.Text = "Contraseña :"
        '
        'lblCorreoMOD
        '
        Me.lblCorreoMOD.AutoSize = True
        Me.lblCorreoMOD.Location = New System.Drawing.Point(280, 254)
        Me.lblCorreoMOD.Name = "lblCorreoMOD"
        Me.lblCorreoMOD.Size = New System.Drawing.Size(44, 13)
        Me.lblCorreoMOD.TabIndex = 20
        Me.lblCorreoMOD.Text = "Correo :"
        '
        'lblTelMOD
        '
        Me.lblTelMOD.AutoSize = True
        Me.lblTelMOD.Location = New System.Drawing.Point(280, 222)
        Me.lblTelMOD.Name = "lblTelMOD"
        Me.lblTelMOD.Size = New System.Drawing.Size(55, 13)
        Me.lblTelMOD.TabIndex = 19
        Me.lblTelMOD.Text = "Telefono :"
        '
        'lblApellidoMOD
        '
        Me.lblApellidoMOD.AutoSize = True
        Me.lblApellidoMOD.Location = New System.Drawing.Point(280, 191)
        Me.lblApellidoMOD.Name = "lblApellidoMOD"
        Me.lblApellidoMOD.Size = New System.Drawing.Size(50, 13)
        Me.lblApellidoMOD.TabIndex = 18
        Me.lblApellidoMOD.Text = "Apellido :"
        '
        'lblNombreMOD
        '
        Me.lblNombreMOD.AutoSize = True
        Me.lblNombreMOD.Location = New System.Drawing.Point(280, 157)
        Me.lblNombreMOD.Name = "lblNombreMOD"
        Me.lblNombreMOD.Size = New System.Drawing.Size(50, 13)
        Me.lblNombreMOD.TabIndex = 17
        Me.lblNombreMOD.Text = "Nombre :"
        '
        'lblCIMOD
        '
        Me.lblCIMOD.AutoSize = True
        Me.lblCIMOD.Location = New System.Drawing.Point(280, 121)
        Me.lblCIMOD.Name = "lblCIMOD"
        Me.lblCIMOD.Size = New System.Drawing.Size(23, 13)
        Me.lblCIMOD.TabIndex = 16
        Me.lblCIMOD.Text = "CI :"
        '
        'tbxCi
        '
        Me.tbxCi.Location = New System.Drawing.Point(367, 118)
        Me.tbxCi.Name = "tbxCi"
        Me.tbxCi.Size = New System.Drawing.Size(100, 20)
        Me.tbxCi.TabIndex = 15
        '
        'lblAltaUser
        '
        Me.lblAltaUser.AutoSize = True
        Me.lblAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaUser.Location = New System.Drawing.Point(251, 29)
        Me.lblAltaUser.Name = "lblAltaUser"
        Me.lblAltaUser.Size = New System.Drawing.Size(245, 25)
        Me.lblAltaUser.TabIndex = 29
        Me.lblAltaUser.Text = "MODIFICAR USUARIO"
        '
        'btnCancelarMOD
        '
        Me.btnCancelarMOD.Location = New System.Drawing.Point(260, 368)
        Me.btnCancelarMOD.Name = "btnCancelarMOD"
        Me.btnCancelarMOD.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarMOD.TabIndex = 31
        Me.btnCancelarMOD.Text = "Cancelar"
        Me.btnCancelarMOD.UseVisualStyleBackColor = True
        '
        'btnAceptarMOD
        '
        Me.btnAceptarMOD.Location = New System.Drawing.Point(401, 368)
        Me.btnAceptarMOD.Name = "btnAceptarMOD"
        Me.btnAceptarMOD.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarMOD.TabIndex = 30
        Me.btnAceptarMOD.Text = "Aceptar"
        Me.btnAceptarMOD.UseVisualStyleBackColor = True
        '
        'tbxNombreUsuario
        '
        Me.tbxNombreUsuario.Location = New System.Drawing.Point(367, 92)
        Me.tbxNombreUsuario.Name = "tbxNombreUsuario"
        Me.tbxNombreUsuario.Size = New System.Drawing.Size(100, 20)
        Me.tbxNombreUsuario.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nombre :"
        '
        'modificarUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbxNombreUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelarMOD)
        Me.Controls.Add(Me.btnAceptarMOD)
        Me.Controls.Add(Me.lblAltaUser)
        Me.Controls.Add(Me.cbxTipoUsuario)
        Me.Controls.Add(Me.tbxTelefono)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.tbxContrasenia)
        Me.Controls.Add(Me.tbxApellido)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.lbltipoUsuarioMOD)
        Me.Controls.Add(Me.lblContraseñaMOD)
        Me.Controls.Add(Me.lblCorreoMOD)
        Me.Controls.Add(Me.lblTelMOD)
        Me.Controls.Add(Me.lblApellidoMOD)
        Me.Controls.Add(Me.lblNombreMOD)
        Me.Controls.Add(Me.lblCIMOD)
        Me.Controls.Add(Me.tbxCi)
        Me.Name = "modificarUserForm"
        Me.Text = "Modificar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxTipoUsuario As ComboBox
    Friend WithEvents tbxTelefono As TextBox
    Friend WithEvents tbxCorreo As TextBox
    Friend WithEvents tbxContrasenia As TextBox
    Friend WithEvents tbxApellido As TextBox
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents lbltipoUsuarioMOD As Label
    Friend WithEvents lblContraseñaMOD As Label
    Friend WithEvents lblCorreoMOD As Label
    Friend WithEvents lblTelMOD As Label
    Friend WithEvents lblApellidoMOD As Label
    Friend WithEvents lblNombreMOD As Label
    Friend WithEvents lblCIMOD As Label
    Friend WithEvents tbxCi As TextBox
    Friend WithEvents lblAltaUser As Label
    Friend WithEvents btnCancelarMOD As Button
    Friend WithEvents btnAceptarMOD As Button
    Friend WithEvents tbxNombreUsuario As TextBox
    Friend WithEvents Label1 As Label
End Class
