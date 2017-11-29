<?php 
include_once 'lib/nusoap.php';
$servicio = new soap_server();
$ns = "urn:miserviciowsdl";
$servicio->configureWSDL("criptografiaService",$ns);
$servicio->schemaTargetNamespace = $ns;
$servicio->register("encriptar", array('password' => 'xsd:string'), array('return' => 'xsd:string'), $ns);
$servicio->register("desencriptar", array('passwordEncriptado' => 'xsd:string'), array('return' => 'xsd:string'), $ns);

	class Encrypter{
		private static $Key="466?marquesada";
		public static function encrypt($input){
			$output=base64_encode(mcrypt_encrypt(MCRYPT_RIJNDAEL_256, md5(Encrypter::$Key),$input, MCRYPT_MODE_CBC, md5(md5(Encrypter::$Key))));
			return $output;
		}
		public static function decrypt($input){
			$output=rtrim(mcrypt_decrypt(MCRYPT_RIJNDAEL_256, md5(Encrypter::$Key), base64_decode($input), MCRYPT_MODE_CBC, md5(md5(Encrypter::$Key))), "\0");
			return $output;
		}
	}
	function encriptar($password){
		$texto_encriptado=Encrypter::encrypt($password);
		return new soapval('return', 'xsd:string', $texto_encriptado);
	}
	function desencriptar($passwordEncriptado){
		$texto_desencriptado=Encrypter::decrypt($passwordEncriptado);
		return new soapval('return', 'xsd:string', $texto_desencriptado);
	}
	
	$HTTP_RAW_POST_DATA = isset($HTTP_RAW_POST_DATA) ? $HTTP_RAW_POST_DATA : '';
	$servicio->service($HTTP_RAW_POST_DATA);
?>