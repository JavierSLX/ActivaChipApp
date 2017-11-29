<?php
function checarNumero($numero)
{
	$db = new mysqli('localhost', 'root', '', 'recargasatc');
	
	if ($db->connect_error) 
	{
	 	echo "<script language=\"JavaScript\">alert(\"Eror en la conexion de base de datos (cN)\");</script>";
		die();
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
