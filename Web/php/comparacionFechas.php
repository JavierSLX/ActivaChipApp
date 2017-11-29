<?php

//Zona horaria de México
date_default_timezone_set('america/mexico_city');

//fecha de recarga
function dias_transcurridos($fecha_i,$fecha_f)
{
	$dias	= (strtotime($fecha_i)-strtotime($fecha_f))/86400;
	$dias 	= abs($dias); $dias = floor($dias);
	return $dias;
}

/*print "Fecha recarga: <br>";
print $FechaRecarga;
print"<br>";

print "Fecha hoy: <br>";


echo "<br>";
print dias_transcurridos($FechaRecarga,$fechaHoy);
*/
?>
