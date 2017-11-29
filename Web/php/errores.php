<?php 
function errores($Opcion){
//$Opcion = 1;

switch ($Opcion) {
	case 1:
		$error = "Usuario no puede ser nulo";
		break;
	case 2:
		$error =  "Password no puede der nulo";
		break;
	case 3:
		$error =  "Operador no puede ser nulo";
		break;
	case 4:
		$error =  "Datos de acceso invalido";
		break;	
	case 10:
		$error =  "Acceso bloqueado";
		break;	
	case 11:
		$error =  "Acceso restringido a este medio de compra";
		break;
	case 12:
		$error =  "Producto no autorizado";
		break;
	case 13:
		$error =  "Producto deshabilitado";
		break;
	case 21:
		$error =  "Se ha superado el limite de venta diaria";
		break;
	case 30:
		$error =  "Proveedor no implementado";
		break;
	case 31:
		$error =  "Se ha superado el limite de venta diaria";
		break;
	case 501:
		$error =  "Telefono no valido";
		break;
	case 502:
		$error =  "Destino no disponible";
		break;
	case 503:
		$error =  "Monto no valido";
		break;
	case 504:
		$error =  "Telefono no sustentable de abono";
		break;
	case 505:
		$error =  "Mantenimiento telcel en curso";
		break;
	case 506:
		$error =  "mantenimiento telcel en curso";
		break;
	case 509:
		$error =  "Autorizador no disponible";
		break;
	case 3020:
		$error =  "Fondos insuficientes";
		break;																			
	default:
		print "";	

	}
	return $error;
}

 ?>