<?php
   //$db = new mysqli('localhost', 'root', '', 'recargasatc')
   $GLOBALS[$db] = new mysqli('localhost', 'root', '', 'recargasatc');
  if ($db->connect_error) {
    die('No autorizado (' . $db->connect_errno . ') '
            . $db->connect_error);
  }


 ?>
