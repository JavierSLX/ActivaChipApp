<?php
$db = new mysqli('localhost', 'root', '', 'recargasatc');
if ($db->connect_error) {
 die('No autorizado (' . $db->connect_errno . ') '
         . $db->connect_error);
}
function consultarNumero($numero){
  $query = "select id from numero where digitos = '$numero'";
   global $db;
  $result=mysqli_query($db , $query);
  if(!$result)
  {
    echo 'Cannot run query.';
    exit;
  }
  $row=mysqli_fetch_row($result);
  $count=$row[0];

  if( $count > 0)
  {

    echo'Si existe el numero';
  }else{
    echo'Este numero no pertenece a este distribuidor TELCEL';

  }

return $count;
}

function checarActivo($idNumero){
  $query = "select id from activado where numero_id = '$idNumero'";
   global $db;
  $result=mysqli_query($db , $query);
  if(!$result)
  {
    echo 'sin conexion a la base de datos.';
    exit;
  }
  $row=mysqli_fetch_row($result);
   $count=$row[0];

  if( $count > 0)
  {
    echo'El numero ya esta activado';
  }else{
    echo 'El numero no esta activado';

  }
  return $count;


}

function insertarActivado($idNumero,$Folio,$Monto){

  date_default_timezone_set('america/mexico_city');
  $fecha=date("Y-m-d H:i:s");

  if (empty($idNumero) || empty($idcliente) || empty($idFolio) ){
    $query = "INSERT INTO activado (cantidad, folio, fecha, estado, numero_id)
              VALUES('1','$Folio','$fecha','$Monto','$idNumero')";
                 global $db;
              $result = $db->query($query);
              if ($result)
                  echo' TU REGISTRO SE REALIZO CON EXITO.';

     }else {
      echo "no se ha podido guardar los datos";

     }
     return $result;

}

function login($nick,$pass){
  $query = "SELECT c.id,c.empresa_id from permiso_cliente p, cliente c where p.cliente_id = c.id and p.nickname = '$nick' and p.pass = '$pass'";
 global $db;
              $result =  $db->query($query);
              $row=mysqli_fetch_row($result);
               $count=$row[0];
              if ($count>0){
              }else{
                //echo "No existe el usuario en la Base de Datos";
              }
return $row;
}

function checarCompañia($telefono){

  $query = "SELECT n.monto, c.nombre from numero n, carrier c  where n.carrier_id = c.id and n.digitos = '$tel'";
 global $db;
  $result = $db->query($query);
  if ($result){
    $row=mysqli_fetch_row($result);
    print $count=$row[0];
    print $count=$row[1];

  }else{
    echo "No entro";
  }
  return $result;


}
function sacarClaveCliente($idCliente){

 $query = "SELECT pv.tipo, cc.numero from clave_cliente cc, cliente c, punto_venta pv where cc.cliente_id = c.id
 and cc.puntoventa_id = pv.id
  and c.id = '$idCliente'";
global $db;
 $result = $db->query($query);
 if ($result){
   $row=mysqli_fetch_row($result);
   $clave = $count=$row[0]."-".$count=$row[1];


 }else{
   //echo "No entro";
 }
 return $clave;


}

function insertarregistroLogin($idCliente){
 //sacar la  hora y fecha actual
 date_default_timezone_set('america/mexico_city');
 $fechaHoy=date("Y-m-d H:i:s");
 //
   $query = "INSERT INTO registro_login(fecha,cliente_id) VALUES ('$fechaHoy','$idCliente')";
   global $db;
   $result = $db->query($query);
   if ($result){
       echo  $db->affected_rows.' TU REGISTRO SE REALIZO CON EXITO.';
     }else{
       //print "No se realizo";
     }

}


function Reporte($id, $fechainicio, $fechafin){
  $query = "SELECT ca.nombre,n.digitos, c.nombre, a.fecha  from numero n, activado a, cliente c, carrier ca
  where a.numero_id = n.id  and n.cliente_id = c.id and n.carrier_id= ca.id
  and c.id = '$id'
  and DATE(a.fecha) >='$fechainicio'
  AND DATE(A.fecha)<= '$fechafin'";

 global $db;
  $result = $db->query($query);
  if ($result){
    $row=mysqli_fetch_row($result);
    print $count=$row[0];
    print $count=$row[1];
    print $count=$row[2];

  }else{
   echo "No entro";
  }
  return $result;



}

function  sacarFecha($telefono){
  $query ="SELECT fecha from numero where digitos = '$telefono'";
   global $db;
  $result = $db->query($query);
  if ($result){
    $row=mysqli_fetch_row($result);
     $count=$row[0];

  }else{
   echo "No entro";
  }
  return $count;


}

function reporteCaducidad($idCliente)
{
  $fechaHoy=date("Y-m-d");
   global $db;

    $query= "SELECT  nu.digitos, ca.nombre,nu.fecha,DATEDIFF(now(),nu.fecha)
    FROM numero nu, carrier ca, cliente cl
    where nu.id NOT IN(SELECT numero_id from activado)
    and nu.carrier_id = ca.id
    and nu.cliente_id = cl.id
    and cl.id = '$idCliente'
    and ca.nombre !='TELCEL'
    and DATE_ADD(nu.fecha, INTERVAL 29 DAY) >= CURDATE();"
     $result = $db->query($query);
     if ($result){
     }else{
      //echo "No entro";
     }
     return $result;
} ?>
