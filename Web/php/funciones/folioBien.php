<?php
  //conexion a la base de Datos
  $db = new mysqli('localhost', 'root', '', 'recargasatc');
  if ($db->connect_error) {
    die('No autorizado (' . $db->connect_errno . ')'. $db->connect_error);
  }

  //sacar el ultimo folio
  $query = "SELECT folio FROM activado ORDER BY id DESC LIMIT 1;";
  $result=mysqli_query($db , $query);



  date_default_timezone_set('america/mexico_city');
  $anio = $fechaHoy=date("Y");




  $row=mysqli_fetch_row($result);
  $count=$row[0];

  //echo $count;

  print "<br>";
    if(isset($count))
  {
    //Descomponer cadena
      $aCount = explode("/", $count);
      $folioNumero = $aCount[1];
      //echo $folioNumero;
      $folioAnio = $aCount[2];
      //echo $folioAnio;
    //si cambio el año del ultimo folio
    if ($folioAnio == $anio) {
        $fNumeroNuevo = "0000001";
        //insertar
    } else {
        $AnioNuevo = $fechaHoy=date("Y");
        $fNumeroNuevo = $folioNumero + 1;


    }

    //numero de caracteres en las variables
      $cacteresfNumeroNuevo = strlen($fNumeroNuevo);
      $caracteresFolioNumero = strlen($folioNumero);


      //generar el folio
    //echo"hola";
  }else{
    //si no hay folio se genera
    //echo "no hay nada";

  }
//asignar el numero de 0s a la cadena
//numero de caracteres en las variables
  $cacteresfNumeroNuevo = strlen($fNumeroNuevo);
  $caracteresFolioNumero = strlen($folioNumero);


//obtiene


 ?>
