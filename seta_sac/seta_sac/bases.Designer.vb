<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bases))
        Me.TxtNomCli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dbgbase = New System.Windows.Forms.DataGridView()
        Me.GrbNavegacion = New System.Windows.Forms.GroupBox()
        Me.Lblregistro = New System.Windows.Forms.Label()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Dbgbase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNomCli
        '
        Me.TxtNomCli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNomCli.Location = New System.Drawing.Point(208, 210)
        Me.TxtNomCli.Name = "TxtNomCli"
        Me.TxtNomCli.Size = New System.Drawing.Size(253, 20)
        Me.TxtNomCli.TabIndex = 274
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Turquoise
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label6.Location = New System.Drawing.Point(14, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 19)
        Me.Label6.TabIndex = 273
        Me.Label6.Text = "Nombre de Cliente"
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
        Me.BtnEliminar.Location = New System.Drawing.Point(500, 355)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(60, 63)
        Me.BtnEliminar.TabIndex = 272
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnactualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnactualizar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.ForeColor = System.Drawing.Color.White
        Me.btnactualizar.Image = CType(resources.GetObject("btnactualizar.Image"), System.Drawing.Image)
        Me.btnactualizar.Location = New System.Drawing.Point(500, 292)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(68, 60)
        Me.btnactualizar.TabIndex = 271
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnactualizar.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(500, 229)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(60, 61)
        Me.BtnCancelar.TabIndex = 270
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
        Me.BtnGuardar.Location = New System.Drawing.Point(500, 175)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(60, 52)
        Me.BtnGuardar.TabIndex = 269
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
        Me.BtnEditar.Location = New System.Drawing.Point(500, 110)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(60, 61)
        Me.BtnEditar.TabIndex = 268
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
        Me.BtnNuevo.Location = New System.Drawing.Point(499, 46)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(61, 60)
        Me.BtnNuevo.TabIndex = 267
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnbuscar.Location = New System.Drawing.Point(493, 426)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 34)
        Me.btnbuscar.TabIndex = 266
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Broadway", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Turquoise
        Me.Label5.Location = New System.Drawing.Point(200, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 43)
        Me.Label5.TabIndex = 265
        Me.Label5.Text = "BASE"
        '
        'Dbgbase
        '
        Me.Dbgbase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dbgbase.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.Dbgbase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dbgbase.Location = New System.Drawing.Point(21, 335)
        Me.Dbgbase.Name = "Dbgbase"
        Me.Dbgbase.Size = New System.Drawing.Size(462, 184)
        Me.Dbgbase.TabIndex = 264
        '
        'GrbNavegacion
        '
        Me.GrbNavegacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrbNavegacion.BackColor = System.Drawing.Color.Transparent
        Me.GrbNavegacion.Controls.Add(Me.Lblregistro)
        Me.GrbNavegacion.Controls.Add(Me.BtnSiguiente)
        Me.GrbNavegacion.Controls.Add(Me.BtnUltimo)
        Me.GrbNavegacion.Controls.Add(Me.BtnAnterior)
        Me.GrbNavegacion.Controls.Add(Me.BtnPrimero)
        Me.GrbNavegacion.ForeColor = System.Drawing.Color.White
        Me.GrbNavegacion.Location = New System.Drawing.Point(10, 257)
        Me.GrbNavegacion.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrbNavegacion.Name = "GrbNavegacion"
        Me.GrbNavegacion.Size = New System.Drawing.Size(484, 61)
        Me.GrbNavegacion.TabIndex = 263
        Me.GrbNavegacion.TabStop = False
        Me.GrbNavegacion.Text = "Navegacion"
        '
        'Lblregistro
        '
        Me.Lblregistro.BackColor = System.Drawing.Color.White
        Me.Lblregistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lblregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblregistro.ForeColor = System.Drawing.Color.Blue
        Me.Lblregistro.Location = New System.Drawing.Point(167, 19)
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
        Me.BtnSiguiente.Location = New System.Drawing.Point(323, 19)
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
        Me.BtnUltimo.Location = New System.Drawing.Point(401, 19)
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
        Me.BtnAnterior.Location = New System.Drawing.Point(89, 19)
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
        Me.BtnPrimero.Location = New System.Drawing.Point(11, 19)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(72, 26)
        Me.BtnPrimero.TabIndex = 124
        Me.BtnPrimero.Text = "|< Primero"
        Me.BtnPrimero.UseVisualStyleBackColor = False
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtdireccion.Location = New System.Drawing.Point(208, 163)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(253, 20)
        Me.Txtdireccion.TabIndex = 262
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombre.Location = New System.Drawing.Point(208, 125)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(253, 20)
        Me.TxtNombre.TabIndex = 261
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtcodigo.Location = New System.Drawing.Point(208, 86)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(132, 20)
        Me.Txtcodigo.TabIndex = 260
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Turquoise
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(14, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 259
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(14, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 258
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Turquoise
        Me.Label2.Location = New System.Drawing.Point(14, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 19)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Codigo de Base"
        '
        'bases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(588, 569)
        Me.Controls.Add(Me.TxtNomCli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Dbgbase)
        Me.Controls.Add(Me.GrbNavegacion)
        Me.Controls.Add(Me.Txtdireccion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Txtcodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "bases"
        Me.Text = "bases"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dbgbase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbNavegacion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNomCli As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Dbgbase As System.Windows.Forms.DataGridView
    Friend WithEvents GrbNavegacion As System.Windows.Forms.GroupBox
    Friend WithEvents Lblregistro As System.Windows.Forms.Label
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents Txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
