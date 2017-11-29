Public Class Generador
    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        DGPassword.Rows.Clear()

        LeerTxt(DGPassword)
    End Sub

    Private Sub Generador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
