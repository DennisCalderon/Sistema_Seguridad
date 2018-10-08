<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reemplazo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reemplazo))
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GrbNavegacion = New System.Windows.Forms.GroupBox()
        Me.Lblregistro = New System.Windows.Forms.Label()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodrem = New System.Windows.Forms.TextBox()
        Me.txtfecharegistro = New System.Windows.Forms.TextBox()
        Me.txtcodvig = New System.Windows.Forms.TextBox()
        Me.txtcodrol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrbNavegacion.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnEliminar.Location = New System.Drawing.Point(478, 392)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(60, 63)
        Me.BtnEliminar.TabIndex = 284
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
        Me.BtnBuscar.Location = New System.Drawing.Point(412, 392)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(60, 60)
        Me.BtnBuscar.TabIndex = 283
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
        Me.BtnCancelar.Location = New System.Drawing.Point(346, 392)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(60, 61)
        Me.BtnCancelar.TabIndex = 282
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
        Me.BtnGuardar.Location = New System.Drawing.Point(280, 392)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(60, 61)
        Me.BtnGuardar.TabIndex = 281
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
        Me.BtnEditar.Location = New System.Drawing.Point(214, 392)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(60, 61)
        Me.BtnEditar.TabIndex = 280
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
        Me.BtnNuevo.Location = New System.Drawing.Point(147, 393)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(61, 60)
        Me.BtnNuevo.TabIndex = 279
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnNuevo.UseVisualStyleBackColor = False
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
        Me.GrbNavegacion.Location = New System.Drawing.Point(97, 167)
        Me.GrbNavegacion.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrbNavegacion.Name = "GrbNavegacion"
        Me.GrbNavegacion.Size = New System.Drawing.Size(519, 61)
        Me.GrbNavegacion.TabIndex = 278
        Me.GrbNavegacion.TabStop = False
        Me.GrbNavegacion.Text = "Navegacion"
        '
        'Lblregistro
        '
        Me.Lblregistro.BackColor = System.Drawing.Color.White
        Me.Lblregistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lblregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblregistro.ForeColor = System.Drawing.Color.CornflowerBlue
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
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(124, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(431, 150)
        Me.DataGridView1.TabIndex = 277
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 31)
        Me.Label4.TabIndex = 276
        Me.Label4.Text = "REEMPLAZO"
        '
        'txtcodrem
        '
        Me.txtcodrem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodrem.Location = New System.Drawing.Point(472, 111)
        Me.txtcodrem.Name = "txtcodrem"
        Me.txtcodrem.Size = New System.Drawing.Size(44, 20)
        Me.txtcodrem.TabIndex = 275
        '
        'txtfecharegistro
        '
        Me.txtfecharegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfecharegistro.Location = New System.Drawing.Point(472, 59)
        Me.txtfecharegistro.Name = "txtfecharegistro"
        Me.txtfecharegistro.Size = New System.Drawing.Size(130, 20)
        Me.txtfecharegistro.TabIndex = 274
        '
        'txtcodvig
        '
        Me.txtcodvig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodvig.Location = New System.Drawing.Point(202, 111)
        Me.txtcodvig.Name = "txtcodvig"
        Me.txtcodvig.Size = New System.Drawing.Size(44, 20)
        Me.txtcodvig.TabIndex = 273
        '
        'txtcodrol
        '
        Me.txtcodrol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcodrol.Location = New System.Drawing.Point(202, 59)
        Me.txtcodrol.Name = "txtcodrol"
        Me.txtcodrol.Size = New System.Drawing.Size(44, 20)
        Me.txtcodrol.TabIndex = 272
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 271
        Me.Label5.Text = "FECHA DE REGISTRO:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "CODIGO DE VIGILANTE:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Location = New System.Drawing.Point(311, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 29)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "CODIGO DE VIGILANTE REMPLAZO:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 268
        Me.Label1.Text = "CODIGO DE ROL:"
        '
        'reemplazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(649, 487)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GrbNavegacion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcodrem)
        Me.Controls.Add(Me.txtfecharegistro)
        Me.Controls.Add(Me.txtcodvig)
        Me.Controls.Add(Me.txtcodrol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "reemplazo"
        Me.Text = "reemplazo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrbNavegacion.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents GrbNavegacion As System.Windows.Forms.GroupBox
    Friend WithEvents Lblregistro As System.Windows.Forms.Label
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcodrem As System.Windows.Forms.TextBox
    Friend WithEvents txtfecharegistro As System.Windows.Forms.TextBox
    Friend WithEvents txtcodvig As System.Windows.Forms.TextBox
    Friend WithEvents txtcodrol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
