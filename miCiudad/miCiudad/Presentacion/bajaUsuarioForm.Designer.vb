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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bajaUsuarioForm))
        Me.lblAltaUser = New System.Windows.Forms.Label()
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.blCI = New System.Windows.Forms.Label()
        Me.btnAceptarBaja = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbxRectangulo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAltaUser
        '
        Me.lblAltaUser.AutoSize = True
        Me.lblAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblAltaUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAltaUser.Location = New System.Drawing.Point(123, 85)
        Me.lblAltaUser.Name = "lblAltaUser"
        Me.lblAltaUser.Size = New System.Drawing.Size(133, 26)
        Me.lblAltaUser.TabIndex = 2
        Me.lblAltaUser.Text = "Baja usuario"
        '
        'tbxCI
        '
        Me.tbxCI.Location = New System.Drawing.Point(80, 216)
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(275, 20)
        Me.tbxCI.TabIndex = 3
        '
        'blCI
        '
        Me.blCI.AutoSize = True
        Me.blCI.ForeColor = System.Drawing.SystemColors.GrayText
        Me.blCI.Location = New System.Drawing.Point(77, 179)
        Me.blCI.Name = "blCI"
        Me.blCI.Size = New System.Drawing.Size(40, 13)
        Me.blCI.TabIndex = 4
        Me.blCI.Text = "Cedula"
        '
        'btnAceptarBaja
        '
        Me.btnAceptarBaja.Location = New System.Drawing.Point(340, 373)
        Me.btnAceptarBaja.Name = "btnAceptarBaja"
        Me.btnAceptarBaja.Size = New System.Drawing.Size(140, 23)
        Me.btnAceptarBaja.TabIndex = 5
        Me.btnAceptarBaja.Text = "Eliminar usuario"
        Me.btnAceptarBaja.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.miCiudad.My.Resources.Resources.Line_1
        Me.PictureBox2.Location = New System.Drawing.Point(50, 120)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(691, 11)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.miCiudad.My.Resources.Resources.Vector
        Me.PictureBox1.Location = New System.Drawing.Point(85, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pbxRectangulo
        '
        Me.pbxRectangulo.Image = CType(resources.GetObject("pbxRectangulo.Image"), System.Drawing.Image)
        Me.pbxRectangulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxRectangulo.Name = "pbxRectangulo"
        Me.pbxRectangulo.Size = New System.Drawing.Size(1120, 60)
        Me.pbxRectangulo.TabIndex = 34
        Me.pbxRectangulo.TabStop = False
        '
        'bajaUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbxRectangulo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAceptarBaja)
        Me.Controls.Add(Me.blCI)
        Me.Controls.Add(Me.tbxCI)
        Me.Controls.Add(Me.lblAltaUser)
        Me.Name = "bajaUsuarioForm"
        Me.Text = "Baja usuario"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAltaUser As Label
    Friend WithEvents tbxCI As TextBox
    Friend WithEvents blCI As Label
    Friend WithEvents btnAceptarBaja As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbxRectangulo As PictureBox
End Class
