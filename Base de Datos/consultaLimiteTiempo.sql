use recargasatc;

SELECT *
FROM numero
WHERE DATE_ADD(fecha, INTERVAL 29 DAY) >= CURDATE();
