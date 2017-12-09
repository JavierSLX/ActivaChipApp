<?php
require "php\claseSesion.php";

$sesion = new Sesion();
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
      <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.6.6/sweetalert2.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.6.6/sweetalert2.min.js"></script>
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.6.6/sweetalert2.css">
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.6.6/sweetalert2.min.css">
<script type="text/javascript" src="../js/jquery.min.js"></script>

      <script>
        function tel(e){
          key=e.keyCode || e.which;
          teclado=String.fromCharCode(key);
          numero='0123456789';
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
      <style type="text/css">
        #loader {
          position: fixed;
          left: 0px;
          top: 0px;
          width: 100%;
          height: 100%;
          z-index: 9999;
          background: 50% 50% no-repeat rgb(249,249,249);
          opacity: .8;
        }
      </style>
</head>

<body>
  <div class="container">
      <ul id="nav" >
          <li class="active"><a href="">Inicio</a></li>
          <li ><a href="reporte">Reporte</a></li>
          <?php if ($permisoID == 2) {
            echo '<li ><a href="caducidad">Caducidad</a></li>';
          } ?>
            <li ><a href="cambioPassword">Cuenta</a></li>
            <ul id="nav-right">
              <li class="push-right"><a href="loginOut">Cerrar Sesion </a></li>

            </ul>
      </ul>
  </div>
  <div id="loader" style="display: none;"></div>
  <div class="login-page">
  <div class="form">

  <h1><img src="img/atc1.png">ctivaChip</h1>

    <form id="formulario" method='post'  autocomplete="off">

      <input required id="digitos" name="digitos" maxlength="10" onkeypress = 'return tel(event)' type="text" placeholder="Número" autofocus/>
      <input required id="numero"  onkeypress = 'return tel(event)' maxlength="10" name="numero" type="text" placeholder="Confirma el número"/>

      <!--<     -->
      
      <button id="btn_enviar" color = "black" onclick="puntero()">Aceptar</button>
    </form>
  </div>
</div>

<script>
$("#btn_enviar").click(function(){
  var url = "./php/procesoRecarga"; // El script a dónde se realizará la petición.
    $.ajax({
      type: "POST",
      url: url,
      data: $("#formulario").serialize(), // Adjuntar los campos del formulario enviado.
      //Ejecutar antes de ser enviado
      beforeSend: function(){
        var miCampoTexto = document.getElementById("digitos").value;
        var miCampoTexto2 = document.getElementById("numero").value;
        //las condiciones de los campos del formulario
        if (miCampoTexto.length == 0 ) {
          alert('El campo 1 esta vacio!');
          document.getElementById("digitos").focus();
          return false;
        }else if (miCampoTexto2.length == 0 ) {
          alert('El campo 2 esta vacio!');
          document.getElementById("numero").focus();
          return false;
        } else if (miCampoTexto.length < 10 ){
          alert('Deben de ser 10 digitos, compruebe su numero en el campo 1');
          document.getElementById("digitos").select();
          return false;
        }else if (miCampoTexto2.length < 10 ){
          alert('Deben de ser 10 digitos, compruebe su numero en el campo 2');
          document.getElementById("numero").select();
          return false;
        } else if (miCampoTexto != miCampoTexto2){
          alert('los digitos del numero telefonico no coinciden');
          document.getElementById("digitos").value = "";
          document.getElementById("numero").value = "";
          document.getElementById("digitos").focus();
          return false;
        }
      document.getElementById("loader").style.display="block";
      document.getElementById("loader").innerHTML="<img src='./img/loading1.gif'>";
      },
      success: function(data){
        $("#respuesta").html(data); // Mostrar la respuestas del script PHP.
          document.getElementById("loader").style.display="none";
          
      }

  });
  return false; // Evitar ejecutar el submit del formulario.
});

$(function(){
  //funcion cunado tecla enter se presiona
  $(window).keypress(function(e){
    if (e.keyCode == 13) {
      var url = "./php/procesoRecarga"; // El script a dónde se realizará la petición.
      $.ajax({
        type: "POST",
        url: url,
        data: $("#formulario").serialize(), // Adjuntar los campos del formulario enviado.
        //Ejecutar antes de ser enviado
        beforeSend: function(){
          var miCampoTexto = document.getElementById("digitos").value;
          var miCampoTexto2 = document.getElementById("numero").value;
          //las condiciones de los campos del formulario
            if (miCampoTexto.length == 0 ) {
              //alert('El campo 1 esta vacio!');
              document.getElementById("digitos").focus();
              return false;
            }else if (miCampoTexto2.length == 0 ) {
              //alert('El campo 2 esta vacio!');
              document.getElementById("numero").focus();
              return false;
            } else if (miCampoTexto.length < 10 ){
              alert('Deben de ser 10 digitos, compruebe su numero en el campo 1');
              document.getElementById("digitos").select();
              return false;
            }else if (miCampoTexto2.length < 10 ){
              alert('Deben de ser 10 digitos, compruebe su numero en el campo 2');
              document.getElementById("numero").select();
              return false;
            } else if (miCampoTexto != miCampoTexto2){
              alert('los digitos del numero telefonico no coinciden');
              document.getElementById("digitos").value = "";
              document.getElementById("numero").value = "";
              document.getElementById("digitos").focus();
              return false;
            }
          document.getElementById("loader").style.display="block";
          document.getElementById("loader").innerHTML="<img src='./img/loading1.gif'>";
        },
        success: function(data){
          $("#respuesta").html(data); // Mostrar la respuestas del script PHP.
          document.getElementById("loader").style.display="none";
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
