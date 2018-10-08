
Imports System.Data.SqlClient

Public Class det_rol_mensual
    Dim c As SqlConnection
    Dim a As SqlDataAdapter
    Dim s As DataSet


    Private Sub det_rol_mensual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        c = New SqlConnection("Data Source=SAMAEL-PC\SQLEXPRESS;Initial Catalog=DBSETA;Integrated Security=True")
        a = New SqlDataAdapter("select * from detalle", c)
        s = New DataSet

        a.Fill(s, "detalle")
        CMBCODROL.DataBindings.Add("text", s, "detalle.codrol")
        CMBCODVIG.DataBindings.Add("text", s, "detalle.codvig")
        txtpuntos.DataBindings.Add("text", s, "detalle.puntos")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_1")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_2")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_3")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_4")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_5")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_6")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_7")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_8")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_9")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_10")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_11")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_12")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_13")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_14")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_15")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_16")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_17")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_18")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_19")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_20")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_21")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_22")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_23")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_24")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_25")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_26")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_27")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_28")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_29")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_30")
        cmbdia1.DataBindings.Add("text", s, "detalle.dia_31")



    End Sub

    Private Sub BtnPrimero_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrimero.Click
        BindingContext(s, "DETALLE").Position = 0
        BtnAnterior.Enabled = False
    End Sub

    Private Sub BtnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnterior.Click
        BindingContext(s, "DETALLE").Position = BindingContext(s, "DETALLE").Position - 1

    End Sub

    Private Sub BtnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles BtnSiguiente.Click
        BindingContext(s, "DETALLE").Position = BindingContext(s, "detalle").Position + 1
        BtnAnterior.Enabled = False
    End Sub

    Private Sub BtnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles BtnUltimo.Click
        BindingContext(s, "detalle").Position = BindingContext(s, "detalle").Count

    End Sub
End Class