<h1><P ALIGN=center>Proyecto Automatización de Recargas ATC</h1>
----------
<h3><P ALIGN=center>Actividades Ángel</h3></P>

----------

<h5>13/11/2017</h5>
Actividades realizadas durante el día 13 de Noviembre del 2017:

* Base de Datos
	* Diseño y generación del script de la base de datos `recargasatc`.	
	* Creación del modulo `BaseDatosDll` necesario para almacenar los métodos propios para la gestión de la base de datos.
	* Se agrego la referencia `MySql.Data` para poder establecer la conexión con la base de datos.
	* Se creó la cadena de conexión con la base de datos.
* Creación del menú `MenuInicio` necesario para la navegación rápida del usuario.
* Creación del submenú `Socios` con las opciones `Visualizar Socios` y `Eliminar/Restaurar Socios` en ella el usuario podrá gestionar los datos de los socios que usaran la aplicación.
* `VisualizarSociosDlg`
	* Creación y diseño del formulario.
	* Creación del método `Insertar` en modulo `BaseDatosDll` para hacer inserción y actualización en la base de datos.
	* Creación del método `ComprobrarExistencia` en modulo `BaseDatosDll` para comprobar la existencia de un elemento en la base de datos.
	* Creación del método `mostrarDatosDataGridView` en modulo `BaseDatosDll` para mostrar los resultados de una consulta en un `DataGridView`.
	* Implementación del método `MostrarSocios` en el se pueden visualizar todos los socios que están activos en la base de datos.
	* Implementación del método `GuardarSocio` para agregar un nuevo socio en la base de datos.
	* Implementación del método `LimpiarFormulario` para reiniciar los elementos del formulario.
	* Implementación del método `EditarSocio` para editar la información de un socio en la base de datos.
	* Se estableció el orden de tabulación de los elementos del formulario.
	* Se implemento que al dar enter se registro o actualice la información según desee el usuario.
	* Validación que el nombre del socio contenga información.
	* Validación que la información del socio contenga información.
	* Validación que el teléfono del socio contenga información.
	* Validación que no exista registros repetidos.
	* Validación que el campo `TbxTelefono` solo acepte valores de tipo entero.
* `EliminarRestaurarSociosDlg`
	* Creación y diseño del formulario.
	* Creación del método generarReporte necesario para visualizar los socios activos o inactivos dependiendo de la opción seleccionada.
	* Creación del método `ActualizarEstado` necesario para actualizar si el socio esta activo o inactivo.
	* Programación del evento `TabSocios_SelectedIndexChanged` para cambiar las opciones que requiere el usuario.
	* Creación del submenú `Usuarios` con las opciones `Visualizar Usuarios` y `Eliminar/Restaurar Usuarios` en ella el usuario podrá gestionar los datos de los socios que usaran la aplicación.
* `VisualizarUsuariosDlg`
	* Creación y diseño del formulario.
	* Creación del método `mostrarEmpresa` en modulo `BaseDatosDll` para mostrar los resultados de la consulta en un `ComboBox`.
	* Implementación del método para mostrar las empresas activas.
	* Implementación del método `MostrarUsuarios` para visualizar los usuarios según la empresa seleccionada.
	* Implementación del método `ObtenerIdEmpresa` para conocer el id de la empresa seleccionada.
	* Implementación del método `GuardarUsuario` necesario para almacenar los datos de un nuevo usuario y su acceso en la base de datos.	
* Web Service.
	* Creación del archivo `webservice` `seguridad.php`, contiene los método `encriptar` y `desencriptar` necesarios para la seguridad de acceso a la base de datos.
	* Se agrego la referencia al web service  de seguridad.
	* Creación del modulo `SeguridadDll` necesario para almacenar los métodos propios para la gestión de la seguridad de acceso.
	* Creación del método `EncriptarPassword` necesario para encriptar el password de acceso al sistema en la base de datos.
	* Creación del método `DesencriptarPassword` necesario para des encriptar el password de acceso al sistema en la base de datos.


<h5>14/11/2017</h5>
Actividades realizadas durante el día 14 de Noviembre del 2017:

* Base de Datos
	* Diseño y generación del script de la base de datos `recargasatc`.
	* Creación del método `ObtenerAcceso` en modulo `BaseDatosDll` para obtener las credenciales de acceso.
