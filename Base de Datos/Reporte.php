
<?php

$db = new mysqli('localhost', 'root', '', 'recargasatc');
$id = $_GET["id"];
$fechainicio = $_GET["fechainicio"];
$fechafin= $_GET["fechafin"];

$query = "SELECT n.digitos, c.nombre, a.fecha from numero n, activado a, cliente c where a.numero_id = n.id and a.cliente_id = c.id and c.id = $id and DATE(a.fecha) >='$fechainicio' AND DATE(A.fecha)<= '$fechafin'";

$result = $db->query($query);
if ($result){
  $row=mysqli_fetch_row($result);
  print $count=$row[0];
  print $count=$row[1];
  print $count=$row[2];

}else{
 echo "No entro";
}


 ?>
