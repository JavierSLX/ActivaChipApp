<?php
//conexion a la base de Datos
    $db = new mysqli('localhost', 'root', '', 'recargasatc');
    if ($db->connect_error) {
    die('No autorizado (' . $db->connect_errno . ')'. $db->connect_error);
}

//sacar el ultimo folio
   function sacarFolio()
  {
    $query = "SELECT folio FROM activado ORDER BY id DESC LIMIT 1;";
    $result=mysqli_query($db , $query);

    $row=mysqli_fetch_row($result);
    $folioAnterior=$row[0];
  }
//generar el primer folio
function primerFolio($claveCliente)
{
  //llamar el metodo de clave cliente
  $claveCliente = "R1-001";
  //anio actual
  $anioActual = date("Y");
  //parte numerica
  $numero = "0000001";

  $primerFolio = $claveCliente."/".$numero."/".$anioActual;
  return $primerFolio;
}


    //generar el folio consecutivo
    function folioNuevo($folioAnterior, $claveCliente)
    {
      $anioActual = date("Y");
          //Descomponer cadena
        $aCount = explode("/", $folioAnterior);
        $folioNumero = $aCount[1];
        $folioAnio = $aCount[2];

        //si cambio el año del ultimo folio
        if ($folioAnio == $anioActual) {
          $AnioNuevo = $fechaHoy=date("Y");

          $fNumeroNuevo = $folioNumero + 1;
          $cadena = str_pad($fNumeroNuevo,6, "0", STR_PAD_LEFT);
          $primerFolio=$claveCliente."/".$cadena."/".$AnioNuevo;
        } else {
            $primerFolio = primerFolio($claveCliente);
        }
        return $primerFolio;
    }
 ?>
