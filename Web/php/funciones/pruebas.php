<?php
	require('./lib/nusoap.php');

	$wsdl = "http://test.xtremecard.com.mx:8081/hub/Listener?WSDL";

	$client = new SoapClient($wsdl, true);

	$login = array('user' => 'MARQUESADA', 'password' => '123456', 'operator' => 'Ma12');
	$respuesta = $client->call("helloHub", $login);

	if ($client->getError())
		echo "<br/><br/>Error al llamar el metodo<br/>".$client->getError();
	else
		print_r($respuesta);
?>
