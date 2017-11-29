Imports System.IO
Module LeerArchivosDll
    Public Sub LeerTxt(DGNumeros As DataGridView, Folio As String, Numero As Integer)
        Try
            Dim myStream As Stream = Nothing
            Dim openFileDialog1 As New OpenFileDialog()

            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    myStream = openFileDialog1.OpenFile()
                    If (myStream IsNot Nothing) Then
                        'Dim freader As New StreamReader(“C:\Users\Dulcinea\Desktop\ANGEL\pruebanumeros.txt”)
                        Dim freader As New StreamReader(openFileDialog1.OpenFile())
                        Dim contenido As String
                        Dim lineas As New ArrayList()
                        Do
                            contenido = freader.ReadLine()
                            If Not contenido Is Nothing Then
                                'si quiero leer solo las líneas que no estén en blanco incluyo esta condicion
                                If contenido.Length <> 0 Then
                                    lineas.Add(contenido)
                                    Dim salida As String = Numero
                                    Dim ceros As String = ""
                                    For i As Integer = Numero.ToString.Length() To 2
                                        ceros += "0"
                                    Next
                                    ceros += salida
                                    Dim FolioCompleto As String = Folio
                                    FolioCompleto += ceros
                                    DGNumeros.Rows.Add(FolioCompleto, contenido, 0)
                                End If
                            End If
                            Numero = Numero + 1
                        Loop Until contenido Is Nothing
                        freader.Close()
                    End If
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
