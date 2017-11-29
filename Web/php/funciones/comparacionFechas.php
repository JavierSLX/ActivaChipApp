<?php

//fecha de recarga
function dias_transcurridos($fecha_i,$fecha_f)
{
	$dias	= (strtotime($fecha_i)-strtotime($fecha_f))/86400;
	$dias 	= abs($dias); $dias = floor($dias);
	return $dias;
}
//fecha Hoy
date_default_timezone_set('america/mexico_city');
$fechaHoy=date("Y-m-d H:i:s");


/*print "Fecha recarga: <br>";
print $FechaRecarga;
print"<br>";

print "Fecha hoy: <br>";


echo "<br>";
print dias_transcurridos($FechaRecarga,$fechaHoy);
*/
?>
