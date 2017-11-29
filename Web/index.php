<?php
require "php\claseSesion.php";

$sesion = new Sesion();
if ($sesion->estadoLogin()==true) {
    header("location:recarga");
} else {
    header("location:login");
}
?>