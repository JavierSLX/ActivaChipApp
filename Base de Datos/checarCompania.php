<?php
$db = new mysqli('localhost', 'root', '', 'recargasatc');
$tel = $_GET["tel"];

$query = "SELECT n.monto, c.nombre from numero n, carrier c  where n.carrier_id = c.id and n.digitos = '$tel'";

$result = $db->query($query);
if ($result){
  $row=mysqli_fetch_row($result);
  print $count=$row[0];
  print $count=$row[1];

}else{
  echo "No entro";
}



 ?>
