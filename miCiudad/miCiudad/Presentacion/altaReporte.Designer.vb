<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAltaReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.tbxDireccion = New System.Windows.Forms.TextBox()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.tbxCi = New System.Windows.Forms.TextBox()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.tbxDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.subirImagen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Estado"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(31, 95)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefono.TabIndex = 34
        Me.lblTelefono.Text = "Direccion"
        '
        'tbxDireccion
        '
        Me.tbxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDireccion.Location = New System.Drawing.Point(36, 118)
        Me.tbxDireccion.Name = "tbxDireccion"
        Me.tbxDireccion.Size = New System.Drawing.Size(192, 26)
        Me.tbxDireccion.TabIndex = 33
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(31, 17)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(25, 20)
        Me.lblCi.TabIndex = 32
        Me.lblCi.Text = "CI"
        '
        'tbxCi
        '
        Me.tbxCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCi.Location = New System.Drawing.Point(36, 40)
        Me.tbxCi.Name = "tbxCi"
        Me.tbxCi.Size = New System.Drawing.Size(192, 26)
        Me.tbxCi.TabIndex = 31
        '
        'cbxEstado
        '
        Me.cbxEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cbxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"En proceso", "Aprobado", "Rechazado"})
        Me.cbxEstado.Location = New System.Drawing.Point(34, 195)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(194, 28)
        Me.cbxEstado.TabIndex = 30
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(31, 250)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(92, 20)
        Me.lblDescripcion.TabIndex = 37
        Me.lblDescripcion.Text = "Descripcion"
        '
        'tbxDescripcion
        '
        Me.tbxDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDescripcion.Location = New System.Drawing.Point(36, 273)
        Me.tbxDescripcion.Multiline = True
        Me.tbxDescripcion.Name = "tbxDescripcion"
        Me.tbxDescripcion.Size = New System.Drawing.Size(192, 29)
        Me.tbxDescripcion.TabIndex = 36
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(557, 250)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 25)
        Me.btnAceptar.TabIndex = 39
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'subirImagen
        '
        Me.subirImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subirImagen.Location = New System.Drawing.Point(438, 95)
        Me.subirImagen.Name = "subirImagen"
        Me.subirImagen.Size = New System.Drawing.Size(170, 25)
        Me.subirImagen.TabIndex = 40
        Me.subirImagen.Text = "subirImagen"
        Me.subirImagen.UseVisualStyleBackColor = True
        '
        'formAltaReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.subirImagen)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.tbxDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.tbxDireccion)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.tbxCi)
        Me.Controls.Add(Me.cbxEstado)
        Me.Name = "formAltaReporte"
        Me.Text = "altaReporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents tbxDireccion As TextBox
    Friend WithEvents lblCi As Label
    Friend WithEvents tbxCi As TextBox
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents tbxDescripcion As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents subirImagen As Button
End Class
