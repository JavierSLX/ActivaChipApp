#include "stdafx.h"  //________________________________________ iNotacom.cpp
#include "iNotacom.h"

int APIENTRY wWinMain(HINSTANCE hInstance, HINSTANCE , LPTSTR cmdLine, int cmdShow){
	iNotacom app;
	return app.BeginDialog(IDI_iNotacom, hInstance);
}

void iNotacom::Window_Open(Win::Event& e)
{
	//Define el id dependiendo de hacia donde está dirigido el software
	local.localID = JUAREZ;

	iNotacomDll::Wintempla wintemplaObj;
	iNotacomDll::SQL sqlObj;
	iNotacomDll::Wstring wstObj;

	//Llena el nombre del local
	tbxLocal.Text = sqlObj.sacarNombreLocal(local.localID);

	//Llena la ddlist ya sea de Zaragoza o Juárez
	wintemplaObj.llenarDdUsuario(ddUsuario, 100, local.localID);

	//Llena la ddlist que contiene los servicios
	wintemplaObj.llenarDdServicio(ddServicio, 100);

	//Llena la celda de folio
	wstring folio = sqlObj.sacarUltimoFolio();
	Sys::Time fecha = Sys::Time::Now();
	wstring cadena;
	if (folio.length() == 0)
	{
		Sys::Format(cadena, L"%04d", 1);
		tbxFolio.Text = cadena + L"/" + Sys::Convert::ToString(fecha.wYear);
	}
	else
	{
		//Compara si el año es el mismo que se cursa
		if (fecha.wYear == wstObj.sacarIdentificadorFecha(folio))
		{
			Sys::Format(cadena, L"%04d", wstObj.sacarIdentificadorNumerico(folio) + 1);
			tbxFolio.Text = cadena + L"/" + Sys::Convert::ToString(fecha.wYear);
		}
		else
		{
			Sys::Format(cadena, L"%04d", 1);
			tbxFolio.Text = cadena + L"/" + Sys::Convert::ToString(fecha.wYear);
		}
	}

	//Nombres e iconos que toma las pestañas de la tab
	Win::ImageList imageList;
	//________________________________________________________ tabPrinc
	imageList.Create(16, 16, 2);
	imageList.AddIcon(this->hInstance, IDI_ROJO);
	imageList.AddIcon(this->hInstance, IDI_AZUL);
	tabFolios.SetImageList(imageList);
	tabFolios.Items.Add(0, 0, L"PENDIENTES");
	tabFolios.Items.Add(1, 1, L"ENTREGADOS");

	//Limita la celda de número a 12 digitos
	tbxTelefono.MaxTextLength = 12;

	//Llena la listview
	wintemplaObj.llenarLvSinEntregar(lvLista, 100);

	//Si no hay usuarios registrados deshabilita el botón Registrar
	if (ddUsuario.Items.Count <= 0 || ddServicio.Items.Count <= 0)
		btRegistrar.Enabled = false;

	//Hace invisible el botón de opciones
	btUsuario.Visible = false;

	//Agrega el icono al botón
	Sys::Icon agregar;
	agregar.Load(hInstance, IDI_AGREGADO);
	btServicio.SetImage(agregar);
	btUsuario.SetImage(agregar);

	Sys::Icon registrar;
	registrar.Load(hInstance, IDI_REGISTRAR);
	btRegistrar.SetImage(registrar);

	Sys::Icon reporte;
	reporte.Load(hInstance, IDI_REPORTE);
	btReporte.SetImage(reporte);

	Sys::Icon opciones;
	opciones.Load(hInstance, IDI_OPCIONES);
	btOpciones.SetImage(opciones);
}

