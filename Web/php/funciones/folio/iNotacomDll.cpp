#include "stdafx.h"  //_____________________________________________ iNotacomDll.cpp
#include "iNotacomDll.h"

//_____________________________________________ CLASE SQL
//Método que inserta un nuevo dato a la tabla Usuario
void iNotacomDll::SQL::insertAUsuario(wstring nombre, int local_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"INSERT INTO usuario (nombre, local_id, activo) \
			VALUES('%s', %d, true);", nombre.c_str(), local_id);
		rows = conn.ExecuteNonQuery(consulta);
		if (rows != 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of inserted rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que inserta un nuevo dato en la tabla Cliente
void iNotacomDll::SQL::insertACliente(wstring nombre, wstring direccion, wstring telefono)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"INSERT INTO cliente (nombre, direccion, telefono, activo) \
			VALUES('%s', '%s', '%s', true);", nombre.c_str(), direccion.c_str(), telefono.c_str(), true);
		rows = conn.ExecuteNonQuery(consulta);
		if (rows != 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of inserted rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que inserta un nuevo dato en la tabla folio
void iNotacomDll::SQL::insertAFolio(wstring identificador, wstring equipo, wstring imei, int servicio_id, wstring observaciones, Sys::Time fecha_reg, 
	Sys::Time fecha_ent, int usuario_id, int cliente_id, double precio_sug)
{
	wstring consulta, parte1, parte2;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(parte1, L"INSERT INTO folio (identificador, equipo, imei, servicio_id, observaciones, fecha_reg, fecha_ent, usuario_id, cliente_id, precio_sug) \
VALUES('%s', '%s', '%s', %d, '%s', '%d-%d-%d %d:%d:%d', ", identificador.c_str(), equipo.c_str(), imei.c_str(), servicio_id, observaciones.c_str(),
			fecha_reg.wYear, fecha_reg.wMonth, fecha_reg.wDay, fecha_reg.wHour, fecha_reg.wMinute, fecha_reg.wSecond);
		Sys::Format(parte2, L"'%d-%d-%d %d:%d:%d', %d, %d, %lf);", fecha_ent.wYear, fecha_ent.wMonth, fecha_ent.wDay, fecha_ent.wHour, fecha_ent.wMinute,
			fecha_ent.wSecond, usuario_id, cliente_id, precio_sug);
		consulta = parte1 + parte2;
		rows = conn.ExecuteNonQuery(consulta);
		if (rows != 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of inserted rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que inserta un nuevo dato en la tabla pago
void iNotacomDll::SQL::insertAPago(int folio_id, double cantidad)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"INSERT INTO pago (folio_id, cantidad) \
			VALUES(%d, %lf);", folio_id, cantidad);
		rows = conn.ExecuteNonQuery(consulta);
		if (rows != 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of inserted rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que inserta un nuevo dato en la tabla servicio
void iNotacomDll::SQL::insertAServicio(wstring nombre)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"INSERT INTO servicio (nombre, activo) \
			VALUES('%s', true);", nombre.c_str());
		rows = conn.ExecuteNonQuery(consulta);
		if (rows != 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of inserted rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que inserta un nuevo dato a la tabla BD entrega
void iNotacomDll::SQL::insertAEntrega(Sys::Time fecha, int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"INSERT INTO entrega (fecha, folio_id) \
			VALUES('%d-%d-%d %d:%d:%d', %d);", fecha.wYear, fecha.wMonth, fecha.wDay, fecha.wHour, fecha.wMinute,
			fecha.wSecond, folio_id);
		rows = conn.ExecuteNonQuery(consulta);
		if (rows != 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of inserted rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que actualiza un elemento de la tabla cliente
void iNotacomDll::SQL::updateACliente(int cliente_id, wstring nombre, wstring direccion, wstring telefono)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"UPDATE cliente \
		SET nombre = '%s', direccion = '%s', telefono = '%s'\
		WHERE id = %d;", nombre.c_str(), direccion.c_str(), telefono.c_str(), cliente_id);
		rows = conn.ExecuteNonQuery(consulta);
		if (rows > 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of updated rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que actualiza un elemento de la tabla folio
void iNotacomDll::SQL::updateAFolio(int folio_id, wstring equipo, wstring imei, int servicio_id, wstring observaciones, double precio_sug)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	if (imei.length() == 0)
		imei = L"S/R";

	if (observaciones.length() == 0)
		observaciones = L"S/R";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"UPDATE folio \
		SET equipo = '%s', imei = '%s', servicio = %d, observaciones = '%s', precio_sug = %lf \
		WHERE id = %d;", equipo.c_str(), imei.c_str(), servicio_id, observaciones.c_str(), precio_sug, folio_id);
		rows = conn.ExecuteNonQuery(consulta);
		if (rows > 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of updated rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que actualiza un método de la tabla pago
void iNotacomDll::SQL::updateAPago(int pago_id, double cantidad)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int rows = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"UPDATE pago \
		SET cantidad = %lf \
		WHERE id = %d;", cantidad, pago_id);
		rows = conn.ExecuteNonQuery(consulta);
		if (rows > 1)
		{
			this->MessageBox(Sys::Convert::ToString(rows), L"Error: number of updated rows", MB_OK | MB_ICONERROR);
		}
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que obtiene el nombre del local
wstring iNotacomDll::SQL::sacarNombreLocal(int local_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT nombre\
		FROM local\
		WHERE id = %d;", local_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		//this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Método que obtiene el nombre del usuario
wstring iNotacomDll::SQL::sacarUsuario(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT u.nombre\
		FROM usuario u, folio f\
		WHERE f.usuario_id = u.id\
		AND f.id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca el último identificador registrado
wstring iNotacomDll::SQL::sacarUltimoFolio(void)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring folio = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT TOP 1 identificador\
		from folio\
		order by identificador desc;");
		conn.GetString(consulta, folio, 50);
	}
	catch (Sql::SqlException e)
	{
		//this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		folio = L"";
	}

	conn.CloseSession();
	return folio;
}

//Saca el folio indicado por su id
wstring iNotacomDll::SQL::sacarFolio(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT identificador\
		FROM folio\
		WHERE id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca le nombre del cliente
wstring iNotacomDll::SQL::sacarCliente(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT c.nombre\
		FROM folio f, cliente c\
		WHERE f.cliente_id = c.id\
		AND f.id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca la dirección del cliente
wstring iNotacomDll::SQL::sacarDireccion(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT c.direccion\
		FROM folio f, cliente c\
		WHERE f.cliente_id = c.id\
		AND f.id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca el teléfono del cliente
wstring iNotacomDll::SQL::sacarTelefono(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT c.telefono\
		FROM folio f, cliente c\
		WHERE f.cliente_id = c.id\
		AND f.id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca el nombre del equipo
wstring iNotacomDll::SQL::sacarEquipo(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT equipo\
		FROM folio\
		WHERE id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca el IMEI con el que se registró
wstring iNotacomDll::SQL::sacarImei(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT imei\
		FROM folio\
		WHERE id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca el servicio con el que se registró
wstring iNotacomDll::SQL::sacarServicio(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT s.nombre\
		FROM folio f, servicio s\
		WHERE f.servicio_id = s.id\
		AND f.id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca las observaciones que se registraron
wstring iNotacomDll::SQL::sacarObservaciones(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	wstring cadena = L"";

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT observaciones\
		FROM folio\
		WHERE id = %d;", folio_id);
		conn.GetString(consulta, cadena, 150);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return cadena;
}

//Saca el id del cliente
int iNotacomDll::SQL::sacarIDCliente(wstring nombre)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int cliente_id = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT id\
		FROM cliente\
		WHERE nombre = '%s';", nombre.c_str());
		cliente_id = conn.GetInt(consulta);
	}
	catch (Sql::SqlException e)
	{
		cliente_id = 0;
	}

	conn.CloseSession();
	return cliente_id;
}

//Saca el id del cliente
int iNotacomDll::SQL::sacarIDCliente(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int cliente_id = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT cliente_id\
		FROM folio\
		WHERE nombre = %d;", folio_id);
		cliente_id = conn.GetInt(consulta);
	}
	catch (Sql::SqlException e)
	{
		cliente_id = 0;
	}

	conn.CloseSession();
	return cliente_id;
}

//Saca el id del usuario
int iNotacomDll::SQL::sacarIDUsuario(wstring nombre)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int estandar_id = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT id\
		FROM cliente\
		WHERE nombre = '%s';", nombre.c_str());
		estandar_id = conn.GetInt(consulta);
	}
	catch (Sql::SqlException e)
	{
		estandar_id = 0;
	}

	conn.CloseSession();
	return estandar_id;
}

//Método que saca el id del folio por un wstring del folio
int iNotacomDll::SQL::sacarIDFolio(wstring folio)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int dato = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT id\
		FROM folio\
		WHERE identificador = '%s';", folio.c_str());
		dato = conn.GetInt(consulta);
	}
	catch (Sql::SqlException e)
	{
		dato = 0;
	}

	conn.CloseSession();
	return dato;
}

//Método que saca el id del pago por medio del folio_id
int iNotacomDll::SQL::sacarIDPago(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int dato = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT id\
		FROM pago\
		WHERE folio_id = %d;", folio_id);
		dato = conn.GetInt(consulta);
	}
	catch (Sql::SqlException e)
	{
		dato = 0;
	}

	conn.CloseSession();
	return dato;
}

//Saca el último id del folio que se registró
int iNotacomDll::SQL::sacarUltimoIDFolio(void)
{
	wstring consulta;
	Sql::SqlConnection conn;
	int folio = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT TOP 1 id\
		from folio\
		order by id desc;");
		conn.GetInt(consulta);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//folio = 0;
	}

	conn.CloseSession();
	return folio;
}

//Saca el anticipo que se dejó en un determinado folio
double iNotacomDll::SQL::sacarAnticipo(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	double dato = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT cantidad\
		FROM pago\
		WHERE folio_id = %d;", folio_id);
		dato = conn.GetDouble(consulta);
	}
	catch (Sql::SqlException e)
	{
		dato = 0;
	}

	conn.CloseSession();
	return dato;
}

