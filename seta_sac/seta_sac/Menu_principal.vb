Imports System.Windows.Forms

Public Class Menu_principal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles BTNBASES.Click
        bases.MdiParent = Me
        bases.Show()
        Call boton(0)
        Call ocultar(0)
        BTNCERRAR.Enabled = True

    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles BTNEMPLEADOS.Click
        empleados.MdiParent = Me
        empleados.Show()
        Call boton(0)
        Call ocultar(0)
        BTNCERRAR.Enabled = True
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles BTNROL_MENSUAL.Click
        rol_mensual_vigilantes.MdiParent = Me
        rol_mensual_vigilantes.Show()
        Call boton(0)
        Call ocultar(0)
        BTNCERRAR.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles BTNVIGILANTES.Click
        Vigilantes.MdiParent = Me
        Vigilantes.Show()
        Call boton(0)
        Call ocultar(0)
        BTNCERRAR.Enabled = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles BTNSERV_DIARIO.Click
        serv_diario.MdiParent = Me
        serv_diario.Show()
        Call boton(0)
        Call ocultar(0)
        BTNCERRAR.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles BTNCERRAR.Click
        bases.Close()
        CARGO.Close()
        det_rol_mensual.Close()
        empleados.Close()
        Login.Close()
        Presentacion.Close()
        reemplazo.Close()
        Vigilantes.Close()
        rol_mensual_vigilantes.Close()
        serv_diario.Close()
        Call boton(1)

        BTNCERRAR.Enabled = False

        Call ocultar(1)
        BTNCERRAR.Size = New System.Drawing.Size(98, 200)
    End Sub
    Sub boton(activ As Boolean)
        BTNBASES.Enabled = activ
        BTNEMPLEADOS.Enabled = activ
        BTNROL_MENSUAL.Enabled = activ
        BTNVIGILANTES.Enabled = activ
        BTNSERV_DIARIO.Enabled = activ
        BTNCERRAR.Enabled = activ
    End Sub

    Sub ocultar(activ As Boolean)
        sep01.Visible = activ
        sep02.Visible = activ
        sep03.Visible = activ
        sep04.Visible = activ
        BTNBASES.Visible = activ
        BTNEMPLEADOS.Visible = activ
        BTNROL_MENSUAL.Visible = activ
        BTNVIGILANTES.Visible = activ
        BTNSERV_DIARIO.Visible = activ

        BTNCERRAR.Size = New System.Drawing.Size(98, 200)

    End Sub

    Private Sub Menu_principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BTNCERRAR.Enabled = False
    End Sub
End Class
