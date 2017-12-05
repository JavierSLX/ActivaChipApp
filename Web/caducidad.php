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
//$result =  reporteCaducidad($usuarioID);

$TAMANO_PAGINA = 1;
	$PAGINAS_MAXIMAS = 1;
	// 
	if (isset($_GET["p"])) {
		$pagina = $_GET["p"];
	} else {
		$pagina = 1;
	}
	$inicio = ($pagina-1)*$TAMANO_PAGINA;

$n= reporteCaducidadcount($usuarioID);
$total_paginas = ceil($n/$TAMANO_PAGINA);

$result = reporteCaducidad($usuarioID,$inicio,$TAMANO_PAGINA);
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
	

  	<script>
		function cambiaPagina(p){
			window.open("caducidad?p="+p,"_self");
		}
	</script>
</head>

<body>

	<div class="container">
      <ul id="nav" >
          <li ><a href="recarga">Inicio</a></li>
          <li ><a href="reporte">Reporte</a></li>
            <?php if ($permisoID == 2) {
            echo '<li class="active"><a href="">Caducidad</a></li>';
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
		<h1>Reporte de Caducidad</h1>
		<h4>
			* El tiempo maximo de activación es de 29 dias habiles a partir de su compra (excepto chips "TELCEL").
		</h4>
	</div>

	</article>
  </div>
  <div class = "tabla">
	<article id='art1' class='col-lg-12 col-md-12 col-sm-10 col-xs-10'>
<table class="responstable">
	<br>
	<?php $i=0; ?>
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
							$i++;
				  }

				 ?>
			 </article>
</div>
  </tr>


</table>
<div class="paginacion">
	<div class="primeras">
	<?php
		if ($total_paginas>$PAGINAS_MAXIMAS) {
			if ($pagina==$total_paginas) {
				$inicio = $pagina-$PAGINAS_MAXIMAS;
				$fin = $total_paginas;
			} else {
				$inicio = $pagina;
				$fin = ($pagina-1) + $PAGINAS_MAXIMAS;
				if ($fin>$total_paginas) $fin = $total_paginas;
			}

			if ($inicio!=1) {
				 
				echo '<button type="button" id="primera" onclick="cambiaPagina(1)">Primera</button>';
				echo '<button type="button" id="primera" onclick="cambiaPagina('.($pagina-1).')">Ant.</button>';
				
			}
		} else {
			$inicio = 1;
			$fin = $total_paginas;
		}
		for ($i=$inicio; $i <= $fin; $i++) { 
			echo '<button type="button" id="primera" class="';
			if ($i==$pagina) echo 'active';
			echo '" onclick="cambiaPagina('.$i.')">'.$i.' </button>';
		}
		if ($total_paginas>$PAGINAS_MAXIMAS && $pagina!=$total_paginas) {
			echo '<button type="button" id="primera" onclick="cambiaPagina('.($pagina+1).')">Sig.</button>';
			echo '<button type="button" id="primera" onclick="cambiaPagina('.($total_paginas).')">Ultima</button>';
		}  

	?>
</div>
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
