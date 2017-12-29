<?php
	error_reporting(0);
	$db = new mysqli('localhost', 'root', '', 'recargasatc');

	if ($db->connect_error) 
	{

		echo "<script language=\"JavaScript\">alert(\"Eror en la conexion de la base de datos (cMysql)\");</script>";
		die();
	}
	
	//Método que permite saber si un numero existe en la base de datos
	function consultarNumero($numero, $idCliente)
	{
		$query = "SELECT id FROM numero WHERE digitos = '$numero' AND cliente_id = $idCliente";
		global $db;
		$result = mysqli_query($db , $query);
		if(!$result)
		{
			echo 'Cannot run query.';
			exit;
		}
		
		$row = mysqli_fetch_row($result);
		$count=$row[0];

		//mysqli_close($db);
		return $count;
	}
	
	//Método que permite saber si un numero existe en la base de datos con su empresa 
	function consultarNumeroCliente($numero, $empresaID)
	{
		$query = "SELECT num.cliente_id FROM numero num, cliente cli WHERE num.digitos = '$numero' and num.cliente_id = cli.id and cli.empresa_id = '$empresaID';";
		global $db;
		$result = mysqli_query($db , $query);
		if(!$result)
		{
			echo 'Cannot run query.';
			exit;
		}
		
		$row = mysqli_fetch_row($result);
		$count=$row[0];

		//mysqli_close($db);
		return $count;
	}

	//Checa si el numero ya fue activado
	function checarActivo($numero)
	{
		$query = "SELECT a.estado FROM activado a, numero n WHERE a.numero_id = n.id AND n.digitos = '$numero';";
		global $db;
		$result = mysqli_query($db , $query);
		if(!$result)
		{
			echo 'sin conexion a la base de datos.';
			exit;
		}
	  
		$row = mysqli_fetch_row($result);
		$count = $row[0];

		//mysqli_close($db);
		return $count;
	}
	
	//Saca el id del numero
	function sacarIDNumero($numero)
	{
		$query = "SELECT id FROM numero WHERE digitos = '$numero';";
		global $db;
		$result = mysqli_query($db , $query);
		if(!$result)
		{
			echo 'sin conexion a la base de datos.';
			exit;
		}
	  
		$row = mysqli_fetch_row($result);
		$count = $row[0];

		//mysqli_close($db);
		return $count;
	}

	//Funcion que inserta el chip a la tabla cuando ya fue activado
	function insertarActivado($idNumero, $idRecargas, $folio, $monto)
	{
		date_default_timezone_set('america/mexico_city');
		$fecha=date("Y-m-d H:i:s");

		$query = "INSERT INTO activado (cantidad, idRecargas, folio, fecha, estado, numero_id)
			VALUES($monto, '$idRecargas', '$folio', '$fecha', true, '$idNumero')";
		
		global $db;  
		$result = $db->query($query);
		
		//mysqli_close($db);
		return $result;
	}

	
	//Función que saca si existen los datos del login del cliente
	function loginCliente($nick, $pass)
	{
		$query = "SELECT c.id,c.empresa_id from permiso_cliente p, cliente c where p.cliente_id = c.id and p.nickname = '$nick' and p.pass = '$pass' AND c.activo = true";
		global $db;
	
		$result =  $db->query($query);
		$row=mysqli_fetch_row($result);
		$count=$row[0];
	
		//mysqli_close($db);
		return $row;
	}
	
	//Función que saca si existen los datos del login del administrador
	function loginAdmin($nick, $pass)
	{
		$query = "SELECT pa.administrador_id, adm.empresa_id FROM permiso_administrador pa, administrador adm  WHERE pa.nickname = '$nick' AND pa.pass = '$pass' AND pa.activo = true and pa.administrador_id = adm.id;";
		global $db;
	
		$result =  $db->query($query);
		$row=mysqli_fetch_row($result);
		$count=$row[0];
	
		//mysqli_close($db);
		return $row;
	}

	//Función que saca los datos de compañia y monto a recargar (manda el objeto con el resultado de la consulta)
	function checarCompania($telefono)
	{
		$query = "SELECT n.monto, c.nombre FROM numero n, carrier c WHERE n.carrier_id = c.id AND n.digitos = '$tel'";
		global $db;
		$result = $db->query($query);
		$row = mysqli_fetch_assoc($result);
	   
		//mysqli_close($db);
		return $row;
	}
	
	//Saca el monto a recargar del numero
	function sacarMonto($numero)
	{
		$query = "SELECT monto FROM numero WHERE digitos = '$numero';";
		global $db;
		$result = $db->query($query);
		$row=mysqli_fetch_row($result);
		
		return $row[0];
	}
	
	//Saca la compañia del numero
	function sacarCompania($numero)
	{
		$query = "SELECT c.nombre FROM numero n, carrier c WHERE n.carrier_id = c.id AND n.digitos = '$numero';";
		global $db;
		$result = $db->query($query);
		$row=mysqli_fetch_row($result);
		
		return $row[0];
	}
	
	//Saca la clave del cliente
	function sacarClaveCliente($idCliente){

		$query = "SELECT pv.tipo, cc.numero FROM clave_cliente cc, cliente c, punto_venta pv WHERE cc.cliente_id = c.id
			AND cc.puntoventa_id = pv.id AND c.id = '$idCliente'";
	
		global $db;
		$result = $db->query($query);
		
		if ($result)
		{
			$row = mysqli_fetch_row($result);
			$clave = $row[0]."-".str_pad($row[1], 3, "0", STR_PAD_LEFT);
		}
		
		//mysqli_close($db);
		return $clave;
	}

	//Inserta un registro de login
	function insertarRegistroLogin($idCliente)
	{
		//sacar la  hora y fecha actual
		date_default_timezone_set('america/mexico_city');
		$fechaHoy=date("Y-m-d H:i:s");
	 
		$query = "INSERT INTO registro_login(fecha,cliente_id) VALUES ('$fechaHoy','$idCliente')";
		global $db;
		$result = $db->query($query);
		
		//mysqli_close($db);
	}


	//Funcion que saca los datos para el reporte
	function Reporte($id, $fechainicio)
	{
		$query = "SELECT ca.nombre,n.digitos, a.fecha, a.cantidad,cl.nombre
			from numero n, activado a, cliente c, carrier ca,cliente cl
			where a.numero_id = n.id
			and n.cliente_id = cl.id
			and n.cliente_id = c.id
			and n.carrier_id= ca.id
			and c.id = '$id'
			and DATE(a.fecha) ='$fechainicio'
			order by a.fecha desc;";

		global $db;
		$result = $db->query($query);
		
		return $result;
	}
	
	//Funcion que saca los datos para el reporte si es administrador
	function reporteAdministrador($fechainicio)
	{
		$query = "SELECT ca.nombre,n.digitos, a.fecha, a.cantidad,cl.nombre
			from numero n, activado a,carrier ca,cliente cl
			where a.numero_id = n.id
			and n.cliente_id = cl.id
			and n.carrier_id= ca.id
			and DATE(a.fecha) ='$fechainicio'
			order by a.fecha desc;";

		global $db;
		$result = $db->query($query);
		
		return $result;
	}
	
	function ReporteContador($id, $fechainicio)
	{
		$query = "SELECT COUNT(*)
			from numero n, activado a, cliente c, carrier ca
			where a.numero_id = n.id
			and n.cliente_id = c.id
			and n.carrier_id= ca.id
			and c.id = '$id'
			and DATE(a.fecha) ='$fechainicio';";

		global $db;
		$result = $db->query($query);
		if ($result)
		{
			$row=mysqli_fetch_row($result);
			$num =$row[0];
		}
		else{
			echo "No entro";
		}
	  return $num;
	}

	//Saca la fecha en el que se registró un numero
	function sacarFecha($telefono)
	{
		$query ="SELECT fecha FROM numero WHERE digitos = '$telefono'";
		global $db;
		$result = $db->query($query);
		
		if ($result)
		{
			$row = mysqli_fetch_row($result);
			$count=$row[0];
		}
		
		//mysqli_close($db);
		return $count;
	}
	
	//Funcion que saca el correo de contacto y el id de la notificacion a partir del numero
	function sacarNotificacion($numero)
	{
		$query = "SELECT n.id, n.email FROM numero num, cliente c, empresa e, notificaciones n WHERE num.cliente_id = c.id AND c.empresa_id = e.id
			AND n.empresa_id = e.id AND num.digitos = '$numero';";
		global $db;
		$result = $db->query($query);
		$row=mysqli_fetch_row($result);
		
		return $row;
	}
	
	//Funcion que saca la bandera para saber si ya fue enviado el mensaje
	function sacarAlerta($notificacion_id)
	{
		$query = "SELECT activo FROM alerta_notificaciones WHERE notificaciones_id = $notificacion_id;";
		global $db;
		$result = $db->query($query);
		$row=mysqli_fetch_row($result);
		
		return $row[0];
	}
	
	//Funcion que cambia el estado de la alerta
	function actualizarAlerta($notificacion_id, $estado)
	{
		$query = "UPDATE alerta_notificaciones SET activo = $estado WHERE notificaciones_id = $notificacion_id;";
		global $db;
		$result = $db->query($query);
	}
	
	//Saca el id de la empresa de acuerdo al numero registrado
	function sacarIDEmpresa($numero)
	{
		$query = "SELECT c.empresa_id FROM numero n, cliente c WHERE n.cliente_id = c.id AND n.digitos = '$numero';";
		global $db;
		$result = $db->query($query);
		$row=mysqli_fetch_row($result);
		
		return $row[0];
	}

	// funcion para sacar los dias restantes antes de que no se puedan activar chips
	function reporteCaducidad($idCliente,$inicio,$TAMANO_PAGINA)
	{
		$fechaHoy=date("Y-m-d");
		global $db;

		$query= "SELECT  nu.digitos, ca.nombre,nu.fecha,29-DATEDIFF(now(),nu.fecha) AS caducidad
		FROM numero nu, carrier ca, cliente cl
		where nu.id NOT IN(SELECT numero_id from activado)
		and nu.carrier_id = ca.id
		and nu.cliente_id = cl.id
		and cl.id = '$idCliente'
		and ca.nombre !='TELCEL'
        and 29 >= DATEDIFF(now(),nu.fecha)
        order by caducidad ASC LIMIt ".$inicio.", ".$TAMANO_PAGINA;
		 
		 $result = $db->query($query);
		 if ($result){
		 }else{
		  //echo "No entro";
		 }
		 return $result;
	}

	function reporteCaducidadcount($idCliente)
	{
		$fechaHoy=date("Y-m-d");
		global $db;

		$query= "SELECT  count(nu.id)
		FROM numero nu, carrier ca, cliente cl
		where nu.id NOT IN(SELECT numero_id from activado)
		and nu.carrier_id = ca.id
		and nu.cliente_id = cl.id
		and cl.id = '$idCliente'
		and ca.nombre !='TELCEL'
        and 29 >= DATEDIFF(now(),nu.fecha);";
		 
		 global $db;
		$result = $db->query($query);
		if ($result)
		{
			$row=mysqli_fetch_row($result);
			$num =$row[0];
		}else{
			echo "No entro";
		}
	  return $num;
	}
	//Compara folio con el numero con su respectivo cliente
	function folioCliente($folio, $empresaID)
	{
		global $db;
	
		$query = "select num.digitos, pv.tipo, cc.numero
		from numero num, cliente cli, clave_cliente cc, punto_venta pv
		where num.folio='$folio'
		and num.cliente_id=cli.id
		and cc.cliente_id=cli.id
		and cc.puntoventa_id=pv.id
		and cli.empresa_id='$empresaID';";

	
		$result = $db->query($query);
				 $row=mysqli_fetch_row($result);
				return $row;
	}

	//comparar el folio con el numero
	function comprobarFolio($folio, $clienteID)
	{
		global $db;

		$query = "select digitos from numero where folio = '$folio' and cliente_id='$clienteID';";
		
	  	$result = $db->query($query);
			 $row=mysqli_fetch_row($result);
			return $row[0];
	}


	//cambia la contraseña del cliente(usuario)
	function cambiarPassword($idCliente, $password)
	{
	   global $db;

		$query= "UPDATE permiso_cliente
				  SET pass = '$password'
				  WHERE cliente_id = '$idCliente'";
		 $result = $db->query($query);
		 if ($result){
		 }else{
		  //echo "No entro";
		 }
	}
	function sacarCliente($idCliente)
	{
	   global $db;

		$query= "SELECT nick
								FROM permiso_cliente
								where cliente_id = '$idCliente'";
		 $result = $db->query($query);
			 $row=mysqli_fetch_row($result);
			return $row[0];
	}

	//Funcion que inserta un nuevo dato al log de los errores
	function insertarError($idNumero, $folioCliente, $topUpID, $idError, $descripcion)
	{
		$fechaHoy=date("Y-m-d");
		global $db;

		$query= "INSERT INTO log_error(fecha, folioCliente, topUpID, errorCode, errorMessage, numero_id) VALUES (now(), '$folioCliente', $topUpID, $idError, '$descripcion', $idNumero);";
		$result = $db->query($query);
	}

	// checa si la contraseña antigua que desea cambiar esta registrada en la base de datos
	function cambiarPasswordOld($idCliente)
	{
	   global $db;

		$query= "SELECT pass FROM permiso_cliente
				  WHERE cliente_id = '$idCliente'";
		 $result = $db->query($query);
			 $row=mysqli_fetch_row($result);
			return $row[0];
	}
 ?>
 
