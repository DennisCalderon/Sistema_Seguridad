<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleados))
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Btnactualizar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txtcargemp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtcontra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdirecemp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtapeemp = New System.Windows.Forms.TextBox()
        Me.Txtnomemp = New System.Windows.Forms.TextBox()
        Me.txtcodemp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblregistro = New System.Windows.Forms.TextBox()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.dgvempleado = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbNavegacion.SuspendLayout()
        CType(Me.dgvempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(491, 262)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(60, 63)
        Me.BtnEliminar.TabIndex = 295
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Btnactualizar
        '
        Me.Btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnactualizar.BackColor = System.Drawing.Color.Transparent
        Me.Btnactualizar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnactualizar.ForeColor = System.Drawing.Color.Transparent
        Me.Btnactualizar.Image = CType(resources.GetObject("Btnactualizar.Image"), System.Drawing.Image)
        Me.Btnactualizar.Location = New System.Drawing.Point(425, 262)
        Me.Btnactualizar.Name = "Btnactualizar"
        Me.Btnactualizar.Size = New System.Drawing.Size(60, 60)
        Me.Btnactualizar.TabIndex = 294
        Me.Btnactualizar.Text = "actualizar"
        Me.Btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btnactualizar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(359, 262)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(60, 61)
        Me.BtnCancelar.TabIndex = 293
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(293, 262)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(60, 61)
        Me.BtnGuardar.TabIndex = 292
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.Location = New System.Drawing.Point(227, 262)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(60, 61)
        Me.BtnEditar.TabIndex = 291
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(160, 263)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(61, 60)
        Me.BtnNuevo.TabIndex = 290
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(263, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 1, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 289
        Me.PictureBox1.TabStop = False
        '
        'Txtcargemp
        '
        Me.Txtcargemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtcargemp.Location = New System.Drawing.Point(561, 148)
        Me.Txtcargemp.Name = "Txtcargemp"
        Me.Txtcargemp.Size = New System.Drawing.Size(110, 20)
        Me.Txtcargemp.TabIndex = 288
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(488, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 287
        Me.Label8.Text = "Cargo"
        '
        'Txtcontra
        '
        Me.Txtcontra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtcontra.Location = New System.Drawing.Point(561, 183)
        Me.Txtcontra.Name = "Txtcontra"
        Me.Txtcontra.Size = New System.Drawing.Size(110, 20)
        Me.Txtcontra.TabIndex = 286
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(457, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 285
        Me.Label9.Text = "Contraseña"
        '
        'txtdni
        '
        Me.txtdni.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdni.Location = New System.Drawing.Point(561, 116)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(110, 20)
        Me.txtdni.TabIndex = 284
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(500, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 283
        Me.Label7.Text = "DNI"
        '
        'txttelefono
        '
        Me.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttelefono.Location = New System.Drawing.Point(561, 83)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(110, 20)
        Me.txttelefono.TabIndex = 282
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(474, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Telefono"
        '
        'txtdirecemp
        '
        Me.txtdirecemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdirecemp.Location = New System.Drawing.Point(134, 201)
        Me.txtdirecemp.Name = "txtdirecemp"
        Me.txtdirecemp.Size = New System.Drawing.Size(110, 20)
        Me.txtdirecemp.TabIndex = 280
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(47, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Direccion"
        '
        'Txtapeemp
        '
        Me.Txtapeemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtapeemp.Location = New System.Drawing.Point(134, 165)
        Me.Txtapeemp.Name = "Txtapeemp"
        Me.Txtapeemp.Size = New System.Drawing.Size(110, 20)
        Me.Txtapeemp.TabIndex = 278
        '
        'Txtnomemp
        '
        Me.Txtnomemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtnomemp.Location = New System.Drawing.Point(134, 123)
        Me.Txtnomemp.Name = "Txtnomemp"
        Me.Txtnomemp.Size = New System.Drawing.Size(110, 20)
        Me.Txtnomemp.TabIndex = 277
        '
        'txtcodemp
        '
        Me.txtcodemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodemp.Location = New System.Drawing.Point(135, 86)
        Me.txtcodemp.Name = "txtcodemp"
        Me.txtcodemp.Size = New System.Drawing.Size(110, 20)
        Me.txtcodemp.TabIndex = 276
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 275
        Me.Label4.Text = "Codigo Empleado"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(47, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(47, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 273
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Broadway", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(139, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 42)
        Me.Label1.TabIndex = 272
        Me.Label1.Text = "DATOS DEL EMPLEADO"
        '
        'GrbNavegacion
        '
        Me.GrbNavegacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrbNavegacion.BackColor = System.Drawing.Color.Transparent
        Me.GrbNavegacion.Controls.Add(Me.lblregistro)
        Me.GrbNavegacion.Controls.Add(Me.BtnSiguiente)
        Me.GrbNavegacion.Controls.Add(Me.BtnUltimo)
        Me.GrbNavegacion.Controls.Add(Me.BtnAnterior)
        Me.GrbNavegacion.Controls.Add(Me.BtnPrimero)
        Me.GrbNavegacion.ForeColor = System.Drawing.Color.White
        Me.GrbNavegacion.Location = New System.Drawing.Point(80, 342)
        Me.GrbNavegacion.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrbNavegacion.Name = "GrbNavegacion"
        Me.GrbNavegacion.Size = New System.Drawing.Size(519, 61)
        Me.GrbNavegacion.TabIndex = 271
        Me.GrbNavegacion.TabStop = False
        Me.GrbNavegacion.Text = "Navegacion"
        '
        'lblregistro
        '
        Me.lblregistro.Location = New System.Drawing.Point(204, 20)
        Me.lblregistro.Name = "lblregistro"
        Me.lblregistro.Size = New System.Drawing.Size(110, 20)
        Me.lblregistro.TabIndex = 287
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackColor = System.Drawing.Color.White
        Me.BtnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.Blue
        Me.BtnSiguiente.Location = New System.Drawing.Point(355, 21)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(72, 26)
        Me.BtnSiguiente.TabIndex = 126
        Me.BtnSiguiente.Text = "Siguiente >"
        Me.BtnSiguiente.UseVisualStyleBackColor = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.BackColor = System.Drawing.Color.White
        Me.BtnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimo.ForeColor = System.Drawing.Color.Blue
        Me.BtnUltimo.Location = New System.Drawing.Point(433, 21)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(72, 26)
        Me.BtnUltimo.TabIndex = 127
        Me.BtnUltimo.Text = "Ultimo >|"
        Me.BtnUltimo.UseVisualStyleBackColor = False
        '
        'BtnAnterior
        '
        Me.BtnAnterior.BackColor = System.Drawing.Color.White
        Me.BtnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.ForeColor = System.Drawing.Color.Blue
        Me.BtnAnterior.Location = New System.Drawing.Point(105, 21)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(72, 26)
        Me.BtnAnterior.TabIndex = 125
        Me.BtnAnterior.Text = "< Anterior"
        Me.BtnAnterior.UseVisualStyleBackColor = False
        '
        'BtnPrimero
        '
        Me.BtnPrimero.BackColor = System.Drawing.Color.White
        Me.BtnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrimero.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrimero.Location = New System.Drawing.Point(18, 19)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(72, 26)
        Me.BtnPrimero.TabIndex = 124
        Me.BtnPrimero.Text = "|< Primero"
        Me.BtnPrimero.UseVisualStyleBackColor = False
        '
        'dgvempleado
        '
        Me.dgvempleado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvempleado.Location = New System.Drawing.Point(80, 411)
        Me.dgvempleado.Name = "dgvempleado"
        Me.dgvempleado.Size = New System.Drawing.Size(519, 150)
        Me.dgvempleado.TabIndex = 296
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnbuscar.Location = New System.Drawing.Point(605, 442)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 297
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(709, 592)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.dgvempleado)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Btnactualizar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txtcargemp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txtcontra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdirecemp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtapeemp)
        Me.Controls.Add(Me.Txtnomemp)
        Me.Controls.Add(Me.txtcodemp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrbNavegacion)
        Me.Name = "empleados"
        Me.Text = "empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbNavegacion.ResumeLayout(False)
        Me.GrbNavegacion.PerformLayout()
        CType(Me.dgvempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents Btnactualizar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txtcargemp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtcontra As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdirecemp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtapeemp As System.Windows.Forms.TextBox
    Friend WithEvents Txtnomemp As System.Windows.Forms.TextBox
    Friend WithEvents txtcodemp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrbNavegacion As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents dgvempleado As System.Windows.Forms.DataGridView
    Friend WithEvents lblregistro As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
End Class
