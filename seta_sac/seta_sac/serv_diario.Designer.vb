<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serv_diario
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.DTfechReg = New System.Windows.Forms.DateTimePicker()
        Me.BTNPOS = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBTAUXILIAR = New System.Windows.Forms.RadioButton()
        Me.RBTFALTO = New System.Windows.Forms.RadioButton()
        Me.RBTTARDE = New System.Windows.Forms.RadioButton()
        Me.RBTPUNTUAL = New System.Windows.Forms.RadioButton()
        Me.BTNNEG = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbservicio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btndetalle = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmbvigreem = New System.Windows.Forms.ComboBox()
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        Me.Cmbvigact = New System.Windows.Forms.ComboBox()
        Me.Cmbrol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNREMPLAZO = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(589, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 18)
        Me.Label7.TabIndex = 236
        Me.Label7.Text = "FECHA ACTUAL"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.Silver
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.BTNBUSCAR.Location = New System.Drawing.Point(302, 352)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(118, 38)
        Me.BTNBUSCAR.TabIndex = 235
        Me.BTNBUSCAR.Text = "BUSCAR VIGILANTE"
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'DTfechReg
        '
        Me.DTfechReg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTfechReg.Enabled = False
        Me.DTfechReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfechReg.Location = New System.Drawing.Point(616, 23)
        Me.DTfechReg.Name = "DTfechReg"
        Me.DTfechReg.Size = New System.Drawing.Size(103, 20)
        Me.DTfechReg.TabIndex = 234
        '
        'BTNPOS
        '
        Me.BTNPOS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNPOS.BackColor = System.Drawing.Color.Silver
        Me.BTNPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPOS.ForeColor = System.Drawing.Color.Black
        Me.BTNPOS.Location = New System.Drawing.Point(629, 389)
        Me.BTNPOS.Name = "BTNPOS"
        Me.BTNPOS.Size = New System.Drawing.Size(118, 38)
        Me.BTNPOS.TabIndex = 233
        Me.BTNPOS.Text = "CALIFICACION POSITIVA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNPOS.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RBTAUXILIAR)
        Me.GroupBox3.Controls.Add(Me.RBTFALTO)
        Me.GroupBox3.Controls.Add(Me.RBTTARDE)
        Me.GroupBox3.Controls.Add(Me.RBTPUNTUAL)
        Me.GroupBox3.Location = New System.Drawing.Point(541, 433)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 121)
        Me.GroupBox3.TabIndex = 232
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CALIFICAION DEL SERVICIO"
        '
        'RBTAUXILIAR
        '
        Me.RBTAUXILIAR.AutoSize = True
        Me.RBTAUXILIAR.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTAUXILIAR.Location = New System.Drawing.Point(15, 88)
        Me.RBTAUXILIAR.Name = "RBTAUXILIAR"
        Me.RBTAUXILIAR.Size = New System.Drawing.Size(90, 19)
        Me.RBTAUXILIAR.TabIndex = 44
        Me.RBTAUXILIAR.TabStop = True
        Me.RBTAUXILIAR.Text = "AUXILIAR"
        Me.RBTAUXILIAR.UseVisualStyleBackColor = True
        '
        'RBTFALTO
        '
        Me.RBTFALTO.AutoSize = True
        Me.RBTFALTO.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTFALTO.Location = New System.Drawing.Point(15, 65)
        Me.RBTFALTO.Name = "RBTFALTO"
        Me.RBTFALTO.Size = New System.Drawing.Size(67, 19)
        Me.RBTFALTO.TabIndex = 43
        Me.RBTFALTO.TabStop = True
        Me.RBTFALTO.Text = "FALTO"
        Me.RBTFALTO.UseVisualStyleBackColor = True
        '
        'RBTTARDE
        '
        Me.RBTTARDE.AutoSize = True
        Me.RBTTARDE.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTTARDE.Location = New System.Drawing.Point(15, 42)
        Me.RBTTARDE.Name = "RBTTARDE"
        Me.RBTTARDE.Size = New System.Drawing.Size(69, 19)
        Me.RBTTARDE.TabIndex = 42
        Me.RBTTARDE.TabStop = True
        Me.RBTTARDE.Text = "TARDE"
        Me.RBTTARDE.UseVisualStyleBackColor = True
        '
        'RBTPUNTUAL
        '
        Me.RBTPUNTUAL.AutoSize = True
        Me.RBTPUNTUAL.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTPUNTUAL.Location = New System.Drawing.Point(15, 19)
        Me.RBTPUNTUAL.Name = "RBTPUNTUAL"
        Me.RBTPUNTUAL.Size = New System.Drawing.Size(86, 19)
        Me.RBTPUNTUAL.TabIndex = 41
        Me.RBTPUNTUAL.TabStop = True
        Me.RBTPUNTUAL.Text = "PUNTUAL"
        Me.RBTPUNTUAL.UseVisualStyleBackColor = True
        '
        'BTNNEG
        '
        Me.BTNNEG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNNEG.BackColor = System.Drawing.Color.Silver
        Me.BTNNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNEG.ForeColor = System.Drawing.Color.Black
        Me.BTNNEG.Location = New System.Drawing.Point(505, 389)
        Me.BTNNEG.Name = "BTNNEG"
        Me.BTNNEG.Size = New System.Drawing.Size(118, 38)
        Me.BTNNEG.TabIndex = 231
        Me.BTNNEG.Text = "CALIFICACION NEGATIVA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNNEG.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(113, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 32)
        Me.Label1.TabIndex = 230
        Me.Label1.Text = "CONTROL DE SERVICIO DIARIO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbaño)
        Me.GroupBox2.Controls.Add(Me.cmbmes)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbDia)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbservicio)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(75, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 94)
        Me.GroupBox2.TabIndex = 229
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECION DE SERVICIO"
        '
        'cmbaño
        '
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbaño.Location = New System.Drawing.Point(277, 62)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(60, 21)
        Me.cmbaño.TabIndex = 22
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbmes.Location = New System.Drawing.Point(118, 62)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(121, 21)
        Me.cmbmes.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "MES Y AÑO:"
        '
        'cmbDia
        '
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Items.AddRange(New Object() {"DIA_1", "DIA_2", "DIA_3", "DIA_4", "DIA_5", "DIA_6", "DIA_7", "DIA_8", "DIA_9", "DIA_10", "DIA_11", "DIA_12", "DIA_13", "DIA_14", "DIA_15", "DIA_16", "DIA_17", "DIA_18", "DIA_19", "DIA_20", "DIA_21", "DIA_22", "DIA_23", "DIA_24", "DIA_25", "DIA_26", "DIA_27", "DIA_28", "DIA_29", "DIA_30", "DIA_31"})
        Me.cmbDia.Location = New System.Drawing.Point(42, 24)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(62, 21)
        Me.cmbDia.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "DIA :"
        '
        'cmbservicio
        '
        Me.cmbservicio.FormattingEnabled = True
        Me.cmbservicio.Items.AddRange(New Object() {"A", "B", "F"})
        Me.cmbservicio.Location = New System.Drawing.Point(292, 27)
        Me.cmbservicio.Name = "cmbservicio"
        Me.cmbservicio.Size = New System.Drawing.Size(45, 21)
        Me.cmbservicio.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(144, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "SERVICIO A / B / F :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btndetalle
        '
        Me.btndetalle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndetalle.BackColor = System.Drawing.Color.Silver
        Me.btndetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndetalle.ForeColor = System.Drawing.Color.Black
        Me.btndetalle.Location = New System.Drawing.Point(156, 352)
        Me.btndetalle.Name = "btndetalle"
        Me.btndetalle.Size = New System.Drawing.Size(118, 38)
        Me.btndetalle.TabIndex = 228
        Me.btndetalle.Text = "MOSTRAR DETALLE"
        Me.btndetalle.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cmbvigreem)
        Me.GroupBox1.Controls.Add(Me.BTNMOSTRAR)
        Me.GroupBox1.Controls.Add(Me.Cmbvigact)
        Me.GroupBox1.Controls.Add(Me.Cmbrol)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNREMPLAZO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(26, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 136)
        Me.GroupBox1.TabIndex = 227
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAMBIO DE VIGILANTE"
        '
        'Cmbvigreem
        '
        Me.Cmbvigreem.FormattingEnabled = True
        Me.Cmbvigreem.Items.AddRange(New Object() {"VIG01", "VIG02", "VIG03", "VIG04", "VIG05", "VIG06", "VIG07", "VIG08", "VIG09", "VIG10", "VIG11", "VIG12", "VIG13", "VIG14", "VIG15", "VIG16", "VIG17", "VIG18", "VIG19", "VIG20"})
        Me.Cmbvigreem.Location = New System.Drawing.Point(326, 105)
        Me.Cmbvigreem.Name = "Cmbvigreem"
        Me.Cmbvigreem.Size = New System.Drawing.Size(68, 21)
        Me.Cmbvigreem.TabIndex = 34
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.BackColor = System.Drawing.Color.Silver
        Me.BTNMOSTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMOSTRAR.ForeColor = System.Drawing.Color.Black
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(566, 60)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(111, 38)
        Me.BTNMOSTRAR.TabIndex = 45
        Me.BTNMOSTRAR.Text = "MOSTRAR REEMPLAZO"
        Me.BTNMOSTRAR.UseVisualStyleBackColor = False
        '
        'Cmbvigact
        '
        Me.Cmbvigact.FormattingEnabled = True
        Me.Cmbvigact.Items.AddRange(New Object() {"VIG01", "VIG02", "VIG03", "VIG04", "VIG05", "VIG06", "VIG07", "VIG08", "VIG09", "VIG10", "VIG11", "VIG12", "VIG13", "VIG14", "VIG15", "VIG16", "VIG17", "VIG18", "VIG19", "VIG20"})
        Me.Cmbvigact.Location = New System.Drawing.Point(326, 71)
        Me.Cmbvigact.Name = "Cmbvigact"
        Me.Cmbvigact.Size = New System.Drawing.Size(68, 21)
        Me.Cmbvigact.TabIndex = 33
        '
        'Cmbrol
        '
        Me.Cmbrol.FormattingEnabled = True
        Me.Cmbrol.Items.AddRange(New Object() {"ROL01   ", "ROL02   ", "ROL03   ", "ROL04   ", "ROL05   ", "ROL06   ", "ROL07   ", "ROL08   ", "ROL09   ", "ROL10   ", "ROL11   ", "ROL12   ", "ROL13   ", "ROL14   ", "ROL15   ", "ROL16   ", "ROL17   ", "ROL18   ", "ROL19   ", "ROL20   "})
        Me.Cmbrol.Location = New System.Drawing.Point(326, 30)
        Me.Cmbrol.Name = "Cmbrol"
        Me.Cmbrol.Size = New System.Drawing.Size(68, 21)
        Me.Cmbrol.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "CODIGO DE ROL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "CODIGO DEL VIGILANTE REEMPLAZO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BTNREMPLAZO
        '
        Me.BTNREMPLAZO.BackColor = System.Drawing.Color.Silver
        Me.BTNREMPLAZO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREMPLAZO.ForeColor = System.Drawing.Color.Black
        Me.BTNREMPLAZO.Location = New System.Drawing.Point(443, 60)
        Me.BTNREMPLAZO.Name = "BTNREMPLAZO"
        Me.BTNREMPLAZO.Size = New System.Drawing.Size(111, 38)
        Me.BTNREMPLAZO.TabIndex = 26
        Me.BTNREMPLAZO.Text = "REEMPLAZAR VIGILANTE"
        Me.BTNREMPLAZO.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "CODIGO DEL VIGILANTE ACTUAL:"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(488, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 44)
        Me.Button1.TabIndex = 226
        Me.Button1.Text = "MOSTRAR SELECCION"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 418)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(464, 158)
        Me.DataGridView1.TabIndex = 225
        '
        'serv_diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(789, 590)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.DTfechReg)
        Me.Controls.Add(Me.BTNPOS)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BTNNEG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btndetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "serv_diario"
        Me.Text = "serv_diario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents DTfechReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTNPOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RBTAUXILIAR As System.Windows.Forms.RadioButton
    Friend WithEvents RBTFALTO As System.Windows.Forms.RadioButton
    Friend WithEvents RBTTARDE As System.Windows.Forms.RadioButton
    Friend WithEvents RBTPUNTUAL As System.Windows.Forms.RadioButton
    Friend WithEvents BTNNEG As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbservicio As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btndetalle As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmbvigreem As System.Windows.Forms.ComboBox
    Friend WithEvents BTNMOSTRAR As System.Windows.Forms.Button
    Friend WithEvents Cmbvigact As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbrol As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNREMPLAZO As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
