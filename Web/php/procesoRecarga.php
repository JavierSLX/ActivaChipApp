<?php
	require ("recargaATC.php");
	require "claseSesion.php";

$sesion = new Sesion();
if ($sesion->estadoLogin()==true) {
$datosUsuario=$sesion->datosUsuario();
  $usuarioID=$datosUsuario[0];
  $empresaID=$datosUsuario[1];
  $permisoID=$datosUsuario[2];
	
	//Recibe los datos para trabajar correctamente
	$inicial = $_POST["digitos"];
	$numero = $_POST["numero"];
	
	//Checa si el numero existe en la base de datos (la validacion se hace con y sin cliente)
	if ($permisoID == 2)
	{
		$bandera = consultarNumero($numero, $usuarioID);
	}
	else
	{
		$valor = consultarNumeroCliente($numero);
	}
	
	if(empty($bandera) && $permisoID == 2)
	{
		echo "<script language=\"JavaScript\">alert(\"El número $numero no existe en la base de datos\");";
		echo "location.href =\"./recarga\";</script>";
		
		exit;
	}
	else
	{
		if ($permisoID == 2)
			$idCliente = $usuarioID;
		else
			$idCliente = $valor;
	}
	if (empty($valor) && $permisoID == 1) {
		echo "<script language=\"JavaScript\">alert(\"El número $numero no existe en la base de datos\");";
		echo "location.href =\"./recarga\";</script>";
		exit;
	}
	
	//Checa si ya se le hizo recarga al numero con anterioridad
	$existente = checarActivo($numero);
	
	if ($existente)
	{
		echo "<script language=\"JavaScript\">alert(\"Ya fue activado el numero $numero\");";
		echo "location.href =\"./recarga\";</script>";
		exit;
	}
	
	//Saca la compañia y el monto a recargar
	$monto = sacarMonto($numero);
	$compania = sacarCompania($numero);
	
	//Si la compañia es distinta a TELCEL compara que la fecha no haya pasado los 29 dias
	if ($compania != "TELCEL")
	{
		//Saca la fecha en la cual se registró el chip
		$fechaInicial = sacarFecha($numero);
		
		$fechaFinal = date("Y-m-d");
		
		//Saca los días transcurridos
		$dias = dias_transcurridos($fechaInicial, $fechaFinal);
		if ($dias > 29)
		{
			echo "<script language=\"JavaScript\">alert(\"$permisoID El chip con el número $numero sobrepasa los 29 días de recarga inicial($dias)\");";
			echo "location.href =\"./recarga\";</script>";
			exit;
		}
	}
	
	//Saca el id del producto de la compañia de recarga
	$idProducto = sacarIdProducto($compania, $monto);
	
	//id de prueba (QUITAR DESPUES DE PROBAR)
	//$idProducto = 100;
	
	//Saca el ultimo folio de la transaccion(si no existe genera el primero)
	$claveCliente = sacarClaveCliente($idCliente);
	$folio = sacarFolio();
	
	if (empty($folio))
		$folio = primerFolio($claveCliente);
	else
	{
		$folio = folioNuevo($folio, $claveCliente);
	}
	
	//Realiza la recarga
	$resultado = recargarSaldo($numero, $idProducto, $folio);
	
	if ($resultado[0] != 0)
	{
		$idNumero = sacarIDNumero($numero);
		insertarActivado($idNumero, $resultado[0], $folio, $monto);
		echo "<script language=\"JavaScript\">alert(\"Recarga al numero $numero hecha de manera correcta. Guarde su folio $folio para cualquier aclaración.\");";
		echo "location.href =\"./recarga\";</script>";
		
	}
	else
	{
		echo "<script language=\"JavaScript\">alert(\"$resultado[1]. Error al activar $numero\");";
		echo "location.href =\"./recarga\";</script>";
	}
	} else {
    header("location:index");
}
?>

<script type="text/javascript">
	function popup(url, ancho, alto) 
	{
		var posicion_x; 
		var posicion_y; 
		posicion_x=(screen.width/2)-(ancho/2); 
		posicion_y=(screen.height/2)-(alto/2); 
		window.open(url, "leonpurpura.com", "width="+ancho+",height="+alto+",menubar=0,toolbar=0,directories=0,scrollbars=no,resizable=no,left="+posicion_x+",top="+posicion_y+"");
	}
</script>