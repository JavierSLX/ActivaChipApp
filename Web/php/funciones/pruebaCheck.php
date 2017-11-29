<?php
	require_once('lib/nusoap.php');

	$wsdl = "http://test.xtremecard.com.mx:8081/hub/Listener?WSDL";
	$client = new SoapClient($wsdl, true);

		$login = array('user' => 'MARQUESADA', 'password' => '123456', 'operator' => 'Ma12','topUpIDValue'=>'13953858','clientFolio'=>'0003');
		$respuesta = $client->call("checkOrder", $login);

		if ($client->getError())
			echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
		else
			print_r($respuesta);
	

?>