//Saca el costo que se originó en el folio
double iNotacomDll::SQL::sacarCosto(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	double dato = 0;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT precio_sug\
		FROM folio\
		WHERE id = %d;", folio_id);
		dato = conn.GetDouble(consulta);
	}
	catch (Sql::SqlException e)
	{
		dato = 0;
	}

	conn.CloseSession();
	return dato;
}

//Saca la fecha de cuando se hizo el registro
Sys::Time iNotacomDll::SQL::sacarFechaRegistro(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	Sys::Time fecha;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT fecha_reg\
		FROM folio\
		WHERE id = %d;", folio_id);
		fecha = conn.GetDate(consulta);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return fecha;
}

//Saca la fecha de cuando se piensa entregar el equipo
Sys::Time iNotacomDll::SQL::sacarFechaEntregado(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	Sys::Time fecha;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT fecha\
		FROM entrega\
		WHERE folio_id = %d;", folio_id);
		fecha = conn.GetDate(consulta);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return fecha;
}

//Saca la fecha de cuando se piensa entregar el equipo
Sys::Time iNotacomDll::SQL::sacarFechaTentativa(int folio_id)
{
	wstring consulta;
	Sql::SqlConnection conn;
	Sys::Time fecha;

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);
		Sys::Format(consulta, L"SELECT fecha_ent\
		FROM folio\
		WHERE id = %d;", folio_id);
		fecha = conn.GetDate(consulta);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
		//cadena = L"";
	}

	conn.CloseSession();
	return fecha;
}

