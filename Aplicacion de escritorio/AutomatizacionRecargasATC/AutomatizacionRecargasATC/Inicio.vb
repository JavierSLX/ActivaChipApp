Public Class Inicio
    Private Sub VisualizarSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarSociosToolStripMenuItem.Click
        VisualizarSociosDlg.Visible = True
    End Sub

    Private Sub EliminarRestaurarSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRestaurarSociosToolStripMenuItem.Click
        EliminarRestaurarSociosDlg.Visible = True
    End Sub

    Private Sub VisualizarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarUsuariosToolStripMenuItem.Click
        VisualizarUsuariosDlg.Visible = True
    End Sub

    Private Sub EliminarRestauararUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRestauararUsuariosToolStripMenuItem.Click
        EliminarRestaurarUsuariosDlg.Visible = True
    End Sub

    Private Sub VisualizarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarClientesToolStripMenuItem.Click
        VisualizarClientesDlg.Visible = True
    End Sub

    Private Sub EliminarRestaurarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRestaurarClientesToolStripMenuItem.Click
        EliminarRestaurarCliente.Visible = True
    End Sub

    Private Sub RegistroDeNúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RegistroFoliosDlg.Visible = True
    End Sub

    Private Sub AgregarPuntoDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPuntoDeVentaToolStripMenuItem.Click
        VisualizarPuntoVentaDlg.Visible = True
    End Sub

    Private Sub EliminarRestaurarPuntoDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRestaurarPuntoDeVentaToolStripMenuItem.Click
        EliminarRestaurarPuntoVenta.Visible = True
    End Sub

    Private Sub VisualizarCompañíasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        VisualizarCarriersDlg.Visible = True
    End Sub

    Private Sub EliminarRestaurarCompañíasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        EliminarRestaurarCarrierDlg.Visible = True
    End Sub

    Private Sub MontoDeRecargaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontoDeRecargaToolStripMenuItem.Click
        MontoRecargaDlg.Visible = True
    End Sub

    Private Sub RegistroNúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroNúmerosToolStripMenuItem.Click
        RegistroFoliosDlg.Visible = True
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SociosToolStripMenuItem.Enabled = False
        ClientesToolStripMenuItem.Enabled = False
        NumerosToolStripMenuItem.Enabled = False
        LbEmpresa.Visible = False
        LbNombre.Visible = False
        GBBienvenido.Visible = False
        SalirToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        LoginDlg.Visible = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        SociosToolStripMenuItem.Enabled = False
        ClientesToolStripMenuItem.Enabled = False
        NumerosToolStripMenuItem.Enabled = False
        LbEmpresa.Visible = False
        LbNombre.Visible = False
        GBBienvenido.Visible = False
        Empresa = ""
        nombre = ""
        Administrador = 0
        Permiso = 0
    End Sub

    Private Sub InformeDeRecargasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeDeRecargasToolStripMenuItem.Click
        InformeRecargasDlg.Visible = True
    End Sub

    Private Sub AccesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoToolStripMenuItem.Click

    End Sub

    Private Sub ComportamientoDeRecargasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComportamientoDeRecargasToolStripMenuItem.Click
        ComportamientoRecargasDlg.Visible = True
    End Sub
End Class
