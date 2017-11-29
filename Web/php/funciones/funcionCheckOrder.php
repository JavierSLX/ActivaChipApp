<?php
	require_once('lib/nusoap.php');

	function checkOrder($usuario, $password, $operador, $id, $folioCliente)
	{
    $wsdl = "http://test.xtremecard.com.mx:8081/hub/Listener?WSDL";
    $client = new SoapClient($wsdl, true);
		$login = array('user' => $usuario, 'password' => $password, 'operator' => $operador, 'topUpIDValue'=>$id, 'clientFolio'=>$folioCliente);
		$respuesta = $client->call("checkOrder", $login);

		if ($client->getError()){
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();

		}else{
      return $Fecha;
    }
	}
  print "<pre>";
  print_r(checkOrder());
  print "<br><br><br><br></pre>";
  //print_r($Fecha);


?>
