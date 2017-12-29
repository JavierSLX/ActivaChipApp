<?php
	//Oculta los warning
	error_reporting(E_ERROR);

	//Importa la libreria necesaria y crea una constante
	require('./library/nusoap/lib/nusoap.php');
	
	define (WSDL, "http://test.xtremecard.com.mx:8081/hub/Listener?WSDL");
	define (USUARIO, "MARQUESADA");
	define (PASSWORD, "123456");
	define (OPERADOR, "Ma12");

	//Función que regresa un arreglo correspondiente al saldo
	function availableBalance($empresa_id)
	{
		$datos = sacarDatosXtreme($empresa_id);
		
		$wsdl = $datos[0];
		$clientBalance = new SoapClient($wsdl, true);
		$peticionBalance = array('user' => $datos[1], 'password' => $datos[2], 'operator' => $datos[3]);
		$respuestaBalance = $clientBalance->call("availableBalance", $peticionBalance);

		if ($clientBalance->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$clientBalance->getError();

		return $respuestaBalance;
	}

	//Funcion que regresa todos los productos
	function getproducts($empresa_id)
	{
		$datos = sacarDatosXtreme($empresa_id);
		
		$wsdl = $datos[0];
		$client = new SoapClient($wsdl, true);
		$login = array('user' => $datos[1], 'password' => $datos[2], 'operator' => $datos[3]);
		$respuesta = $client->call("getProducts", $login);

		if ($client->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		else
			return $respuesta;
	}

	//Funcion que arma la orden
	function getOrder($empresa_id, $idProducto, $numero, $folioCliente)
	{
		//Crea el cliente
		$datos = sacarDatosXtreme($empresa_id);
		
		$wsdl = $datos[0];
		$client = new SoapClient($wsdl, true);

		//Coloca los datos necesarios y manda llamar la operacion
		$peticion = array('user' => $datos[1], 'password' => $datos[2], 'operator' => $datos[3], 'idProduct' => $idProducto, 'numberAccount' => $numero, 'clientFolio' => $folioCliente);
		$respuesta = $client->call("getOrder", $peticion);

		//Verifica que se haya obtenido una respuesta
		if ($client->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		else
			return $respuesta;
	}

	//Funcion que procesa la orden
	function doOrder($empresa_id, $idOrden, $folioCliente)
	{
		$datos = sacarDatosXtreme($empresa_id);
		
		$wsdl = $datos[0];

		$client = new SoapClient($wsdl, true);

		$login = array('user' => $datos[1], 'password' => $datos[2], 'operator' => $datos[3], 'topUpIDValue' => $idOrden, 'clientFolio' => $folioCliente);
		$respuesta = $client->call("doOrder", $login);

		if ($client->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		else
			return $respuesta;
	}

	//Funcion que checa la informacion de la orden
	function checkOrder($empresa_id, $idOrden, $folioCliente)
	{
		$datos = sacarDatosXtreme($empresa_id);
		
		$wsdl = $datos[0];
		$client = new SoapClient($wsdl, true);
		$login = array('user' => $datos[1], 'password' => $datos[2], 'operator' => $datos[3], 'topUpIDValue'=>$idOrden, 'clientFolio'=>$folioCliente);
		$respuesta = $client->call("checkOrder", $login);

		if ($client->getError())
		{
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		}else
		{
			return $respuesta;
		}
    }
	
	//Funcion para obtener un arreglo de datos
	function sacarDatosXtreme($empresa_id)
	{
		//Hace la consulta para obtener el arreglo de datos
		$db = new mysqli('localhost', 'root', '', 'recargasatc');
		if ($db->connect_error) 
		{
			echo "<script language=\"JavaScript\">alert(\"Error en la conexion de base de datos (x)\");</script>";
			die();
		}
		
		//Hace la consulta
		$query = "SELECT wsdl, usuario, pass, clave_operador FROM acceso_empresa WHERE empresa_id = $empresa_id;";
		$result = $db->query($query);
		$row = mysqli_fetch_row($result);
		
		return $row;
	}
?>
