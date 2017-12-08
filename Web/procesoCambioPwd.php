<?php
error_reporting(E_ERROR);
require "php\claseSesion.php";
require "php/library/nusoap/lib/nusoap.php";


$sesion = new Sesion();
$cliente = new nusoap_client("http://atc.mx/WebService/Aplicacion%20de%20escritorio/seguridad/seguridad.php?wsdl",false);
if ($sesion->estadoLogin()==true) {
$datosUsuario=$sesion->datosUsuario();
  $usuarioID=$datosUsuario[0];
  $empresaID=$datosUsuario[1];
  $permisoID=$datosUsuario[2];

  $clave0 = $_POST['pwsOld'];
  $clave1 = $_POST['digitos'];
  $clave2 = $_POST['numero'];

  if (!empty($clave0)) {
    $parametros = array('password'=>$clave0);
    $pwsOldEncriptado = $cliente->call('encriptar',$parametros);
    $confirmaPswOld = cambiarPasswordOld($usuarioID);
    if ($pwsOldEncriptado == $confirmaPswOld) {
      if (!empty($clave1)&&!empty($clave2)) {
        if ($clave1 == $clave2) {
          $parametros = array('password'=>$clave2);
          $passencriptado = $cliente->call('encriptar',$parametros);
          $cambio = cambiarPassword($usuarioID,$passencriptado);
          //$usuario = sacarCliente($usuarioID);
          $sesion->nuevoPass($passencriptado);
          echo "<script language=\"JavaScript\">alert(\"Tu nueva contraseña ha sido cambiada con exito\");";
          echo "location.href =\"./cambioPassword\";</script>";
        }
      }
    } else {
      echo "<script language=\"JavaScript\">alert(\"El campo de la contraseña actual no coincide\");";
      echo "location.href =\"./cambioPassword\";</script>";
    }
  }

} else {
    header("location:index");
}
?>
