<?php
error_reporting(E_ERROR);
require "php/claseSesion.php";
//require "..\Base de Datos/Consultas.php";

$sesion = new Sesion();
if ($sesion->estadoLogin()==true) {
$datosUsuario=$sesion->datosUsuario();
  $usuarioID=$datosUsuario[0];
  $empresaID=$datosUsuario[1];
  $permisoID=$datosUsuario[2];
$result =  reporteCaducidad($usuarioID);
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>ActivaChip</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<link rel="stylesheet" type="text/css" href="css/bootstrap/css/bootstrap.min.css">
	<script type="text/javascript" src="js/jquery-1.3.1.min.js"></script>
	<script type="text/javascript" src="js/jquery.functions.js"></script>
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
	<link rel="stylesheet" href="css/styleReporte.css">
	<link rel="stylesheet" href="css/main.css">
  <link rel="stylesheet" type="text/css" href="css/principal.css" />
  <link href="css/styleR.css" rel="stylesheet" type="text/css" />
</head>

<body>

	<div class="container">
      <ul id="nav" >
          <li ><a href="recarga">Inicio</a></li>
          <li ><a href="reporte">Reporte</a></li>
            <li class="active"><a href="caducidad">Caducidad</a></li>
            <li ><a href="cambioPassword">Cuenta</a></li>
            <ul id="nav-right">
              <li class="push-right"><a href="loginOut">Cerrar Sesion </a></li>


            </ul>
      </ul>

	<div class = "reporte">
		<br>
		<br>

		<p><br></p>
		<h1>Reporte de Caducidad</h1>
	</div>

	</article>
  </div>
  <div class = "tabla">
	<article id='art1' class='col-lg-12 col-md-12 col-sm-10 col-xs-10'>
<table class="responstable">
	<br>
  <tr>
    <th>Compañia</th>
    <th data-th="Driver details"><span>Número</span></th>
    <th>Fecha</th>
    <th>Dias Habiles</th>
  </tr>
				  <?php
				  while ($row = mysqli_fetch_array($result)){

							echo "<tr>";
							echo "<td height = 10>"."   ".$row[0]."   "."</td>";
							echo "<td height = 10>"."   ".$row[1]."   "."</td>";
							echo "<td height = 10>"."   ".$row[2]."   "."</td>";
							echo "<td height = 10>"."   ".$row[3]."   "."</td>";

							echo "</tr>";
				  }

				 ?>
			 </article>
</div>
  </tr>


</table>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/respond.js/1.4.2/respond.js'></script>
	</div>


</body>
<footer >
<br>
<br>
<br>
<br>
<br>
<br>
Contacto: webmaster.atc.mx@gmail.com <br>
Copyright© 2017-2018. Morpheus DSS
</footer>
</html>
<?php
} else {
    header("location:index");
}
?>