//Botón Registrar
void iNotacom::btRegistrar_Click(Win::Event& e)
{
	int cliente_id;
	int usuario_id;
	int servicio_id;
	iNotacomDll::SQL sqlObj;
	iNotacomDll::Wintempla winObj;
	Sys::Time actual = Sys::Time::Now();

	//Checa que no existan espacios vacíos en las celdas que son obligatorias
	if (tbxNombre.GetTextLength() == 0 || tbxDireccion.GetTextLength() == 0 || tbxTelefono.GetTextLength() == 0)
	{
		MessageBoxW(L"Llene los espacios vacíos", L"Registro", MB_OK | MB_ICONERROR);
		return;
	}

	if (tbxEquipo.GetTextLength() == 0 || tbxImei.GetTextLength() == 0 || tbxCosto.GetTextLength() == 0)
	{
		MessageBoxW(L"Llene los espacios vacíos", L"Registro", MB_OK | MB_ICONERROR);
		return;
	}

	//Checa si el cliente ya existe en la base de datos
	cliente_id = sqlObj.sacarIDCliente(tbxNombre.Text);
	if (cliente_id <= 0)
	{
		sqlObj.insertACliente(tbxNombre.Text, tbxDireccion.Text, tbxTelefono.Text);
		cliente_id = sqlObj.sacarIDCliente(tbxNombre.Text);
	}

	//Saca el id del usuario
	usuario_id = winObj.sacarIDOcultoDd(ddUsuario);

	//Saca el id del servicio
	servicio_id = winObj.sacarIDOcultoDd(ddServicio);

	//Verifica que la fecha de registro no sea la misma del día de hoy
	Sys::Time fecha = dtboxEntrega.GetSelectedDateTime();
	if (fecha.wDay == actual.wDay && fecha.wMonth == actual.wMonth && fecha.wYear == actual.wYear)
	{
		if (MessageBoxW(L"¿Va a hacer la entrega el día de hoy?", L"Entrega", MB_YESNO | MB_ICONQUESTION) != IDYES)
			return;
	}

	//Checa si la celda de observaciones está vacía
	wstring observaciones;
	if (tbxObservaciones.GetTextLength() == 0)
		observaciones = L"S/R";
	else
		observaciones = tbxObservaciones.Text;

	//Hace una inserción en la tabla folio
	sqlObj.insertAFolio(tbxFolio.Text, tbxEquipo.Text, tbxImei.Text, servicio_id, observaciones, actual, fecha, usuario_id, cliente_id, tbxCosto.DoubleValue);

	//Si la persona dejó un abono se registra en la tabla pago
	if (tbxAnticipo.GetTextLength() > 0 && tbxAnticipo.DoubleValue != 0)
	{
		//Si la cantidad dejada es mayor que el costo informa del error
		if (tbxCosto.DoubleValue < tbxAnticipo.DoubleValue)
		{
			MessageBoxW(L"El costo es menor que el anticipo, corriga el dato por favor", L"Anticipo", MB_OK | MB_ICONINFORMATION);
			return;
		}
		else
			sqlObj.insertAPago(sqlObj.sacarIDFolio(tbxFolio.Text), tbxAnticipo.IntValue);
	}

	//Da aviso al usuario
	MessageBoxW(L"Datos introducidos correctamente", L"Registro", MB_OK | MB_ICONINFORMATION);
	imprimirDocumento();

	//Vuelve a cargar la listview de pendientes
	tabFolios.SetSelected(0);
	limpiarCampos();
}

//Botón Usuario
void iNotacom::btUsuario_Click(Win::Event& e)
{
	iNotacomDll::Wintempla winObj;

	//Manda llamar la ventana de usuario
	RegistroUsuario dlg(local.localID);
	dlg.BeginDialog(hWnd);

	//Carga de nuevo la ddlist de usuario
	winObj.llenarDdUsuario(ddUsuario, 100, local.localID);
	btRegistrar.Enabled = true;
}