//_____________________________________________ CLASE WINTEMPLA
//Método que llena la ddlist de los usuarios del local
void iNotacomDll::Wintempla::llenarDdUsuario(Win::DropDownList ddUsuario, int large, int local)
{
	Sql::SqlConnection conn;
	wstring consulta;

	//Borra todos los posibles elementos que puedan ya existir
	ddUsuario.DeleteAllItems();

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Ejecuta la consulta en la drop down list (Solo muestra las salidas)
		Sys::Format(consulta, L"SELECT id, nombre\
		FROM usuario\
		WHERE activo = true\
		AND local_id = %d\
		ORDER BY nombre ASC;", local);

		conn.ExecuteSelect(consulta, large, ddUsuario);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	ddUsuario.SetSelectedIndex(0);
	conn.CloseSession();
}

//Método que llena la ddlist de los servicios que se ofrecen
void iNotacomDll::Wintempla::llenarDdServicio(Win::DropDownList ddServicio, int large)
{
	Sql::SqlConnection conn;
	wstring consulta;

	//Borra todos los posibles elementos que puedan ya existir
	ddServicio.DeleteAllItems();

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Ejecuta la consulta en la drop down list (Solo muestra las salidas)
		Sys::Format(consulta, L"SELECT id, nombre\
		FROM servicio\
		WHERE activo = true\
		ORDER BY nombre ASC;");

		conn.ExecuteSelect(consulta, large, ddServicio);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	ddServicio.SetSelectedIndex(0);
	conn.CloseSession();
}

