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

  $clave0 = $_POST['actual'];
  $clave1 = $_POST['digitos'];
  $clave2 = $_POST['numero'];
  
  if (!empty($clave0))
  {
	  
  }

  if (!empty($clave1)&&!empty($clave2)) {
    if ($clave1 == $clave2) {
      $parametros = array('password'=>$clave2);
      $passencriptado = $cliente->call('encriptar',$parametros);
      $cambio = cambiarPassword($usuarioID,$passencriptado);
      //$usuario = sacarCliente($usuarioID);
      $sesion->nuevoPass($passencriptado);
      ?>
      <script type="text/javascript">
        alert("Tu nueva contraseña ha sido cambiado con exito")
        //location.href="recarga.php"
      </script>
      <?php
    }else {
      ?>
      <script type="text/javascript">
        alert("no coinciden los campos")
      </script>
      <?php
    }
  }


?>
<!DOCTYPE html>
<html >
<head>
  <meta charset="UTF-8">
  <title>ActivaChip</title>

      <link rel="stylesheet" href="css/main.css">
      <link rel="stylesheet" type="text/css" href="css/principal.css" />
      <link href="css/styleR.css" rel="stylesheet" type="text/css" />


</head>

<body>
  <div class="container">
      <ul id="nav" >
          <li><a href="recarga">Inicio</a></li>
          <li ><a href="reporte">Reporte</a></li>
            <?php if ($permisoID == 2) {
            echo '<li ><a href="caducidad">Caducidad</a></li>';
            } ?>
            <li class="active"><a href="">Cuenta</a></li>
            <ul id="nav-right">
              <li class="push-right"><a href="loginOut">Cerrar Sesion </a></li>

            </ul>
      </ul>
  </div>
  <div class="login-page">
  <div class="form">

  <h1><img src="img/atc1.png">ctivaChip</h1>

    <form method='post' action =""  autocomplete="off">

		<input id="actual" name="antigua" maxlength="15" onkeypress = 'return tel(event)' type="text" placeholder="Contraseña actual"/>
      <input id="digitos" name="digitos" maxlength="15" onkeypress = 'return tel(event)' type="text" placeholder="Nueva contraseña"/>
      <input id="numero"  onkeypress = 'return tel(event)' maxlength="15" name="numero" type="text" placeholder="Confirma nueva contraseña"/>

      <!--<     -->
      <button color = "black">Aceptar</button>
    </form>
  </div>
</div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script  src="js/index.js"></script>

</body>
<footer >
Contacto: webmaster.atc.mx@gmail.com <br>
Copyright© 2017-2018. Morpheus DSS
</footer>
</html>
<?php
} else {
    header("location:index");
}
?>
