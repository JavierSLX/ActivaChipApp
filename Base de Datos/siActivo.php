<?php
//$numero = '1234567890';
$idNumero = $_GET["idnumero"];
$db = new mysqli('localhost', 'root', '', 'recargasatc');
if ($db->connect_error) {
  die('No autorizado (' . $db->connect_errno . ') '
          . $db->connect_error);
}

$query = "select id from activado where numero_id = '$idNumero'";
$result=mysqli_query($db , $query);
if(!$result)
{
  echo 'sin conexion a la base de datos.';
  exit;
}
$row=mysqli_fetch_row($result);
$count=$row[0];

if( $count > 0)
{
  echo'El numero ya esta activado';
}else{
  echo 'El numero no esta activado';

}

 ?>
