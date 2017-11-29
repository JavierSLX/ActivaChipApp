<?php
$db = new mysqli('localhost', 'root', '', 'recargasatc');
$nick = $_GET["nick"];
$pass =$_GET["pass"];

$query = "SELECT  c.empresa_id , c.id from permiso_cliente p, cliente c where p.cliente_id = c.id and p.nickname = '$nick' and p.pass = '$pass'";

            $result = $db->query($query);
             $rownum = mysqli_fetch_row($result);
             print $rownum[0];
             print $rownum[1];
            if( $rownum > 0)
            {


            }else{
              echo ' <h1>  ¡Go away! </h1>';
              echo ' you are not authorized to view to view this resource.';
            }



 ?>
