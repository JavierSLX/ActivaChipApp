<?php
	require_once("./library/PHPMailer/PHPMailerAutoload.php");
	
	//Función que manda un correo a una cuenta determinada
	function mandarMailGmail($remitente, $password, $nombreRemitente, $destinatario, $nombreDestinatario, $asunto, $mensaje)
	{
		//Crea una nueva instancia de PHPMailer
		$mail = new PHPMailer;

		//Le dice a PHPMailer a usar SMTP
		$mail->isSMTP();

		//Coloca el nombre del host del servidor del mail
		$mail->Host = 'smtp.gmail.com';
		// use
		// $mail->Host = gethostbyname('smtp.gmail.com');
		// if your network does not support SMTP over IPv6

		//Se coloca el puerto del SMTP en este caso es 587
		$mail->Port = 587;

		//Coloca el método de encriptación
		$mail->SMTPSecure = 'tls';

		//Se coloca el método de autenticación
		$mail->SMTPAuth = true;
		
		//Usuario que se autenticará para el envío por gmail
		$mail->Username = $remitente;
		
		//Password a usar para autenticación SMTP
		$mail->Password = $password;
		
		//Coloca quien manda el mensaje
		$mail->setFrom($remitente, $nombreRemitente);
		
		//Coloca a quien se le contesta el mensaje (en su caso)
		$mail->addReplyTo($remitente, $nombreRemitente);
		
		//Coloca a quien se le enviará el mensaje
		$mail->addAddress($destinatario, $nombreDestinatario);
		
		//Coloca el contenido del mensaje
		$mail->Subject = $asunto;
		$mail->Body = $mensaje;
		
		//send the message, check for errors
		if (!$mail->send()) 
			$estado = false;
			//echo "Mailer Error: " . $mail->ErrorInfo;
		else
			$estado = true;
			//echo "Message sent!";
			
		return $estado;
	}
?>