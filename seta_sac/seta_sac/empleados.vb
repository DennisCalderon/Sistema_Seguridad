Imports System.Data.SqlClient



Public Class empleados

    Dim c As SqlConnection
    Dim d As SqlDataAdapter
    Dim s As DataSet
    Dim x As Integer
    Public Sub REGISTRO()
        Dim num, den As Integer
        num = BindingContext(s, "EMPLEADO").Position + 1
        den = BindingContext(s, "EMPLEADO").Count

        lblregistro.Text = num & "/" & den
    End Sub

    Public Sub DESACTIVAR_TEXTBOX(D As Boolean)
        txtcodemp.Enabled = D
        Txtnomemp.Enabled = D
        Txtapeemp.Enabled = D
        txtdirecemp.Enabled = D
        txtdni.Enabled = D
        txttelefono.Enabled = D
        txtdirecemp.Enabled = D
        Txtcargemp.Enabled = D
        Txtcontra.Enabled = D

    End Sub


    Private Sub empleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        c = New SqlConnection("Data Source=PC02-28-PC\SQLEXPRESS;Initial Catalog=seta_sac;Integrated Security=True")
        d = New SqlDataAdapter("select * from EMPLEADO", c)
        s = New DataSet

        d.Fill(s, "EMPLEADO")
        txtcodemp.DataBindings.Add("text", s, "empleado.codemp")
        Txtnomemp.DataBindings.Add("text", s, "empleado.nomemp")
        Txtapeemp.DataBindings.Add("text", s, "EMPLEADO.apeemp")
        txtdirecemp.DataBindings.Add("text", s, "EMPLEADO.direcemp")
        txtdni.DataBindings.Add("text", s, "EMPLEADO.dniemp")
        Txtcontra.DataBindings.Add("text", s, "EMPLEADO.contraseña")
        Txtcargemp.DataBindings.Add("text", s, "EMPLEADO.codcargo")
        txttelefono.DataBindings.Add("text", s, "EMPLEADO.telemp")

        dgvempleado.DataMember = "EMPLEADO"
        dgvempleado.DataSource = s

        Call REGISTRO()
        Call DESACTIVAR_TEXTBOX(0)


    End Sub

    Private Sub BtnPrimero_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrimero.Click
        BindingContext(s, "EMPLEADO").Position = 0
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = True
        Call REGISTRO()

    End Sub

    Private Sub BtnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnterior.Click
        BindingContext(s, "EMPLEADO").Position = BindingContext(s, "EMPLEADO").Position - 1
        BtnSiguiente.Enabled = True
        BtnUltimo.Enabled = True
        If (BindingContext(s, "EMPLEADO").Position = 0) Then
            BtnAnterior.Enabled = False
            BtnPrimero.Enabled = False
        End If
        Call REGISTRO()
    End Sub

    Private Sub BtnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles BtnSiguiente.Click
        BindingContext(s, "EMPLEADO").Position = BindingContext(s, "EMPLEADO").Position + 1
        BtnAnterior.Enabled = True
        BtnPrimero.Enabled = True
        If (BindingContext(s, "EMPLEADO").Position = BindingContext(s, "EMPLEADO").Count - 1) Then
            BtnSiguiente.Enabled = False
            BtnUltimo.Enabled = False
        End If
        Call REGISTRO()
    End Sub

    Private Sub BtnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles BtnUltimo.Click
        BindingContext(s, "EMPLEADO").Position = BindingContext(s, "EMPLEADO").Count
        BtnSiguiente.Enabled = False
        BtnAnterior.Enabled = True
        Call REGISTRO()

    End Sub



    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        x = 1
        txtcodemp.Text = ""
        Txtnomemp.Text = ""
        Txtapeemp.Text = ""
        txtdirecemp.Text = ""
        txttelefono.Text = ""
        txtdni.Text = ""
        Txtcargemp.Text = ""
        Txtcontra.Text = ""

        txtcodemp.Focus()

        BtnGuardar.Enabled = True
        dgvempleado.Enabled = False

        BtnNuevo.Enabled = False
        BtnEditar.Enabled = False
        Btnactualizar.Enabled = False
        BtnEliminar.Enabled = False

        BtnPrimero.Enabled = False
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False


        Call DESACTIVAR_TEXTBOX(1)
        


    End Sub

    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click
        Dim comm As SqlCommand
        Dim codigo, nombre, apellido, direccion, telefono, dni, cargo, contraseña As String
        codigo = "'" & txtcodemp.Text & "'"
        nombre = "'" & Txtnomemp.Text & "'"
        apellido = "'" & Txtapeemp.Text & "'"
        direccion = "'" & txtdirecemp.Text & "'"
        telefono = "'" & txttelefono.Text & "'"
        dni = "'" & txtdni.Text & "'"
        cargo = "'" & Txtcargemp.Text & "'"
        contraseña = "'" & Txtcontra.Text & "'"

        Dim y As String
        If x = 1 Then
            y = "insert into empleado values(" & codigo & "," & nombre & "," & apellido & "," & direccion & "," & telefono & "," & dni & "," & cargo & "," & contraseña & ""
        Else : x = 2
            y = "update empleado set nomemp=" & nombre & ", Apeemp=" & apellido & ", DNI=" & dni & ", Telemp=" & telefono & ", diremp=" & direccion & ", cargo=" & cargo & ", contraseña=" & contraseña & " WHERE CODEMP=" & codigo & ""


        End If
        comm = New SqlCommand(y, c)

        c.Open()

        s.Clear()
        d.Fill(s, "EMPLEADO")
        comm.ExecuteNonQuery()


        s.Clear()
        d.Fill(s, "EMPLEADO")
        c.Close()
        Call REGISTRO()
        BtnGuardar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        Dim comm As SqlCommand
        Dim codigo As String

        Dim eliminar As String

        codigo = "'" & txtcodemp.Text & "'"
        MessageBox.Show("realmente desea eliminar el registro", "ALERTA!")
        eliminar = "DELETE FROM EMPLEADO WHERE CODEMP=" & codigo & ""

        comm = New SqlCommand(eliminar, c)
        c.Open()
        s.Clear()
        d.Fill(s, "EMPLEADO")
        comm.ExecuteNonQuery()

        c.Close()
        s.Clear()
        d.Fill(s, "EMPLEADO")

    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        dgvempleado.Enabled = True

        BtnPrimero.Enabled = True
        BtnAnterior.Enabled = True
        BtnSiguiente.Enabled = True
        BtnUltimo.Enabled = True

        BtnNuevo.Enabled = True
        BtnEditar.Enabled = True
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        Btnactualizar.Enabled = True
        BtnEliminar.Enabled = True



        s.Clear()
        d.Fill(s, "EMPLEADO")
        Call DESACTIVAR_TEXTBOX(1)

        BtnGuardar.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click

        BtnGuardar.Enabled = True
        dgvempleado.Enabled = False

        BtnNuevo.Enabled = False
        Btnactualizar.Enabled = False
        BtnEliminar.Enabled = False

        BtnPrimero.Enabled = False
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False

        x = 2
        Call DESACTIVAR_TEXTBOX(0)
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True

        txtcodemp.Enabled = False





    End Sub

    Private Sub Btnactualizar_Click(sender As System.Object, e As System.EventArgs) Handles Btnactualizar.Click
        s.Clear()
        d.Fill(s, "EMPLEADO")
    End Sub

    Private Sub btnbuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscar.Click

        Dim codigo As String
        Dim dv As DataView
        Dim x As Integer

        dv = New DataView
        dv.Table = s.Tables("EMPLEADO")
        dv.Sort = "codemp"
        codigo = InputBox("codigo a buscar")
        x = dv.Find(codigo)
        If x = -1 Then
            MessageBox.Show("codigo de EMPLEADO no existe", "cuidado")
            Exit Sub
        End If
        Me.BindingContext(s, "EMPLEADO").Position = x
        Call REGISTRO()

        s.Clear()
        d.Fill(s, "EMPLEADO")


    End Sub
End Class