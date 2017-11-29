<?php
	require("ConsultasMySQL.php");
	
	//$arreglo = sacarNotificacion("4661104294");
	actualizarAlerta(1, 0);
	$bandera = sacarAlerta(1);
	
	//echo "Correo: $arreglo[1], notificacion_id = $arreglo[0]";
	echo "bandera: $bandera";
?>