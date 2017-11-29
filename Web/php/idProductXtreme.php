<?php
    require('./libATC.php');

    function idProducto($usuario, $password, $operador, $compania, $monto)
    {
        $contenido = getproducts($usuario, $password, $operador);
        $id = 0;
        
        for($i = 0; $i < count($contenido["listProducts"]["product"]); $i++)
        {
            if (($contenido["listProducts"]["product"][$i]["providerProduct"] == $compania) && 
                    ($contenido["listProducts"]["product"][$i]["amount"] == $monto))
            {
                $id = $contenido["listProducts"]["product"][$i]["idProduct"];
                break;
            }
        }
        
        return $id;
    }
?>