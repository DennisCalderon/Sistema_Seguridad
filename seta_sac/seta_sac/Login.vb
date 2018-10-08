Imports System.Data.SqlClient
Public Class Login

    Dim c As SqlConnection
    Dim d As SqlDataAdapter
    Dim s As DataSet

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        c = New SqlConnection("Data Source=PC02-28-PC\SQLEXPRESS;Initial Catalog=seta_sac;Integrated Security=True")
        d = New SqlDataAdapter("select * from EMPLEADO", c)
        s = New DataSet
        d.Fill(s, "EMPLEADO")

        txtUsuario.DataBindings.Add("Text", c, "empleado.codemp")
        txtContraseña.DataBindings.Add("Text", c, "empleado.contraseña")

        txtUsuario.Clear()
        txtContraseña.Clear()
        txtUsuario.Focus()



    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Static inte As Integer
        Dim dvw As New DataView
        dvw.Table = s.Tables("empleado")
        dvw.RowFilter = "codemp ='" & txtUsuario.Text & "'" & " and " & " contraseña='" & txtContraseña.Text & "'"

        If dvw.Count > 0 Then
            MsgBox("BIENVENIDO A SETA.SAC", MsgBoxStyle.Information, "SEGURIDAD TACNA")
            Hide()

            Menu_principal.Show()
            Me.Close()

        Else

            inte = inte + 1
            If inte = 3 Then
                MsgBox("ADIOS", MsgBoxStyle.Exclamation, "SEGURIDAD TACNA")
                Close()
                Exit Sub

            End If

            MsgBox("LE QUEDA  " + Str(3 - inte) + " OPORTUNIDAD(ES) ", MsgBoxStyle.Critical, "SEGURIDAD TACNA")

            txtUsuario.Clear()
            txtContraseña.Clear()
            txtUsuario.Focus()


        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
