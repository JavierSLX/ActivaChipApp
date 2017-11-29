<?php 
function sacarIdProducto($Opcion, $Monto){
//$Opcion = 1;

switch ($Opcion) {
	case 'TEST':
		switch($Monto){
			case 0:
			$id=100;
			break;
	}
	break;
	case 'TELCEL':
		switch($Monto){
			case 10:
			$id=357;
			break;
			case 20:
			$id=358;
			break;
			case 30:
			$id=332;
			break;
			case 50:
			$id=318;
			break;
			case 80:
			$id=380;
			break;
			case 100:
			$id=285;
			break;
			case 150:
			$id=360;
			break;
			case 200:
			$id=286;
			break;
			case 300:
			$id=287;
			break;
			case 500:
			$id=288;
			break;
		}
		break;
	case 'MOVISTAR':
		switch($Monto){
			case 10:
			$id=160010;
			break;
			case 20:
			$id=160020;
			break;
			case 30:
			$id=160030;
			break;
			case 40:
			$id=160040;
			break;
			case 50:
			$id=160050;
			break;
			case 60:
			$id=160060;
			break;
			case 70:
			$id=160070;
			break;
			case 80:
			$id=160080;
			break;
			case 100:
			$id=160100;
			break;
			case 120:
			$id=160120;
			break;
			case 150:
			$id=160150;
			break;
			case 200:
			$id=160200;
			break;
			case 250:
			$id=160250;
			break;
			case 300:
			$id=160300;
			break;
			case 400:
			$id=160400;
			break;
			case 500:
			$id=160500;
			break;
		}
		break;
	case 'SERVICIOS TELCEL':
			switch($Monto){
			case 5:
			$id=21005;
			break;
			case 20:
			$id=21020;
			break;
			case 30:
			$id=21031;
			break;
			case 50:
			$id=21051;
			break;
			case 100:
			$id=21101;
			break;
			case 150:
			$id=21151;
			break;
			case 200:
			$id=21201;
			break;
			case 300:
			$id=21301;
			break;
			case 500:
			$id=21501;
			break;
			
		}
		break;
	case 'ALÓ':
		switch($Monto){
			case 10:
			$id=310;
			break;
			case 20:
			$id=320;
			break;
			case 30:
			$id=330;
			break;
			case 50:
			$id=350;
			break;
			case 100:
			$id=351;
			break;
			case 150:
			$id=352;
			break;
			case 200:
			$id=353;
			break;
			case 300:
			$id=354;
			break;
			case 500:
			$id=355;
			break;
		}
		break;	
	case 'AT&T':case 'UNEFON':
		switch($Monto){
			case 10:
			$id=40010;
			break;
			case 20:
			$id=40020;
			break;
			case 30:
			$id=40030;
			break;
			case 50:
			$id=40050;
			break;
			case 55:
			$id=40055;
			break;
			case 70:
			$id=470;
			break;
			case 100:
			$id=40100;
			break;
			case 150:
			$id=40150;
			break;
			case 200:
			$id=40200;
			break;
			case 300:
			$id=40300;
			break;
			case 500:
			$id=40500;
			break;
			case 600:
			$id=40600;
			break;
			case 800:
			$id=40800;
			break;
			case 900:
			$id=40900;
			break;
			case 1000:
			$id=41000;
			break;
			case 1200:
			$id=41200;
			break;
			}
		break;	
	case 'VIRGIN':
		switch($Monto){
			case 20:
			$id=9020;
			break;
			case 30:
			$id=9030;
			break;
			case 40:
			$id=9040;
			break;
			case 50:
			$id=9050;
			break;
			case 100:
			$id=9100;
			break;
			case 150:
			$id=9150;
			break;
			case 200:
			$id=9200;
			break;
			case 300:
			$id=9300;
			break;
			case 500:
			$id=9500;
			break;
			}
		break;
	default:
		print "";	

	}
	return $id;
}

 ?>