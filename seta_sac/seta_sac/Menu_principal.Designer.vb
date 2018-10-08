<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_principal))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.botones = New System.Windows.Forms.ToolStrip()
        Me.BTNBASES = New System.Windows.Forms.ToolStripButton()
        Me.sep01 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNEMPLEADOS = New System.Windows.Forms.ToolStripButton()
        Me.sep02 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNROL_MENSUAL = New System.Windows.Forms.ToolStripButton()
        Me.sep03 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNVIGILANTES = New System.Windows.Forms.ToolStripButton()
        Me.sep04 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNSERV_DIARIO = New System.Windows.Forms.ToolStripButton()
        Me.sep05 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNCERRAR = New System.Windows.Forms.ToolStripButton()
        Me.sep06 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripButton, Me.ToolStripSeparator2, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(819, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Ayuda"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 699)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(819, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'botones
        '
        Me.botones.AutoSize = False
        Me.botones.Dock = System.Windows.Forms.DockStyle.Left
        Me.botones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNBASES, Me.sep01, Me.BTNEMPLEADOS, Me.sep02, Me.BTNROL_MENSUAL, Me.sep03, Me.BTNVIGILANTES, Me.sep04, Me.BTNSERV_DIARIO, Me.sep05, Me.BTNCERRAR, Me.sep06})
        Me.botones.Location = New System.Drawing.Point(0, 25)
        Me.botones.Name = "botones"
        Me.botones.Size = New System.Drawing.Size(100, 674)
        Me.botones.TabIndex = 9
        Me.botones.Text = "ToolStrip1"
        '
        'BTNBASES
        '
        Me.BTNBASES.AutoSize = False
        Me.BTNBASES.Image = Global.seta_sac.My.Resources.Resources.casita
        Me.BTNBASES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNBASES.Name = "BTNBASES"
        Me.BTNBASES.Size = New System.Drawing.Size(98, 70)
        Me.BTNBASES.Text = "BASES"
        Me.BTNBASES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sep01
        '
        Me.sep01.Name = "sep01"
        Me.sep01.Size = New System.Drawing.Size(98, 6)
        '
        'BTNEMPLEADOS
        '
        Me.BTNEMPLEADOS.AutoSize = False
        Me.BTNEMPLEADOS.Image = CType(resources.GetObject("BTNEMPLEADOS.Image"), System.Drawing.Image)
        Me.BTNEMPLEADOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNEMPLEADOS.Name = "BTNEMPLEADOS"
        Me.BTNEMPLEADOS.Size = New System.Drawing.Size(98, 70)
        Me.BTNEMPLEADOS.Text = "EMPLEADOS"
        Me.BTNEMPLEADOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sep02
        '
        Me.sep02.Name = "sep02"
        Me.sep02.Size = New System.Drawing.Size(98, 6)
        '
        'BTNROL_MENSUAL
        '
        Me.BTNROL_MENSUAL.AutoSize = False
        Me.BTNROL_MENSUAL.Image = CType(resources.GetObject("BTNROL_MENSUAL.Image"), System.Drawing.Image)
        Me.BTNROL_MENSUAL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNROL_MENSUAL.Name = "BTNROL_MENSUAL"
        Me.BTNROL_MENSUAL.Size = New System.Drawing.Size(98, 70)
        Me.BTNROL_MENSUAL.Text = "ROL MENSUAL"
        Me.BTNROL_MENSUAL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sep03
        '
        Me.sep03.Name = "sep03"
        Me.sep03.Size = New System.Drawing.Size(98, 6)
        '
        'BTNVIGILANTES
        '
        Me.BTNVIGILANTES.AutoSize = False
        Me.BTNVIGILANTES.Image = CType(resources.GetObject("BTNVIGILANTES.Image"), System.Drawing.Image)
        Me.BTNVIGILANTES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNVIGILANTES.Name = "BTNVIGILANTES"
        Me.BTNVIGILANTES.Size = New System.Drawing.Size(98, 70)
        Me.BTNVIGILANTES.Text = "VIGILANTES"
        Me.BTNVIGILANTES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sep04
        '
        Me.sep04.Name = "sep04"
        Me.sep04.Size = New System.Drawing.Size(98, 6)
        '
        'BTNSERV_DIARIO
        '
        Me.BTNSERV_DIARIO.AutoSize = False
        Me.BTNSERV_DIARIO.Image = CType(resources.GetObject("BTNSERV_DIARIO.Image"), System.Drawing.Image)
        Me.BTNSERV_DIARIO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNSERV_DIARIO.Name = "BTNSERV_DIARIO"
        Me.BTNSERV_DIARIO.Size = New System.Drawing.Size(98, 70)
        Me.BTNSERV_DIARIO.Text = "SERVICIO DIARIO"
        Me.BTNSERV_DIARIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sep05
        '
        Me.sep05.Name = "sep05"
        Me.sep05.Size = New System.Drawing.Size(98, 6)
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.AutoSize = False
        Me.BTNCERRAR.Image = CType(resources.GetObject("BTNCERRAR.Image"), System.Drawing.Image)
        Me.BTNCERRAR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(98, 70)
        Me.BTNCERRAR.Text = "CERRAR"
        Me.BTNCERRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sep06
        '
        Me.sep06.Name = "sep06"
        Me.sep06.Size = New System.Drawing.Size(98, 6)
        '
        'Menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 721)
        Me.Controls.Add(Me.botones)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "Menu_principal"
        Me.Text = "Menu_principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.botones.ResumeLayout(False)
        Me.botones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents botones As System.Windows.Forms.ToolStrip
    Friend WithEvents BTNBASES As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTNEMPLEADOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTNROL_MENSUAL As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTNVIGILANTES As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTNSERV_DIARIO As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTNCERRAR As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep06 As System.Windows.Forms.ToolStripSeparator

End Class