//Método que llena la tabla de elementos sin entregar
void iNotacomDll::Wintempla::llenarLvSinEntregar(Win::ListView lvTabla, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, Format(f.fecha_reg, 'dd/MM/yyyy hh:mm')\
	FROM folio f, cliente c\
	WHERE f.id NOT IN\
	(SELECT folio_id\
		FROM entrega)\
	AND f.cliente_id = c.id\
	ORDER BY f.identificador DESC;");

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 150, L"Registro");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que llena la tabla de servicios hechos a equipos
void iNotacomDll::Wintempla::LlenarLvEquiposServicio(Win::ListView lvTabla, wstring servicio, Sys::Time inicio, Sys::Time termino, bool completado, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	int diaInicio, mesInicio, anoInicio;
	int diaFinal, mesFinal, anoFinal;

	//Asigna los valores
	diaInicio = inicio.wDay;
	mesInicio = inicio.wMonth;
	anoInicio = inicio.wYear;

	diaFinal = termino.wDay;
	mesFinal = termino.wMonth;
	anoFinal = termino.wYear;

	if (!completado)
	{
		Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, f.equipo, f.imei, Format(f.fecha_reg, 'dd/MM/yyyy'), Format(f.fecha_ent, 'dd/MM/yyyy'), '$ ' & ROUND(f.precio_sug), u.nombre\
		FROM folio f, cliente c, usuario u, servicio s\
		WHERE f.id NOT IN\
		(SELECT folio_id\
			FROM entrega)\
		AND f.cliente_id = c.id\
		AND f.usuario_id = u.id\
		AND s.id = f.servicio_id\
		AND s.nombre = '%s'\
		AND f.fecha_reg >= #%d-%d-%d 00:00:00#\
		AND f.fecha_reg <= #%d-%d-%d 23:59:59#\
		ORDER BY u.nombre ASC;", servicio.c_str(), anoInicio, mesInicio, diaInicio, anoFinal, mesFinal, diaFinal);
	}
	else
	{
		Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, f.equipo, f.imei, Format(f.fecha_reg, 'dd/MM/yyyy'), Format(f.fecha_ent, 'dd/MM/yyyy'), '$ ' & ROUND(f.precio_sug), u.nombre\
		FROM folio f, cliente c, entrega e, usuario u, servicio s\
		WHERE c.id = f.cliente_id\
		AND e.folio_id = f.id\
		AND f.usuario_id = u.id\
		AND s.id = f.servicio_id\
		AND s.nombre = '%s'\
		AND f.fecha_reg >= #%d-%d-%d 00:00:00#\
		AND f.fecha_reg <= #%d-%d-%d 23:59:59#\
		ORDER BY u.nombre ASC;", servicio.c_str(), anoInicio, mesInicio, diaInicio, anoFinal, mesFinal, diaFinal);
	}

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 120, L"Equipo");
		lvTabla.Cols.Add(3, LVCFMT_LEFT, 120, L"IMEI");
		lvTabla.Cols.Add(4, LVCFMT_LEFT, 80, L"Registro");
		lvTabla.Cols.Add(5, LVCFMT_LEFT, 80, L"Entregar");
		lvTabla.Cols.Add(6, LVCFMT_LEFT, 80, L"Costo");
		lvTabla.Cols.Add(7, LVCFMT_LEFT, 150, L"Usuario");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que llena la tabla de usuario que atendió a los equipos
