Imports System.Data.SqlClient

Public Class CARGO

    Dim c As SqlConnection
    Dim a As SqlDataAdapter
    Dim s As DataSet

    Dim x As Integer
    Public Sub registro()

        Dim num, den As Integer
        num = BindingContext(s, "CARGO").Position + 1
        den = BindingContext(s, "CARGO").Count

        lblregistro.Text = num & "/" & den

    End Sub

    Private Sub CARGO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        c = New SqlConnection("Data Source=PC02-28-PC\SQLEXPRESS;Initial Catalog=seta_sac;Integrated Security=True")
        a = New SqlDataAdapter("select * from CARGO", c)
        s = New DataSet

        a.Fill(s, "CARGO")
        TXTCODIGO.DataBindings.Add("text", s, "CARGO.codcargo")
        TXTDESCRIPCION.DataBindings.Add("text", s, "CARGO.descripcargo")
        

        dgvcargo.DataMember = "CARGO"
        dgvcargo.DataSource = s

        Call REGISTRO()



    End Sub

    Private Sub BtnPrimero_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrimero.Click
        BindingContext(s, "CARGO").Position = 0
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = False

        BtnSiguiente.Enabled = True
        BtnUltimo.Enabled = True
        Call registro()
    End Sub

    Private Sub BtnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnterior.Click
        BindingContext(s, "CARGO").Position = BindingContext(s, "CARGO").Position - 1
        BtnSiguiente.Enabled = True
        BtnUltimo.Enabled = True
        If (BindingContext(s, "CARGO").Position = 0) Then
            BtnAnterior.Enabled = False
            BtnPrimero.Enabled = False
        End If
        Call registro()
    End Sub

    Private Sub BtnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles BtnSiguiente.Click
        BindingContext(s, "CARGO").Position = BindingContext(s, "CARGO").Position + 1
        BtnAnterior.Enabled = True
        BtnPrimero.Enabled = True
        If (BindingContext(s, "CARGO").Position = BindingContext(s, "CARGO").Count - 1) Then
            BtnSiguiente.Enabled = False
            BtnUltimo.Enabled = False
        End If
        Call registro()
    End Sub

    Private Sub BtnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles BtnUltimo.Click
        BindingContext(s, "CARGO").Position = BindingContext(s, "CARGO").Count
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False

        BtnAnterior.Enabled = True
        BtnUltimo.Enabled = True
        Call registro()
    End Sub

    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        BtnGuardar.Enabled = True
        dgvcargo.Enabled = False

        BtnNuevo.Enabled = False
        BtnEditar.Enabled = False
        btnactualizar.Enabled = False
        BtnEliminar.Enabled = False

        BtnPrimero.Enabled = False
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False

        x = 1
        TXTCODIGO.Text = ""
        TXTDESCRIPCION.Text = ""

        TXTCODIGO.Enabled = False
        TXTDESCRIPCION.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        BtnGuardar.Enabled = True
        dgvcargo.Enabled = False

        BtnNuevo.Enabled = False
        btnactualizar.Enabled = False
        BtnEliminar.Enabled = False

        BtnPrimero.Enabled = False
        BtnAnterior.Enabled = False
        BtnSiguiente.Enabled = False
        BtnUltimo.Enabled = False

        x = 2
        TXTCODIGO.Enabled = False
        TXTDESCRIPCION.Enabled = False

    End Sub
End Class