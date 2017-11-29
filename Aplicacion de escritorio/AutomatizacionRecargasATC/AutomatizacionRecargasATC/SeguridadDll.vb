Imports AutomatizacionRecargasATC.seguridadService.criptografiaService
Imports AutomatizacionRecargasATC.mx.atc.criptografiaService
Module SeguridadDll
    Dim sql As String
    'Variables de acceso
    Public Empresa As String
    Public nombre As String
    Public Function EncriptarPassword(ByVal password As String) As String
        'Dim seguridadWebService As New seguridadService.criptografiaService
        Dim seguridadWebService As New mx.atc.criptografiaService
        Dim passwordEncriptado As String
        Try
            passwordEncriptado = seguridadWebService.encriptar(password)
            EncriptarPassword = passwordEncriptado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function DesencriptarPassword(ByVal passwordEncriptado As String) As String
        'Dim seguridadWebService As New seguridadService.criptografiaService
        Dim seguridadWebService As New mx.atc.criptografiaService
        Dim passwordDesencriptado As String
        Try
            passwordDesencriptado = seguridadWebService.desencriptar(passwordEncriptado)

            DesencriptarPassword = passwordDesencriptado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub AccesoUsuario(nick As String, pass As String)
        sql = "SELECT administrador_id,permiso_id
                FROM permiso_administrador
                WHERE nickname='" + nick.ToString + "'
                AND pass='" + pass.ToString + "'
                AND activo=true"
        ObtenerPermiso(sql)
        sql = "SELECT nombre
                FROM administrador
                WHERE id='" + Administrador.ToString + "'"
        nombre = ObtneerNombreUsuario(sql)
        sql = "SELECT emp.nombre
                FROM administrador adm,empresa emp
                WHERE adm.id='" + Administrador.ToString + "'
                AND adm.empresa_id=emp.id"
        Empresa = ObtneerNombreUsuario(sql)
    End Sub
End Module
