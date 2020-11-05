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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAltaUsuario))
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.pbxRectangulo = New System.Windows.Forms.PictureBox()
        Me.pbxLinea = New System.Windows.Forms.PictureBox()
        Me.pbxVectorAltaUsuario = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.tbxContrasenia = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.tbxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.tbxCi = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.btnBorrar.Location = New System.Drawing.Point(376, 507)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(87, 25)
        Me.btnBorrar.TabIndex = 30
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'tbxNombre
        '
        Me.tbxNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxNombre.Location = New System.Drawing.Point(156, 201)
        Me.tbxNombre.Multiline = True
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(196, 35)
        Me.tbxNombre.TabIndex = 17
        '
        'pbxRectangulo
        '
        Me.pbxRectangulo.Image = CType(resources.GetObject("pbxRectangulo.Image"), System.Drawing.Image)
        Me.pbxRectangulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxRectangulo.Name = "pbxRectangulo"
        Me.pbxRectangulo.Size = New System.Drawing.Size(1120, 60)
        Me.pbxRectangulo.TabIndex = 33
        Me.pbxRectangulo.TabStop = False
        '
        'pbxLinea
        '
        Me.pbxLinea.Image = CType(resources.GetObject("pbxLinea.Image"), System.Drawing.Image)
        Me.pbxLinea.Location = New System.Drawing.Point(60, 120)
        Me.pbxLinea.Name = "pbxLinea"
        Me.pbxLinea.Size = New System.Drawing.Size(1000, 14)
        Me.pbxLinea.TabIndex = 34
        Me.pbxLinea.TabStop = False
        '
        'pbxVectorAltaUsuario
        '
        Me.pbxVectorAltaUsuario.Image = Global.miCiudad.My.Resources.Resources.Vector
        Me.pbxVectorAltaUsuario.Location = New System.Drawing.Point(85, 88)
        Me.pbxVectorAltaUsuario.Name = "pbxVectorAltaUsuario"
        Me.pbxVectorAltaUsuario.Size = New System.Drawing.Size(34, 27)
        Me.pbxVectorAltaUsuario.TabIndex = 35
        Me.pbxVectorAltaUsuario.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(123, 85)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(143, 28)
        Me.lblTitulo.TabIndex = 37
        Me.lblTitulo.Text = "Alta usuario"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNombre.Location = New System.Drawing.Point(154, 169)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 20)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "Nombre"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCorreo.Location = New System.Drawing.Point(154, 261)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(60, 20)
        Me.lblCorreo.TabIndex = 40
        Me.lblCorreo.Text = "Correo"
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxCorreo.Location = New System.Drawing.Point(156, 293)
        Me.tbxCorreo.Multiline = True
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(196, 35)
        Me.tbxCorreo.TabIndex = 39
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblContrasenia.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblContrasenia.Location = New System.Drawing.Point(154, 357)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(95, 20)
        Me.lblContrasenia.TabIndex = 42
        Me.lblContrasenia.Text = "Contraseña"
        '
        'tbxContrasenia
        '
        Me.tbxContrasenia.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxContrasenia.Location = New System.Drawing.Point(156, 389)
        Me.tbxContrasenia.Multiline = True
        Me.tbxContrasenia.Name = "tbxContrasenia"
        Me.tbxContrasenia.Size = New System.Drawing.Size(196, 35)
        Me.tbxContrasenia.TabIndex = 41
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNombreUsuario.Location = New System.Drawing.Point(459, 357)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(151, 20)
        Me.lblNombreUsuario.TabIndex = 48
        Me.lblNombreUsuario.Text = "Nombre de usuario"
        '
        'tbxNombreUsuario
        '
        Me.tbxNombreUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxNombreUsuario.Location = New System.Drawing.Point(461, 389)
        Me.tbxNombreUsuario.Multiline = True
        Me.tbxNombreUsuario.Name = "tbxNombreUsuario"
        Me.tbxNombreUsuario.Size = New System.Drawing.Size(196, 35)
        Me.tbxNombreUsuario.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(459, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Telefono"
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxTelefono.Location = New System.Drawing.Point(461, 293)
        Me.tbxTelefono.Multiline = True
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.Size = New System.Drawing.Size(196, 35)
        Me.tbxTelefono.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(459, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Apellido"
        '
        'tbxApellido
        '
        Me.tbxApellido.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxApellido.Location = New System.Drawing.Point(461, 201)
        Me.tbxApellido.Multiline = True
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(196, 35)
        Me.tbxApellido.TabIndex = 43
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblCi.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCi.Location = New System.Drawing.Point(765, 169)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(33, 20)
        Me.lblCi.TabIndex = 50
        Me.lblCi.Text = "C.I."
        '
        'tbxCi
        '
        Me.tbxCi.Font = New System.Drawing.Font("Microsoft Tai Le", 12.5!)
        Me.tbxCi.Location = New System.Drawing.Point(767, 201)
        Me.tbxCi.Multiline = True
        Me.tbxCi.Name = "tbxCi"
        Me.tbxCi.Size = New System.Drawing.Size(196, 35)
        Me.tbxCi.TabIndex = 49
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.btnAceptar.Location = New System.Drawing.Point(586, 507)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 36)
        Me.btnAceptar.TabIndex = 51
        Me.btnAceptar.Text = "Button1"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'formAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1104, 611)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.tbxCi)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.tbxNombreUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxApellido)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.tbxContrasenia)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pbxVectorAltaUsuario)
        Me.Controls.Add(Me.pbxLinea)
        Me.Controls.Add(Me.pbxRectangulo)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.tbxNombre)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formAltaUsuario"
        Me.Text = "Alta usuario"
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxVectorAltaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrar As Button
    Friend WithEvents pbxRectangulo As PictureBox
    Friend WithEvents pbxLinea As PictureBox
    Friend WithEvents pbxVectorAltaUsuario As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Private WithEvents tbxNombre As TextBox
    Friend WithEvents lblCorreo As Label
    Private WithEvents tbxCorreo As TextBox
    Friend WithEvents lblContrasenia As Label
    Private WithEvents tbxContrasenia As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Private WithEvents tbxNombreUsuario As TextBox
    Friend WithEvents Label4 As Label
    Private WithEvents tbxTelefono As TextBox
    Friend WithEvents Label5 As Label
    Private WithEvents tbxApellido As TextBox
    Friend WithEvents lblCi As Label
    Private WithEvents tbxCi As TextBox
    Friend WithEvents btnAceptar As Button
End Class