//Cuando la celda de folio cambia
void iNotacom::tbxFolioBusq_Change(Win::Event& e)
{
	iNotacomDll::Wintempla winObj;

	if (tabFolios.GetSelectedIndex() == 0)
	{
		if (tbxFolioBusq.GetTextLength() == 0)
			winObj.llenarLvSinEntregar(lvLista, 200);
		else
			winObj.llenarLvSinEntregarBusqueda(lvLista, tbxFolioBusq.IntValue, 200);
	}
	else
	{
		if (tbxFolioBusq.GetTextLength() == 0)
			winObj.llenarLvEntregado(lvLista, 200);
		else
			winObj.llenarLvEntregadoBusqueda(lvLista, tbxFolioBusq.IntValue, 200);
	}
}

//Cuando la celda de nombre cambia
void iNotacom::tbxNombreBusq_Change(Win::Event& e)
{
	iNotacomDll::Wintempla winObj;

	if (tabFolios.GetSelectedIndex() == 0)
	{
		if (tbxNombreBusq.GetTextLength() == 0)
			winObj.llenarLvSinEntregar(lvLista, 200);
		else
			winObj.llenarLvSinEntregarNombre(lvLista, tbxNombreBusq.Text, 200);
	}
	else
	{
		if (tbxNombreBusq.GetTextLength() == 0)
			winObj.llenarLvEntregado(lvLista, 200);
		else
			winObj.llenarLvEntregadoNombre(lvLista, tbxNombreBusq.Text, 200);
	}
}

//Cuando cambia la tab
void iNotacom::tabFolios_SelChange(Win::Event& e)
{
	iNotacomDll::Wintempla winObj;
	tbxFolioBusq.Text = L"";
	tbxNombreBusq.Text = L"";

	if (tabFolios.GetSelectedIndex() == 0)
		winObj.llenarLvSinEntregar(lvLista, 200);
	else
		winObj.llenarLvEntregado(lvLista, 200);
}

//Cuando se le da doble click sobre una celda
void iNotacom::lvLista_ItemActivate(Win::Event& e)
{
	iNotacomDll::Wintempla winObj;

	bool entregado;
	if (tabFolios.GetSelectedIndex() == 0)
		entregado = false;
	else
		entregado = true;

	AnalisisFolio dlg(winObj.sacarIDOcultoLV(lvLista), entregado);
	dlg.BeginDialog(hWnd);

	if (tabFolios.GetSelectedIndex() == 0)
		winObj.llenarLvSinEntregar(lvLista, 100);
	else
		winObj.llenarLvEntregado(lvLista, 100);
}

//Cuando se le da click al botón opciones
void iNotacom::btOpciones_Click(Win::Event& e)
{
	if (btOpciones.Text == L"Ocultar")
	{
		btOpciones.Text = L"Opciones";
		btUsuario.Visible = false;
		acceso = false;
	}
	else
	{
		Login login;
		login.BeginDialog(hWnd);
		acceso = login.acceso;
	}

	if (acceso)
	{
		btOpciones.Text = L"Ocultar";
		btUsuario.Visible = true;
	}
}

//Cuando se le da click al botón reporte
void iNotacom::btReporte_Click(Win::Event& e)
{
	ReporteDlg dlg(local.localID);
	dlg.BeginDialog(hWnd);
}

//Cuando se le da click al botón servicio
void iNotacom::btServicio_Click(Win::Event& e)
{
	iNotacomDll::Wintempla winObj;
	RegistroServicio dlg(local.localID);
	dlg.BeginDialog(hWnd);

	//Actualiza la ddlist de Servicio
	winObj.llenarDdServicio(ddServicio, 100);
}

