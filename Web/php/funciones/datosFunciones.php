<?php

require('xtremeLib.php');

//sacamos fecha de recarga
function fecha($usuario, $password, $operador, $id, $folioCliente){
    $respuesta = checkOrder($usuario, $password, $operador, $id, $folioCliente);
    //$respuesta = checkOrder($usuario, $password, $operador, $id, $folioCliente);
    $Fecha = $respuesta['TopUpResult']['date'];
    //echo $Fecha;
    return $Fecha;
}

function folio($usuario, $password, $operador, $id, $folioCliente){
    $respuesta = checkOrder($usuario, $password, $operador, $id, $folioCliente);
    //$respuesta = checkOrder($usuario, $password, $operador, $id, $folioCliente);
    $folio = $respuesta['TopUpResult']['folio'];
    //echo $Fecha;
    return $folio;
}

function numero($usuario, $password, $operador, $id, $folioCliente){
    $respuesta = checkOrder($usuario, $password, $operador, $id, $folioCliente);
    //$respuesta = checkOrder($usuario, $password, $operador, $id, $folioCliente);
    $numero = $respuesta['TopUpResult']['numberAccount'];
    //echo $Fecha;
    return $numero;
}


print_r(fecha('MARQUESADA','123456','Ma12','14015531','Prueba/001'));
print "<br>";
/*print_r(folio('MARQUESADA','123456','Ma12','13953858','0003'));
print "<br>";
print_r(numero('MARQUESADA','123456','Ma12','13953858','0003'));
*/

date_default_timezone_set('america/mexico_city');
print($fecha=date("Y-m-d H:i:s"));


?>
