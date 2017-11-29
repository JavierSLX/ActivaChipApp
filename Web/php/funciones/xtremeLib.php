<?php
	//Oculta los warning
	error_reporting(E_ERROR);

	//Importa la libreria necesaria y crea una constante
	require('./lib/nusoap.php');
	define (WSDL, "http://test.xtremecard.com.mx:8081/hub/Listener?WSDL");

	//Función que regresa un arreglo correspondiente al saldo
	function availableBalance($usuario, $pass, $oper)
	{
		$wsdl = WSDL;
		$clientBalance = new SoapClient($wsdl, true);
		$peticionBalance = array('user' => $usuario, 'password' => $pass, 'operator' => $oper);
		$respuestaBalance = $clientBalance->call("availableBalance", $peticionBalance);

		if ($clientBalance->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$clientBalance->getError();

		return $respuestaBalance;
	}

	//Funcion que regresa todos los productos
	function getproducts($usuario, $password, $operator)
	{
		$wsdl = WSDL;

		$client = new SoapClient($wsdl, true);
		$login = array('user' => $usuario, 'password' => $password, 'operator' => $operator);
		$respuesta = $client->call("getProducts", $login);

		if ($client->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		else
			return $respuesta;
	}

	//Funcion que arma la orden
	function getOrder($usuario, $password, $operador, $idProducto, $numero, $folio)
	{
		//Crea el cliente
		$wsdl = WSDL;
		$client = new SoapClient($wsdl, true);

		//Coloca los datos necesarios y manda llamar la operacion
		$peticion = array('user' => $usuario, 'password' => $password, 'operator' => $operador, 'idProduct' => $idProducto, 'numberAccount' => $numero, 'clientFolio' => $folio);
		$respuesta = $client->call("getOrder", $peticion);

		//Verifica que se haya obtenido una respuesta
		if ($client->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		else
			return $respuesta;
	}

	//Funcion que procesa la orden
	function doOrder($usuario, $password, $operador, $id, $folioCliente)
	{
		$wsdl = WSDL;

		$client = new SoapClient($wsdl, true);

		$login = array('user' => $usuario, 'password' => $password, 'operator' => $operador, 'topUpIDValue' => $id, 'clientFolio' => $folioCliente);
		$respuesta = $client->call("doOrder", $login);

		if ($client->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		else
			return $respuesta;
	}

	//Funcion que checa la informacion de la orden
	function checkOrder($usuario, $password, $operador, $id, $folioCliente)
	{
		$wsdl = WSDL;
		$client = new SoapClient($wsdl, true);
		$login = array('user' => $usuario, 'password' => $password, 'operator' => $operador, 'topUpIDValue'=>$id, 'clientFolio'=>$folioCliente);
		$respuesta = $client->call("checkOrder", $login);

		if ($client->getError())
		{
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		}else
		{
			return $respuesta;
		}
    }
?>
