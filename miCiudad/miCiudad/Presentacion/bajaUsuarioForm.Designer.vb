<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bajaUsuarioForm
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
        Me.lblAltaUser = New System.Windows.Forms.Label()
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.blCI = New System.Windows.Forms.Label()
        Me.btnAceptarBaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAltaUser
        '
        Me.lblAltaUser.AutoSize = True
        Me.lblAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaUser.Location = New System.Drawing.Point(311, 94)
        Me.lblAltaUser.Name = "lblAltaUser"
        Me.lblAltaUser.Size = New System.Drawing.Size(177, 25)
        Me.lblAltaUser.TabIndex = 2
        Me.lblAltaUser.Text = "BAJA USUARIO"
        '
        'tbxCI
        '
        Me.tbxCI.Location = New System.Drawing.Point(356, 179)
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(100, 20)
        Me.tbxCI.TabIndex = 3
        '
        'blCI
        '
        Me.blCI.AutoSize = True
        Me.blCI.Location = New System.Drawing.Point(327, 182)
        Me.blCI.Name = "blCI"
        Me.blCI.Size = New System.Drawing.Size(23, 13)
        Me.blCI.TabIndex = 4
        Me.blCI.Text = "CI :"
        '
        'btnAceptarBaja
        '
        Me.btnAceptarBaja.Location = New System.Drawing.Point(316, 259)
        Me.btnAceptarBaja.Name = "btnAceptarBaja"
        Me.btnAceptarBaja.Size = New System.Drawing.Size(140, 23)
        Me.btnAceptarBaja.TabIndex = 5
        Me.btnAceptarBaja.Text = "Eliminar usuario"
        Me.btnAceptarBaja.UseVisualStyleBackColor = True
        '
        'bajaUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAceptarBaja)
        Me.Controls.Add(Me.blCI)
        Me.Controls.Add(Me.tbxCI)
        Me.Controls.Add(Me.lblAltaUser)
        Me.Name = "bajaUsuarioForm"
        Me.Text = "Baja usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAltaUser As Label
    Friend WithEvents tbxCI As TextBox
    Friend WithEvents blCI As Label
    Friend WithEvents btnAceptarBaja As Button
End Class