* `VisualizarUsuariosDlg`
	* Implementación del método `DesencriptarPassword` para mostrar el password descifrado.
	* Implementación del método `EditarUsuario` necesario para poder actualizar la información y credenciales de acceso de un administrador.
	* Creación del método `mostrarPermiso` en modulo `BaseDatosDll` para obtener las credenciales de acceso.
	* Validación que el nombre del socio contenga información.
	* Validación que la información del socio contenga información.
	* Validación que el teléfono del socio contenga información.
	* Validación que no exista registros repetidos.
	* Se estableció el orden de tabulación del formulario `VisualizarUsuariosDlg`.
	* Se implemento que al dar enter se haga la inserción o la actualización según sea el caso.
* `EliminarRestaurarUsuarioDlg`
	* Creación y diseño del formulario necesario para cambiar el estado de los usuarios.
	* Implementación del método `actualizarEstado`.
	* Se estableció el orden de tabulación.
	* Validación de los elementos del formulario.
* `VisualizarClientesDlg`
	* Creación y diseño del formulario necesario para visualizar los clientes y sus credenciales de acceso.
	* Implementación del método generar para insertar o actualizar un cliente.
	* Se estableció el orden de tabulación.
	* Validación de los elementos del formulario.
* `EliminarRestaurarClienteDlg`
	* Creación y diseño del formulario necesario para cambiar el estado de los cliente.
	* Implementación del método `actualziarEstado`.
	* Se estableció el orden de tabulación.
	* Validación de los elementos del formulario.
* Base de Datos
	* Se agrego la base de datos la tabla `punto_venta`, en ella se almacenan los diferentes puntos de venta correspondientes a una empresa.
	* Se agrego en la base de datos la tabla `clave_cliente`, en ella se almacenan las claves para control interno de los clientes.
* `VisualizarPuntoVentaDlg` 
	* Creación y diseño del formulario necesario para agregar un nuevo punto de venta.
	* Implementación del método `generar`.
	* Se estableció el orden de tabulación.
	* Validación de los elementos del formulario.
* `EliminarRestaurarPuntoVenta` 
	* Creación y diseño del formulario necesario para eliminar y restaurar un punto de venta.
	* Implementación del método `actualizarEstado`.
	* Se estableció el orden de tabulación.
	* Validación de los elementos del formulario.

<h5>15/11/2017</h5>
Actividades realizadas durante el día 15 de Noviembre del 2017:

* `VisualizarClientes`
	* Creación y diseño del formulario.
	* Inserción en la base de datos del nuevo cliente.
	* Generación de la clave del cliente e inserción en la base de datos.
	* Generación del password encriptado.
	* Inserción en la base de datos `permiso_cliente`.
	* Des encriptación del password.
	* Actualización de datos del cliente.
* `EliminarRestaurarCliente`
	* Creación y diseño del formulario.
	* Cambio de estado del cliente.
	* Se estableció el orden de tabulación.
	* Validación de los datos del formulario.
* `VisualizarCarrier`
	* Creación y diseño del formulario.
	* Visualización de las compañías telefónicas.
	* Inserción de una nueva compañía telefónica.
	* Actualización de una nueva compañía telefónica.
	* Se estableció el orden de tabulación.
	* Validación de los datos del formulario.
* `EliminarRestaurarCarrier`
	* Creación y diseño del formulario.
	* Actualización del estado de la compañía telefónica.
	* Se estableció el orden de tabulación.
	* Validación de los datos del formulario.

<h5>16/11/2017</h5>
Actividades realizadas durante el día 16 de Noviembre del 2017:

* `MontoRecargaDlg`
	* Creación y diseño del formulario.
	* Visualización de los montos por compañía telefónica.
	* Visualización de las compañías sin monto asignado.
	* Inserción de nuevo monto en la base de datos.
	* Actualización del monto en la base de datos.
	* Se estableció el orden de tabulación.
	* Validación de los datos del formulario.
* `LeerArchivosDll`
	* Creación del modulo `LeerArchivosDll` en el se podrán hacer operaciones con archivos externos como son `txt`, `xls`, etc.
	* Creación del método `LeerTxt` en el se puede abrir un `txt` utilizando un `openFileDialog` y mostrando los resultados en un `DataGridView`.
* `RegistroFoliosDlg`
	* Creación y diseño del formulario, necesario para introducir en la base de datos los números a recargar.
	* Creación del método que genera los folios automáticamente.
	* Creación del método `mostrarClaveCliente`, sirve para visualizar la clave del cliente en un `ComboBox`.
	* Creación del método `mostrarMonto` necesario para mostrarle al usuario el monto mínimo de recarga para la compañía solicitada.

