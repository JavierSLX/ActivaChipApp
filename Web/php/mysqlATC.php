<?php
	/*define (MYSQLHOST, "localhost");
	define (MYSQLUSER, "root");
	define (MYSQLPASS, "");
	define (DB, "recargasatc");*/
	
	//Funcion que conecta a la base de datos
	function conectarBD()
	{
		//Se conecta la base de datos
		$conn = mysqli_connect("localhost", "root", "", "recargasatc") or die ("Error al conectarse a la BD");
		
		return $conn;
	}
	
	//Funcion que desconecta a la base de datos
	function desconectarBD($conexion)
	{
		mysqli_close($conexion);
	}
	
	//Funcion que inserta/elimina/modifica/obtiene elemento un elemento a una tabla
	function registroABD($conexion, $instruccion)
	{
		$elemento = mysqli_query($conexion, $instruccion) or die ("Error al ejecutar instruccion");
		return $elemento;
	}
?>