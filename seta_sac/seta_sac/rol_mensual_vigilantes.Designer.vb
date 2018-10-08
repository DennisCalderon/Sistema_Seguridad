<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rol_mensual_vigilantes
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
        Dim Label2 As System.Windows.Forms.Label
        Dim CODEMPLEADOLabel As System.Windows.Forms.Label
        Dim CODBASELabel As System.Windows.Forms.Label
        Dim CODROLLabel As System.Windows.Forms.Label
        Dim FECHA_REGISTROLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rol_mensual_vigilantes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.DTfechReg = New System.Windows.Forms.DateTimePicker()
        Me.GrbNavegacion = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Lblregistro = New System.Windows.Forms.Label()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodemp = New System.Windows.Forms.TextBox()
        Me.txtcodbas = New System.Windows.Forms.TextBox()
        Me.txtcodrol = New System.Windows.Forms.TextBox()
        Me.dtgrol = New System.Windows.Forms.DataGridView()
        Label2 = New System.Windows.Forms.Label()
        CODEMPLEADOLabel = New System.Windows.Forms.Label()
        CODBASELabel = New System.Windows.Forms.Label()
        CODROLLabel = New System.Windows.Forms.Label()
        FECHA_REGISTROLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbNavegacion.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(12, 19)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(130, 24)
        Label2.TabIndex = 239
        Label2.Text = "MES  Y  AÑO "
        '
        'CODEMPLEADOLabel
        '
        CODEMPLEADOLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        CODEMPLEADOLabel.AutoSize = True
        CODEMPLEADOLabel.BackColor = System.Drawing.Color.Transparent
        CODEMPLEADOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CODEMPLEADOLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CODEMPLEADOLabel.Location = New System.Drawing.Point(185, 179)
        CODEMPLEADOLabel.Name = "CODEMPLEADOLabel"
        CODEMPLEADOLabel.Size = New System.Drawing.Size(161, 24)
        CODEMPLEADOLabel.TabIndex = 268
        CODEMPLEADOLabel.Text = "CODEMPLEADO:"
        '
        'CODBASELabel
        '
        CODBASELabel.Anchor = System.Windows.Forms.AnchorStyles.None
        CODBASELabel.AutoSize = True
        CODBASELabel.BackColor = System.Drawing.Color.Transparent
        CODBASELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CODBASELabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CODBASELabel.Location = New System.Drawing.Point(240, 142)
        CODBASELabel.Name = "CODBASELabel"
        CODBASELabel.Size = New System.Drawing.Size(106, 24)
        CODBASELabel.TabIndex = 266
        CODBASELabel.Text = "CODBASE:"
        '
        'CODROLLabel
        '
        CODROLLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        CODROLLabel.AutoSize = True
        CODROLLabel.BackColor = System.Drawing.Color.Transparent
        CODROLLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CODROLLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CODROLLabel.Location = New System.Drawing.Point(252, 109)
        CODROLLabel.Name = "CODROLLabel"
        CODROLLabel.Size = New System.Drawing.Size(94, 24)
        CODROLLabel.TabIndex = 264
        CODROLLabel.Text = "CODROL:"
        '
        'FECHA_REGISTROLabel
        '
        FECHA_REGISTROLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        FECHA_REGISTROLabel.AutoSize = True
        FECHA_REGISTROLabel.BackColor = System.Drawing.Color.Transparent
        FECHA_REGISTROLabel.ForeColor = System.Drawing.Color.White
        FECHA_REGISTROLabel.Location = New System.Drawing.Point(532, 26)
        FECHA_REGISTROLabel.Name = "FECHA_REGISTROLabel"
        FECHA_REGISTROLabel.Size = New System.Drawing.Size(104, 13)
        FECHA_REGISTROLabel.TabIndex = 263
        FECHA_REGISTROLabel.Text = "FECHA REGISTRO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.cmbaño)
        Me.GroupBox1.Controls.Add(Me.cmbmes)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(493, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 83)
        Me.GroupBox1.TabIndex = 282
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FECHA DEL PROXIMO ROL"
        '
        'cmbaño
        '
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbaño.Location = New System.Drawing.Point(158, 46)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(71, 21)
        Me.cmbaño.TabIndex = 241
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbmes.Location = New System.Drawing.Point(10, 46)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(128, 21)
        Me.cmbmes.TabIndex = 240
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 281
        Me.PictureBox1.TabStop = False
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
        Me.BtnEliminar.Location = New System.Drawing.Point(684, 457)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(60, 63)
        Me.BtnEliminar.TabIndex = 280
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(683, 393)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(60, 60)
        Me.BtnBuscar.TabIndex = 279
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBuscar.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(682, 327)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(60, 61)
        Me.BtnCancelar.TabIndex = 278
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
        Me.BtnGuardar.Location = New System.Drawing.Point(616, 392)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(60, 61)
        Me.BtnGuardar.TabIndex = 277
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
        Me.BtnEditar.Location = New System.Drawing.Point(616, 457)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(60, 61)
        Me.BtnEditar.TabIndex = 276
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
        Me.BtnNuevo.Location = New System.Drawing.Point(615, 328)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(61, 60)
        Me.BtnNuevo.TabIndex = 275
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNSALIR.Location = New System.Drawing.Point(527, 453)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(75, 34)
        Me.BTNSALIR.TabIndex = 274
        Me.BTNSALIR.Text = "SALIR"
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'DTfechReg
        '
        Me.DTfechReg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTfechReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfechReg.Location = New System.Drawing.Point(534, 46)
        Me.DTfechReg.Name = "DTfechReg"
        Me.DTfechReg.Size = New System.Drawing.Size(97, 20)
        Me.DTfechReg.TabIndex = 273
        '
        'GrbNavegacion
        '
        Me.GrbNavegacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrbNavegacion.BackColor = System.Drawing.Color.Transparent
        Me.GrbNavegacion.Controls.Add(Me.DataGridView2)
        Me.GrbNavegacion.Controls.Add(Me.Lblregistro)
        Me.GrbNavegacion.Controls.Add(Me.BtnSiguiente)
        Me.GrbNavegacion.Controls.Add(Me.BtnUltimo)
        Me.GrbNavegacion.Controls.Add(Me.BtnAnterior)
        Me.GrbNavegacion.Controls.Add(Me.BtnPrimero)
        Me.GrbNavegacion.ForeColor = System.Drawing.Color.Lavender
        Me.GrbNavegacion.Location = New System.Drawing.Point(70, 293)
        Me.GrbNavegacion.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrbNavegacion.Name = "GrbNavegacion"
        Me.GrbNavegacion.Size = New System.Drawing.Size(519, 61)
        Me.GrbNavegacion.TabIndex = 272
        Me.GrbNavegacion.TabStop = False
        Me.GrbNavegacion.Text = "Navegacion"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(134, 69)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(357, 150)
        Me.DataGridView2.TabIndex = 207
        '
        'Lblregistro
        '
        Me.Lblregistro.BackColor = System.Drawing.Color.White
        Me.Lblregistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lblregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblregistro.ForeColor = System.Drawing.Color.Blue
        Me.Lblregistro.Location = New System.Drawing.Point(183, 19)
        Me.Lblregistro.Name = "Lblregistro"
        Me.Lblregistro.Size = New System.Drawing.Size(150, 30)
        Me.Lblregistro.TabIndex = 128
        Me.Lblregistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Broadway", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PowderBlue
        Me.Label1.Location = New System.Drawing.Point(125, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 55)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "ROL MENSUAL"
        '
        'txtcodemp
        '
        Me.txtcodemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodemp.Location = New System.Drawing.Point(363, 175)
        Me.txtcodemp.Name = "txtcodemp"
        Me.txtcodemp.Size = New System.Drawing.Size(100, 28)
        Me.txtcodemp.TabIndex = 269
        '
        'txtcodbas
        '
        Me.txtcodbas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodbas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodbas.Location = New System.Drawing.Point(363, 141)
        Me.txtcodbas.Name = "txtcodbas"
        Me.txtcodbas.Size = New System.Drawing.Size(100, 28)
        Me.txtcodbas.TabIndex = 267
        '
        'txtcodrol
        '
        Me.txtcodrol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodrol.Location = New System.Drawing.Point(363, 107)
        Me.txtcodrol.Name = "txtcodrol"
        Me.txtcodrol.Size = New System.Drawing.Size(100, 28)
        Me.txtcodrol.TabIndex = 265
        '
        'dtgrol
        '
        Me.dtgrol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtgrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrol.Location = New System.Drawing.Point(70, 378)
        Me.dtgrol.Name = "dtgrol"
        Me.dtgrol.Size = New System.Drawing.Size(451, 164)
        Me.dtgrol.TabIndex = 283
        '
        'rol_mensual_vigilantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(794, 570)
        Me.Controls.Add(Me.dtgrol)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.DTfechReg)
        Me.Controls.Add(Me.GrbNavegacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CODEMPLEADOLabel)
        Me.Controls.Add(Me.txtcodemp)
        Me.Controls.Add(CODBASELabel)
        Me.Controls.Add(Me.txtcodbas)
        Me.Controls.Add(CODROLLabel)
        Me.Controls.Add(Me.txtcodrol)
        Me.Controls.Add(FECHA_REGISTROLabel)
        Me.Name = "rol_mensual_vigilantes"
        Me.Text = "rol_mensual_vigilantes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbNavegacion.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents DTfechReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrbNavegacion As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Lblregistro As System.Windows.Forms.Label
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodemp As System.Windows.Forms.TextBox
    Friend WithEvents txtcodbas As System.Windows.Forms.TextBox
    Friend WithEvents txtcodrol As System.Windows.Forms.TextBox
    Friend WithEvents dtgrol As System.Windows.Forms.DataGridView
End Class
