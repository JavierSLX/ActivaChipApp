Public Class LoginDlg

    Private Sub BtnAcceso_Click(sender As Object, e As EventArgs) Handles BtnAcceso.Click
        Loggin()
    End Sub
    Private Sub Limpiar()
        TbxNick.Text = ""
        TbxPass.Text = ""
        TbxNick.Select()
    End Sub
    Private Sub Loggin()
        If TbxNick.Text.Length() > 0 Then
            If TbxPass.Text.Length() > 0 Then
                Dim passwordEncriptado As String = EncriptarPassword(TbxPass.Text)
                'MsgBox(passwordEncriptado)
                AccesoUsuario(TbxNick.Text, passwordEncriptado)
                If Administrador > 0 Then
                    Inicio.SociosToolStripMenuItem.Enabled = True
                    Inicio.ClientesToolStripMenuItem.Enabled = True
                    Inicio.NumerosToolStripMenuItem.Enabled = True
                    Inicio.LbEmpresa.Text = Empresa
                    Inicio.LbNombre.Text = nombre
                    Inicio.LbEmpresa.Visible = True
                    Inicio.LbNombre.Visible = True
                    Inicio.GBBienvenido.Visible = True
                    Inicio.SalirToolStripMenuItem.Enabled = True
                    Inicio.LoginToolStripMenuItem.Enabled = False
                    If Permiso = 3 Then

                    Else
                        Inicio.VisualizarSociosToolStripMenuItem.Enabled = False
                        Inicio.EliminarRestaurarSociosToolStripMenuItem.Enabled = False
                        'Inicio.CompañíasToolStripMenuItem.Enabled = False
                        If Permiso = 1 Then
                            Inicio.SociosToolStripMenuItem.Enabled = False
                        End If
                    End If
                    Close()
                Else
                    MsgBox("Datos de acceso incorrectos", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
                    Limpiar()
                End If
            Else
                MsgBox("Favor de teclear el password de acceso", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
                TbxPass.Select()
                Return
            End If
        Else
            MsgBox("Favor de teclear el nick de acceso", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
            TbxNick.Select()
            Return
        End If
    End Sub

    Private Sub TbxNick_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxNick.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Loggin()
        End Select
    End Sub

    Private Sub TbxPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Loggin()
        End Select
    End Sub
End Class