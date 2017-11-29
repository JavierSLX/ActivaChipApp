<?php
error_reporting(E_ERROR);
require "../claseSesion.php";

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
	<title>Reporte de Activaciones</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<link rel="stylesheet" type="text/css" href="css/bootstrap/css/bootstrap.min.css">
	<script type="text/javascript" src="js/jquery-1.3.1.min.js"></script>
	<script type="text/javascript" src="js/jquery.functions.js"></script>
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
	<link rel="stylesheet" href="css/styleReporte.css">
	<link rel="stylesheet" href="css/main.css">
      <link rel="stylesheet" href="css/principal">
      <link href="css/styleR.css" rel="stylesheet" type="text/css" />
</head>

<body>
	<div class="container">
      <ul id="nav" >
          <li ><a href="../../recarga.php">Home</a></li>
          <li class="active"><a href="">Reporte</a>
              <span id="s1"></span>
              <ul class="subs">
                      <ul>
                          <li><a href="">Reporte del dia</a></li>
                      </ul>
                  </li>

              </ul>
          </li>


            <ul id="nav-right">
              <li class="push-right"><a href="..\..\loginOut.php">Cerrar Sesion </a></li>

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
		<article id='art1' class='col-lg-5 col-md-5 col-sm-5 col-xs-12'>
		<form id="formulario">
			<p><label for="fecha"> DE:
				<input type="date" name="fechainicio"  step="1" value="<?php echo date("Y-m-d");?>">
			<input type="date" name="fechafin" step="1"value="<?php echo date("Y-m-d");?>">
			<input id="boton_enviar" method='post' type="submit">

			<?php
	$fechaIn = $_POST["fechainicio"];
	$fechafi= $_POST["fechafin"];
	$id=$usuarioID;

	//header("location: index.php");
	//redirect('index.php','refresh');
	$num= ReporteContador($id,$fechaIn,$fechafi);
	//print "<br>".$num;
	$result = Reporte($id,$fechaIn,$fechafi);

?>

		    </div>
		    </label>
		    </p>
		</form>
	</article>
  </div>
<div class = "tabla">
	<article id='art1' class='col-lg-10 col-md-10 col-sm-10 col-xs-12'>
<table class="responstable">
	<br>
  <tr>
    <th>Compañia</th>
    <th data-th="Driver details"><span>Número</span></th>
    <th>Fecha</th>
    <th>Monto</th>
  </tr>
				  <?php
				  while ($row = mysqli_fetch_array($result)){

							echo "<tr>";
							echo "<td height = 10>"."   ".$row[0]."   "."</td>";
							echo "<td height = 10>"."   ".$row[1]."   "."</td>";
							echo "<td height = 10>"."   ".$row[2]."   "."</td>";
							echo "<td height = 10>"."$".$row[3]."   "."</td>";

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
</html>
<?php
} else {
    header("location:..\..\index.php");
}
?>