//Limpia los campos de una ventana
void iNotacom::limpiarCampos(void)
{
	iNotacomDll::SQL objSQL;
	iNotacomDll::Wstring objWst;
	iNotacomDll::Wintempla objWin;
	wstring folio = objSQL.sacarUltimoFolio();
	Sys::Time actual = Sys::Time::Now();
	wstring cadena;

	//Coloca por default
	tbxNombre.Text = L"";
	tbxDireccion.Text = L"";
	tbxTelefono.Text = L"";
	tbxEquipo.Text = L"";
	tbxImei.Text = L"";
	tbxCosto.Text = L"";
	tbxAnticipo.Text = L"";
	tbxObservaciones.Text = L"";
	tbxNombreBusq.Text = L"";
	tbxFolioBusq.Text = L"";
	dtboxEntrega.SetSelectedDateTime(actual);

	//Llena la celda de folio
	if (folio.length() == 0)
	{
		Sys::Format(cadena, L"%04d", 1);
		tbxFolio.Text = cadena + L"/" + Sys::Convert::ToString(actual.wYear);
	}
	else
	{
		//Compara si el año es el mismo que se cursa
		if (actual.wYear == objWst.sacarIdentificadorFecha(folio))
		{
			Sys::Format(cadena, L"%04d", objWst.sacarIdentificadorNumerico(folio) + 1);
			tbxFolio.Text = cadena + L"/" + Sys::Convert::ToString(actual.wYear);
		}
		else
		{
			Sys::Format(cadena, L"%04d", 1);
			tbxFolio.Text = cadena + L"/" + Sys::Convert::ToString(actual.wYear);
		}
	}

	//Actualiza la tabla
	tabFolios.SetSelected(0);
	objWin.llenarLvSinEntregar(lvLista, 200);

	//Coloca el cursor en el nombre
	tbxNombre.SetFocus();
}

