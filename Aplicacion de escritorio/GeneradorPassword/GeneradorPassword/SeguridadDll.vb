Imports AutomatizacionRecargasATC.mx.atc.criptografiaService
Module SeguridadDll
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

End Module
