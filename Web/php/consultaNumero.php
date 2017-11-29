<?php
function checarNumero($numero)
{
	$db = new mysqli('localhost', 'root', '', 'recargasatc');
	
	if ($db->connect_error) 
	{
	  die('No autorizado (' . $db->connect_errno . ') '
			  . $db->connect_error);
	}

	$query = "SELECT id FROM numero WHERE digitos = '$numero'";
	$result = mysqli_query($db , $query);
	if(!$result)
	{
	  echo 'Cannot run query.';
	  exit;
	}
	
	$row = mysqli_fetch_row($result);
	print $count=$row[0];

	if( $count > 0)
	{
	  echo'Si existe el numero';
	}else{
	  echo'Este numero no pertenece a este distribuidor TELCEL';

	}
}
 ?>
