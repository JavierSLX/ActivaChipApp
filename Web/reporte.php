<?php
error_reporting(E_ERROR);
require "php/claseSesion.php";

$sesion = new Sesion();
if ($sesion->estadoLogin()==true) {
$datosUsuario=$sesion->datosUsuario();
  $usuarioID=$datosUsuario[0];
  $empresaID=$datosUsuario[1];
  $permisoID=$datosUsuario[2];
  
  

?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta charset="UTF-8" />
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
          <li class="active"><a href="">Reporte</a></li>
            <?php if ($permisoID == 2) {
            echo '<li ><a href="caducidad">Caducidad</a></li>';
          	} ?>
            <li ><a href="cambioPassword">Cuenta</a></li>
            <ul id="nav-right">
              <li class="push-right"><a href="loginOut">Cerrar Sesion </a></li>


            </ul>
      </ul>

	<div class = "reporte">
		<br>
		<br>

		<p><br></p>
		<h1>Reporte de Activaciones</h1>
	</div>
	<?php
			date_default_timezone_set('america/mexico_city');
	 ?>
<form  method="post" action="" id="formulario">
	<div class= "fecha">
		<article id='art1' class='col-lg-11 col-md-11 col-sm-11 col-xs-12'>
		<form id="formulario">
			<p><label for="fecha"> DE:
				<input type="date" name="fechainicio"  step="1" value="<?php echo date("Y-m-d");?>">
			<input type="date" name="fechafin" step="1"value="<?php echo date("Y-m-d");?>">
			<input id="boton_enviar" method='post' type="submit">

			<?php
	$fechaIn = $_POST["fechainicio"];
	$fechafi= $_POST["fechafin"];
	
if (empty($fechaIn && $fechafi)){
	$id=$usuarioID;
	$fechaIn=date("Y-m-d");
	$fechafi=date("Y-m-d");
	if($permisoID == 2){
	$result = Reporte($id,$fechaIn,$fechafi);
	}else{
	$result = reporteAdministrador($fechaIn,$fechafi);
	}
	
} else {
	$id=$usuarioID;
	if($permisoID == 2){
	$result = Reporte($id,$fechaIn,$fechafi);
	}else{
	$result = reporteAdministrador($fechaIn,$fechafi);
	}
}

?>

		    </div>
		    </label>
		    </p>
		</form>
	</article>
  </div>
<div class = "tabla">
	<article id='art1' class='col-lg-12 col-md-12 col-sm-12 col-xs-12'>
<table class="responstable">
	<br>
  <tr>
    <th>Compañia</th>
    <th data-th="Driver details"><span>Número</span></th>
    <th>Fecha</th>
    <th>Monto</th>
    <th>Cliente</th>
  </tr>
				  <?php
				  while ($row = mysqli_fetch_array($result)){

							echo "<tr>";
							echo "<td height = 10>"."   ".$row[0]."   "."</td>";
							echo "<td height = 10>"."   ".$row[1]."   "."</td>";
							echo "<td height = 10>"."   ".$row[2]."   "."</td>";
							echo "<td height = 10>"."$".$row[3]."   "."</td>";
							echo "<td height = 10>"."   ".utf8_encode($row[4])."   "."</td>";
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
Contactoo: webmaster.atc.mx@gmail.com <br>
Copyright© 2017-2018. Morpheus DSS
</footer>
</html>
<?php
} else {
    header("location:index");
}
?>