<h5>17/11/2017</h5>
Actividades realizadas durante el día 17 de Noviembre del 2017:

* `RegistroFoliosDlg`
	* Creación del método para recorrer todos los registros solicitados.
	* Validación que el campo dígitos solo pueda recibir números.
	* Validación que el campo dígitos tenga diez dígitos solamente.
	* Validación que no existan folios repetidos en una empresa.
	* Validación que el número no exista en la base de datos.
	* Inserción de número nuevo en la base de datos.
	* Limpiar elementos del formulario.

* `LoginDlg`
	* Creación y diseño del formulario, necesario para el acceso a la aplicación de escritorio.
	* Creación del método `ObtenerPermiso` para conocer el id del administrador y el permiso asignado.
	* Validar las opciones de acceso a la aplicación.
	* Se estableció el orden de tabulación del formulario.
	* Se programo que al dar enter se haga la función del loggin.
* `VisualizarSociosDlg`
	* Se agrego el correo de contacto
	* Inserción en la tabla notificaciones.
	* Se valido que solo los usuarios con permiso de super usuario puedan entrar a esta sección.
* `EliminarRestaurarSociosDlg`
	* Se agrego el correo de contacto.
	* Se valido que solo los usuarios con permiso de super usuario puedan entrar a esta sección.
* `VisualizarUsuariosDlg`
	* Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo los usuarios con permiso de super usuario puedan seleccionar otra opción de empresa.
* `EliminarRestaurarUsuariosDlg`
	* Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo los usuarios con permiso de super usuario puedan seleccionar otra opción de empresa.

<h5>17/11/2017</h5>
Actividades realizadas durante el día 17 de Noviembre del 2017:

* `VisualizarPuntoVentaDlg`
	* Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo los usuarios con permiso de super usuario puedan seleccionar otra opción de empresa.
	* Orden de tabulación.
*  `EliminarRestaurarPuntoVentaDlg`
	* Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo los usuarios con permiso de super usuario puedan seleccionar otra opción de empresa.
	* Orden de tabulación.
* `VisualizarClientesDlg`
	*  Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo los usuarios con permiso de super usuario puedan seleccionar otra opción de empresa.
	* Orden de tabulación.
* `EliminarRestaurarClientesDlg`
	* Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo  los usuarios con permiso de super usuario puedan seleccionar otra opción de empresa.
	* Orden de tabulación.
* `MontoRecargaDlg`
	* Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo los usuarios con permiso de super usuario puedan seleccionar otra opción.
* `RegistroFoliosDlg`
	* Cambio en le diseño del formulario.
	* Actualización de los montos de recargas sugeridos de manera automática.
	* Se elimino el botón Guardar, ahora las acciones se realizan en un solo botón dependiendo del nivel de acción que se tenga.
	* Se estableció el orden de tabulación del formulario.
	* Poner por default la opción de la empresa a la que pertenece el usuario.
	* Se valido que solo los usuarios con permiso de super usuario puedan seleccionar otra opción de empresa.

<h5>21/11/2017</h5>
Actividades realizadas durante el día 21 de Noviembre del 2017:

* `RegistroFoliosDlg`
	* Validación que el monto de recarga tenga valor de tipo entero.
	* Se estableció el orden de tabulación del formulario.
	* Se programo el evento `Key Down` en los elementos del formulario.
* Base de Datos
	* Se creó la tabla `acceso_empresa` en ella se almacenarán las credenciales de acceso al sistema de `Xtreme Card`.
* `VisualizarSociosDlg`
	* Se agregó los elementos del formulario necesario para guardar las credenciales de acceso del socio.
	* Se programo la inserción de las credenciales de acceso a la base de datos.
* Base de datos
	* Se crearon los ejemplos de acceso cliente con el password del cliente.
* `InformeRecargasDlg`
	* Creación y diseño del formulario, necesario para visualizar la cantidad de recargas y el monto total de las mismas.

<h5>22/11/2017</h5>
Actividades realizadas durante el día 22 de Noviembre del 2017:

* `InformeRecargasDlg`
	* Implementación del método generar reporte, en el se puede consultar el reporte de recargas solicitadas.
	* Implementación del método dar formato, en el se puede dar formato de salida al reporte de recargas.
* `VisualizarSociosDlg`
	* Se agregó el botón limpiar.
	* Se agregó el icono de ATC al formulario.
	* Se agregaron los iconos a los botones del formulario.
* `EliminarRestaurarSociosDlg`
	* Se agrego el icono de ATC al formulario.
	* Se agregaron los iconos a los botones del formulario.