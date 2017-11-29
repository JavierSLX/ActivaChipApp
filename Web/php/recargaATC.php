<?php
	require('./libATC.php');
	
	//Funcion que permite realizar una recarga
	function recargarSaldo($numero, $idProducto, $folioCliente)
	{
		//Saca el id de la empresa
		$empresa_id = sacarIDEmpresa($numero);
		
		//Checamos saldo y saca el arreglo de notificacion
		$resultado = availableBalance($empresa_id);
		$saldo = $resultado["avBalance_lmCredit"]["topUpAvBalance"];
		$arreglo = sacarNotificacion($numero);
		
		//Si el saldo es inferior a un limite y la bandera esta desactivada manda un correo y desactiva la bandera
		//$bandera = true;
		$bandera = sacarAlerta($arreglo[0]);
		if ($saldo < 5695 && !$bandera)
		{
			mandarCorreo($saldo, $arreglo[1], "Administrador");
			//$bandera = true;
			actualizarAlerta($arreglo[0], 1);
		}
		else if ($saldo > 5695 && $bandera)
			//$bandera = false;
			actualizarAlerta($arreglo[0], 0);
		
		//Hace la orden y realiza la recarga
		$codigoError = 0;
		$contador = 1;
		do
		{
			//Arma la orden
			$resultado = getOrder($empresa_id, $idProducto, $numero, $folioCliente);
			
			//Saca el id de la orden
			$idOrden = $resultado["TopUpID"]["topUpIDValue"];
			
			$orden = doOrder($empresa_id, $idOrden, $folioCliente);
			
			//Si dio un error en la recarga se registra
			if(isset($orden["TopUpResult"]["errorCode"]))
			{
				$codigoError = $orden["TopUpResult"]["errorCode"];
				
				/*//Checa si el error fue por saldo insuficiente
				if ($codigoError == 20)
				{
					mandarCorreo($saldo, $arreglo[1], "Administrador");
					return array("0", "Error (20). Contacte con el Administrador");
				}
				else if ($codigoError != 19 && $codigoError != 9)
				{
					$cadena = errores($codigoError);
					
					//En caso de ser error a mostrar al cliente, lo muestra
					if(count($cadena) == 0)
					{
						$asunto = "Error $codigoError registrado";
						$mensaje = "Se registro un error $codigoError en la recarga para el número $numero";
						mandarMailGmail("webmaster.atc.mx@gmail.com", "marquesada.466", "WebMaster ATC", "javier.serrano@marquesadacelular.com", "Javier Serrano", $asunto, $mensaje);
						
						//Le da un mensaje al usuario de su error
						return array("0", $cadena);
					}
				}*/		
			}
			else
			{
				$mensaje = $orden["TopUpResult"]["ticket"];
				$codigoError = 0;
			}
			
			$contador++;
		}while($contador < 1 && ($codigoError == 19 || $codigoError == 9));
		
		//Indica que la recarga se hizo de manera correcta
		if ($codigoError != 0)
		{
			//Inserta el error en la base de datos
			$idNumero = sacarIDNumero($numero);
			insertarError($idNumero, $folioCliente, $idOrden, $orden["TopUpResult"]["errorCode"], $orden["TopUpResult"]["errorMessage"]);
			
			return array("0", $orden["TopUpResult"]["errorMessage"]);
		}
		else
			return array($idOrden, $mensaje);
	}
	
	//Manda un correo
	function mandarCorreo($saldo, $email, $nombre)
	{
		$contador = 0;
		
		//Manda un correo
		$asunto = "Saldo al limite!";
		$mensaje = "Hola, buen día. Le informo que el saldo de recargas se encuentra en $";
		$mensaje .= number_format($saldo, 2).", le pido por favor depositar para que la página siga trabajando adecuadamente. Gracias.";
		$contador = 1;
		
		do
		{
			$estado = mandarMailGmail("webmaster.atc.mx@gmail.com", "marquesada.466", "WebMaster ATC", $email, $nombre, $asunto, $mensaje);
			
			if (!$estado)
				$contador++;
			
		}while($contador < 10 && !$estado);
	}
?>