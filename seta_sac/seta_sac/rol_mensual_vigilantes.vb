
Imports System.Data.SqlClient

Public Class rol_mensual_vigilantes
    Dim c As SqlConnection
    Dim a As SqlDataAdapter
    Dim s As DataSet


    Private Sub rol_mensual_vigilantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        c = New SqlConnection("Data Source=PC02-28-PC\SQLEXPRESS;Initial Catalog=seta_sac;Integrated Security=True")
        a = New SqlDataAdapter("select * from ROL", c)
        s = New DataSet

        a.Fill(s, "ROL")

        txtcodrol.DataBindings.Add("text", s, "ROL.codrol")
        txtcodbas.DataBindings.Add("text", s, "ROL.codbase")
        txtcodemp.DataBindings.Add("text", s, "ROL.codemp")
        cmbaño.DataBindings.Add("text", s, "ROL.año")
        cmbmes.DataBindings.Add("text", s, "ROL.mes")

        DTfechReg.DataBindings.Add("text", s, "ROL.fecha_de_registro")

        dtgrol.DataMember = "ROL"
        dtgrol.DataSource = s

        Dim num, den As Integer
        num = BindingContext(s, "rol").Position + 1
        den = BindingContext(s, "rol").Count
        Lblregistro.Text = num & "/" & den

    End Sub

    Private Sub BtnPrimero_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrimero.Click
        BindingContext(s, "ROL").Position = 0
        BtnAnterior.Enabled = False

    End Sub

    Private Sub BtnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnterior.Click
        BindingContext(s, "ROL").Position = BindingContext(s, "ROL").Position - 1
        BtnSiguiente.Enabled = True

    End Sub

    Private Sub BtnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles BtnSiguiente.Click
        BindingContext(s, "ROL").Position = BindingContext(s, "rol").Position + 1
        BtnAnterior.Enabled = True

    End Sub

    Private Sub BtnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles BtnUltimo.Click
        BindingContext(s, "ROL").Position = BindingContext(s, "ROL").Count
        BtnSiguiente.Enabled = False

    End Sub
End Class