void iNotacomDll::Wintempla::LlenarLvEquiposUsuario(Win::ListView lvTabla, wstring usuario, Sys::Time inicio, Sys::Time termino, bool completado, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	int diaInicio, mesInicio, anoInicio;
	int diaFinal, mesFinal, anoFinal;

	//Asigna los valores
	diaInicio = inicio.wDay;
	mesInicio = inicio.wMonth;
	anoInicio = inicio.wYear;

	diaFinal = termino.wDay;
	mesFinal = termino.wMonth;
	anoFinal = termino.wYear;

	if (!completado)
	{
		Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, f.equipo, f.imei, Format(f.fecha_reg, 'dd/MM/yyyy'), Format(f.fecha_ent, 'dd/MM/yyyy'), '$ ' & ROUND(f.precio_sug), s.nombre\
		FROM folio f, cliente c, usuario u, servicio s\
		WHERE f.id NOT IN\
		(SELECT folio_id\
			FROM entrega)\
		AND f.cliente_id = c.id\
		AND f.usuario_id = u.id\
		AND s.id = f.servicio_id\
		AND u.nombre = '%s'\
		AND f.fecha_reg >= #%d-%d-%d 00:00:00#\
		AND f.fecha_reg <= #%d-%d-%d 23:59:59#\
		ORDER BY s.nombre ASC;", usuario.c_str(), anoInicio, mesInicio, diaInicio, anoFinal, mesFinal, diaFinal);
	}
	else
	{
		Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, f.equipo, f.imei, Format(f.fecha_reg, 'dd/MM/yyyy'), Format(f.fecha_ent, 'dd/MM/yyyy'), '$ ' & ROUND(f.precio_sug), s.nombre\
		FROM folio f, cliente c, entrega e, usuario u, servicio s\
		WHERE c.id = f.cliente_id\
		AND e.folio_id = f.id\
		AND f.usuario_id = u.id\
		AND s.id = f.servicio_id\
		AND u.nombre = '%s'\
		AND f.fecha_reg >= #%d-%d-%d 00:00:00#\
		AND f.fecha_reg <= #%d-%d-%d 23:59:59#\
		ORDER BY s.nombre ASC;", usuario.c_str(), anoInicio, mesInicio, diaInicio, anoFinal, mesFinal, diaFinal);
	}

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 120, L"Equipo");
		lvTabla.Cols.Add(3, LVCFMT_LEFT, 120, L"IMEI");
		lvTabla.Cols.Add(4, LVCFMT_LEFT, 80, L"Registro");
		lvTabla.Cols.Add(5, LVCFMT_LEFT, 80, L"Entregar");
		lvTabla.Cols.Add(6, LVCFMT_LEFT, 80, L"Costo");
		lvTabla.Cols.Add(7, LVCFMT_LEFT, 100, L"Servicio");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que llena la tabla de los elementos entregados
void iNotacomDll::Wintempla::llenarLvEntregado(Win::ListView lvTabla, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, Format(e.fecha, 'dd/MM/yyyy hh:mm')\
	FROM folio f, entrega e, cliente c\
	WHERE f.id = e.folio_id\
	AND f.cliente_id = c.id\
	ORDER BY f.identificador DESC;");

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 150, L"Entregado");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que llena la tabla dependiendo de la búsqueda del usuario
void iNotacomDll::Wintempla::llenarLvSinEntregarBusqueda(Win::ListView lvTabla, int folio, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;
	wstring n;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	Sys::Format(n, L"%04d", folio);

	Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, Format(f.fecha_reg, 'dd/MM/yyyy hh:mm')\
	FROM folio f, cliente c\
	WHERE f.id NOT IN\
	(SELECT folio_id\
		FROM entrega)\
	AND f.cliente_id = c.id\
	AND f.identificador LIKE '%s%%'\
	ORDER BY f.identificador DESC;", n.c_str());

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 150, L"Registro");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que llena la tabla dependiendo de la búsqueda por nombre
void iNotacomDll::Wintempla::llenarLvSinEntregarNombre(Win::ListView lvTabla, wstring cadena, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, Format(f.fecha_reg, 'dd/MM/yyyy hh:mm')\
	FROM folio f, cliente c\
	WHERE f.id NOT IN\
	(SELECT folio_id\
		FROM entrega)\
	AND f.cliente_id = c.id\
	AND c.nombre LIKE '%s%%'\
	ORDER BY f.identificador DESC;", cadena.c_str());

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 150, L"Registro");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que llena la tabla de los elementos entregados según la busqueda
void iNotacomDll::Wintempla::llenarLvEntregadoBusqueda(Win::ListView lvTabla, int folio, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;
	wstring n;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	Sys::Format(n, L"%04d", folio);

	Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, Format(e.fecha, 'dd/MM/yyyy hh:mm')\
	FROM folio f, entrega e, cliente c\
	WHERE f.id = e.folio_id\
	AND f.cliente_id = c.id\
	AND f.identificador LIKE '%s%%'\
	ORDER BY f.identificador DESC;", n.c_str());

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 150, L"Entregado");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Método que llena la tabla de los elementos entregados según la búsqueda por usuario
void iNotacomDll::Wintempla::llenarLvEntregadoNombre(Win::ListView lvTabla, wstring cadena, int large)
{
	Sql::SqlConnection conn;

	wstring consulta;

	lvTabla.SetRedraw(false);
	lvTabla.Cols.DeleteAll();
	lvTabla.Items.DeleteAll();
	lvTabla.SetRedraw(true);

	Sys::Format(consulta, L"SELECT f.id, f.identificador, c.nombre, Format(e.fecha, 'dd/MM/yyyy hh:mm')\
	FROM folio f, entrega e, cliente c\
	WHERE f.id = e.folio_id\
	AND f.cliente_id = c.id\
	AND c.nombre LIKE '%s%%'\
	ORDER BY f.identificador DESC;", cadena.c_str());

	try
	{
		conn.OpenSession(hWnd, CONNECTION_STRING);

		//Se define los nombres de las columnas
		lvTabla.Cols.Add(0, LVCFMT_LEFT, 80, L"Folio");
		lvTabla.Cols.Add(1, LVCFMT_LEFT, 150, L"Cliente");
		lvTabla.Cols.Add(2, LVCFMT_LEFT, 150, L"Entregado");

		conn.ExecuteSelect(consulta, large, lvTabla);
	}
	catch (Sql::SqlException e)
	{
		this->MessageBox(e.GetDescription(), L"Error", MB_OK | MB_ICONERROR);
	}

	conn.CloseSession();
}

