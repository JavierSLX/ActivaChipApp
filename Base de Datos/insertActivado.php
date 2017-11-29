<?php
$idNumero = $_GET["idNumero"];
$idCliente =$_GET["idCliente"];
$Folio = $_GET["folio"];
//fecha
date_default_timezone_set('america/mexico_city');
$fecha=date("Y-m-d H:i:s");


$db = new mysqli('localhost', 'root', '', 'recargasatc');
if ($db->connect_error) {
  die('No autorizado (' . $db->connect_errno . ')'. $db->connect_error);
}


if (empty($idNumero) || empty($idcliente) || empty($idFolio) ){
  $query = "INSERT INTO activado (cantidad, folio, fecha, estado, numero_id, cliente_id)
            VALUES('1','$Folio','$fecha','1','$idNumero','$idCliente')";

            $result = $db->query($query);
            if ($result)
                echo' TU REGISTRO SE REALIZO CON EXITO.';

   }else {
    echo "no se ha podido guardar los datos";

   }

?>
