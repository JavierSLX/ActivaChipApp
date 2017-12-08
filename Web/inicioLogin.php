<?php
require "php\claseSesion.php";
//require "php\ConsultasMySQL.php";
require "php/library/nusoap/lib/nusoap.php";
$cliente = new nusoap_client("http://atc.mx/WebService/Aplicacion%20de%20escritorio/seguridad/seguridad.php?wsdl",false);

$sesion = new Sesion();

if (isset($_POST["nick"]))
{
    $usuario = $_POST["nick"];
    $pass = $_POST["pass"];
    $parametros = array('password'=>$pass);
    $passencriptado = $cliente->call('encriptar',$parametros);

	//Checa si la persona logeada es administrador
	$resultado = loginAdmin($usuario, $passencriptado);
	if ($resultado[0] > 0)
	{
		$permisoID = 1;
		$usuarioID = $resultado[0];
		$sesion->inicioLogin($usuario,$passencriptado);
		echo "<script language=\"JavaScript\">alert('Bienvenido administrador: $usuario.'); location.href='recarga.php';</script>";
	}
	else
	{
		//Checa si la persona logeada es un cliente
		$resultado = loginCliente($usuario,$passencriptado);

		if ($resultado[0] > 0)
		{
			$permisoID = 2;
			$usuarioID = $resultado[0];
			insertarRegistroLogin($usuarioID);
			$sesion->inicioLogin($usuario,$passencriptado);
			echo "<script language=\"JavaScript\">alert('Bienvenido usuario: $usuario.');
      location.href='recarga';</script>";
		}
		else
			echo "<script language=\"JavaScript\">alert('$usuario, usted no esta autorizado para acceder.');location.href='login';</script>";
	}
}
?>
