Imports System.IO
Module LeerArchivosDll
    Public Sub LeerTxt(DGPassword As DataGridView)
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
                                    Dim usuario As String = ""
                                    For x As Integer = 0 To contenido.Length() - 1
                                        If Char.IsDigit(contenido.Chars(x)) Then

                                        Else
                                            usuario += contenido.Chars(x)
                                        End If
                                    Next
                                    lineas.Add(contenido)
                                    Dim password As String = contenido
                                    Dim passwordEncriptado As String = EncriptarPassword(password)

                                    DGPassword.Rows.Add(usuario, password, passwordEncriptado)
                                End If
                            End If
                            'id = id + 1
                        Loop Until contenido Is Nothing
                        freader.Close()
                    End If
                    MsgBox("Passwords generados")
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Guardar en txt
    Function gridatxt(ByVal Grid As DataGridView) As Boolean
        Dim texto As StreamWriter
        Dim escribo As String
        Dim filas As Integer
        Dim columnas As Integer
        Dim titulo As String = ""
        Dim palabra As String
        Dim letras As Integer
        Dim nuevo As String
        filas = Grid.RowCount - 1
        columnas = Grid.ColumnCount - 1
        texto = New StreamWriter("C:PRUEBA.txt")
        Dim tamaño(columnas) As Integer
        For i = 0 To columnas
            tamaño(i) = 0
        Next
        For a = 0 To filas
            Grid.CurrentCell = Grid.Rows(a).Cells(0)
            For b = 0 To columnas
                titulo = Grid.Columns(b).Name
                If IsDBNull(Grid.CurrentRow.Cells.Item(titulo).Value) Then
                    palabra = "NULL"
                Else
                    palabra = Grid.CurrentRow.Cells.Item(titulo).Value
                End If
                letras = palabra.Length
                If letras > tamaño(b) Then
                    tamaño(b) = letras
                End If
            Next
        Next
        For a = 0 To filas
            escribo = ""
            Grid.CurrentCell = Grid.Rows(a).Cells(0)
            For b = 0 To columnas
                titulo = Grid.Columns(b).Name
                If b = 0 Then
                    If IsDBNull(Grid.CurrentRow.Cells.Item(titulo).Value) Then
                        escribo = "NULL"
                    Else
                        escribo = Grid.CurrentRow.Cells.Item(titulo).Value
                        letras = escribo.Length
                    End If
                Else
                    If IsDBNull(Grid.CurrentRow.Cells.Item(titulo).Value) Then
                        escribo = "NULL"
                    Else
                        nuevo = Grid.CurrentRow.Cells.Item(titulo).Value
                        letras = nuevo.Length
                        Do While letras < tamaño(b)
                            nuevo = nuevo & " "
                            letras = letras + 1
                        Loop
                        escribo = escribo & " " & nuevo
                    End If
                End If
            Next
            texto.WriteLine(escribo)
        Next
        texto.Close()
    End Function
End Module
