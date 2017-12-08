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

?>
<!DOCTYPE html>
<html >
<head>
  <meta charset="UTF-8">
  <title>ActivaChip</title>
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js"></script>
      <link rel="stylesheet" href="css/main.css">
      <link rel="stylesheet" type="text/css" href="css/principal.css" />
      <link href="css/styleR.css" rel="stylesheet" type="text/css" />
      <script>
        function tel(e){
          key=e.keyCode || e.which;
          teclado=String.fromCharCode(key);
          numero='0123456789qazwsxedcrfvtgbyhnujmiklopñQAZWSXEDCRFVTGBYHNUJMIKOLPÑ.-_';
          especiales='37-38-46';
          teclado_especiales=false;
          for(var i in especiales){
            if(key==especiales[i]){
              teclado_especiales=true;
            }
          }
          if(numero.indexOf(teclado)==-1 && !teclado_especiales){
            return false;
          }
          if(e.value.length <15){
            return false;
          }
        };
      </script>
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

    <form id="formulario" method='post'  autocomplete="off">
      
      <input id="pwsOld" name="pwsOld" maxlength="15"  type="text" placeholder="Contraseña Actual" autofocus/>
      <input id="digitos" name="digitos" maxlength="15"  type="text" placeholder="Nueva contraseña"/>
      <input id="numero"  maxlength="15" name="numero" type="text" placeholder="Confirma nueva contraseña"/>

      <!--<     -->
      <button id="btn_enviar" color = "black" onclick="puntero()">Aceptar</button>
    </form>
  </div>
</div>
  <script>
$("#btn_enviar").click(function(){
  var url = "./procesoCambioPwd"; // El script a dónde se realizará la petición.
    $.ajax({
      type: "POST",
      url: url,
      data: $("#formulario").serialize(), // Adjuntar los campos del formulario enviado.
      //Ejecutar antes de ser enviado
      beforeSend: function(){
        var miCampoTexto0 = document.getElementById("pwsOld").value;
        var miCampoTexto = document.getElementById("digitos").value;
        var miCampoTexto2 = document.getElementById("numero").value;
        //las condiciones de los campos del formulario
        if (miCampoTexto0.length == 0){;
          document.getElementById("pwsOld").focus();
          return false;
        }else if (miCampoTexto.length == 0 ) {
          document.getElementById("digitos").focus();
          return false;
        }else if (miCampoTexto2.length == 0 ) {
          document.getElementById("numero").focus();
          return false;
        } else if (miCampoTexto != miCampoTexto2){
          alert('Los campos de contraseña actual no coinciden');
          document.getElementById("digitos").value = "";
          document.getElementById("numero").value = "";
          document.getElementById("digitos").focus();
          return false;
        }
      
      },
      success: function(data){
        $("#respuesta").html(data); // Mostrar la respuestas del script PHP.
      }

  });
  return false; // Evitar ejecutar el submit del formulario.
});

$(function(){
  //funcion cunado tecla enter se presiona
  $(window).keypress(function(e){
    if (e.keyCode == 13) {
      var url = "./procesoCambioPwd"; // El script a dónde se realizará la petición.
      $.ajax({
        type: "POST",
        url: url,
        data: $("#formulario").serialize(), // Adjuntar los campos del formulario enviado.
        //Ejecutar antes de ser enviado
        beforeSend: function(){
          var miCampoTexto0 = document.getElementById("pwsOld").value;
          var miCampoTexto = document.getElementById("digitos").value;
          var miCampoTexto2 = document.getElementById("numero").value;
          //las condiciones de los campos del formulario
          if (miCampoTexto0.length == 0){
          document.getElementById("pwsOld").focus();
          return false;
        }else if (miCampoTexto.length == 0 ) {
          document.getElementById("digitos").focus();
          return false;
        }else if (miCampoTexto2.length == 0 ) {
          document.getElementById("numero").focus();
          return false;
        }else if (miCampoTexto != miCampoTexto2){
          alert('Los campos de contraseña actual no coinciden');
          document.getElementById("digitos").value = "";
          document.getElementById("numero").value = "";
          document.getElementById("digitos").focus();
          return false;
        }
        },
        success: function(data){
          $("#respuesta").html(data); // Mostrar la respuestas del script PHP.
        }
      });
      return false; // Evitar ejecutar el submit del formulario.
    }
  });
});
</script>

<div id="respuesta"></div>

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
