<?php
require "ConsultasMySQL.php";
class Sesion{
	private $login=false;
	private $usuario;
	private $pass;

	function __construct(){
		global $login;
		session_start();
		$this->verificaLogin();
		if($login){
			//codigo si esta logueado
		} else {
			//no esta logueado
		}
	}

	private function verificaLogin(){
		if(isset($_SESSION["usuario"]) & isset($_SESSION["pass"])){
			$this->usuario = $_SESSION["usuario"];
			$this->pass = $_SESSION["pass"];
			$this->login = true;
		} else {
			unset($this->usuario);
			unset($this->pass);
			$this->login = false;
		}
	}

	public function inicioLogin($usuario,$pass){
		if($usuario & $pass){
			$this->usuario = $_SESSION["usuario"] = $usuario;
			$this->pass = $_SESSION["pass"] = $pass;
			$this->login = true;
		}
	}

	public function finLogin($usuario,$pass){
		unset($_SESSION["usuario"]);
		unset($_SESSION["pass"]);
		unset($this->usuario);
		unset($this->pass);
		$this->login = false;
	}

	public function estadoLogin(){
		return $this->login;
	}

	public function getUsuario(){
		return $this->usuario;
	}

	public function datosUsuario(){
     	$user=$this->usuario;
     	$pass=$this->pass;
    	$resultado = loginAdmin($user, $pass);
		if ($resultado[0] > 0)
		{
			$resultado[2] = 1;
			return $resultado;
		}
		else
	  	{
			//Checa si la persona logeada es un cliente
			$resultado = loginCliente($user,$pass);
			$resultado[2] = 2;
			return $resultado;
       	}
	}

	public function nuevoPass($pass){
		unset($_SESSION["pass"]);
		$this->pass = $_SESSION["pass"] = $pass;
	}

}
?>