//Método de impresión
void iNotacom::imprimirDocumento(void)
{
	iNotacomDll dll;
	Win::PrintDoc doc;
	iNotacomDll::Logo logo(L".\\img\\invertido.emf", 1200);

	doc.Create(L"Documento");

	//Agrega una fecha
	Sys::Time fecha = Sys::Time::Now();
	tbxCabecera.SetFont(dll.arialCursiva);
	wstring cadena;
	Sys::Format(cadena, L"Salvatierra, Guanajuato. A %02d/%02d/%d", fecha.wDay, fecha.wMonth, fecha.wYear);
	tbxCabecera.Text = cadena;
	doc.Add(300, tbxCabecera.GetPrintLineCount(doc, 300) + 1, tbxCabecera);

	//Agrega folio
	wstring folio = tbxFolio.Text;
	tbxTitulo.SetFont(dll.arialNegrita);
	tbxTitulo.SetPrintAlignment(2);
	tbxTitulo.Text = L"FOLIO: " + folio;
	doc.Add(550, tbxTitulo.GetPrintLineCount(doc, 550) + 1, tbxTitulo);

	//Logo
	doc.Add(200, 1, logo);

	//Agrega el nombre de la sección
	tbxSubtitulo1.Text = L"CLIENTE:";
	tbxSubtitulo1.SetFont(dll.arialNegrita);
	doc.Add(450, tbxSubtitulo1.GetPrintLineCount(doc, 450) + 1, tbxSubtitulo1);

	//Agrega nombre, telefono y dirección
	wstring nombre = tbxNombre.Text;
	wstring telefono = tbxTelefono.Text;
	wstring direccion = tbxDireccion.Text;
	Sys::Format(cadena, L"NOMBRE: %s\t\t                        TELEFONO: %s\t\t                         DIRECCIÓN: %s\r\n",
		nombre.c_str(), telefono.c_str(), direccion.c_str());
	tbxCliente.Text = cadena;
	doc.Add(350, tbxCliente.GetPrintLineCount(doc, 350) + 1, tbxCliente);

	//Agrega el nombre de la sección
	tbxSubtitulo2.Text = L"SERVICIO:";
	tbxSubtitulo2.SetFont(dll.arialNegrita);
	doc.Add(450, tbxSubtitulo2.GetPrintLineCount(doc, 450) + 1, tbxSubtitulo2);

	//Agrega equipo e imei
	wstring equipo = tbxEquipo.Text;
	wstring imei;
	if (tbxImei.GetTextLength() == 0)
		imei = L"S/R";
	else
		imei = tbxImei.Text;
	wstring servicio = ddServicio.Text;
	Sys::Format(cadena, L"EQUIPO: %s                              IMEI: %s                              SERVICIO: %s",
		equipo.c_str(), imei.c_str(), servicio.c_str());
	tbxEquipoD.Text = cadena;
	doc.Add(350, tbxEquipoD.GetPrintLineCount(doc, 350) + 1, tbxEquipoD);

	//Agrega costo y anticipo en caso de dejarse
	wstring costo = tbxCosto.Text;
	wstring anticipo = tbxAnticipo.Text;
	if (anticipo.length() > 0)
		Sys::Format(cadena, L"COSTO: $ %s                                    ANTICIPO: $ %s                                    FALTANTE: $ %s",
			costo.c_str(), anticipo.c_str(), Sys::Convert::ToString(Sys::Convert::ToDouble(costo) - Sys::Convert::ToDouble(anticipo)).c_str());
	else
		Sys::Format(cadena, L"                                   COSTO: %s", costo.c_str());
	tbxCostoD.Text = cadena;
	doc.Add(350, tbxCostoD.GetPrintLineCount(doc, 350) + 1, tbxCostoD);

	//Agrega observaciones
	wstring observaciones = tbxObservaciones.Text;
	if (tbxObservaciones.GetTextLength() == 0)
		observaciones = L"S/R";
	else
		observaciones = tbxObservaciones.Text;
	Sys::Format(cadena, L"OBSERVACIONES: %s\r\n", observaciones.c_str());
	tbxObservacionesD.Text = cadena;
	doc.Add(350, tbxObservacionesD.GetPrintLineCount(doc, 350) + 1, tbxObservacionesD);

	//Agrega la fecha tentativa de entrega
	Sys::Time tentativa = dtboxEntrega.GetSelectedDateTime();
	Sys::Format(cadena, L"FECHA TENTATIVA DE ENTREGA: %02d/%02d/%d\r\n", tentativa.wDay, tentativa.wMonth, tentativa.wYear);
	tbxEntregaD.Text = cadena;
	tbxEntregaD.SetFont(dll.arialSubrayado);
	tbxEntregaD.SetPrintAlignment(2);
	doc.Add(450, tbxEntregaD.GetPrintLineCount(doc, 450) + 1, tbxEntregaD);

	//Agrega el nombre de quien lo atendió
	wstring usuario = ddUsuario.Text;
	Sys::Format(cadena, L"RECIBIDO POR: %s\r\n", usuario.c_str());
	tbxRecibido.Text = cadena;
	tbxRecibido.SetFont(dll.arialCursiva);
	tbxRecibido.SetPrintAlignment(2);
	doc.Add(350, tbxRecibido.GetPrintLineCount(doc, 350) + 1, tbxRecibido);

	//Agrega la clausula de la nota
	wstring nota = L"No nos hacemos responsables de ningún equipo que haya sido dejado en nuestra sucursal después de ";
	nota += L"haber pasado 20 días a partir de la fecha de entrega indicada en este documento.\r\nHe leido y acepto sin ";
	nota += L"reservas de ninguna índole lo anterior descrito en este documento y manifiesto que el equipo es de mi ";
	nota += L"propiedad y puedo tomar decisiones sobre él haciéndome responsable por cualquier incoveniente que surgiera ";
	nota += L"en caso de que la información proporcionada no sea real.";
	tbxAdvertencia.Text = nota;
	tbxAdvertencia.SetPrintAlignment(2);
	doc.Add(350, tbxAdvertencia.GetPrintLineCount(doc, 350) + 1, tbxAdvertencia);

	//Agrega el pie de página
	tbxFirma.Text = L"Local Juárez 212 y Local Zaragoza Esq. con Ocampo. Tel. 044(466)1008293";
	tbxFirma.SetPrintAlignment(1);
	tbxFirma.SetFont(dll.arialCursiva);
	doc.Add(300, tbxFirma.GetPrintLineCount(doc, 300) + 1, tbxFirma);

	/*Win::PrintPreviewDlg dlg;
	dlg.BeginDialog_(hWnd, &doc);*/

	Win::PrintDlg_ print;
	print.BeginDialog(hWnd, &doc);
}
