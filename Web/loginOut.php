<?php
error_reporting(E_ERROR);
require "php\claseSesion.php";
require "login.php";

$sesion = new Sesion();
$usuario = $_POST["nick"];
$pass = $_POST["pass"];

$sesion->finLogin($usuario,$pass);
header("location: index.php")
?>