//Saca el id oculto en cualquier drop down list, lo regresa
int iNotacomDll::Wintempla::sacarIDOcultoDd(Win::DropDownList ddLista)
{
	int indice = ddLista.GetSelectedIndex();
	int id = ddLista.Items[indice].Data;

	return id;
}

//Saca la id oculto en cualquier listview, lo regresa
int iNotacomDll::Wintempla::sacarIDOcultoLV(Win::ListView lvTabla)
{
	int indice = lvTabla.GetSelectedIndex();
	int id = lvTabla.Items[indice].Data;

	return id;
}

//________________________________________________CLASE WSTRING
//Saca la parte numérica del identificador
int iNotacomDll::Wstring::sacarIdentificadorNumerico(wstring cadena)
{
	int guion = -1;

	if (cadena.length() == 0)
		return -1;

	for (int unsigned i = 0; i < cadena.length(); i++)
		if (cadena.at(i) == '/')
		{
			guion = i;
			break;
		}

	//Si no existe el guion
	if (guion == -1)
		return -1;

	//Saca la parte numerica del identificador
	return Sys::Convert::ToInt(cadena.substr(0, guion));
}

//Saca la parte de la fecha del identificador
int iNotacomDll::Wstring::sacarIdentificadorFecha(wstring cadena)
{
	int guion = -1;

	if (cadena.length() == 0)
		return -1;

	for (int unsigned i = 0; i < cadena.length(); i++)
		if (cadena.at(i) == '/')
		{
			guion = i;
			break;
		}

	//Si no existe el guion
	if (guion == -1)
		return -1;

	//Saca la parte numerica del identificador
	return Sys::Convert::ToInt(cadena.substr(guion + 1));
}

// ________________________________________________CLASE LOGO
//Constructor
iNotacomDll::Logo::Logo(wstring direccion, int tamano)
{
	this->tamano = tamano;
	metafile.Load(direccion.c_str());
}

//Permite imprimir un logo en un documento
void iNotacomDll::Logo::Print(CG::Gdi &gdi, Win::PrintInfo pi)
{
	SIZE size = metafile.GetSizeIn0_01mm();
	const double logoSize = tamano;
	double scale = min(logoSize / (size.cy + 0.5), logoSize / (size.cy + 0.5));
	RECT rc;
	rc.left = pi.pageWidth;
	rc.right = (int)(pi.pageWidth - size.cx*scale + 0.5);
	/*rc.left = (int)(pi.pageWidth - size.cx*scale + 0.5);
	rc.right = pi.pageWidth;*/
	rc.top = 0;
	rc.bottom = (int)(size.cy*scale + 0.5);
	gdi.DrawMetafile(metafile, rc);
	//wchar_t text[128];
	gdi.Select(pen);
}