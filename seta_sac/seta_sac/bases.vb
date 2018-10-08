Imports System.Data.SqlClient
Public Class bases
    Dim c As SqlConnection
    Dim d As SqlDataAdapter
    Dim s As DataSet

    Dim x As Integer

    Public Sub REGISTRO()
        Dim NUM, DEN As Integer
        NUM = BindingContext(s, "BASE").Position + 1
        DEN = BindingContext(s, "BASE").Count
        Lblregistro.Text = NUM & "/" & DEN
    End Sub

    Public Sub DESACTIVAR_TEXTBOX(D As Boolean)
        Txtcodigo.Enabled = D
        TxtNombre.Enabled = D
        Txtdireccion.Enabled = D
        TxtNomCli.Enabled = D
    End Sub
 
    Private Sub bases_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dbgbase.ReadOnly = True
        BtnGuardar.Enabled = False

        c = New SqlConnection("Data Source=PC02-28-PC\SQLEXPRESS;Initial Catalog=seta_sac;Integrated Security=True")
        d = New SqlDataAdapter("select * from BASE", c)
        s = New DataSet
        d.Fill(s, "BASE")

        Txtcodigo.DataBindings.Add("text", s, "BASE.CODBASE")
        TxtNombre.DataBindings.Add("TEXT", s, "BASE.NOMBASE")
        Txtdireccion.DataBindings.Add("text", s, "BASE.DIRECBASE")
        TxtNomCli.DataBindings.Add("text", s, "BASE.NOMCLIBASE")

        Dbgbase.DataMember = "BASE"
        Dbgbase.DataSource = s


        Call REGISTRO()

        Call DESACTIVAR_TEXTBOX(0)

    End Sub

    Private Sub BtnPrimero_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrimero.Click
        BindingContext(s, "BASE").Position = 0
        BtnAnterior.Enabled = False
        BtnPrimero.Enabled = False

        BtnSiguiente.Enabled = True
        BtnUltimo.Enabled = True
        Call REGISTRO()

    End Sub

    Private Sub BtnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnterior.Click
        BindingContext(s, "BASE").Position = BindingContext(s, "BASE").Position - 1
        BtnSiguiente.Enabled = True
        BtnUltimo.Enabled = True
        If (BindingContext(s, "BASE").Position = 0) Then
            BtnAnterior.Enabled = False
            BtnPrimero.Enabled = False
        End If
        Call REGISTRO()

    End Sub

    Private Sub BtnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles BtnSiguiente.Click
        BindingContext(s, "BASE").Position = BindingContext(s, "BASE").Position + 1
        BtnAnterior.Enabled = True
        BtnPrimero.Enabled = True
        If (BindingContext(s, "BASE").Position = BindingContext(s, "BASE").Count - 1) Then
            BtnSiguiente.Enabled = False
            BtnUltimo.Enabled = False
        End If
        Call REGISTRO()

    End Sub

    Private Sub BtnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles BtnUltimo.Click
        BindingContext(s, "BASE").Position = BindingContext(s, "BASE").Count
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False

        BtnAnterior.Enabled = True
        BtnUltimo.Enabled = True
        Call REGISTRO()

    End Sub


    Private Sub Dbgbase_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dbgbase.CellContentClick
        Call REGISTRO()

    End Sub


    Private Sub btnbuscar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnbuscar.Click
        Dim codigo As String
        Dim dv As DataView
        Dim x As Integer

        dv = New DataView
        dv.Table = s.Tables("BASE")
        dv.Sort = "CODBASE"
        codigo = InputBox("codigo a buscar")
        x = dv.Find(codigo)

        If x = -1 Then
            MessageBox.Show("codigo de alumno no existe", "cuidado")
            Exit Sub
        End If
        Me.BindingContext(s, "BASE").Position = x
        Call REGISTRO()

    End Sub

    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click

        BtnGuardar.Enabled = True
        Dbgbase.Enabled = False

        BtnNuevo.Enabled = False
        BtnEditar.Enabled = False
        btnactualizar.Enabled = False
        BtnEliminar.Enabled = False

        BtnPrimero.Enabled = False
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False

        x = 1
        Txtcodigo.Text = ""
        TxtNombre.Text = ""
        Txtdireccion.Text = ""
        TxtNomCli.Text = ""
        Call DESACTIVAR_TEXTBOX(1)


    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        BtnGuardar.Enabled = True
        Dbgbase.Enabled = False

        BtnNuevo.Enabled = False
        btnactualizar.Enabled = False
        BtnEliminar.Enabled = False

        BtnPrimero.Enabled = False
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False

        x = 2
        Call DESACTIVAR_TEXTBOX(1)
        Txtcodigo.Enabled = False

    End Sub

    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click

        Dbgbase.Enabled = True

        Dim comm As SqlCommand
        Dim codigo, nombre, direccion, nomcli As String

        codigo = "'" & Txtcodigo.Text & "'"
        nombre = "'" & TxtNombre.Text & "'"
        direccion = "'" & Txtdireccion.Text & "'"
        nomcli = "'" & TxtNomCli.Text & "'"

        Dim y As String
        If x = 1 Then
            y = "INSERT INTO BASE VALUES (" & codigo & ", " & nombre & ", " & direccion & ", " & nomcli & ")"
        Else : x = 2
            y = "UPDATE BASE SET NOMBRE=" & nombre & ", DIRECCION=" & direccion & ", NOMCLI=" & nomcli & " WHERE CODBASE=" & codigo & ""
        End If
        comm = New SqlCommand(y, c)

        c.Open()

        s.Clear()
        d.fill(s, "BASE")
        comm.ExecuteNonQuery()
        c.Close()

        s.Clear()
        d.fill(s, "BASE")

        Call REGISTRO()

        BtnGuardar.Enabled = False

    End Sub

    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        Dim comm As SqlCommand
        Dim codigo As String

        Dim eliminar As String

        codigo = "'" & Txtcodigo.Text & "'"
        MessageBox.Show("realmente desea eliminar el registro", "ALERTA!")
        eliminar = "DELETE FROM BASE WHERE CODBASE=" & codigo & ""

        comm = New SqlCommand(eliminar, c)
        c.Open()
        s.Clear()
        d.Fill(s, "BASE")
        comm.ExecuteNonQuery()

        c.Close()
        s.Clear()
        d.Fill(s, "BASE")


    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click

        Dbgbase.Enabled = True

        BtnPrimero.Enabled = True
        BtnAnterior.Enabled = True
        BtnSiguiente.Enabled = True
        BtnUltimo.Enabled = True

        BtnNuevo.Enabled = True
        BtnEditar.Enabled = True
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        btnactualizar.Enabled = True
        BtnEliminar.Enabled = True

        s.Clear()
        d.Fill(s, "BASE")
        Call DESACTIVAR_TEXTBOX(0)

        BtnGuardar.Enabled = False
    End Sub

    Private Sub btnactualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnactualizar.Click
        s.Clear()
        d.Fill(s, "BASE")

    End Sub
End Class