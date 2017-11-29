DROP DATABASE IF EXISTS recargasatc;
CREATE DATABASE recargasatc;
USE recargasatc;

CREATE TABLE empresa
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(200) NOT NULL,
    direccion VARCHAR(200) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    activo bool not null
);

INSERT INTO empresa(nombre, direccion, telefono, activo) VALUES ('ATC', 'Arteaga 32', '4661271818', true);

CREATE TABLE acceso_empresa
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	wsdl VARCHAR(200) NOT NULL,
    usuario VARCHAR(200) NOT NULL,
    pass VARCHAR(200) NOT NULL,
    clave_operador VARCHAR(100) NOT NULL,
    empresa_id INT UNSIGNED NOT NULL REFERENCES empresa.id ON UPDATE CASCADE
);
INSERT INTO acceso_empresa(wsdl, usuario, pass, clave_operador, empresa_id) VALUES ('https://tae.xtremecard.com.mx/hub/Listener?wsdl', 'MARQUESADA', '123456', 'Ma12', 1);

CREATE TABLE administrador
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(200) NOT NULL,
    empresa_id INT UNSIGNED NOT NULL REFERENCES empresa.id ON UPDATE CASCADE
);

INSERT INTO administrador(nombre, empresa_id) VALUES ('Principal', 1);
INSERT INTO administrador(nombre, empresa_id) VALUES ('Sistemas', 1);
INSERT INTO administrador(nombre, empresa_id) VALUES ('Oficina', 1);

CREATE TABLE permiso
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	tipo VARCHAR(50)
);

INSERT INTO permiso(tipo)VALUES('Normal');
INSERT INTO permiso(tipo)VALUES('Administrador');
INSERT INTO permiso(tipo)VALUES('Super Administrador');
INSERT INTO permiso(tipo)VALUES('Ventas');

CREATE TABLE permiso_administrador
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nickname VARCHAR(200) NOT NULL,
    pass VARCHAR(200) NOT NULL,
    activo BOOL NOT NULL,
    administrador_id INT UNSIGNED NOT NULL REFERENCES administrador.id ON UPDATE CASCADE,
    permiso_id INT UNSIGNED NOT NULL REFERENCES permiso.id ON UPDATE CASCADE
);

/*Pendiente*/
INSERT INTO permiso_administrador(nickname,pass,activo,administrador_id,permiso_id) VALUES('Principal','M989at+tjQxHNT2JVchRo6q+B4qklbS1M3ThVcUv2oA=',true,1,3);
INSERT INTO permiso_Administrador(nickname,pass,activo,administrador_id,permiso_id) VALUES('Sistemas','fru0ljjXxDC3pogal8pC3u0eOMTfXUjnhqGHuDThErw=',true,2,3);
INSERT INTO permiso_Administrador(nickname,pass,activo,administrador_id,permiso_id) VALUES('Oficina','mmtu+/RdPvxUC2WHzaQnOTwX8i1OX6Df8H+Nyp+RMTI=',true,3,3);
CREATE TABLE cliente
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(200) NOT NULL,
    direccion VARCHAR(200) NOT NULL,
    telefono VARCHAR(200) NOT NULL,
    email VARCHAR(50),
    activo BOOL NOT NULL,
    empresa_id INT UNSIGNED NOT NULL REFERENCES empresa.id ON UPDATE CASCADE
);

INSERT INTO cliente VALUES (1,'General','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES (2,'Oficina','Juárez´ 212','S/R','S/R',1,1);
INSERT INTO cliente VALUES (3,'Local Zaragoza','Zaragoza 328','S/R','S/R',1,1);
INSERT INTO cliente VALUES (4,'Local Juárez 212','Juárez 212','S/R','S/R',1,1);
INSERT INTO cliente VALUES (5,'Local Juárez 111','Juárez 111','S/R','S/R',1,1);
INSERT INTO cliente VALUES (6,'Arturo Pacheco','Hidalgo','S/R','S/R',1,1);
INSERT INTO cliente VALUES (7,'Alvino X','Urireo','S/R','S/R',1,1);
INSERT INTO cliente VALUES (8,'Ángel Precoma','San José Iturbide','S/R','S/R',1,1);
INSERT INTO cliente VALUES (9,'Isabel X','Ocampo','S/R','S/R',1,1);
INSERT INTO cliente VALUES (10,'Isaac Medrano','San Nicolás de los A','S/R','S/R',1,1);
INSERT INTO cliente VALUES (11,'José Espinoza','Ocampo','S/R','S/R',1,1);
INSERT INTO cliente VALUES (12,'Fidel Paredes','Niños Héroes #5','438 100 4824','S/R',1,1);
INSERT INTO cliente VALUES (13,'María Vázquez','M. De la Piedra 31','438 101 4951','S/R',1,1);
INSERT INTO cliente VALUES (14,'Natalia Reyes','Morelos 98','445 111 2527','S/R',1,1);
INSERT INTO cliente VALUES (15,'Leidy Anahí','Leandro Valle # 112','445 122 7606','S/R',1,1);
INSERT INTO cliente VALUES (16,'Filiberto Parédez','J. Jesús Montaño 12','438 111 0088','S/R',1,1);
INSERT INTO cliente VALUES (17,'Alfredo Villalón','Urrutia 70','445 108 4027','S/R',1,1);
INSERT INTO cliente VALUES (18,'Antonio Murillo','San Miguel 26','445 104 1444','S/R',1,1);
INSERT INTO cliente VALUES (19,'José Luis Morales','5 Mayo NO. 8','445 102 8278','S/R',1,1);
INSERT INTO cliente VALUES (20,'Carlos Plancarte','5 Mayo # 1','445 106 4550','S/R',1,1); 
INSERT INTO cliente VALUES (21,'Eduardo','Hidalgo #72','4454562133','S/R',1,1);
INSERT INTO cliente VALUES (22,'Yolanda Orozco','12 de Oct y Abasolo','445 111 6593','S/R',1,1);
INSERT INTO cliente VALUES (23,'Alfonso Chávez','5 de Mayo','452 127 9903','S/R',1,1);
INSERT INTO cliente VALUES (24,'Maricela Aguilar','Fernando Núñez # 5','445 140 6823','S/R',1,1);
INSERT INTO cliente VALUES (25,'Delia Calderón','Hidalgo # 59','445 102 7918','S/R',1,1);
INSERT INTO cliente VALUES (26,'Omar Arreola Tellez','Pípila #254','4454558781','S/R',1,1);
INSERT INTO cliente VALUES (27,'Román Barbosa','Plaza Llenciso 25','445 456 3135','S/R',1,1);
INSERT INTO cliente VALUES (28,'Imelda González','Av. Juárez Oriente 330','427 112 8270','S/R',1,1);
INSERT INTO cliente VALUES (29,'Alejandro Ramírez','Av.Puebla 408','445 131 4137','S/R',1,1);
INSERT INTO cliente VALUES (30,'Israel López','Francisco Villa 45','4271737022','S/R',1,1);
INSERT INTO cliente VALUES (31,'Ricardo Resendiz Gómez','F. Villa 31','4271449999','S/R',1,1);
INSERT INTO cliente VALUES (32,'Carlos Gomes','Av. Juárez 320','427 124 3617','S/R',1,1);
INSERT INTO cliente VALUES (33,'José Veseral','Av. Hidalgo 234','427 108 1571','S/R',1,1);
INSERT INTO cliente VALUES (34,'Elizabeth Acebedo','Av. Juárez 164','427 149 4780','S/R',1,1);
INSERT INTO cliente VALUES (35,'Flor Silvestre','Claveles 165','427 124 3251','S/R',1,1);
INSERT INTO cliente VALUES (36,'Eduardo Feregrino','Artículo 4, Local 2','427 110 3690','S/R',1,1);
INSERT INTO cliente VALUES (37,'Alejandro Velazquez','F. Villa 21','427 306 7524','S/R',1,1);
INSERT INTO cliente VALUES (38,'Leticia Linarez','Pensamiento 37','427 306 0141','S/R',1,1);
INSERT INTO cliente VALUES (39,'Melanny','Rivapalacio #12','4271229119','S/R',1,1);
INSERT INTO cliente VALUES (40,'Moises Flores','20 Nov','427 120 0791','S/R',1,1);
INSERT INTO cliente VALUES (41,'José Luis Colín','20 Nov 90 B','427 108 7027','S/R',1,1);
INSERT INTO cliente VALUES(42,'Emma Mendoza Vargas','Av. Universidad #1, Cerro Gordo','427 110 3690','S/R',1,1);
INSERT INTO cliente VALUES(43,'Ángel Torres','Camino Rancho de en Medio, Andador Santa Lucía','427 110 3690','S/R',1,1);
INSERT INTO cliente VALUES(44,'Jorge Ruíz','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(45,'Jorge Rodríguez Miranda','Rivapalacio 53','442 133 1017','S/R',1,1);
INSERT INTO cliente VALUES(46,'Juan Pedro Ruíz Moreno','Adolfo López Mateos 26','442 155 9198','S/R',1,1);
INSERT INTO cliente VALUES(47,'Hugo Nieto','Fco. Villa 64','427 134 5585','S/R',1,1);
INSERT INTO cliente VALUES(48,'Jesús Zavala','Santa Mónica 2161, Col. Reforma','462 170 1310','S/R',1,1);
INSERT INTO cliente VALUES(49,'Carmen Hernández','16 de Diciembre No. 90, Col. Juárez','462 173 5854','S/R',1,1);
INSERT INTO cliente VALUES(50,'Daniel Calderón','5 de Mayo 76','456 101 2773','S/R',1,1);
INSERT INTO cliente VALUES(51,'Alberto Hidalgo','Carr. a Amelco KM 6','427 159 1210','S/R',1,1);
INSERT INTO cliente VALUES(52,'Don Luis','Obregón Sur 199','464 133 9660','S/R',1,1);
INSERT INTO cliente VALUES(53,'Abigail García','Andrés Delgado 214','464 601 5740','S/R',1,1);
INSERT INTO cliente VALUES(54,'Andrea Miranda','Calle 5 DE MAYO #408','464 655 3352','S/R',1,1);
INSERT INTO cliente VALUES(55,'Jary','5 de Mayo 303-B','464 102 5057','S/R',1,1);
INSERT INTO cliente VALUES(56,'Esther Saldivar','Av. del Trabajo','464 133 2946','S/R',1,1);
INSERT INTO cliente VALUES(57,'Razo Marco','Villa #320','464 157 0975','S/R',1,1);
INSERT INTO cliente VALUES(58,'Moises Ornelas Loera','Villas Salamanca 506','464 645 0354','S/R',1,1);
INSERT INTO cliente VALUES(59,'Gaby López','Mercado 5 Mayo','464 167 1344','S/R',1,1);
INSERT INTO cliente VALUES(60,'Brenda González Ortíz','Calle Comunicación Norte 522','464 105 3554','S/R',1,1);
INSERT INTO cliente VALUES(61,'Liliana Pacheco','Madero 36','449 1067894','S/R',1,1);
INSERT INTO cliente VALUES(62,'Eder Martínez','Daxial # 1624','4621920351','S/R',1,1);
INSERT INTO cliente VALUES(63,'Ricardo Valencia G.','15 de Mayo No. 2','464 124 0151','S/R',1,1);
INSERT INTO cliente VALUES(64,'Claudia Gutierrez','Diego Morán 301','464 136 1123','S/R',1,1);
INSERT INTO cliente VALUES(65,'Sandra Karina Castañeda Arredondo','Boulevard Villas Salamanca 176','464 136 6664','S/R',1,1);
INSERT INTO cliente VALUES(66,'Juan Cirilo Arellano Media','Comunicación Norte 509, Infonavit','464 655 8822','S/R',1,1);
INSERT INTO cliente VALUES(67,'Luis Angel','Zaragoza 606','411 108 8008','S/R',1,1);
INSERT INTO cliente VALUES(68,'Rafael Vázquez','Rayón 581','468 103 5129','S/R',1,1);
INSERT INTO cliente VALUES(69,'Janet Ramírez','Rayón 572','468 117 5817','S/R',1,1);
INSERT INTO cliente VALUES(70,'Sandra Guerrero','Rayón # 313','468 680 2120','S/R',1,1);
INSERT INTO cliente VALUES(71,'Saúl Guerra','Josefa Ortíz 36','468 687 3251','S/R',1,1);
INSERT INTO cliente VALUES(72,'Ray Leonor','Rayón 206','468 103 8024','S/R',1,1);
INSERT INTO cliente VALUES(73,'Uriel López','Comercio 147, Centro','445 462 2711','S/R',1,1);
INSERT INTO cliente VALUES(74,'Ana Patricia Solís','Hidalgo 133','468 687 6358','S/R',1,1);
INSERT INTO cliente VALUES(75,'Elvia Villanueva','Galeana 349','468 106 6117','S/R',1,1);
INSERT INTO cliente VALUES(76,'Silvia López','Bravo 501','468 114 6807','S/R',1,1);
INSERT INTO cliente VALUES(77,'María del Carmen','Zaragoza 110','468 686 9842','S/R',1,1);
INSERT INTO cliente VALUES(78,'Miguel Cano','Yucatán #36','418 101 1587','S/R',1,1);
INSERT INTO cliente VALUES(79,'José Díaz','Boulevard Adolfo López Mateos 21 Int 22','461 133 6148','S/R',1,1);
INSERT INTO cliente VALUES(80,'Ivan Jaramillo','Rayón 427','468 100 4577','S/R',1,1);
INSERT INTO cliente VALUES(81,'Juanita Salinas','Rayón 316','468 117 2759','S/R',1,1);
INSERT INTO cliente VALUES(82,'Ulises Durán','Rayón','468 113 7493','S/R',1,1);
INSERT INTO cliente VALUES(83,'Soledad','Guerrero','S/R','S/R',1,1);
INSERT INTO cliente VALUES(84,'Arturo Aguilera Leiva','Bravo 619','468 108 85 37','S/R',1,1);
INSERT INTO cliente VALUES(85,'Mauricio Cuellar Cervantez','Juárez 12','412 117 9660','S/R',1,1);
INSERT INTO cliente VALUES(86,'Irvin Reyez','Plaza Nueva','712 103 6030','S/R',1,1);
INSERT INTO cliente VALUES(87,'Saúl García Arredondo','Juárez Esq. Morelos','461 188 3349','S/R',1,1);
INSERT INTO cliente VALUES(88,'Agustín Herrera Martínez','Av. Las Aguilas 101, Col Aguilas','427 144 7100','S/R',1,1);
INSERT INTO cliente VALUES(89,'José Alfredo','Av. Universidad 201','461 127 9792','S/R',1,1);
INSERT INTO cliente VALUES(90,'Ana Laura Muñíz','Reforma Agraria 1500','461 254 3081','S/R',1,1);
INSERT INTO cliente VALUES(91,'Miguel Rodríguez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(92,'Juan Jesús Martínez','Yucatan #13','4181165708','S/R',1,1);
INSERT INTO cliente VALUES(93,'Adrian Casillas','Morelos #16','418 102 0224','S/R',1,1);
INSERT INTO cliente VALUES(94,'Juan Manuel Martínez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(95,'Carlos Moctezuma','Av. Sur 12','S/R','S/R',1,1);
INSERT INTO cliente VALUES(96,'José Antonio Rangel','Corregidora 12','418 101 0596','S/R',1,1);
INSERT INTO cliente VALUES(97,'Nestor G','Guanajuato 32','4181849758','S/R',1,1);
INSERT INTO cliente VALUES(98,'Ana Patricia Solís','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(99,'Edgar Ochoa','Camino a Jofre 6','S/R','S/R',1,1);
INSERT INTO cliente VALUES(100,'Rodrigo Zetter R.','Int. Mercado Tomasa Estebes Local 161','464 653 9773','S/R',1,1);
INSERT INTO cliente VALUES(101,'Marina Sánchez','Tianguis 5 de Mayo loc. 126','4271042966','S/R',1,1);
INSERT INTO cliente VALUES(102,'Jorge Vargas Luna','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(103,'Ana Lilia Rodríguez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(104,'Daniel Ocampo','Av. Saavedra # 100','4641392803','S/R',1,1);
INSERT INTO cliente VALUES(105,'Juan Carlos Guerrero','Hidalgo 201B','412 117 7651','S/R',1,1);
INSERT INTO cliente VALUES(106,'Jorge Morril','Hidalgo 302','412 171 7030','S/R',1,1);
INSERT INTO cliente VALUES(107,'Berenice Cortéz','Av. Pedregal 512','443 268 1768','S/R',1,1);
INSERT INTO cliente VALUES(108,'Enrique Castillo','16 de Sep 104B','461 239 6110','S/R',1,1);
INSERT INTO cliente VALUES(109,'Antonio Godinez','Corregidora 217A','412 117 1336','S/R',1,1);
INSERT INTO cliente VALUES(110,'Bernardo Buenavista','Isabel la Católica 405','412 104 8187','S/R',1,1);
INSERT INTO cliente VALUES(111,'José Guadalupe Montenegro','Camino Real No. 4','464 639 6822','S/R',1,1);
INSERT INTO cliente VALUES(112,'Andrea Dábalos','Benito Juárez 2A','443 131 8444','S/R',1,1);
INSERT INTO cliente VALUES(113,'Lourdes Zavala','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(114,'María del Carmen Hernández','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(115,'Vicente Jazzo Diaz','Benito Juarez','4612566945','S/R',1,1);
INSERT INTO cliente VALUES(116,'Miguel Cano','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(117,'Gerrardo López','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(118,'Armando Montés','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(119,'Sanjuan Sobras','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(120,'Brenda Gallardo González','5 de Mayo sin N','464 642 3195','S/R',1,1);
INSERT INTO cliente VALUES(121,'Marina Sánchez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(122,'Chava','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(123,'Gustabo','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(124,'María Teresa Magaña','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(125,'Gustabo Lazaro','Aldama # 103','4646441043','S/R',1,1);
INSERT INTO cliente VALUES(126,'Obdulia','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(127,'Jasmín Maldonado','Villas del Secreto 172, Villas de los Arcos','461 174 9150','S/R',1,1);
INSERT INTO cliente VALUES(128,'Gloria Rosales','Plaza Restar Módulo Telcel','4622304303','S/R',1,1);
INSERT INTO cliente VALUES(129,'Mayra Juárez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(130,'María Teresa García Ramírez','18 Marzo # 117 Cardenas','4641201219','S/R',1,1);
INSERT INTO cliente VALUES(131,'Oscar Quintana Núñez','Blvd. Hidalgo 36','551 339 7189','S/R',1,1);
INSERT INTO cliente VALUES(132,'Ricardo Ferreira Lara','Fray Cervando y Teresa Demier #401A',' 4612631439','S/R',1,1);
INSERT INTO cliente VALUES(133,'María Martín Merino','S/R','S/R','S/R',1,66),(134,'Adonay','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(135,'Mayra del Sol Mendoza','5 de Mayo No. 54B','445 144 9628','S/R',1,1);
INSERT INTO cliente VALUES(136,'Evelin','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(137,'Teresa Álvarez','Insurgente 6, Panales Jamaica','4661096012','S/R',1,1);
INSERT INTO cliente VALUES(138,'Juan Carrillo','S/R','S/R','S/R',1,66),(139,'Felix Daniel','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(140,'Bernando Núñez Suárez ','Ejido de Santa Anita 105','461 184 7091','S/R',1,1);
INSERT INTO cliente VALUES(141,'José Luis','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(142,'Javier Vargas','Av. Presa Álvaro Obregón #11 Colonia Bonfil','461 242 4585','S/R',1,1);
INSERT INTO cliente VALUES(143,'Josue','Luis de Velazco #127','4431100137','S/R',1,1);
INSERT INTO cliente VALUES(144,'Berenice Butania Santoyo','Guadalupe Victoria #18 A','4561241676','S/R',1,1);
INSERT INTO cliente VALUES(145,'Ricardo Gómez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(146,'Patricia','Carr. Salida a Celaya 3C','4612084644','S/R',1,1);
INSERT INTO cliente VALUES(147,'Rogelio Molina','Av. Torreon Nuevo 2602','4434122580','S/R',1,1);
INSERT INTO cliente VALUES(148,'Sandra Sosa','Gral Negrete 147','436 100 3445','S/R',1,1);
INSERT INTO cliente VALUES(149,'Sandrita Sosa','General Negrete #147','4361003445','S/R',1,1);
INSERT INTO cliente VALUES(150,'Erick Sosa','General Negrete #147','436 112 0992','S/R',1,1);
INSERT INTO cliente VALUES(151,'Mireya León','Morelos 125','4431747068','S/R',1,1);
INSERT INTO cliente VALUES(152,'Ivan Marquez','Carr Nal. 10','351 100 0345','S/R',1,1);
INSERT INTO cliente VALUES(153,'Santiago Prado','Santo Tomás #5','351 180 6986','S/R',1,1);
INSERT INTO cliente VALUES(154,'Ana Karen','Carlos Salazar 306','4521590585','S/R',1,1);
INSERT INTO cliente VALUES(155,'Alejandra Vargas','Ananehuilco 144','4611411182','S/R',1,1);
INSERT INTO cliente VALUES(156,'Salvador Robles','Aldama #114','8531096415','S/R',1,1);
INSERT INTO cliente VALUES(157,'Laura Vega Villanueva','Madero 212','3511085250','S/R',1,1);
INSERT INTO cliente VALUES(158,'Patricia Sánchez','Madero # 214','3511333463','S/R',1,1);
INSERT INTO cliente VALUES(159,'Daniel Váldez','Madero 249','3511452293','S/R',1,1);
INSERT INTO cliente VALUES(160,'José Zaragoza','Madero 239','3511135251','S/R',1,1);
INSERT INTO cliente VALUES(161,'José Manuel Venegas','Insurgentes 212','353 120 7089','S/R',1,1);
INSERT INTO cliente VALUES(162,'Enrique Mosqueda Ramírez','Madero 92, Local 9 ','3535351176','S/R',1,1);
INSERT INTO cliente VALUES(163,'Flabio Castillo','Matamoros 237','332 346 1380','S/R',1,1);
INSERT INTO cliente VALUES(164,'German Geo','S/R','3531154481','S/R',1,1);
INSERT INTO cliente VALUES(165,'Diego Castañeda','Hidalgo 10','332 107 82209','S/R',1,1);
INSERT INTO cliente VALUES(166,'Hernan Geo','ZARAGOZA','3531154481','S/R',1,1);
INSERT INTO cliente VALUES(167,'Gonzalo Regollar Carrillo','Av. Lazaro Cardenas Sur 600','4432555260','S/R',1,1);
INSERT INTO cliente VALUES(168,'María Carmen Torres','Madero #5','3511454933','S/R',1,1);
INSERT INTO cliente VALUES(169,'Gaby Briseño','Hidalgo #258','3931057438','S/R',1,1);
INSERT INTO cliente VALUES(170,'Salvador','Constitución','3531017115','S/R',1,1);
INSERT INTO cliente VALUES(171,'Remedios García','Carr. Nacional 77','353 123 1838','S/R',1,1);
INSERT INTO cliente VALUES(172,'Blanca Cecilia','Portal Castellanos','3535397609','S/R',1,1);
INSERT INTO cliente VALUES(173,'Lucila García','Francisco y Madero #18','3535359663','S/R',1,1);
INSERT INTO cliente VALUES(174,'Yolanda Cardoso','5 de Mayo #9C','466 1260141','S/R',1,1);
INSERT INTO cliente VALUES(175,'Gloria Rosales','Manuel Doblado #30','411 1068777','S/R',1,1);
INSERT INTO cliente VALUES(176,'Juan Manuel Sánchez','Chilpancingo Zacatecas #401','411 1068777','S/R',1,1);
INSERT INTO cliente VALUES(177,'Diana Mancera','Hidalgo','411 1242981','S/R',1,1);
INSERT INTO cliente VALUES(178,'Juan Raya','Juárez #304','411 1256075','S/R',1,1);
INSERT INTO cliente VALUES(179,'Edwin Silva','Juárez #500','456 1032318','S/R',1,1);
INSERT INTO cliente VALUES(180,'Luis Martínez','Hidalgo #115','429 1004872','S/R',1,1);
INSERT INTO cliente VALUES(181,'Oralia Rodríguez','Hidalgo #17','429 103 8521','S/R',1,1);
INSERT INTO cliente VALUES(182,'María Guadalupe Vargas','Jesús María Montaño #37','429 1225620','S/R',1,1);
INSERT INTO cliente VALUES(183,'José Luis Sánchez','Guanajuato #825','462 1915180','S/R',1,1);
INSERT INTO cliente VALUES(184,'Virginia','Blvd. Esperanza #16','462 1221611','S/R',1,1);
INSERT INTO cliente VALUES(185,'Leonardo Silva','Guerrero #113C','456 1018172','S/R',1,1);
INSERT INTO cliente VALUES(186,'Miguel Negrete','Lerdo #139','429 1113156','S/R',1,1);
INSERT INTO cliente VALUES(187,'Dulce María López','Echegaray #205','429 1033661','S/R',1,1);
INSERT INTO cliente VALUES(188,'Cecilia Negrete','Aldama #17','429 1113160','S/R',1,1);
INSERT INTO cliente VALUES(189,'Jesús Castro','Prolongación','S/R','S/R',1,1);
INSERT INTO cliente VALUES(190,'Lenyn Espino','Hidalgo #19','438 1137856','S/R',1,1);
INSERT INTO cliente VALUES(191,'María Dolores Quirino','Hidalgo #45','438 6980263','S/R',1,1);
INSERT INTO cliente VALUES(192,'Luis Mercedes','Melchor Ocampo #75A','429 1112886','S/R',1,1);
INSERT INTO cliente VALUES(193,'Guillermo Cázarez','Hidalgo #121','352 1086969','S/R',1,1);
INSERT INTO cliente VALUES(194,'Hernestina Domingues','Av Padre Hidalgo #254','352 1221012','S/R',1,1);
INSERT INTO cliente VALUES(195,'Claudia Arevalo','Av Padre Hidalgo #252','352 1112524','S/R',1,1);
INSERT INTO cliente VALUES(196,'Luis Meneses','Blvd. Lázaro Cárdenas #194','352 1200562','S/R',1,1);
INSERT INTO cliente VALUES(197,'Fabián Vargas','Tehuacán #802','462 2224016','S/R',1,1);
INSERT INTO cliente VALUES(198,'Pedro Arreola','Francisco I. Madero #332','462 1089250','S/R',1,1);
INSERT INTO cliente VALUES(199,'Armando Chávez','5 de Mayo #546','474 7415712','S/R',1,1);
INSERT INTO cliente VALUES(200,'Margarita Gutierrez','5 de Mayo #567','474 7379683','S/R',1,1);
INSERT INTO cliente VALUES(201,'Lupita Hernández','5 de Mayo #154','474 41280800','S/R',1,1);
INSERT INTO cliente VALUES(202,'Cristobal Rangel','Games Sarias #15','465 9553414','S/R',1,1);
INSERT INTO cliente VALUES(203,'Roberto Serrano','Luis Moreno #269','474 7428829','S/R',1,1);
INSERT INTO cliente VALUES(204,'Daniel Ortega','Agustín Rivera #237','474 7457911','S/R',1,1);
INSERT INTO cliente VALUES(205,'Daniel Pérez','Antonio González #129','474 1266936','S/R',1,1);
INSERT INTO cliente VALUES(206,'Maricela Rangel','Jiménez #100','465 1081444','S/R',1,1);
INSERT INTO cliente VALUES(207,'Fernando Hernández','5 de Mayo #505','331 1632701','S/R',1,1);
INSERT INTO cliente VALUES(208,'José Salas','Jesús E. Zapata #205','449 1916771','S/R',1,1);
INSERT INTO cliente VALUES(209,'Sergio Santana','Av. Juárez #406','465 1092648','S/R',1,1);
INSERT INTO cliente VALUES(210,'Blanca Rangel','Ecnegaray','465 1088535','S/R',1,1);
INSERT INTO cliente VALUES(211,'Marisol de Lerdo','Plutarco Elias Calles 17','449 2737573','S/R',1,1);
INSERT INTO cliente VALUES(212,'Cruz Asara','Av. Revolución #28','465 1169639','S/R',1,1);
INSERT INTO cliente VALUES(213,'Antonio Flores','16 de Sep # 10','465 1166998','S/R',1,1);
INSERT INTO cliente VALUES(214,'Priscila Celaya','Julio Cadena 116','449 1004639','S/R',1,1);
INSERT INTO cliente VALUES(215,'Israel Hernández','Juárez Merced #75','346 1008585','S/R',1,1);
INSERT INTO cliente VALUES(216,'Jhonatan Gutierrez','5 de Mayo #214','478 1002040','S/R',1,1);
INSERT INTO cliente VALUES(217,'Juan Pablo','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(218,'Leonardo Pérez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(219,'Gerardo Almanza','Jesús Montaño #78','438 1005607','S/R',1,1);
INSERT INTO cliente VALUES(220,'Antonio Martínez','Nicolás Bravo #45','438 1214423','S/R',1,1);
INSERT INTO cliente VALUES(221,'Jazmín Borjoques P','M de la Piedra #103','438 1145809','S/R',1,1);
INSERT INTO cliente VALUES(222,'Salvador Paredes','Niños Héroes #10A','438 1215333','S/R',1,1);
INSERT INTO cliente VALUES(223,'Israel Paredes','Niños Héroes #120','445 4452176','S/R',1,1);
INSERT INTO cliente VALUES(224,'Luis Alberto Almanza','Montaño #63','438 3623002','S/R',1,1);
INSERT INTO cliente VALUES(225,'Jesús Enrique López','Francisco Sierra #25B','438 1162512','S/R',1,1);
INSERT INTO cliente VALUES(226,'Guillermo Hernández P','Abasolo #111B','438 1001838','S/R',1,1);
INSERT INTO cliente VALUES(227,'Angélica Madris','5 de Mayo #38','438 1143631','S/R',1,1);
INSERT INTO cliente VALUES(228,'Luis Higareda','Nicolás Ravo 45','438 1034936','S/R',1,1);
INSERT INTO cliente VALUES(229,'Uriel Torres','5 de Mayo','449 1447773','S/R',1,1);
INSERT INTO cliente VALUES(230,'Raúl','Faja de Oro 1400','461 1699233','S/R',1,1);
INSERT INTO cliente VALUES(231,'Rigoberto López','No Reelección #16','462 2103896','S/R',1,1);
INSERT INTO cliente VALUES(232,'Eder Pérez','Mina #60','418 1105096','S/R',1,1);
INSERT INTO cliente VALUES(233,'Carlos Ávila','Hidalgo #406','466 1073802','S/R',1,1);
INSERT INTO cliente VALUES(234,'Marín Pérez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(235,'Eduardo López','Zaragoza #23','466 1160702','S/R',1,1);
INSERT INTO cliente VALUES(236,'Juan Castro','Abasolo #1885','462 111961','S/R',1,1);
INSERT INTO cliente VALUES(237,'Omar Castro','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(238,'Javier Estrada','Lazaro Cárdenas #8A','438 1110867','S/R',1,1);
INSERT INTO cliente VALUES(239,'Carmen Sillas','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(240,'Sergio Sánchez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(241,'Jorge Omar de la Paz','Guerrero #15A','469 6218054','S/R',1,1);
INSERT INTO cliente VALUES(242,'Antonio López','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(243,'Fyly Hernández','Av. San Joaquín #460','462 1251452','S/R',1,1);
INSERT INTO cliente VALUES(244,'César Acosta','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(245,'Judith Paredes','Juárez #133','466 1234573','S/R',1,1);
INSERT INTO cliente VALUES(246,'Leopoldo Hernández','José Torres Landa Esq.','461 1194026','S/R',1,1);
INSERT INTO cliente VALUES(247,'Javier','José Reyes 301','465 9558022','S/R',1,1);
INSERT INTO cliente VALUES(248,'Martín Salas','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(249,'Eder Pérez','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(250,'Mauricio Vernabe','Miguel Lerdo #91A','474 7944364','S/R',1,1);
INSERT INTO cliente VALUES(251,'Guillermo Castillo','Blvd. Lázaro Cárdenas','352 5618531','S/R',1,1);
INSERT INTO cliente VALUES(252,'Carlos Antonio','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(253,'Liborio López','Seg. Pública #403','S/R','S/R',1,1);
INSERT INTO cliente VALUES(254,'Ricardo Barroso','Lagunilla #653','462 1647833','S/R',1,1);
INSERT INTO cliente VALUES(255,'Ángel Moreno','S/R','S/R','S/R',1,1);
INSERT INTO cliente VALUES(256,'Marco Mendes','Blvd. Lázaro Cárdenas #194','352 1395887','S/R',1,1);
INSERT INTO cliente VALUES(257,'Elvira Llanas','Juan Domínguez #302','465 1085701','S/R',1,1);
INSERT INTO cliente VALUES(258,'Javier Domínguez','José Reyes #301','492 8925035','S/R',1,1);
INSERT INTO cliente VALUES(259,'Ana Gabriela','Morelos #505','411 1110608','S/R',1,1);
INSERT INTO cliente VALUES(260,'Carlos Lara','Zaragoza #1421','449 3230874','S/R',1,1);
INSERT INTO cliente VALUES(261,'Erick Ramírez','Benito Juárez #57','466 1151818','S/R',1,1);
INSERT INTO cliente VALUES(262,'Claudia Lara Sánchez','Manuel Doblado #7','921 1629167','S/R',1,1);
INSERT INTO cliente VALUES(263,'Álvaro Mota','Tránsito #202','478 1057186','S/R',1,1);
INSERT INTO cliente VALUES(264,'Mireya Parrales','Mercado Hidalgo, Local #2','417 100 2354','S/R',1,1);
INSERT INTO cliente VALUES(265,'Alfredo López','16 de Septiembre #870','415 106 5437','S/R',1,1);
INSERT INTO cliente VALUES(266,'Hector','Mercado hidalgo,local #6 Acambaro gto','4171799992','S/R',1,1);
INSERT INTO cliente VALUES(267,'Ernesto Tecno-Cell','Av 1 de Mayo # 661-A','417 110 0083','S/R',1,1);
INSERT INTO cliente VALUES(268,'Roberto Moreno Castro','Andador Juárez # 431','417 107 5700','S/R',1,1);
INSERT INTO cliente VALUES(269,'Mundo Cell','Mariano Abasolo #34-A','417 177 6136','S/R',1,1);
INSERT INTO cliente VALUES(270,'Dalia Orozco','Hidalgo  #70','417 113 8340','S/R',1,1);
INSERT INTO cliente VALUES(271,'Nayeli Hidalgo','Hidalgo #5','417 101 5434','S/R',1,1);
INSERT INTO cliente VALUES(272,'Luz María Rodríguez Trejo','Morelos #531','417 112 9344','S/R',1,1);
INSERT INTO cliente VALUES(273,'Carmen Fierros Valiois','Hidalgo #127','421 102 7365','S/R',1,1);
INSERT INTO cliente VALUES(274,'Luis Hernández','Av. Miguel Hidalgo #988','417 100 1300','S/R',1,1);
INSERT INTO cliente VALUES(275,'Liliana Sex Shop','Av. Guerrero # 439','417 104 4485','S/R',1,1);
INSERT INTO cliente VALUES(276,'Diana Parrales','Aldama #62 B','417 117 1097','S/R',1,1);
INSERT INTO cliente VALUES(277,'Ramiro Beltran','Av. Zaragoza #181','421 472 6091','S/R',1,1);
INSERT INTO cliente VALUES(278,'José Guadalupe','Juárez #78','421 105 1671','S/R',1,1);
INSERT INTO cliente VALUES(279,'Elizabeth Pérez','José Aguilar y Maya #56','421 105 1293','S/R',1,1);
INSERT INTO cliente VALUES(280,'Fabiola Rodrigues','Guerrero # 14B','417 104 2223','S/R',1,1);
INSERT INTO cliente VALUES(281,'Yosen Giovani Camacho','Abasolo #54 B','442 471 0407','S/R',1,1);
INSERT INTO cliente VALUES(282,'Antonio Pérez','Héroes de Nacozari #646','417 179 4390','S/R',1,1);
INSERT INTO cliente VALUES(283,'Edgar Uriel Rivera','20 de Mayo # 4','417 178 9947','S/R',1,1);
INSERT INTO cliente VALUES(284,'Karla Merlo','Plaza Sámano #83','417 104 3921','S/R',1,1);
INSERT INTO cliente VALUES(285,'Ma. Santos','Quintana Roo Local 5','413 101 5472','S/R',1,1);
INSERT INTO cliente VALUES(286,'Leticia Hernández','Jardín Cuauhtemoc #10','442 120 8754','S/R',1,1);
INSERT INTO cliente VALUES(287,'Alvaro Ezequiel Lara','Venustiano Carranza #316','442 410 5139','S/R',1,1);
INSERT INTO cliente VALUES(288,'Octavio Tinajero','Prol. Miguel Alemán #409','413 112 5076','S/R',1,1);
INSERT INTO cliente VALUES(289,'Minerva Arazate','Juárez #610','4612279683','S/R',1,1);
INSERT INTO cliente VALUES(290,'Gustavo Anaya','Francisco Javier Mina #305','413 102 7118','S/R',1,1);
INSERT INTO cliente VALUES(291,'Paola Ñañes','Guadalupe Victoria #105','461 231 8563','S/R',1,1);
INSERT INTO cliente VALUES(292,'Carlos Pérez','Vicente Ruíz #105','412 101 8145','S/R',1,1);
INSERT INTO cliente VALUES(293,'Yolanda Gutierrez','Mariano Matamoros #200-B','413 120 7693','S/R',1,1);
INSERT INTO cliente VALUES(294,'José Julian García','Aldama # 126 B','413 100 2594','S/R',1,1);
INSERT INTO cliente VALUES(295,'Carlos Cruz','Venustiano Carranza, Central','461 200 6136','S/R',1,1);
INSERT INTO cliente VALUES(296,'Brayan Guerrero','Prol. Miguel Alemán #521','413 111 9754','S/R',1,1);
INSERT INTO cliente VALUES(297,'Fernando Ibarra','Guadalupe Victoria S/N','413 158 2472','S/R',1,1);
INSERT INTO cliente VALUES(298,'Javier Lucero','Narciso Mendoza #99','413 118 2540','S/R',1,1);
INSERT INTO cliente VALUES(299,'Margarita Carreto','Antonio Plaza S/N Mercado','413 123 6533','S/R',1,1);
INSERT INTO cliente VALUES(300,'Ricardo Páramo','Saltillo #121 Col Santarita','461 151 1863','S/R',1,1);
INSERT INTO cliente VALUES(301,'Janet Naranjo Ruíz','Aguascalientes #166, Col. Santa Rita','461 608 7690','S/R',1,1);
INSERT INTO cliente VALUES(302,'Brenda Raquel','Chetumal #301, Col. Santa Rita','461 611 4233','S/R',1,1);
INSERT INTO cliente VALUES(303,'Martha Medina','Puebla #301, Col, Santa Rita','461 109 4698','S/R',1,1);
INSERT INTO cliente VALUES(304,'Flor Rodríguez','Paulino Leon #35 Santa María del Refugio','461 600 7342','S/R',1,1);
INSERT INTO cliente VALUES(305,'Jesús Farmacia','Camino de las Torres #445 Col El Campanario','461 119 5083','S/R',1,1);
INSERT INTO cliente VALUES(306,'Veronica Medina','Aldama # 206','461 223 1059','S/R',1,1);
INSERT INTO cliente VALUES(307,'Javier Vargas','Av. Presa Álvaro Obregón #11 Colonia Bonfil','461 242 4585','S/R',1,1);
INSERT INTO cliente VALUES(308,'Cesar Todo Para Tu Celular','Av. Presa Alvaro Obregón #432 Colonia Bonfil','461 265 1247','S/R',1,1);
INSERT INTO cliente VALUES(309,'Ali Rojas','Herrera Rocha #1778','411 133 1103','S/R',1,1);
INSERT INTO cliente VALUES(310,'Elizabeth Rojas González','Fray Servando Teresa de Mier #303','411 125 7196','S/R',1,1);
INSERT INTO cliente VALUES(311,'Cecilio Emicell','Del Cipreses #12-A','456 112 0318','S/R',1,1);
INSERT INTO cliente VALUES(312,'Fatima Miranda','Av. Juarez #217','456 111 2543','S/R',1,1);
INSERT INTO cliente VALUES(313,'Luis Arias','Av Benito Juarez #218','4561043007','S/R',1,1);
INSERT INTO cliente VALUES(314,'Liliana Murillo Arroyo','Manuel Doblado #15','4561013554','S/R',1,1);
INSERT INTO cliente VALUES(315,'Carmen Britos','Av. Mena #168','4561291615','S/R',1,1);
INSERT INTO cliente VALUES(316,'MASTER CELL','Manuel Doblado #25','4561023298','S/R',1,1);
INSERT INTO cliente VALUES(317,'Karla Martinez','Av. Mena #168','4561291615','S/R',1,1);
INSERT INTO cliente VALUES(318,'Maricela Gasca','Av. Arteaga #13','456 110 8024','S/R',1,1);
INSERT INTO cliente VALUES(319,'Rubi Sierra','Av. Arteaga #13','456 651 2459','S/R',1,1);
INSERT INTO cliente VALUES(320,'Virginia Vargas','Av. Arteaga # 20','456 103 1442','S/R',1,1);
INSERT INTO cliente VALUES(321,'Ángel García','Vicente Guerrero #108','456 101 9078','S/R',1,1);
INSERT INTO cliente VALUES(322,'Juan Carlos Lezama','Av. Mena #210','456 651 8781','S/R',1,1);
INSERT INTO cliente VALUES(323,'Paola Andrade Turbo Cell','Ignacio Comonfort #101','461 151 7677','S/R',1,1);
INSERT INTO cliente VALUES(324,'Abraham Salgado','Av. el Sauz #223 Col. Valle de los Naranjos','461 120 9610','S/R',1,1);
INSERT INTO cliente VALUES(325,'Abigail','Av. Juan José Torres Landa #503','461 615 5177','S/R',1,1);
INSERT INTO cliente VALUES(326,'Erik Tadeo','Antonio Plaza #106','461 139 2509','S/R',1,1);
INSERT INTO cliente VALUES(327,'Amalia González','Mariano Jiménez #561','461 112 2609','S/R',1,1);
INSERT INTO cliente VALUES(328,'Axel Contreras','Francisco I Madero #29','412 120 4090','S/R',1,1);
INSERT INTO cliente VALUES(329,'Hortencia Rocha','Av. Juarez # 242','473 110 9990','S/R',1,1);
INSERT INTO cliente VALUES(330,'Ofelia Carrillo Ramírez','Av. Juarez #236','473 101 2800','S/R',1,1);
INSERT INTO cliente VALUES(331,'Mary','Av. Juarez # 117 Int 1','473 652 7330','S/R',1,1);
INSERT INTO cliente VALUES(332,'Ana Camacho','Av. Juarez # 182','473 122 9149','S/R',1,1);
INSERT INTO cliente VALUES(333,'Alfredo Fernández','Av. Juarez #178','473 114 0510','S/R',1,1);
INSERT INTO cliente VALUES(334,'Gonzalo Galvan','Av Juarez #180','473 597 2442','S/R',1,1);
INSERT INTO cliente VALUES(335,'Gerardo Barcenas','Roble #108 Col Arroyo Verde','477 272 5271','S/R',1,1);
INSERT INTO cliente VALUES(336,'Cristian Gasca','Miguel Hidalgo #119','412 117 3795','S/R',1,1);
INSERT INTO cliente VALUES(337,'Antonio Godínez','Corregidora #216','412 187 7632','S/R',1,1);
INSERT INTO cliente VALUES(338,'José Guadalupe Martínez','Netzahuatcoyotl #205','412 118 3572','S/R',1,1);
INSERT INTO cliente VALUES(339,'José Guerrero','Adolfo López Mateos Local 36','412 105 3272','S/R',1,1);
INSERT INTO cliente VALUES(340,'Jazmín Aguilar','Zaragoza # 114','412 122 0886','S/R',1,1);
INSERT INTO cliente VALUES(341,'Obdulia Ríos','Molino de Santa Ana #11','462 132 0665','S/R',1,1);
INSERT INTO cliente VALUES(342,'Virginia González','Barrio Nuevo 32','432 102 7333','S/R',1,1);
INSERT INTO cliente VALUES(343,'Evelin','Morelos #431','412 128 0151','S/R',1,1);
INSERT INTO cliente VALUES(344,'Accesorios Michell','Carr. Juventino Rosas Guanajuato La Yerbabuena 23','473 139 2242','S/R',1,1);
INSERT INTO cliente VALUES(345,'Guadalupe Mancera','Emiliano Zapata # 17','461 112 4064','S/R',1,1);
INSERT INTO cliente VALUES(346,'Carmen Guerrero','Guerrero #89','466 103 6307','S/R',1,1);
INSERT INTO cliente VALUES(347,'Erick Ramírez Abonce','Juárez # 70','466 115 1818','S/R',1,1);
INSERT INTO cliente VALUES(348,'Felipe Villanueva ','Francisco Juarez ,#503A Celaya Gto ','4611310800','S/R',1,1);
INSERT INTO cliente VALUES(349,'Aura Juárez','Paseo de los Olivos #1237','461 287 7484','S/R',1,1);
INSERT INTO cliente VALUES(350,'Andrea Ojeda Jiménez','General Francisco Villa #23','461 679 2020','S/R',1,1);
INSERT INTO cliente VALUES(351,'Maria Luisa Villafuerte','INDEPENDENCIA #112','466 1270183','S/R',1,1);
INSERT INTO cliente VALUES(352,'Alberto Moncada','Av. Arteaga 5','4561329330','S/R',1,1);
INSERT INTO cliente VALUES(353,'Miguel Armando ','Hidalgo','4121076490','S/R',1,1);
INSERT INTO cliente VALUES(354,'Carmen Guerrero','HIDALGO 100','4121172830','S/R',1,1);
INSERT INTO cliente VALUES(355,'Juan Carlos Guerrero','Hidalgo 221','4121177651','S/R',1,1);
INSERT INTO cliente VALUES(356,'Luis  Casas','Carr. a Silao km10.5,Col. Santa Teresa','4731390241','S/R',1,1);
INSERT INTO cliente VALUES(357,'Adrian Canedo','Miguel Hidalgo 297','4661035390','S/R',1,1);
INSERT INTO cliente VALUES(358,'Javier Tales','Liborio Crespo 128B','4616199629','S/R',1,1);
INSERT INTO cliente VALUES(359,'Valentin Rodriguez','Alameda 707','4641282846','S/R',1,1);
INSERT INTO cliente VALUES(360,'Jorge Luis','12 de Octubre 345','4611972439','S/R',1,1);
INSERT INTO cliente VALUES(361,'German Martinez','Plutarco Elias Calles 110','4651091836','S/R',1,1);
INSERT INTO cliente VALUES(362,'Raul Contreras','Av. Pedregal 378','4431387041','S/R',1,1);
INSERT INTO cliente VALUES(363,'Juan Pablo Vazquez','Rayon 413','4686900514','S/R',1,1);
INSERT INTO cliente VALUES(364,'Berenice Cortezz','Av. Pedregal 173','4432681768','S/R',1,1);
INSERT INTO cliente VALUES(365,'Mario Hernandez','Miguel Hidalgo 419','4681110228','S/R',1,1);
INSERT INTO cliente VALUES(366,'David Gallardo Mejia','Av. Lomas del Pedregoso 331','4681234567','S/R',1,1);
INSERT INTO cliente VALUES(367,'Elizabeth Olvera','Av. Juarez 164','4271219182','S/R',1,1);
INSERT INTO cliente VALUES(368,'Ismael Castelan Duran','Alvaro Obregon 1','4611282426','S/R',1,1);
INSERT INTO cliente VALUES(369,'Maria Infante','San Sebastian 34','4641234567','S/R',1,1);
INSERT INTO cliente VALUES(370,'Miguel ','Zapata','3531061254','S/R',1,1);
INSERT INTO cliente VALUES(371,'Maria Guadalupe G.','Av. Pedregal 747','4431924455','S/R',1,1);
INSERT INTO cliente VALUES(372,'Alexander Alvarez','8 de Enero 30','4431012137','S/R',1,1);
INSERT INTO cliente VALUES(373,'Saul Nava','Lazaro Cardenas 8C','4434008221','S/R',1,1);
INSERT INTO cliente VALUES(374,'Joaquin Perez','Eje Norponiente 34','4611234567','S/R',1,1);
INSERT INTO cliente VALUES(375,'Norma Zendejas Perez','1o de Mayo 63','4434394193','S/R',1,1);
INSERT INTO cliente VALUES(376,'Griselda Zendejas Perez','1o de Mayo 18','4434394193','S/R',1,1);
INSERT INTO cliente VALUES(377,'Maricela Perez','5 de Mayo 125','4612647530','S/R',1,1);
INSERT INTO cliente VALUES(378,'Jose Martinez','BOULERVAR ADOLFO LOPEZ MATEOS #211','4611336148','S/R',1,1);
INSERT INTO cliente VALUES(379,'Astrid Judith Ojeda','Francisco Velez 114','4271204729','S/R',1,1);
INSERT INTO cliente VALUES(380,'Flavio Mata','Plazuela Union 24','4191193002','S/R',1,1);
INSERT INTO cliente VALUES(381,'Carmen Gonzalez','Jardin Principal 21','4191056868','S/R',1,1);
INSERT INTO cliente VALUES(382,'Oseas Mata','Plazuela Union 80','4191000235','S/R',1,1);
INSERT INTO cliente VALUES(383,'Arturo Montes','Av. 1o de Mayo 1','4621839191','S/R',1,1);
INSERT INTO cliente VALUE(384,'Angel Daniel Navarrete','Hidalgo 206','4611118655','S/R',1,1);
INSERT INTO cliente VALUES(385,'Emma Alejandra Hernandez','Av. Sur 4','4181031234','S/R',1,1);
INSERT INTO cliente VALUES(386,'Cristian Arroyo','Jardin Central 12','4291078585','S/R',1,1);
INSERT INTO cliente VALUES(387,'Maribel Jimenes Guzman','Abasolo 76','4451106662','S/R',1,1);
INSERT INTO cliente VALUES(388,'Alejandra Vargas','Anehuilco esq. Tecnologico','4611411182','S/R',1,1);
INSERT INTO cliente VALUES(389,'Estrella Areas Rodriguez','Av. Cecyteg Deportiva 17','4771058151','S/R',1,1);
INSERT INTO cliente VALUES(390,'Alan Huitron','Alameda 37','4171771508','S/R',1,1);
INSERT INTO cliente VALUES(391,'Juana Maria Duran Ramirez','Hidalgo 60','4191930163','S/R',1,1);
INSERT INTO cliente VALUES(392,'Ruth Herrera Reyes','Sabino 21','4171172398','S/R',1,1);
INSERT INTO cliente VALUES(393,'Maria Eliza Ortega Jimenez','Narciso mendoza #310','4615461506','S/R',1,1);
INSERT INTO cliente VALUES(394,'Nancy Treso ','Lazaro Cardenas #506','4131015657','S/R',1,1);
INSERT INTO cliente VALUES(395,'Carmen Guerrero','Hidalgo #100','4121172830','S/R',1,1);
INSERT INTO cliente VALUES(396,'Marco Martinez','5 de Ferbrero','4424982306','S/R',1,1);
INSERT INTO cliente VALUES(397,'Teresa Serrano','Morelos #53','4871308888','S/R',1,1);
INSERT INTO cliente VALUES(398,'Artuto Hernandez Camacho','Aldama #23','4871025127','S/R',1,1);
INSERT INTO cliente VALUES(399,'Yanciry Cruz','Hidalgo #219','4871046331','S/R',1,1);
INSERT INTO cliente VALUES(400,'Luis Briones','Hidalgo #213','4871117910','S/R',1,1);
INSERT INTO cliente VALUES(401,'Andres Gonzales','Hidalgo #23','4871045182','S/R',1,1);
INSERT INTO cliente VALUES(402,'Alejandro Zarate','Morelos Plaza Centro #111','4871102310','S/R',1,1);
INSERT INTO cliente VALUES(403,'Laura Gonzales','Jimenez #397C','4871122177','S/R',1,1);
INSERT INTO cliente VALUES(404,'Angel Arguello Diaz','Aldama #403','4871163020','S/R',1,1);
INSERT INTO cliente VALUES(405,'Allyn Morales Novia','Carr. Gto-Sialo KM. 10 Santa Teresa','4734593473','S/R',1,1);
INSERT INTO cliente VALUES(406,'Victor Manuel Reyes','Av.16 de Sep. #306 ','4211011061','S/R',1,1);
INSERT INTO cliente VALUES(407,'Roberto Rivera Navor','Carr. La Griega km .5','4425958918','S/R',1,1);
INSERT INTO cliente VALUES(408,'MARLEN GARCIA ','HIDALGO #131 ','4431884367','S/R',1,1);
INSERT INTO cliente VALUES(409,'Marina Rodriguez ','Esquina Angel Anguina y Guadalupe Victoria ','4759518894','S/R',1,1);
INSERT INTO cliente VALUES(410,'JESÚS ADÁN GARCÍA','DOCTOR ISLAS #409','4871051545','S/R',1,1);
INSERT INTO cliente VALUES(411,'JIMENA RAMIREZ','MERCADO MUNICIPAL','4857973810','S/R',1,1);
INSERT INTO cliente VALUES(412,'IRMA PADRÓN','PLAZUELA M HERNANDEZ #100','4446580362','S/R',1,1);
INSERT INTO cliente VALUES(413,'CATALINA CRUZ HERRERA','PRIV. FRANCISCO LICEO #102','4131019566','S/R',1,1);
INSERT INTO cliente VALUES(414,'DANIEL CALDERON','5 DE MAYO #76 ESQUINA LEANDRO VALLE','4561012773','S/R',1,1);
INSERT INTO cliente VALUES(415,'RIGOBERTO MENDIOLA','AV. REVOLUCIÓN #5','4471012150','S/R',1,1);
INSERT INTO cliente VALUES(416,'MANUEL ERIBERTO TREJO','AV. BOULEVARD LUIS DONALDO COLOSIO #611','417 177 3776','S/R',1,1);
INSERT INTO cliente VALUES(417,'FELIPE PADRON OCHOA ','PIPILA  #329','413 100 7857','S/R',1,1);
INSERT INTO cliente VALUES(418,'Leodegaria Arteaga Zavala','Fraternidad y Lucha #25','4661053234','S/R',1,1);
INSERT INTO cliente VALUES(419,'KENYA ORTIZ ','20 DE NOVIEMBRE #3','465 113 8597','S/R',1,1);
INSERT INTO cliente VALUES(420,'SERGIO ARREAGA ','PLAZA PRINCIPAL #7 CENTRO','419 100 2415','S/R',1,1);
INSERT INTO cliente VALUES(421,'OLGA TREJO ','VICENTE GUERRERO ESQUINA MORELOS #2 F','419 107 4065','S/R',1,1);
INSERT INTO cliente VALUES(422,'HORACIO LOPEZ','GALEANA #215','4291026448','S/R',1,1);
INSERT INTO cliente VALUES(423,'PIA RAMIREZ','GUERRERO #54','5520464533','S/R',1,1);
INSERT INTO cliente VALUES(425,'Hector Virchis Martinez','Guerrero #60','4857977996','S/R',1,1);
INSERT INTO cliente VALUES(426,'FERNANDO ORTIZ LOPEZ ','MERCADO FRANCISCO LEON LOCAL 5 Y 6','4741038578','S/R',1,1);
INSERT INTO cliente VALUES(427,'ISMAEL ','PLAZA DE LA TECNOLOGÍA LOCAL 192 ','5544048502','S/R',1,1);
INSERT INTO cliente VALUES(428,'ANGEL MALDONADO ','PLAZA PRINCIPAL #29 ','419 101 0752','S/R',1,1);
INSERT INTO cliente VALUES(429,'Claudia Santillon ','Allende #24 B','417 123 7045','S/R',1,1);
INSERT INTO cliente VALUES(430,'MARIA  LOURDES ','5 DE MAYO #351 ','429 109 6900','S/R',1,1);
INSERT INTO cliente VALUES(431,'Josué Nicolás ','Sostenes Rocha #181','461 218 3999','S/R',1,1);
INSERT INTO cliente VALUES(432,'Bertha Perez ','Mariana J. Pozos #314, Insurgentes ','461 132 3965','S/R',1,1);
INSERT INTO cliente VALUES(433,'Jose Carlos Pérez','Miguel Aleman #701','413 106 69 26','S/R',1,1);
INSERT INTO cliente VALUES(434,'Isaac Medrano Zepeda','Mariano Matamoros #103','466 110 8968','S/R',1,1);
INSERT INTO cliente VALUES(435,'Yesica Capetillo Angeles','Priv. San Felipe #108 Col. Ejidal','4612233440','S/R',1,1);
INSERT INTO cliente VALUES(436,'Cristina Garcia  ','Obregon #27','4561322313','S/R',1,1);
INSERT INTO cliente VALUES(437,'Hector Gonzalez Martinez','Jesus Montañon #10','4291078625','S/R',1,1);
INSERT INTO cliente VALUES(438,'Jose Jesus Hernandez','Agustin Rivera #76B','4741128095','S/R',1,1);
INSERT INTO cliente VALUES(439,'Carlos Maga ','Rayon #236 ','468 113 1937','S/R',1,1);
INSERT INTO cliente VALUES(440,'María de los Ángeles','Hidalgo #47','4171612459','S/R',1,1);
INSERT INTO cliente VALUES(441,'Agripina López','Francisco Villa #8,  San Nicolás','4561144597','S/R',1,1);
INSERT INTO cliente VALUES(442,'Mario Alberto Villagomez','Blvd. Adolfo López Mateos #403','4612109344','S/R',1,1);
INSERT INTO cliente VALUES(443,'Eduardo Mendoza','16 de Septiembre #108','4612134576','S/R',1,1);
INSERT INTO cliente VALUES(444,'Guadalupe Gonzalez','Avenida Paseo de los Olivos #1237','4611557303','S/R',1,1);
INSERT INTO cliente VALUES(445,'Jorge Cardenas','Independencia Sur #2 Interior A, Santa Rosa Jorgue','4425395650','S/R',1,1);
INSERT INTO cliente VALUES(446,'Miguel Angel Gomez Diaz','Fray Servando Teresa de Mier #401B','9241434859','S/R',1,1);
INSERT INTO cliente VALUES(447,'Adriana Vargas Arvisu','Morelos #205','4291199524','S/R',1,1);
INSERT INTO cliente VALUES(448,'Analine Valencia Delgado','Zaragoza #17','4421812264','S/R',1,1);
INSERT INTO cliente VALUES(449,'Blanca Zamora ','Reforma #5','466 105 1187','S/R',1,1);
INSERT INTO cliente VALUES(450,'Manuel Pedroza','Guerrero Esquina Morelos','4511004440','S/R',1,1);
INSERT INTO cliente VALUES(451,'Leonardo Cintora Alanis','Melchor Ocampo #14','4431191985','S/R',1,1);
INSERT INTO cliente VALUES(452,'Miguel Garcia','Plaza Quinto Sol','4611462020','S/R',1,1);
INSERT INTO cliente VALUES(453,'Rafael García Jasso','Hidalgo #170','417 155 4110','S/R',1,1);
INSERT INTO cliente VALUES(454,'Victor Hugo López Tirado','San José #1','466 125 39 93','S/R',1,1);
INSERT INTO cliente VALUES(455,'Ramona Gasca Martinez','Juarez #191','4566551083','S/R',1,1);
INSERT INTO cliente VALUES(456,'Manuel Guerra','Lopez Cutilla #310A','474 111169','S/R',1,1);
INSERT INTO cliente VALUES(457,'Miguel Martínez ','Aldama #507','0','S/R',1,1);
INSERT INTO cliente VALUES(458,'Hector Palma','Zaragoza #146','4151191089','S/R',1,1);
INSERT INTO cliente VALUES(459,'Isabel Montes','Ocampo esquina con Santos Degollado ','466 110 5959','S/R',1,1);
INSERT INTO cliente VALUES(460,'Mirna Armenta Gamboa','Paseo de San Nicolas #137, col. Arboleadas','4611322325','S/R',1,1);
INSERT INTO cliente VALUES(461,'Cirila Centeno Jimenez','Juventino Rosas #23 Cuadrilla Ze Centeno','4121174403','S/R',1,1);
INSERT INTO cliente VALUES(462,'Albaro Gutierrez','Mercedes Camacho #6, local 18','4272902191','S/R',1,1);
INSERT INTO cliente VALUES(463,'Antonio Sandoval','Calle Ramón López Lara  s/n al lado de electra','451 100 6671','S/R',1,1);
INSERT INTO cliente VALUES(464,'Juan Ramon Lara','24 de Junio #20','3411173278','S/R',1,1);
INSERT INTO cliente VALUES(465,'Jazmin Bojorques','M. de la Piedra #103','4381145809','S/R',1,1);
INSERT INTO cliente VALUES(466,'Guillermo Hernandez','Abasolo #111B','4381001838','S/R',1,1);
INSERT INTO cliente VALUES(467,'Alexis Carbajal','16 de septiembre #405','413 114 83 32','S/R',1,1);
INSERT INTO cliente VALUES(468,'Ricardo Ramírez ','Oaxaca #147 col Hidalgo ','462 106 0001','S/R',1,1);
INSERT INTO cliente VALUES(469,'Edit Almanza','Independencia #120','411 122 7605','S/R',1,1);
INSERT INTO cliente VALUES(470,'Elizabeth Perez','Benito Juarez #101','4611265362','S/R',1,1);
INSERT INTO cliente VALUES(471,'Jesús Olmos ','Pasaje Guadalupe Frente al 101 ','461 109 6387','S/R',1,1);
INSERT INTO cliente VALUES(472,'Antonio Pérez','Mina #18','419 110 2728','S/R',1,1);
INSERT INTO cliente VALUES(473,'Adonay Mundo Movil ','Aztecas #600','461 132 2044','S/R',1,1);
INSERT INTO cliente VALUES(474,'Teresa Arroyo ','Jiménez #422 local 2','461 150 3651','S/R',1,1);
INSERT INTO cliente VALUES(475,'Jesús Guerrero','Francisco I Madero #10','412 109 0416','S/R',1,1);
INSERT INTO cliente VALUES(476,'Angel Fernando','Villafuerte #12','4451254243','S/R',1,1);
INSERT INTO cliente VALUES(477,'Jesus Enrique Lopez','Francisco Sierra #256','4381162512','S/R',1,1);
INSERT INTO cliente VALUES(478,'Miguel Angel Gonzalez','Miguel Martinez #7','4451452204','S/R',1,1);
INSERT INTO cliente VALUES(479,'Oswaldo Llamas','Melchor Ocampo #27','4211047394','S/R',1,1);
INSERT INTO cliente VALUES(480,'Guadalupe Bacilio','16 de Septiembre #10','4471013438','S/R',1,1);
INSERT INTO cliente VALUES(481,'Arturo Araiza','Heróico Colegio Militar #1202','442 498 1924','S/R',1,1);
INSERT INTO cliente VALUES(482,'Fabio Hidalgo','Petróleos Mexicános #67','456 116 0725','S/R',1,1);
INSERT INTO cliente VALUES(483,'Guadalupe','Colegio Militar #4 col centro ','445 115 78 39','S/R',1,1);
INSERT INTO cliente VALUES(484,'Jesús Zavala ','Santa Monica #2161','462 170 1310','S/R',1,1);
INSERT INTO cliente VALUES(485,'Maria Guadalupe Infante ','San Martin #1387','462 113 1692','S/R',1,1);

CREATE TABLE permiso_cliente
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nickname VARCHAR(200) NOT NULL,
    pass VARCHAR(200) NOT NULL,
    activo BOOL NOT NULL,
    cliente_id INT UNSIGNED NOT NULL REFERENCES cliente.id ON UPDATE CASCADE
);

/*Pendiente*/
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('General','JabKY8ooQlAQfD87AUWSr1xaJpg1Bn3hM3u7VkLEs1A=',true,1);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Oficina','kMMMA+qqCoRsDUJ9Sbk4PWWm/Gt99BQl6GzYp6Z2znQ=',	true,	2);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Zaragoza',	'BNygAXYUVbQLkH6fcMb8VsUBAMWbCZK7JIWQ/zVWl0g=',	true,	3);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juarez',	'D/UAWi4JS7JwRlZ+ptA5Ijo14xKz1o5RyZRs2lm6S0g=',	true,	4);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juarez',	'1nZgvQl6h8v25qmpxgfyprC7LS4he4SPLbKsJdrot9s=',	true,	5);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Arturo',	's52gFJzXMy+77sAOcc6ZrFcsYSKOmgn2Ck4w9pPOtYs=',	true,	6);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alvino',	'7DzxVvXgCNLAmX00sG7G1QXBZJpljWv/CZsjxmLQTIU=',	true,	7);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angel',	'W4pAzrPqdDprf2dQ00dGtWS3YTVbl0oIvhS8hr6fn88=',	true,	8);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Isabel',	'V+tRvzQm539IrKS28FBRWQH71Hw2Q0xFwIxsTI7Q2Bc=',	true,	9);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Isaac',	'VsFsamMkfdq86GtXkAKrmCYPJUXpTedU76mdqzHsFI4=',	true,	10);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'd66mypRrY6RPayI5JyeqBsnBaKNUeSI3KokoLdTNPVQ=',	true,	11);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fidel',	'Q2MHZjcQKuHhH7i2Q8L1Pf7fHssSTY34oQO7SAunmFg=',	true,	12);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'A3w/5ooGd1p0GBeQwmA30x6z8FG4IMeIbUe0yfYecnE=',	true,	13);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Natalia',	'1KS4juLBpK8AoiIwp8LILQmPI/yyuoG9OzpvepE7NPQ=',	true,	14);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leidy',	'Y5lcreQZAtpNhoKDhr/pA2E/fdUdOZg6Q1YlUt+JSms=',	true,	15);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Filiberto',	'B4hYU9KrcQQLwRjMkmUge+gujopenK1B0dBqrMY53fI=',	true,	16);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alfredo',	'WBirZz7n65R9ls7HJDPeKHO4+zy9ahr4V2yzORown0E=',	true,	17);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'1bpQ0kbNh42AlFipSDeeIE56rFqQKvPv0MDRTKywBwE=',	true,	18);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'1rfib64OjBSuNeuhcfChdfdHaNYkWsvhshdw+d+s9cc=',	true,	19);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'/yrHfA9QUE2YNa2V2nJp5z8y7bSyr+a16c2ECL1nB8g=',	true,	20);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Eduardo',	'fLo/o+dusJqDf4w7M328lMaCoYJZZ98NCnku9QOGsDM=',	true,	21);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Yolanda',	'i92EpvjZQDMpA5PApQ8baPAQb+C1Pme8zqtJEI2s6sE=',	true,	22);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alfonso',	'KPrNG1e+im9+M7sEuXlhD4RyaqWUFXLu8hkGw+oU/ug=',	true,	23);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maricela',	'+6uWryUx2IcWQwKelb82GNzVTlo7XVv7JXU4uvlDBFE=',	true,	24);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Delia',	'4ryROBVWRK+maP4hqeYfhdgZadDxZ7hyHf9f33rBK8s=',	true,	25);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Omar',	'7BTBG4akm1DZSlEEUk2wD+7NII3pNbgPqsl6S9Qll0E=',	true,	26);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Roman',	'ILrnCP7FAw/NwuaZkK4lVQh3LFEIJObe8KX6M/kjlXs=',	true,	27);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Imelda',	'EJEOFzL+JT5SIO5BM+RPwX28km0G5QaY1vpl5OV7EGg=',	true,	28);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alejandro',	'4RQhcfAGjW1Cc1CRhxe3YBXRuma6B4uQVrbA4vSvZRc=',	true,	29);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Israel',	'A9QritIXDeyW4hftTPodCGs9K33sVlB7XWTkggVT/VE=',	true,	30);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ricardo',	'ViDF9fzUs80KGfkPNVJjTRnJ458InMB1EgfFVQOrahY=',	true,	31);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'mk+3GSC/mH9xtGufBlnOkzy0TkPj/YRAIn1N8psslPc=',	true,	32);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'mijY3EpmIsBj4hn0R29BaBHvYn36V0MxqQpdyTbLwJo=',	true,	33);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Elizabeth',	'KG5W2LlyFKL9b4sKYwkj/JzFYUb7Nz4j7NcJHciNE0k=',	true,	34);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Flor',	'F0HuFh3U+5Dj7UM0g+W+Qk6KG7RvC23DlR5DH45KAlc=',	true,	35);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Eduardo',	'sw8fSE9oAXjvGid4PcCiIzVS+/835THHTweymKkQXA0=',	true,	36);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alejandro',	'm8ba4MbQ3oYDVgaWkCNsAtxxicc0rUaLT5W2lxifeBc=',	true,	37);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leticia',	'EusjNufCSlGnhDgKB0iKRnetWEGbUxm4oCOXGuytGmU=',	true,	38);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Melanny',	'e1dutEcMCuom8rZGu9kyNkVb7+aE0zRpBVo4/hr85B8=',	true,	39);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Moises',	'JuXkfGPPJu5xjYnRVeEXIMR9gY9YcoD93mxPKU8sCew=',	true,	40);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'ej9BpE3DPscBOJlDaAJVcZERtetoGfdW0liJOgYRjlM=',	true,	41);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Emma',	'ojpdebvVuRqT2aMzd0E4luKITzsCWxl2qOh1wma3nwQ=',	true,	42);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angel',	'0MY06/RmrDnFHcetmGRz2M4DFdOIHMtp9d5Hjy5Mso4=',	true,	43);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jorge',	'+LkLVaBHfiQKoHXnDh5Af4AYvB8N2iEvX9R+WESRS9c=',	true,	44);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jorge',	'FopBTfNrSti/bQc0w5NKi7aOT80YwFDxk08wAQ5mb2M=',	true,	45);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'v7xAsZQvbU6omVl/rT+KiXj0B6bovJA5UhMeTHUMinI=',	true,	46);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hugo',	'NfYSjlR7lbq0ClSnM3fjkBfyEnF5NlePoEUNlgmkflo=',	true,	47);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'qKPxNdTypkuEuWQUDCCQX5cs+EDlSpzt00tqxowDsvw=',	true,	48);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'FHPOT46saV+RJfEmFhqC3XYTzXr4VI4cX946I342gqE=',	true,	49);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Daniel',	'zR35eVDT8ZKqjFWnYu52IX7KACVOHCf8wBKX8nWraNw=',	true,	50);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alberto',	'YVOHuNTJGJmYYUlP50Kkd12LnwG9Gzf2eSpvIs7MjrY=',	true,	51);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'Wl8C5UJtl1oRfaFh8CJGNbxwQsPFnuJxIcsm9kUssAo=',	true,	52);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Abigail',	'KagvV2OtxuTByZ5Y0x241dhZX3X3ypfWr38NbjZyYc8=',	true,	53);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Andrea',	'b2LXaHIPaxeVQtxhkqdiAoJXrUOWAgAvOx5OMg/ow80=',	true,	54);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jary',	'NS5w9njIHYwNNllmPxtDJxkQ931EWbZh5LNs1sXv7Uw=',	true,	55);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Esther',	'O6C0GAMFQiwliZOdvQI47eKtpDr/1M2Oj0E0SRrtvBk=',	true,	56);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marco',	'MFJy30zaupupc9xB6ecXy1luuMUoRuZ7z3GKUxP1OCM=',	true,	57);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Moises',	'ocIBvXaajgTD90xrBQ+fnWX2ertMUMxhDZsIWLkHNJ4=',	true,	58);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gaby',	'GBComwDH3mwleb1IwpodmZSIlWnBSY5BcxSqz5gdehM=',	true,	59);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Brenda',	'wVeHlPJKV5wqKgdzG77+NugjWoH3QrfvAecU2M5BDLo=',	true,	60);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Liliana',	'2a5evg4AfO3zcrCqUZEy9un+bGF/iiteQ5qeD3su1/M=',	true,	61);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Eder',	'ohCt6UlgqaxQ8rybBOZj0ZDmxvpUM7Kn9yO9vOe9H3c=',	true,	62);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ricardo',	'6d/jk2BODqpjnalL9Mpjcbgd1PPYjISByRYDHW9eGzk=',	true,	63);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Claudia',	'Lax1usJ6+C69hel/FhgxAAYwlqftOk/mC3RlKfzEyiY=',	true,	64);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Sandra',	'vauk3i1hwi2n0+19HeygbBKCEYVtu9/sRsa+1eLq5L8=',	true,	65);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'SFN0UPf91EasW7wDT8NVEdVdShSqIeqFkN4V/uiaw2M=',	true,	66);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'oLTRhmEqvQzSx6OkSUNIwc4Cp0XTSGqDMbMnVxKbPBg=',	true,	67);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Rafael',	'UlXsvfTPCYP7ztO3rm7sL8nnveqIHBaUbFx2AsIhoAk=',	true,	68);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Janet',	'2CnLr8RIQIP90pfTUDseTb7vAqo/F2l1ARC7IsYpaHw=',	true,	69);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Sandra',	'DFW3fEQInCPB/KLcZ/3udFTxMUYotBXV3MzOQNQhKVE=',	true,	70);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Saul',	'nlh6cgVUbwUia0gxzDkr2ut7Ezo+s8BJ1C0V7G64kqk=',	true,	71);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ray',	'TT8Dp3W1oKNtsvkU7nFOyFg0Y4SCUGvKoJGBIYPDsns=',	true,	72);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Uriel',	'8wrDIQASbJaq292Hi15iX7N20Uo4zaSp2kufd5dR/X4=',	true,	73);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ana',	'YBhHb+zqCXSHAv9HNw5NiUqJNq3rIhovGlzt7IZTYIM=',	true,	74);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Elvia',	'9ja6nNNl/5w0sgNLcBoTiRHIWJYLsLwngGdkNLOuOtk=',	true,	75);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Silvia',	's3nqlrtEtkCAoGRMPF7H2ydmxpFVpUk5HvxQ++y15o0=',	true,	76);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'JkbPLRhjFbGGEK0cPDFEvalp6npqXrgaSczAvxzQ7Tg=',	true,	77);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'kWvQGtUGiWukm9qvB4GMmHWqM7zKgr6niHEk8iMFaP0=',	true,	78);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'YVTB+YdeSIU2VGKtAkmcrAmXT2XGEF013PzNIytDDZU=',	true,	79);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ivan',	'rTDifevz/M3V37/EeO3COmcSMYbvZfWSBFnA3Ou6I9w=',	true,	80);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juanita',	'S8BjPoyLyAxWVZmenK+8paZ/1KxRa1W4wwRgpFoQDQE=',	true,	81);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ulises',	'FVshtJtw+ldUfG05KwBcSzQxfHtZMvF1/cocyH6AFBs=',	true,	82);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Soledad',	'DJHu/og3lrOsw712V5LSdCZcIpKTHisNucNy/ix073Q=',	true,	83);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Arturo',	'IsghSQGJO9MIguYY/iBrolCtDdmw8HKy2MT7C2MPZyM=',	true,	84);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mauricio',	'kgupn5ZxGf22+N7Bh66uPy0SennGTy6no+gl3EVUwKM=',	true,	85);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Irvin',	'tOdx9aTVYHv3DO6SzJucxHUzqf1F/7Je4nqFUvXKez4=',	true,	86);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Saul',	'/g/q3IXfgN4E/SXlB7vTcczu2kIYVq7EJEm6sO27444=',	true,	87);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Agustin',	'f3hPngUX+sJAN5udvyXNnNc5+cV3eGwjJt8frThEXik=',	true,	88);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'KjRaQhzfZjiEwiKItcA/SVxo+i4AHFQaBBVZ4Xt3HxM=',	true,	89);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ana',	'TlgkmdRz4jV6bzes5zC+9ZKvXdmN7xT57wwTPU3hp6Y=',	true,	90);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'knF3uljp45Z4jsMuwwiZbKhSR9sr71xevcgxCrprziU=',	true,	91);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'nRM6hdI+mNikT5KMZSmRY6qUh1ZBRV6AeCWV2WQ0V6k=',	true,	92);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Adrian',	'sYHZjTy7Qf8pj8UYN6wsh2PP2eNIfxy2SZYhgdeZazI=',	true,	93);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'USDIfm82JVVUTn7rE10cgMIPh/TbniCgmgj+oAmgoIc=',	true,	94);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'qx38DwVi75M+UdDQHaivN7DcfdEAIHg1FBbZA7KXhSM=',	true,	95);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'RwAch+JLS96XvgmCkY3mfSkvaYvvV3DwOAES9EqlHuk=',	true,	96);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Nestor',	'D2igGj8rKUJ7tXfa/VdbUrhq/w3u1ntwCpf4jcZxgVM=',	true,	97);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ana',	'RTQQPz49lqT+6xl/mvJq4BuJoGsX/KIFfTZdswx52ZA=',	true,	98);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Edgar',	'PJQKtoeLj2Y5avkkCchE4+m/TKP9EStU4rLrWS9adCA=',	true,	99);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Rodrigo',	'mzT7KLKR59g4Gv5tQmD3pqecB2XWswhLoEyz+22T5sQ=',	true,	100);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marina',	'R5gH722ixmEl915TyNdoRiC9WLpDFQv7AjlRqlYP2LY=',	true,	101);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jorge',	'DUHvOITvR0qeDSACAd87lGfBfJkHEYfHrNa45mLaGQU=',	true,	102);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ana',	'CvK09DWu/WWoqi+vzTTLVAH9ySw4H6LFWtMBwg3VV6o=',	true,	103);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Daniel',	'dfpW4XUMJcEwzm2Jz/Rdbd/xW5aO01v/fO3m8AMikRo=',	true,	104);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'XUOX0HeTpM9DBGo7TUY3avJWhrYIaOs1/SZI1vjzgCU=',	true,	105);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jorge',	'Ot3VOI8yjO6IMrf5csP+GiKXgEopflZ8FKOpEuu9ii4=',	true,	106);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Berenice',	'ej0APA/hfN5vlhoKKKJPSwDVu1LD20s9MYrRO/B/l70=',	true,	107);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Enrique',	'B7MSsddX/UaLh/sO2htQYd6hsF0hcueZdLDbv3CBKSA=',	true,	108);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'6PZ4ARwB0bGi6YDw8VE4seNazPAvmMB+4PeqEUH3haA=',	true,	109);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Bernardo',	'qClPA0lsDGbQN8A4AU9Q+pjcsZ8YvqpUeZl3uyVPXss=',	true,	110);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'2BAr3dUEECIr8Uft38s0QhQ+eDrRoU1t/Eg4Nbb574s=',	true,	111);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Andrea',	'+k7sPV/DsEB0LvcLIJlL+bwQuHT/nXH0bnO3N7fz1/w=',	true,	112);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Lourdes',	'L/1ue27dJYn2aJ+Vocgl3gt35lyuTWYuvXtvFQgnixQ=',	true,	113);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'Yo3+oWF31XXR89cXLUXHQgx/7jDDfzLh3xN1GcsrXU0=',	true,	114);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Vicente',	'JDGDDlN+v2aDGaAKBiFhi3dGh03T8RLkBPgn9DqhVbo=',	true,	115);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'VxGjySwkmk3O+OO0Wk+MtD/HeFgW2HG0g1o+Pgn8ig4=',	true,	116);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gerardo',	'FJSLQd42z5yf3NML6aueeh7fa+vX3nZmnZxBmIqfLag=',	true,	117);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Armando',	'SKTWl1QveVmU4stUV0TtTtdXcvLzMAv7A7daT61H1MY=',	true,	118);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Sanjuan',	'gQnA86MtaGmmjnH9MoVP8C/GUxxO3QZel1F2hdfMWb8=',	true,	119);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Brenda',	'9ROaHHZb0v1ajrCNO5xWhBwm4oPiJENW1nGfFl9r18k=',	true,	120);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marina',	'v8UrkJJMdao/zlTOCvh8nBuRIRJp4oGCrSJ1RADDC+E=',	true,	121);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Chava',	'o9NuSXJZYjnM4+/zOMOrAkfQEk+sJPx1y36j/OqJVhg=',	true,	122);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gustavo',	'XzpjaRE5sVHpDl666S2qGtFTcUmDN4LaWPxzNnMg/BY=',	true,	123);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'4TTQO1hiTu5N9i8tY71LJJYOvV3h8Sh9DqTpmg631EA=',	true,	124);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gustavo',	'wq540Sa9c6SCJg1gTY2bSHXQPbbrNACrYH6Ja6TSJhM=',	true,	125);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Obdulia',	'yxeHmyJRGF4tH3vl0ZE4jVEQO6PFpfG3qvYoMSp3PhU=',	true,	126);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jazmin',	'xBfgjt79cD1HB9VB9wG1plg+h9l8RVs5ofjk5yIRjQc=',	true,	127);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gloria',	'UEbYltYLt/tJ7rR5rv5JBk+86V5BeZtW5r/KNR/Nofc=',	true,	128);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mayra',	'dcyfWK8x2FGvPRJaDAUThekI8ChLEo5uEDwXNu/qCnM=',	true,	129);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'QAIjZf1l8eX8H3Mo7DjJoFyK8Ixg0giJqnmceDh0wcY=',	true,	130);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Oscar',	'Zji1PoGS9yxnkfYAxnnwDfW70hk6hzonWUL8fAwtaxA=',	true,	131);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ricardo',	'Mt+dmCo4HkgPPoMZGf6xnefyQELqQaa3t5A3A/NngO8=',	true,	132);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'5zUlfo/r1tl+1YbKBZGwspxGiog+axqarIRouwRo7no=',	true,	133);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Adonay',	'25k5+zys05c7Xe2P4GLmeFplNNZ0XwLgpxu+BTSlOqg=',	true,	134);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mayra',	'syNURkWVkXgZeRuJYjncjXoQfeDiugGLu6ysDzIBTYo=',	true,	135);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Evelin',	'5fvPVlnpoWsWBd5J1wmYSbmoiyErhocPaIQS2Kdloxs=',	true,	136);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Teresa',	'htRr6/Qhxv1GWho+FxWMNYpGYiJwNhclBECoubRp3Wk=',	true,	137);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'UPiD5zN71EJu/2fprQfrtX0KS/ak8Wpwt4Og+sr7Efo=',	true,	138);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Felix',	'fJemrERpMsRJSz0kDppOBPORrajYW+5MZGsWRUvMKMg=',	true,	139);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Bernando',	'lDRJuP/L07jmGyBCYEnG4zNVlIliK/4GW+sh/k/qmoQ=',	true,	140);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'GafB3DVg75CbEsxzoKNcz6zj+v2x23EGzD0yD+uhorc=',	true,	141);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Javier',	'T/JVWod+VYZ7aTTIZK/1oLtpDalVsUcS8Gf8X2QFpgs=',	true,	142);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Josue',	'DVeYvhLi6H54S+mEim2Fmibu730sMteRSNVJj1rmzcA=',	true,	143);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Berenice',	'cl1Pl74n7plbEKRyZJCEC27yV33+UOzGtlcGIbphbdw=',	true,	144);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ricardo',	'fvNCHVauDX3Vw6/BVhIKY9ZZifl8JETmGFYIPcW5Ty4=',	true, 145);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Patricia',	'y7T7T6RGFD2r+3nnnD01mILpCGgrvgsZGvxtnzqtwyI=',	true,	146);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Rogelio',	'KdsarIllAytKTtAjiyCbmZPSDZ5VSBQLPMk1LMtANis=',	true,	147);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Sandra',	'Nz2uTKu6qt6NK2v5OIrWjrRLWUmuJkHMDEFGme5GzGU=',	true,	148);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Sandrita',	'13F/NCHdU3llGBOnsmTiba4jKCxDe3lmzJf0v7mKXug=',	true,	149);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Erick',	'/qw+Va8fSR+pEZ3RqoD3Dzg2EE1e5fovQu4J64qm5sQ=',	true,	150);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mireya',	'ReKErMsZE+vzY5S2s5chw0ra7/NCqD/jAH1jA+8JBtI=',	true,	151);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ivan',	'zCETFXG5auBamDoo6GdR3ur2SHDWXsTqUUiMDmgO1nE=',	true,	152);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Santiago',	'U/hYQvddfuoAz9gn2rgzsw9YrZ3ZEX/lI0ba8EZRJyY=',	true,	153);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ana',	'gVsDBJkqrUuliItMjipYMq2WsHsu6ByvU/gl2r/2d7s=',	true,	154);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alejandra',	'/PKp8tkUhFwECPk2oUYzzF4SgSqZxhD+w/aWV8wK+6I=',	true,	155);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Salvador',	'MocCgEPD0Py1aL+cGjpt+EZ69eW+eoyL7a38ct/OIXU=',	true,	156);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Laura',	'jJAFdBkKXonpX/7xI/t5IVN0OtYAzwsdHaQyYAxbpow=',	true,	157);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Patricia',	'Pbi6ZF4jtX3d6a9KapsuaewZkL5RW17wONLJJ5ePIE8=',	true,	158);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Daniel',	'bOtKwM1+NU5JoJZ1iggyNYMfYdFVs0I4O0mhGGnoWk4=',	true,	159);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'FmZTQpsaJeUZNU+pAYRbxrqnYiIxMKM1qTA7u3ZHC28=',	true,	160);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'lwIMPp2FYiCWXqU6FGnqGvNI5EjRrd2ay4vtfRJAvSU=',	true,	161);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Enrique',	'7c5J/jMVI4sojdHBkJT9Snh96NcsI5D2yvI8eCUcCpY=',	true,	162);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Flavio',	'lE4C8dzaeWnJg5RQ6nh0ghIjqLCQDATNFfrZC79qLFY=',	true,	163);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('German',	'vtjMF0gCMdYWVIqcVJn3xI4SJUfFqw/pHhZb3EydURI=',	true,	164);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Diego',	'fvDg2kttY+EGkBEd03WKBP0Dru1U3YMNsQIhHSox2ZI=',	true,	165);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hernan',	'SHNytbiga3EB7z4xWtGZcRKogyYORruh6VXMOcNrLUo=',	true,	166);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gonzalo',	'VfLiHPAke9P/itsFbSWAr8V5Xylgo8ONTVtajVKYbDw=',	true,	167);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'0YbUL+3ScRlm8NOzJxYV81dRWzqpcp5+biVD6e+YYho=',	true,	168);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gaby',	'VXHxE9qHikD4aGQXb9TGl5TqgHInIe13i3hMSjUHxTs=',	true,	169);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Salvador',	'jp5GnI3LRRSF6MIXo7T5PnBp6NpAY0OEea/Xu2x1h5M=',	true,	170);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Remedios',	'9zlVZeXxBiS2VxLdcg7UuQR1/IpZ4uo6p8ZLqB1t4l8=',	true,	171);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Blanca',	'CjUQ74U1Vis/fQwlHkrJ9RgX/MUFtYWpnCNG0gSbbRo=',	true,	172);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Lucila',	'WMjGpn2ip16XwF5VdLBBL8kgaPnh+8W8tPa+qVj7QSs=',	true,	173);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Yolanda',	'+4nmwgzR4P/ARGH6CK/t0ZICFGPxqJzFJf138rIO5DU=',	true,	174);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gloria',	'NhjxU0iObpjRzrq/pfQHcO51L/SMqRjVMVjAhMmRDVg=',	true,	175);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'NNKkCEqreiFhEaM6UCU629CQO+SbITwPVDzdpbSqimM=',	true,	176);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Diana',	'WumqHTUAQlsFuRc9znHpifHZNQbn4yXd2AtTZH+QmFw=',	true,	177);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'n/AlSFGQdmCf7SJuVJBsJv36rMnYYR1nRyuwT+sehvg=',	true,	178);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Edwin',	'9HhRvQkadvNEdAFU1ixNqm1zG4TfHf3QygUZVrg1nIc=',	true,	179);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'JfaWeWaKS1LFcYdqU/w/FTQxLTD+xT8eww3/S2Fw6q4=',	true,	180);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Oralia',	'QepFFYlLxT6pe/gWlJVyoIvfbQsxdum3oR3aCbMR6os=',	true,	181);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'rzwWytdpjjg5/7MN0tq37sP3k6eH5gzDW9071PS0VNQ=',	true,	182);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'SVMNezMwo2L/F1Oflzm7BuMCKzNSltG9RFrpl8QJ+I4=',	true,	183);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Virginia',	'SVfYu5AUlyy6xa+20BkUbbtCQoOhUKtHNtS4BRgEkfU=',	true,	184);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leonardo',	'BrGqLc8aAsCyjpdSfNRoQQpippSwrD4QOThNdNw/Vc0=',	true,	185);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'sYx5XVfDAmUnc7BOF2FVYe2HyHr0uQO8Fc+sgAVgkcs=',	true,	186);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Dulce',	'9W+EQHdj/R+VvtX14SZ2yGdJOTiXAaUxjz8kuMAmlCI=',	true,	187);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cecilia',	'T+49WLxBMxOv+C4WC4aQXXZKpT0cMvfZOUJrVPJwCWM=',	true,	188);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'IV+dL39FE1lbqtBSAkACvA5sAZTAcR2ns3xjlvp7KCs=',	true,	189);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Lenyn',	'8prf5vkCYEKXUeEiQrX/YRaOpFB9pGDG4ThQm/RNhQs=',	true,	190);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'd/zAYUtZIJ/qDMAHqX1yCQO0IgVBe1hwStVML0TLT3Q=',	true,	191);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'aDmMYIU3qdAFczMEPq1Xsopsb2bHmxZ+h1Smt1ZIk48=',	true,	192);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guillermo',	'Tjgzbtm6pjwur4g6R94vqKVdtr/gbTxB/SZgCsNEebc=',	true,	193);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hernestina',	'eFh/Lz6wlisI9BrdM3sGSqL0cs48CuKavJu0pHc1HDg=',	true,	194);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Claudia',	'kW4AlSLLZqByJaI++1dWSs54cevCRvGSjnn1H3sLMiU=',	true,	195);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'DGnSL4dqvDCIt/rbfhYO0ohQMajbyam/vbzdzdTigeY=',	true,	196);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fabian',	'OCXdzp2Q10tLonCz5ZCkN3l26h2VapOd6ftvbhAoKhU=',	true,	197);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Pedro',	'YzmzBLhFxR6oKb3bLfIsZ30CzyNDVC26CfegQv0VRpM=',	true,	198);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Armando',	'hIjJWIa+4biGdJecsDp06PVHo3IKbCNvZguMxusZVtY=',	true,	199);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Margarita',	'2hj7IwJtJg/QV/A8ZpdHj5dpwI/RzVaRr/T6+cb7V2U=',	true,	200);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Lupita',	'WTfBcn7my2Kln1z5rHopWpGBdfdzjbgV+uytBhL6T2o=',	true,	201);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cristobal',	'2LRJFcuOISGOscFVOKpp5XTMWlKkrf24ZtM+1GHHNkI=',	true,	202);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Roberto',	'SqRt1jhwpgmeO7nEcFCPB8cnjkAbPV0UFDQ6VR5uT4Y=',	true,	203);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Daniel',	'xyyEQTAkbQG6yyA49A83oVFPk6xMZJJ/9I5XFBgaxnw=',	true,	204);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Daniel',	'3DSzDOKQOAkyHRWYARQXmfJaE+DS6BQ6x5nIifi8lXo=',	true,	205);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maricela',	'W6PZg3q/uDidm4ZPEiUEvbHSjXadswA4J6LX1vXypMg=',	true,	206);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fernando',	'Z45xlkGMHUWcPk1CThTFC4JkWiNToZ3TjLjLXiJqKnc=',	true,	207);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'cOGNKGCGUoZ9JKC5d+9be97+Mx4z0TV8ld2+UxGdutk=',	true,	208);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Sergio',	'Y67Dp9s71h6TtgYc1zOkVUjepgdB8rAc4Pno2LoRStg=',	true,	209);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Blanca',	'K9WONSUlCAmnRw2cbJDChG2AOGxRj42zpBBp+rUyUkw=',	true,	210);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marisol',	'Q5fpc1TVYYlNqLOeGXp+xTjByTvHNl9B+3qlMp74Mgw=',	true,	211);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cruz',	'EQuogqdjvA3Q8vxY1V3HdfsZ0vmPYNW4l/pqrzTalGQ=',	true,	212);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'pnHGet8HepIEGJr8aVO6ZyjRhCjNnrfgJa9eCSDy2A8=',	true,	213);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Priscila',	'mQNtTfch2bvfQuLTeZMqhK+0+PUXNcx80o3rZzFCtWo=',	true,	214);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Israel',	'Pv1yW9Yy7VabShukoovM9EJZmj3JAxwLF1nKyOFwlxE=',	true,	215);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jhonatan',	'1xVTHVti5pQ45jecjQ16RLz5MPS8BJ/dvm6Z3/4jIkM=',	true,	216);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'fk1sixfUY3e5uW5FQIjmF36ICO97uzGA+5PWm0PY1n0=',	true,	217);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leonardo',	'60TWfVQj0WGDaJYVjRKvR2pza675ShctPQytY1+lZwc=',	true,	218);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gerardo',	'NwUo82w4PQr/GAPSMFCnw/A2+7ZqBdbMLFP/YDe4RNU=',	true,	219);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'dksCsvz9429ka4u1SGFq3C0zSSeJ8JuwKtyox/JgPc4=',	true,	220);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jazmin',	'PvT3aeacXYThvYcMWwq6M+c35o+IZMKVO2vXQM1g4l8=',	true,	221);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Salvador',	'gksead/PCXcnF9UBnejBME2rReJH77DpC7YsZd3VAYA=',	true,	222);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Israel',	'uOkW5WkceV9+RRi+yhF/UzuFhOaZ9wkfWfxwJ8kQR10=',	true,	223);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'OYafa2teM6PRt5MgvJbdineQeOHTuHDEon6h7PSLxlU=',	true,	224);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'PvSme+3ZooA+8BhqqwchMWmOeJ0jOxi9hPCKgTBwzn0=',	true,	225);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guillermo',	'6CDN10PMbJQ2hSLajZAiZnHfoJRcO9VKl0sHXDcqiNo=',	true,	226);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angelica',	'R5rUGYMzJIiph11kRmIWGdZU9PWNAzvevwORF4jofHQ=',	true,	227);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'gWrlNjfXzgOXQoUU69vDOLWhijvg1OG9WRubSONm+vc=',	true,	228);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Uriel',	'3MLCRxm+2PTd5I+49+GsMGBehK8pden+biEfWXDTVts=',	true,	229);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Raul',	'iV2Wvl0rOtbA6eYaVPvakzK7IlmAo3prAumNk+WKmoY=',	true,	230);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Rigoberto',	'c2RAaiKIcek9AItq/HorZKxY7/zHXJtDasdb1I/H3mE=',	true,	231);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Eder',	'NOxDENB4ddGboNeVaDmM3lN8ZNuIu5SnGL4NVjn1xQo=',	true,	232);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'pXNawkVcn734fISY3VIJJ4cIqqv9I4wqBpIeojvUO00=',	true,	233);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marin',	'CnaZQm6bgNqGa0CzkH/YIlGgawtbkkQtHkExlcfoQS4=',	true,	234);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Eduardo',	'NFkAMQw1K6z7BZVNMwRUWPzR6j9xJj2ufFPf53yqor0=',	true,	235);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'yILRdcSfRSvik9PSAZWvRRx0dyrMnaouSLLCAKnmTKE=',	true,	236);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Omar',	'unSmxg++4dnNDvuU+umWtB2gIrcnCWFa9+Wi1S9JnEc=',	true,	237);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Javier',	'pVg/EDqQviMmYZJiXK7YjwMxuEme5ndZwN0oN37Nxyk=',	true,	238);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'79PgDeQdPipvE7hIbZle9vTvpiolxS+wE3B5CB7aCjM=',	true,	239);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Sergio',	'nMwXmYymCcgW3gEzli25BAJ7Rj9de9yLgU6Ge59mljA=',	true,	240);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jorge',	'7YQSQ/8CYZhOKqdQvJwgMz/I6lr8dLBXfgIOfVCG0nk=',	true,	241);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'NqL85dLbbadANRFA4ruGoE6AMOKuvBY8/1F3wH3RbM0=',	true,	242);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fyly',	'ExCEJsuKQKpavRNhGUhqGRwo/SlqVLwjfn5doxcyKBw=',	true,	243);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cesar',	'nlaI+jL+XLgTxXuF4X3oMtfqFvcr/JF3IoOVjnM6b5c=',	true,	244);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Judith',	'/yvKd3LrAkcrgm0jI+DxN0dvJmOu1cxQlJ6mbN4eg9g=',	true,	245);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leopoldo',	'DypzpzYgCxRlIrl0thA+XUeuzengsYFFhCX+yV7J7/Q=',	true,	246);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Javier',	'lS6I52UeI4yhUCbshCbfV7+wE0SHTu/hdz2qYusAx2g=',	true,	247);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Martin',	'7lKFfRHAMek61t7AZomGMVorCyfL2eG5WBkCgxJPvd0=',	true,	248);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Eder',	'XI8NeNPr6pjP65cWmSIvz83JDBNYgMjA2yIqFTmwx+s=',	true,	249);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mauricio',	'WqZYHSTYttlwGaq8wK1xuhsLiL8UnFZRSlu89h2X1WU=',	true,	250);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guillermo',	'+1gJHeUJDedwDXClF4uKFUkZMEC1/Ops5NLJ9i6XOxM=',	true,	251);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'nlWoYEqPSWQjIz7+Yq4sy2eCdHuR4BQ0JCWobkXDhQE=',	true,	252);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Liborio',	'M3ks/ZvDdY1UWZI27bjiMbarItQX2UWLL8sY0x9IgHg=',	true,	253);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ricardo',	'4XW1Wpls9939RpHS+1pVSIoFolM/RD/YyT83mMvggzs=',	true,	254);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angel',	'3gMVPJYfonO2pJwN9RjzQ0ZifiN/tpAHj9tCsGF+yd8=',	true,	255);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marco',	'a0LZtiPILpxIzqvfykgir51v6NGB1JxHtyc6AI5WYvE=',	true,	256);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Elvira',	'yO4IOKIfjN4H4Lg/bDCT19MYg55T2Lk/xQjHfnwrh5A=',	true,	257);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Javier',	'w2PD1TdsIHMeAQ9dXkDcs4Z3CUYLeK+qoRRrvplFH9Q=',	true,	258);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ana',	'QlfCVMXfryMiwKIaUEdu0RVx1B3eHeSBroDLCzvcoLM=',	true,	259);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'FlpitGmOKyzjk5JFl02CO7OixKqYaC3Jw0dYGBNeMJ0=',	true,	260);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Erick',	'9uv6xuYaSprQdF3BgtVKb1NM2dGPLALLVJpPGXHHss0=',	true,	261);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Claudia',	'WZGePEinKg+baiQfpjFIXMIjPJaaKx/50CJVAykTtjE=',	true,	262);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alvaro',	'4qai+K3qF0BpSCt2T0p+MClTHqfTHKkUvuqBkooDmjo=',	true,	263);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mireya',	'rhBBLpmrj3SGIVV2f7n7D4PJnvW7rcACKVcuAIjlpas=',	true,	264);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alfredo',	'kizxnieNKvIHMWzRuSPACk7/fd3NuZ3ScYz481c0LRo=',	true,	265);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hector',	'Kr+fQmb7Oq8BK42c3c2ofDQPR6WcOegvqJURCjO1AZI=',	true,	266);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ernesto',	'SWT83zz7jA7ybUjSd5edfbcePXt/Mr0PEp1XqRENua8=',	true,	267);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Roberto',	'yx0oetOqePL7FGYiwhoex8/KDZyxq3ulC2JLqP2oA80=',	true,	268);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('MundoCell',	'H1i5Ihuns0Lu0rkkLD+p+zV6+hmrGDncOzTnlqjZTas=',	true,	269);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Dalia',	'bPyjEAL1In54wZ0+KkvgeoGaJkIIihYxTG+U2bxnqmA=',	true,	270);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Nayeli',	'4tGb8svk0njmLYZmWNc4nWa9v5Dn3WxBkKNiIFbKmfY=',	true,	271);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luz',	'8H4HO0X2jnwYIs52/+dQ0JNDVGXFqQc+6PhbRCK4uBw=',	true,	272);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'jSnMoCT9pVZIy+YU0Gk6VPklqfQ3tYGzO127TIGlYMo=',	true,	273);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'mmU1rTIWZR8E6JgS9bCdrj92KkjbXB3904V0RyEKf7g=',	true,	274);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Liliana',	'DK5+wCSwrlYJm803pbuA/ppCI9WDbRleWrl9WNwd7cs=',	true,	275);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Diana',	'pUnCb1YWjwgiD57ZH+BvD85dQbgt5aHS/uJvLzF4WuU=',	true,	276);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ramiro',	'kecnB9GTgRpC0mOU80QlxOG6KG/D6YuZ8Bnbpice6pA=',	true,	277);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	't50rMD8pwyv54g/bIXFXWi1RETkE+BsXmoL1NeHPNXI=',	true,	278);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Elizabeth',	'pKCXEqEwZIIKEtTYKrl+Cs2Fyt+nYY4ptBDXrvlEBOA=',	true,	279);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fabiola',	'8fOcFy51znnqZVGIFFo1kBTjWynqY3QUSK88mIu+kRE=',	true,	280);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Yosen',	'UpnuG0DOwi6JkC62hNQ1ZG19CmMmwOp7mwQk8NZiFUE=',	true,	281);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'exA8WiwWJ35IKqPmT8Ql52CoSEqQIQJm0ZPn98Fvm74=',	true,	282);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Edgar',	'0YrK/FklYjXCHnJZWUezMRAVqiC121dbhd12UDoLYVA=',	true,	283);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Karla',	'rsob3qp3bKAxYro1dBl643Dty/AFjUE+NvEX7g7XJyk=',	true,	284);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'kuIR/c8J0cgDpx8lXgclmf31jp4llB3mpI18FPqmcOs=',	true,	285);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leticia',	'DUh9f3OofXd0ZG/tZ+uPd4Th9y79ulyH0mroduLGd8k=',	true,	286);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alvaro',	'W5nZlj+mdUo3QwX295ii/mjD5hKBq4No+3lmnkmWWss=',	true,	287);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Octavio',	'u/nMLDI4hIWqieggirPYzEw4ZDazI/mzAc1Sflb2Y6k=',	true,	288);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Minerva',	'IGcDkZvY/AvV8vA/b+ofWaZFuq2qtprLceu7X5UgzWE=',	true,	289);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gustavo',	'mcbmhtuelf2jheNgEeUjW4shoeSqX0invH55QjzbCeM=',	true,	290);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Paola',	'AvW+0U5+XSNv2CA7mTruOwvcQDle7a+mp0uIEQDWMbs=',	true,	291);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'WXlQR2Meh+vw+VZsNhXdgRqY8Upj8DFkLVJ6VZeu5kw=',	true,	292);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Yolanda',	'7/pIYHwXRSrFHnhtObu6WKlSleeY7NtaisBe56x/7Gc=',	true,	293);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'ZtzwXng/gqt6zxi65Dt19r2wQXoClhHulQgqciyGEnw=',	true,	294);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'IMTZyNeoDf+bnYenMaW41l2L3HwtTep3WOTelxW/v18=',	true,	295);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Brayan',	'92UCbEH1to+0gdMP6gtS2nDGUJXM76fhtp9GRdp7YWg=',	true,	296);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fernando',	'Z45xlkGMHUWcPk1CThTFC4JkWiNToZ3TjLjLXiJqKnc=',	true,	297);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Javier',	'LkAGyybyfLdlx6ePs4SqlnlSSpPDgEoxoNf2HR9mdVY=',	true,	298);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Margarita',	'vtj8E6VCankVJqA8fkKJrYadj5Wmgf/73yFGSa83QTE=',	true,	299);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ricardo',	'e29xUEJHXUtMaQmcTCSZ/sslQSRGmwMlblNpEJOo0cM=',	true,	300);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Janet',	'rh4v/YVoShZ1tYFWDRw6QfpZyRjSuRGR18YUc7hi1UU=',	true,	301);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Brenda',	'CNyQQKfT6zAjNs4m4lzMQ6tSRCImTSyC5qwJqOL4KUI=',	true,	302);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Martha',	'rqtCMJRcjzeNHv+bpNqdeeHhGX/Abk/ZgSuZcUQFM38=',	true,	303);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Flor',	'/xoo9Bo9pLBQIpqo9WY7o2lvd2M17TL98G9X+mGHpvM=',	true,	304);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'S6SGa/7GbGNpVb0BKE0JG3P6t1LcJent5CTl/U50TTI=',	true,	305);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Veronica',	'wkKAYbRFHBklMQD4N+izkSpFLDDnGtzcEujq1Z7d/C8=',	true,	306);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Javier',	'+XSlPYhxK2I9EXLS/pgBmDt+F10RDYrhDIwki47NyBs=',	true,	307);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cesar',	'acQwmYr5ASBYCL9P17sOHf9PF7WpqMfCDBC5ySX8iHc=',	true,	308);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ali',	'GvEIlcD1EA+ollLeEfE1SHqG5/0l5i6WebsHWINAaXU=',	true,	309);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Elizabeth',	'9Ns870ByDPOSQpw9q1xihlZjGqc15dHX/XLNYL6PWK8=',	true,	310);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cecilio',	'x/HgHFqr5tW/cNW7j4v30TeAKxuXvoO1QLoXWy0Zqt0=',	true,	311);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fatima',	'Ov/1Ksjc3BvXYXglhf4qAsdJC7ORupb6RpuubOSUEi0=',	true,	312);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'v5zdu/dKADfOkvNdBh827cWdzatQ7XtJWK88Bdk/Wr4=',	true,	313);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Liliana',	'+uEm3XU3qWH5fmtQE96Dtc8KkqGQjRv9Sdq31b38R/o=',	true,	314);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'OU/wmh1ZjFPDJdc0RJxoTMnUDfTze19/YkK6P06GRfU=',	true,	315);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('MASTERCELL',	'HQQxFrwp2e8pmmruCNvUCzjEixzHnFHYsTkY03SDuDk=',	true,	316);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Karla',	'U7lusSpb+wLBsRQMrf3w3vKSLyH/N8ExrLPUmtGNXXw=',	true,	317);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maricela',	'avE9HwaSGDXy717FUzSRIN/gRfPGH9pzQ19CztrnEVY=',	true,	318);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Rubi',	'CYzE0slDkevrsb+yeAwJqcEA36Di2pvbkmDZTTgEgZY=',	true,	319);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Virginia',	'T01Ddna/eYRHYAEVHYj666tLyAnHN4DQ44XrnCBoXZs=',	true,	320);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angel',	'UfU2NB1hHeS1cbx+tunIjUWoo/l/S+IaCR8MNXOaCT4=',	true,	321);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'h31i05jbaQVVdzK4v7umHPSbdT58i8D+2NzA9Vy4EqA=',	true,	322);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Paola',	'7CmWNGkPZyZmYxr08DLjNBcCq0nhr9JTo7u3Sa3cIg8=',	true,	323);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Abraham',	'Aev2ZPlATtPu1QOCSPM/COaEhCsLrFgMR+kI7w7g7Vc=',	true,	324);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Abigail',	'Hq0347De6STr+OlxY+5QfaDdXkhlcIfIFmlePpiFqho=',	true,	325);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Erik',	'FaRKgldnXcasNhEGBOaq9K6J36DndRlTKb50GYjCeis=',	true,	326);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Amalia',	'rHBcCTB97OCo+8SJ3wvHtNB+jcjo82S9/SARK1eduN8=',	true,	327);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Axel',	'rah8AOdNHMIJ7NVVBuLfzIZdLFtkJM7fkjuNfh3EyxM=',	true,	328);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hortencia',	'8Ru7kyxSr70YKOj7ppe/iBwV+7716MJBBl3p6VYh+Ss=',	true,	329);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ofelia',	'4WKtjiHgVBwDBjrb83baY3ao2feAioSDONaDcmNIXhs=',	true,	330);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mary',	'x4fHl6LHfzq0DEwFgUQ58qJNJ7czpYYw5FEf9hQZvFQ=',	true,	331);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ana',	'mLhXXD/56eQ3Je/gC613Tlgqja/tq49UCbgYGUXJ6F4=',	true,	332);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alfredo',	'3LcW/hSZ2MxT63+jXfO7ZHnwHCSAWMjfkt+/kTQcaY0=',	true,	333);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gonzalo',	'uBsJ7p/cHXSDQzhvpXJGXmSmrxxIzSSKYZTMw7in89c=',	true,	334);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Gerardo',	'cJDmnlcv0hRPCAOoDpMR767euyCjIjG94cILdaNaf6c=',	true,	335);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cristian',	'5qYxJFZaqo4G+TIWxUEiCK/7JzyHTH68XWXLo9s9xRk=',	true,	336);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'ynqLePiEy0whGIFH8EnVEHS8YjKrRpJzsxj/vs8zVPM=',	true,	337);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'NzI1XSInYU81yd8rgiZyB1wHt0nFLsKtOGq38iOIm5E=',	true,	338);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'Hz+nzgei5hPfyR2yvEvUtjonD32KuggH7pqhaPNJFI0=',	true,	339);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jazmin',	'JHX0YxtB82gW68g+9AmCEXeNZiezWUb/VYjyxVj+SxM=',	true,	340);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Obdulia',	'7JSISvVhi8ahOrH548q8AfjXG22rQw81/iT2MHIC31w=',	true,	341);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Virginia',	'SipSxfs/S6MtLGoVhjU4xfyVpsp3U/jg50759k7rgrs=',	true,	342);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Evelin',	'X5Rpcj1s+00MR7/6piUhY76irmAGUf8xT1xKSJkH+Q4=',	true,	343);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Michell',	'6MN09jwGpHru7Gu3bA+2/p3o99S68S5O9mYF2zX1Isk=',	true,	344);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guadalupe',	'FSazTr3uAbbizQXkDl6wmTyQ6KTsr6nLuOGaKJEEI8M=',	true,	345);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'+8IIvaFy0U2YDggYLni4hWdcuVoS5Pw+yPC7nG2ScUI=',	true,	346);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Erick',	'0wT71hjM5zJtXNHaSPYomv96HMlkhwvpUp3nGiIzWV4=',	true,	347);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Felipe',	'WELzZ2ncAowcWkg0lu0Y5UIHMy+jyPXYXGDFAvNCz7I=',	true,	348);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Aura',	'azkD0tR41J7ocApfkbhxpaSZJ6LB4s1wnKEliAdPTYU=',	true,	349);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Andrea',	'UuoYaSjh2ZLQpu8ru1hDtXuhm+f40F4fR46S3kAvWZE=',	true,	350);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'fI2N2Zmvn9UJSiRYJH0VjQtqDjPn/fFmrZKkzwGzUk8=',	true,	351);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alberto',	'BXYwX0CT3mqRy7djqhd2XLFLW3MdW65AGTM/QgwOjrI=',	true,	352);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'CXiXZLat1tsCrY+1QbDFFZ/dC2wiHotxrscRH7OLk04=',	true,	353);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'fkgUwus/mmR8LrYLv71xKTuWRlMD6uPZMUskUKkKLUY=',	true,	354);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	't4PsEz5UizpXrRO1bIkWv3UlS5MkNgkipEH62p8RqcA=',	true,	355);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'3lwyb4uYhfWaXpMTfoZrORv+X2glrGWzzEFQpI0dopA=',	true,	356);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Adrian',	'xxxPeh5bxL0/B5+jxeRydUL7T9fr465nq6hF0SM/1ms=',	true,	357);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Javier',	'aXAatTG4vY6887UIRO2v4dbUYlgZPYMc0eunwPD/hwc=',	true,	358);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Valentin',	'L7UsuSWGT0FihzJLWpIbO+ljTQXCloS7rYqJba7F3lg=',	true,	359);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jorge',	'5legNU9+1wg/lY8hVydFOeX9krBlhSmTDVoNf+v6pRA=',	true,	360);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('German',	'C2zx4yRNO05TvKb/jHZbmFHo/no74/S7uU14eWc1wRU=',	true,	361);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Raul',	'c7MV5uDwqh4hI3BoOQkYBjmZ6ZdMHfQ6qgiaeRZINZ4=',	true,	362);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'Z2RZ6xoaAugwudHGpbe5U41Qo1ICg+SsAYnIGf/qbIE=',	true,	363);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Berenice',	'/qhwgaSf6t2rvequ723JQr5ncvTPdpwu6jUZ5vF/Nm0=',	true,	364);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mario',	'KMKDJC4HV6OYbtsrtPHrNZUPLrONbLcZMkEhkp/iShE=',	true,	365);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('David',	'u6DeTLM/7D4sWzwZyle6dVwVChMqvK5y83bmml7h2JE=',	true,	366);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Elizabeth',	'/ZQQLeq3np1FsRInLQin9+1WCSyMkBnEsCQXal8Nun8=',	true,	367);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ismael',	'WU6xmhkDqMbyu8eySu2/sCcaC6rV9qvX3Vh0ofG4qlM=',	true,	368);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'YeECv59eJijbXNfBUbiQbXuShruIZPz8MkqU981Fa3g=',	true,	369);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'GAg4D0vOMUrDctInT2OGaAuWTALeFcO0LYI4SIcHPxk=',	true,	370);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'DJOHfrRJmhav6Rrz1FE3LP/8ycwep6qwXGVn+7b+E9U=',	true,	371);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alexander',	'7iNZz5Mr2X1sipfkZq55pBH2HTEyROdilFRUBRNev8c=',	true,	372);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Saul',	'dkcK3QW6VQa8IqhVYiIP4KhIlRxNyh9CDqyS2ob1d7A=',	true,	373);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Joaquin',	'OOSxaHUTQM0BThPuostqiXPCsEw2zvqIffqhkGvAGBg=',	true,	374);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Norma',	'NLS94fUfs2AJxFxRk9Rth16mZSinG1MkYLyH+QM9Wvs=',	true,	375);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Griselda',	'psftTkVC3NX3GpM2wlK0SMHCj1R055GXYiNrl7Iin54=',	true,	376);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maricela',	'NWiydpe3tMUQNtzbCIzJXCpvpsGSNtIXztVntbeDDOc=',	true,	377);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'oOJC8NpKyl2kkfQcM6wlieA0VvXqv8uMNEH1P7w7tD4=',	true,	378);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Astrid',	'tzFLY5SEFstCbjoPR1ai5cET8MstpTinerkKX9T/JUs=',	true,	379);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Flavio',	'qaCuOPb9McRupuU/tG+qPUjygUzEq8M+4A6XjmiLKNE=',	true,	380);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'7VROIUk9S224BWxJTYAmj/mdB/0vQZflNjCbpphCMR8=',	true,	381);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Oseas',	'odibE9FYIcbRPPAQczSjyMUIJr8i9Y9OYhFIJMiEvpo=',	true,	382);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Arturo',	'mPKjTFMrA4R232x9Q5wpY08vQ72uEjhXNkNZQ7HAPZo=',	true,	383);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angel',	'b18UK+8VCizx21tgzRZSq/beemk05GttmYwKqZgqc6M=',	true,	384);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Emma',	'bKHngD9rtaHyQL8+aL0RdxzvM/vAYzwl8UBexnkaZh8=',	true,	385);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cristian',	'qV6oii4wLzckdw++RGDpXqQ8fzfn2YXDldxC8TGB/Lg=',	true,	386);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maribel',	'drZG9t0S4Qlb6VRow6GXIxkcxf5m1VrQg1WUnbHX+xA=',	true,	387);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alejandra',	'aPXKWtpfPTeB3xadlA5Lkn3BWQuXMf9/W0jYk5/RrLg=',	true,	388);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Estrella',	'fnkPTLvUKsnGXKjmO0fs7xT5c/Xw0Xpi0Eh6zZMdi5U=',	true,	389);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alan',	'dvpf8KVBiPoL3iRX5hdMVkrN0MdXxlO/9ofkv01zuo0=',	true,	390);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juana',	'qVzJs/MVG+OW/kwNUPwvaU2YZkEPf894v3WhaOL8w6E=',	true,	391);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ruth',	'E9YNMHPEjngAuT/lRSXRaTI7sBs30gjPcG4qMMedDlI=',	true,	392);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'kOJPwX/piwh5KRYZKLf92KOZjug6lxZ6hdqJt/27qJU=',	true,	393);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Nancy',	'IgV18W6aTRY7UIcgXrPhZF4uAJBxGs2sy/b1uD2vhYk=',	true,	394);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carmen',	'y7uFguoyXC5v8IOE3wouce4XPDzz/mhaQAC804BXLnM=',	true,	395);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marco',	'euiwD9WkyowtAsOo4YQWzFA2FaMU++OdI6MHPpOw9d0=',	true,	396);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Teresa',	'vzGq10X9khAlN1jYS5u4Ke4E9OltjE5ApL/HPgP/pyc=',	true,	397);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Artuto',	'xfAvBM0yRxWvKTq9rlsafAJZkS0E512syo5G5Ask/Ag=',	true,	398);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Yanciry',	'jP7DrhdFj20sXdD2Vv7uDubDFZZ1KVU3sIcLtyMtjc0=',	true,	399);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Luis',	'YOrODOgdOJ2zNVNriFqBS/QR8M4JYeuXYMLBR6B4NOw=',	true,	400);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Andres',	'zjvsEECVTF7uhR4ePbGbkqLygzhmEFX0DaHGFN351tc=',	true,	401);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alejandro',	'6falWmCdC4an1UZPZcmZQyjcn5hgmxzY4Ij3xg2wvEE=',	true,	402);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Laura',	'8v74c3Fck0niMm48s3Yzf31xzAQlu0A+s4jITqrGpZw=',	true,	403);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angel',	'oQbYLU1sNHWPNmfd5Rp2sZ9PTialPopmSRH1ktTzatk=',	true,	404);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Allyn',	'4baIWAuJaUHU/3FHHmlY8vZHQXl0T8St/s8Bym9xAVo=',	true,	405);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Victor',	'tjTKkIERf6uvnOdvXRuWX6EsCcEOFAVgD8L8QzRHQIs=',	true,	406);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Roberto',	'hsA3sAwJmUXBGGDeUPgdf/ix4cr849hwsagB0kjVjII=',	true,	407);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('MARLEN',	'uAMeUlbqR2Mcno+Z4upDISzM6pIe78v5TC+375S9hY0=',	true,	408);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Marina',	'lvcvjnULzUSHlAzzcmqbrBAl4iLMeTpYrFQJCOO1VG8=',	true,	409);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('JESUS',	'q9V1nB8FA8Nr5Ual02P8JgkD4yMFy6OaKo8L+VIF5D0=',	true,	410);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('JIMENA',	'k0O73qtttO3NmjCW+3qNhXYfTNzqO+/X+lZMXP71KuQ=',	true,	411);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('IRMA',	'ZbMM2kJPUNceoeCIEVJ0/t6Mc3DpxlhnPJCCY1EVZ9o=',	true,	412);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('CATALINA',	'bfoYn7N/j0lLJEBBNXI0yI/4LxWRbWFhnmb4Us+S1V4=',	true,	413);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('DANIEL',	'quARxQfUmUtqQSFFMZbidOEfasQ+jLOTexevfHpi2tw=',	true,	414);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('RIGOBERTO',	'Zoers4RQHLpHsyIuM2zY0g+G0T3wzKCmIxdR09AHYms=',	true,	415);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('MANUEL',	'i23zmvT2CdhDo+rN+/LRXHK00kDG32/57bURhRQS1xQ=',	true,	416);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('FELIPE',	'HMIWwWsVNBUx+y3nodeyoP1bVK1SI4YBkSHYYxhf0yQ=',	true,	417);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leodegaria',	'LFG+HeNO5NaOB19U8HVUzvLa19/D8/ecDSGyIDrC4Z0=',	true,	418);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('KENYA',	'EAJYJd2uDqEzwNXlPY+W2PyYw0/XYr8/r2SK4PDtb8s=',	true,	419);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('SERGIO',	'oQa7wfLpPF5YoYjLc0Y/LrIP7Jwia20YwvUJD9InbJU=',	true,	420);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('OLGA',	'HKWJY5a+SNbfGLdzEePAMz8ReM9RNVLq5e3zR2OoLt4=',	true,	421);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('HORACIO',	'FRELt84EsOtHy9yMGX8HyAebFepR/mvsCtsw8utR7wk=',	true,	422);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('PIA',	'proNlzJ1Ghn8dZtf/BhIqWXX2vky2g7qiOCmzDVdk4E=',	true,	423);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hector',	'6mXnxf7cIa3kWuORdafrKloG8NBmaadsqtmpG+jfWdM=',	true,	424);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('FERNANDO',	'2oOTTOXBN0WZnykxKEssGgKh3BSN9Y8WekR2CTocbVw=',	true,	425);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('ISMAEL',	'FKDUkRY+A/v12R5DDQoFdidEyOjGFRm3lKCrsCSc8UI=',	true,	426);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('ANGEL',	'fRYb79tdoil4UgJ4xL3hvPe8oIHf/Lv8dwL93IWfFh0=',	true,	427);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Claudia',	'j1vpsHbCxztNLxKT8eSpaYX0vhyoRIge//SjdQLJFG4=',	true,	428);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('MARIA',	'kwgap4CKb/PsygG0cQ3hyZLbAsTtZXAtbMccursifeM=',	true,	429);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Josue',	'XMrWWJb4c4XLGoZXg1J1ZkIvbW1lJrpjaXbvHqI0IL4=',	true,	430);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Bertha',	'gMLM+Y0Sn8LMHcHb++10oluPLfUvQacs5cE7flb4CT4=',	true,	431);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'miG7vstuctP+zM6X4CWa47xu6iBZ6ibbAyxcmN6qpzw=',	true,	432);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Isaac',	'YcQmpZxN8vGsrEXQZ+JmY8LQnjJfu7a2gPofJBqJvQI=',	true,	433);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Yesica',	'sOc7ErGAtW1DxMk0TKcourEzWLlHiR4yEwalUJuH3sY=',	true,	434);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cristina',	'KzUf3xi6cGxjZvy/XYQ3Rw1HYlb2uTxig4neKJ5qfZk=',	true,	435);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hector',	'tOXlBtbOFTjBiLnHedG8edA6hSC2gZoregWJmFjxCw4=',	true,	436);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jose',	'Yz4feuZWy93MaUCd7TE0aKVgv7nBZQRV03MHvk5lie4=',	true,	437);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Carlos',	'URKSXzMO6yYDv73ZOKHx/FI0kbD+AVdpO0YBf1U5Cj0=',	true,	438);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'THVlJFW/E/Gk8tyeEPi5oNK9Arad2dndsyuNhUqfEsI=',	true,	439);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Agripina',	'LO6qsaauAYgpfjeQbVTf6HWl+Mx8fU1Rk74Les6Z0WI=',	true,	440);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mario',	'a/eew0zNmJuHeSGnT1z3FlkfjJytil7H41I7DDuOZGQ=',	true,	441);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Eduardo',	'DhKcvbQfb4wl2CdthtIywI70Vm39fi763L4Tqsc/JB0=',	true,	442);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guadalupe',	'Ba65ivN5N8SbDh5WzHY+89qavWrXwSkQ32+xySJn3Bc=',	true,	443);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jorge',	'OOAC+9j6dsNvGyhmws5YzhUPp8lfATYlOnhEApclUrE=',	true,	444);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'1BD82KsM+ZbINPMxv4FLYSOfJO1E7k98RVnKI4qEJWs=',	true,	445);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Adriana',	'agNpamINdYcCMOQnO3PY7ljzjZAGN0Fcl6JfmiaQ7fM=',	true,	446);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Analine',	'ppb7b3R/quzMm6JVOdeKtPkxNFoF662tH7CX3491/14=',	true,	447);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Blanca',	'hQLLaOdInv4MXjVwqv6vdq2CUdJKOEQYXWwNEMsJwTA=',	true,	448);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Manuel',	'GFwdOPECK1JN7Q43dq9OTrizIng3blUPJC2HGE1gjJU=',	true,	449);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Leonardo',	'nW8Gn/uggLsD2r8NyaockQxRBJo02zSHSfDjQ2kSjfQ=',	true,	450);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'NpL2OA4tSQz7v84uUA2ZRadd/lYTleuKB7QcCgKD2uc=',	true,	451);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Rafael',	'VYlkLyoF08xcHnX05d/CgGPaZ9VTK+JykXNjJU55Vsc=',	true,	452);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Victor',	'u9tiCknM+fn8bC/P+vW5jcPzVfJqq8EB5HjEl6YY/d8=',	true,	453);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ramona',	'09+y0xNlHghn/6ufNeNWLCY+ti6hHZftJ46ZK+Yn8iA=',	true,	454);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Manuel',	'V5sFBRV6N6XYKJH05I5mEwpOB0QS2E9EpbIA+imNAL4=',	true,	455);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'sXl0EC3ALqFv07rd/3z571UxQOsNYDRnUV2J9PY+NPA=',	true,	456);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Hector',	'E/nkbnM5iaHn4Nx3YVFX9bRrbybTsZ8pfsVPAn7NmPE=',	true,	457);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Isabel',	'V9yma88tLiL0r1BxqgS0iijUjWewM2hnxvy7zXGRpko=',	true,	458);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Mirna',	'rbf8DSJ8npRWmLrrVeacZRWpHkgRJR4IYpZIn2GTUrg=',	true,	459);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Cirila',	'IiwDpGNROLfx3E68kI5c3xiea3kXq9lHrDk5wWJR2XE=',	true,	460);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Albaro',	'Bl4p3S/Ta8bB5BqwNwFdhpUw7DJAaJkQMRx7/ANTmZA=',	true,	461);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'xOHPJAMumkFHbVoiY2KIL2IC76Fq9Is6UI2A6MyosRo=',	true,	462);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Juan',	'X0ZFwBM7EscfnAn6aXm0yFcW+kfxcPhI/N1PwrhEieY=',	true,	463);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jazmin',	'5dxIXKSbjbC2srI1Y4/eFlZDJfI+8ZTdYXkGBKY2U3c=',	true,	464);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guillermo',	'5X46PTkGMw1RxFs5VC60wOs04oOQVJvd3yHgfNcSZWQ=',	true,	465);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Alexis',	'Xds/KLx29KWBoSEJTs6iX21hNE0Qkb2qazgrdCuxTDA=',	true,	466);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Ricardo',	'vEmanEj1CHkvRfFvMpqmEb2Mfc9D0R/gh/sS6Nh8i84=',	true,	467);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Edit',	'x2ilT1ZpoWOKTiLIyLjD4mdDSzkEylebeq2dE68Kop8=',	true,	468);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Elizabeth',	'HQCNKmQu4zV253qR6yaiM9SFXeuXGDXn5JuiEWpO1Dg=',	true,	469);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'6iOayfEH4YVhcL5bzIKSUVzrjyzJze/X9g5FzXqaMtI=',	true,	470);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Antonio',	'JHZlASrZdnnd05rVOf0ORiGOlQaM9s3QeA8BsPiJle0=',	true,	471);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Adonay',	'Yzb9cdA6aPqL0HpdbsjXa1Yvvt/GotDV6tDsUf2PKmU=',	true,	472);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Teresa',	'ZzQ1GNPSXx1xZsLhwR0YPgj0o/+tSZhnCXJO6GR5Q7s=',	true,	473);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'828a6VGI7ikr6E+qW1iTlpV5QKCd+qnntqI9y1Q38sc=',	true,	474);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Angel',	'DEr+Cla0F/iQVXxq9JbmxAKNSB3X7Z4u212pjH1t0tk=',	true,	475);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'YftYvtLNFy+6aS0th5zBYkZNLIptCp3aPiCyQ4fmsWE=',	true,	476);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Miguel',	'rFB+a5WdJL/R2yfyx2adqr8vZEUoQ6u5rUDH97gVY3w=',	true,	477);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Oswaldo',	'6oMgdEz2R8pYHQy8ibjEzHarqfTwZK2Hm27JrgUzVJ4=',	true,	478);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guadalupe',	'omy678WwwqkJbIYp/yGg4+5S61tnZkrxSuw7SqO1JBc=',	true,	479);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Arturo',	'1AgPb5ggSekIumqI5sNWJrButz7Qh0sZ2JgSuYgZkNk=',	true,	480);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Fabio',	'77+q8FUsIYAHpk1QoiuQ4zVaN503T6Fc/AoY1EUn130=',	true,	481);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Guadalupe',	'/iFS+U7L1vIwV0ic1Y9NAujBwVj8wCnuy8EQsqM54LM=',	true,	482);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Jesus',	'bbAygUEOjynFX2m6LEtwcS38AF/0UxVHEMB6rqQa4ik=',	true,	483);
INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id) VALUES('Maria',	'2qa9ulAdNw9S6znbZc51u2Lz3ayYdEn5U1eOMr69CAk=',	true,	484);

CREATE TABLE registro_login
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	fecha DATETIME NOT NULL,
    cliente_id INT UNSIGNED NOT NULL REFERENCES cliente.id ON UPDATE CASCADE
);

CREATE TABLE carrier
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL,
    activo bool not null
);

INSERT INTO carrier(nombre, activo) VALUES ('TELCEL', true);
INSERT INTO carrier(nombre, activo) VALUES ('SERVICIOS TELCEL', true);
INSERT INTO carrier(nombre, activo) VALUES ('MOVISTAR', true);
INSERT INTO carrier(nombre, activo) VALUES ('AT&T', true);
INSERT INTO carrier(nombre, activo) VALUES ('UNEFON', true);
INSERT INTO carrier(nombre, activo) VALUES ('ALÓ', true);
INSERT INTO carrier(nombre, activo) VALUES ('VIRGIN', true);
INSERT INTO carrier(nombre, activo) VALUES ('TEST', true);

CREATE TABLE empresa_carrier
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	empresa_id INT UNSIGNED NOT NULL REFERENCES empresa.id ON UPDATE CASCADE,
    carrier_id INT UNSIGNED NOT NULL REFERENCES carrier.id ON UPDATE CASCADE
);

INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 1);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 2);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 3);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 4);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 5);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 8);

CREATE TABLE recarga_carrier
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	monto INT UNSIGNED NOT NULL,
    empresa_id INT UNSIGNED NOT NULL REFERENCES empresa.id ON UPDATE CASCADE,
    carrier_id INT UNSIGNED NOT NULL REFERENCES carrier.id ON UPDATE CASCADE
);

CREATE TABLE numero
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	folio VARCHAR(30) NOT NULL,
    digitos VARCHAR(10) NOT NULL,
	fecha DATETIME NOT NULL,
    monto INT UNSIGNED NOT NULL,
    carrier_id INT UNSIGNED NOT NULL REFERENCES carrier.id ON UPDATE CASCADE,
    cliente_id INT UNSIGNED NOT NULL REFERENCES cliente.id ON UPDATE CASCADE
    
);

CREATE TABLE activado
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	cantidad INT UNSIGNED NOT NULL,
    folio VARCHAR(50) NOT NULL,
    idRecargas VARCHAR(50)NOT NULL,
	fecha DATETIME NOT NULL,
    estado BOOL NOT NULL,
    numero_id INT UNSIGNED NOT NULL REFERENCES numero.id ON UPDATE CASCADE
);

CREATE TABLE notificaciones
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	email VARCHAR(50) NOT NULL,
    activo BOOL NOT NULL,
    empresa_id INT UNSIGNED NOT NULL REFERENCES empresa.id ON UPDATE CASCADE
);

INSERT INTO notificaciones(email, activo, empresa_id) VALUES ('javier.serrano@marquesadacelular.com', true, 1);

CREATE TABLE alerta_notificaciones
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	activo BOOL NOT NULL,
    notificaciones_id INT UNSIGNED NOT NULL REFERENCES notificaciones.id ON UPDATE CASCADE
);

INSERT INTO alerta_notificaciones(activo, notificaciones_id) VALUES (true, 1);

CREATE TABLE punto_venta
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	tipo VARCHAR(30) NOT NULL,
    activo BOOL NOT NULL,
    empresa_id INT UNSIGNED NOT NULL REFERENCES empresa.id ON UPDATE CASCADE
);

INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('R0', true, 1);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('R1', true, 1);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('R2', true, 1);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('R3', true, 1);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('Zaragoza', true, 2);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('Juarez', true, 2);

CREATE TABLE clave_cliente
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	numero VARCHAR(10) NOT NULL,
    activo BOOL NOT NULL,
    cliente_id INT UNSIGNED NOT NULL REFERENCES cliente.id ON UPDATE CASCADE,
    puntoventa_id INT UNSIGNED NOT NULL REFERENCES punto_venta.id ON UPDATE CASCADE
);

INSERT INTO clave_cliente VALUES (1,'001',1,1,1),
(2,'002',1,2,1),
(3,'003',1,3,1),
(4,'004',1,4,1),
(5,'005',1,5,1),
(6,'006',1,6,1),
(7,'007',1,7,1),
(8,'008',1,8,1),
(9,'009',1,9,1),
(10,'010',1,10,1),
(11,'011',1,11,1),
(12,'001',1,12,2),
(13,'002',1,13,2),
(14,'003',1,14,2),
(15,'004',1,15,2),
(16,'005',1,16,2),
(17,'006',1,17,2),
(18,'007',1,18,2),
(19,'008',1,19,2),
(20,'009',1,20,2),
(21,'010',1,21,2),
(22,'011',1,22,2),
(23,'012',1,23,2),
(24,'013',1,24,2),
(25,'014',1,25,2),
(26,'015',1,26,2),
(27,'016',1,27,2),
(28,'017',1,28,2),
(29,'018',1,29,2),
(30,'019',1,30,2),
(31,'020',1,31,2),
(32,'021',1,32,2),
(33,'022',1,33,2),
(34,'023',1,34,2),
(35,'024',1,35,2),
(36,'025',1,36,2),
(37,'026',1,37,2),(38,'027',1,38,2),(39,'028',0,39,2),(40,'029',1,40,2),(41,'030',1,41,2),(42,'031',1,42,2),(43,'032',1,43,2),
(44,'033',0,44,2),(45,'034',1,45,2),(46,'035',1,46,2),(47,'036',1,47,2),(48,'037',1,48,2),(49,'038',1,49,2),(50,'039',1,50,2),(51,'040',1,51,2),(52,'041',1,52,2),(53,'042',1,53,2),(54,'043',1,54,2),
(55,'044',0,55,2),(56,'045',1,56,2),(57,'046',1,57,2),(58,'047',1,58,2),(59,'048',1,59,2),(60,'049',1,60,2),(61,'050',1,61,2),(62,'051',1,62,2),(63,'052',1,63,2),(64,'053',1,64,2),(65,'054',1,65,2),
(66,'055',1,66,2),(67,'056',1,67,2),(68,'057',1,68,2),(69,'058',1,69,2),(70,'059',1,70,2),(71,'060',1,71,2),(72,'061',1,72,2),(73,'062',1,73,2),(74,'063',1,74,2),(75,'064',1,75,2),(76,'065',1,76,2),
(77,'066',1,77,2),(78,'067',1,78,2),(79,'068',1,79,2),(80,'069',1,80,2),(81,'070',1,81,2),(82,'071',0,82,2),(83,'072',0,83,2),(84,'073',1,84,2),(85,'074',1,85,2),(86,'075',1,86,2),(87,'076',1,87,2),
(88,'077',1,88,2),(89,'078',1,89,2),(90,'079',1,90,2),(91,'080',0,91,2),(92,'081',1,92,2),(93,'082',1,93,2),(94,'083',0,94,2),(95,'084',0,95,2),(96,'085',1,96,2),(97,'086',1,97,2),(98,'087',0,98,2),
(99,'088',1,99,2),(100,'089',1,100,2),(101,'090',1,101,2),(102,'091',0,102,2),(103,'092',0,103,2),(104,'093',1,104,2),(105,'094',0,105,2),(106,'095',0,106,2),(107,'096',1,107,2),(108,'097',0,108,2),
(109,'098',1,109,2),(110,'099',1,110,2),(111,'100',1,111,2),(112,'101',1,112,2),(113,'102',0,113,2),(114,'103',0,114,2),(115,'104',0,115,2),(116,'105',0,116,2),(117,'106',0,117,2),(118,'107',0,118,2),
(119,'108',0,119,2),(120,'109',1,120,2),(121,'110',0,121,2),(122,'111',0,122,2),(123,'112',0,123,2),(124,'113',0,124,2),(125,'114',1,125,2),(126,'115',0,126,2),(127,'116',1,127,2),(128,'117',1,128,2),
(129,'118',0,129,2),(130,'119',1,130,2),(131,'120',1,131,2),(132,'121',1,132,2),(133,'122',0,133,2),(134,'123',0,134,2),(135,'124',1,135,2),(136,'125',0,136,2),(137,'126',1,137,2),(138,'127',0,138,2),
(139,'128',0,139,2),(140,'129',1,140,2),(141,'130',0,141,2),(142,'131',0,142,2),(143,'132',1,143,2),(144,'133',1,144,2),(145,'134',0,145,2),(146,'135',0,146,2),(147,'136',0,147,2),(148,'137',1,148,2),
(149,'138',1,149,2),(150,'139',1,150,2),(151,'140',1,151,2),(152,'141',1,152,2),(153,'142',1,153,2),(154,'143',1,154,2),(155,'144',0,155,2),(156,'145',1,156,2),(157,'146',1,157,2),(158,'147',1,158,2),
(159,'148',1,159,2),(160,'149',1,160,2),(161,'150',1,161,2),(162,'151',1,162,2),(163,'152',1,163,2),(164,'153',1,164,2),(165,'154',1,165,2),(166,'155',0,166,2),(167,'156',0,167,2),(168,'157',1,168,2),
(169,'158',1,169,2),(170,'159',1,170,2),(171,'160',1,171,2),(172,'161',1,172,2),(173,'162',1,173,2),(174,'001',1,174,3),(175,'002',1,175,3),(176,'003',1,176,3),(177,'004',1,177,3),(178,'005',1,178,3),
(179,'006',1,179,3),(180,'007',1,180,3),(181,'008',1,181,3),(182,'009',1,182,3),(183,'010',1,183,3),(184,'011',1,184,3),(185,'012',1,185,3),(186,'013',1,186,3),(187,'014',1,187,3),(188,'015',1,188,3),
(189,'016',0,189,3),(190,'017',1,190,3),(191,'018',1,191,3),(192,'019',1,192,3),(193,'020',1,193,3),(194,'021',1,194,3),(195,'022',1,195,3),(196,'023',1,196,3),(197,'024',1,197,3),(198,'025',1,198,3),
(199,'026',1,199,3),(200,'027',1,200,3),(201,'028',1,201,3),(202,'029',1,202,3),(203,'030',1,203,3),(204,'031',1,204,3),(205,'032',1,205,3),(206,'033',1,206,3),(207,'034',1,207,3),(208,'035',1,208,3),
(209,'036',1,209,3),(210,'037',1,210,3),(211,'038',1,211,3),(212,'039',1,212,3),(213,'040',1,213,3),(214,'041',1,214,3),(215,'042',1,215,3),(216,'043',1,216,3),(217,'044',0,217,3),(218,'045',0,218,3),
(219,'046',1,219,3),(220,'047',1,220,3),(221,'048',0,221,3),(222,'049',1,222,3),(223,'050',1,223,3),(224,'051',1,224,3),(225,'052',1,225,3),(226,'053',0,226,3),(227,'054',1,227,3),(228,'055',1,228,3),
(229,'056',1,229,3),(230,'057',1,230,3),(231,'058',1,231,3),(232,'059',1,232,3),(233,'060',1,233,3),(234,'061',0,234,3),(235,'062',1,235,3),(236,'063',1,236,3),(237,'064',1,237,3),(238,'065',1,238,3),
(239,'066',0,239,3),(240,'067',0,240,3),(241,'068',1,241,3),(242,'069',0,242,3),(243,'070',1,243,3),(244,'071',0,244,3),(245,'072',1,245,3),(246,'073',1,246,3),(247,'074',1,247,3),(248,'075',0,248,3),
(249,'076',1,249,3),(250,'077',1,250,3),(251,'078',1,251,3),(252,'079',0,252,3),(253,'080',1,253,3),(254,'081',1,254,3),(255,'082',0,255,3),(256,'083',1,256,3),(257,'084',1,257,3),(258,'085',1,258,3),
(259,'086',1,259,3),(260,'087',1,260,3),(261,'088',1,261,3),(262,'089',1,262,3),(263,'090',1,263,3),(264,'001',1,264,4),(265,'002',1,265,4),(266,'003',1,266,4),(267,'004',1,267,4),(268,'005',1,268,4),
(269,'006',1,269,4),(270,'007',1,270,4),(271,'008',1,271,4),(272,'009',1,272,4),(273,'010',1,273,4),(274,'011',1,274,4),(275,'012',1,275,4),(276,'013',1,276,4),(277,'014',1,277,4),(278,'015',1,278,4),
(279,'016',1,279,4),(280,'017',1,280,4),(281,'018',1,281,4),(282,'019',1,282,4),(283,'020',1,283,4),(284,'021',1,284,4),(285,'022',1,285,4),(286,'023',1,286,4),(287,'024',1,287,4),(288,'025',1,288,4),
(289,'026',1,289,4),(290,'027',1,290,4),(291,'028',1,291,4),(292,'029',1,292,4),(293,'030',1,293,4),(294,'031',1,294,4),(295,'032',1,295,4),(296,'033',1,296,4),(297,'034',1,297,4),(298,'035',1,298,4),
(299,'036',1,299,4),(300,'037',1,300,4),(301,'038',1,301,4),(302,'039',1,302,4),(303,'040',1,303,4),(304,'041',1,304,4),(305,'042',1,305,4),(306,'043',1,306,4),(307,'044',1,307,4),(308,'045',1,308,4),
(309,'046',1,309,4),(310,'047',1,310,4),(311,'048',1,311,4),(312,'049',1,312,4),(313,'050',1,313,4),(314,'051',1,314,4),(315,'052',1,315,4),(316,'053',1,316,4),(317,'054',1,317,4),(318,'055',1,318,4),
(319,'056',1,319,4),(320,'057',1,320,4),(321,'058',1,321,4),(322,'059',1,322,4),(323,'060',1,323,4),(324,'061',1,324,4),(325,'062',1,325,4),(326,'063',1,326,4),(327,'064',1,327,4),(328,'065',1,328,4),
(329,'066',1,329,4),(330,'067',1,330,4),(331,'068',1,331,4),(332,'069',1,332,4),(333,'070',1,333,4),(334,'071',1,334,4),(335,'072',1,335,4),(336,'073',1,336,4),(337,'074',1,337,4),(338,'075',1,338,4),
(339,'076',1,339,4),(340,'077',1,340,4),(341,'078',1,341,4),(342,'079',1,342,4),(343,'080',1,343,4),(344,'081',1,344,4),(345,'082',1,345,4),(346,'083',1,346,4),(347,'084',1,347,4),(348,'085',1,348,4),
(349,'086',1,349,4),(350,'087',1,350,4),(351,'088',1,351,4),(352,'089',1,352,4),(353,'090',1,353,4),(354,'091',1,354,4),(355,'092',1,355,4),(356,'093',1,356,4),(357,'091',1,357,3),(358,'092',1,358,3),
(359,'093',1,359,3),(360,'094',1,360,3),(361,'095',1,361,3),(362,'163',1,362,2),(363,'164',1,363,2),(364,'165',1,364,2),(365,'166',1,365,2),(366,'167',0,366,2),(367,'168',1,367,2),(368,'169',1,368,2),
(369,'170',0,369,2),(370,'171',0,370,2),(371,'172',1,371,2),(372,'173',1,372,2),(373,'174',1,373,2),(374,'175',0,374,2),(375,'176',1,375,2),(376,'177',1,376,2),(377,'178',1,377,2),(378,'179',1,378,2),
(379,'180',1,379,2),(380,'181',1,380,2),(381,'182',1,381,2),(382,'183',1,382,2),(383,'184',1,383,2),(384,'185',1,384,2),(385,'186',1,385,2),(386,'187',1,386,2),(387,'188',1,387,2),(388,'094',1,388,4),
(389,'095',1,389,4),(390,'096',1,390,4),(391,'189',1,391,2),(392,'097',1,392,4),(393,'098',1,393,4),(394,'099',1,394,4),(395,'100',1,395,4),(396,'101',1,396,4),(397,'102',1,397,4),(398,'103',1,398,4),
(399,'104',1,399,4),(400,'105',1,400,4),(401,'106',1,401,4),(402,'107',1,402,4),(403,'108',1,403,4),(404,'109',1,404,4),(405,'110',1,405,4),(406,'111',1,406,4),(407,'190',1,407,2),(408,'191',1,408,2),
(409,'096',1,409,3),(410,'112',1,410,4),(411,'113',1,411,4),(412,'114',1,412,4),(413,'115',1,413,4),(414,'116',1,414,4),(415,'117',1,415,4),(416,'118',1,416,4),(417,'119',1,417,4),(418,'192',1,418,2),
(419,'097',1,419,3),(420,'193',1,420,2),(421,'194',1,421,2),(422,'098',1,422,3),(423,'099',1,423,3),(425,'120',1,425,4),(426,'100',1,426,3),(427,'101',1,427,3),(428,'195',1,428,2),(429,'121',1,429,4),
(430,'196',1,430,2),(431,'197',1,431,2),(432,'198',1,432,2),(433,'122',1,433,4),(434,'123',1,434,4),(435,'199',1,435,2),(436,'102',1,436,3),(437,'103',1,437,3),(438,'104',1,438,3),(439,'200',1,439,2),
(440,'124',1,440,4),(441,'105',1,441,3),(442,'201',1,442,2),(443,'202',1,443,2),(444,'203',1,444,2),(445,'204',1,445,2),(446,'205',1,446,2),(447,'206',1,447,2),(448,'207',1,448,2),(449,'125',1,449,4),
(450,'126',1,450,4),(451,'127',1,451,4),(452,'106',1,452,3),(453,'208',1,453,2),(454,'209',1,454,2),(455,'128',1,455,4),(456,'107',1,456,3),(457,'108',1,457,3),(458,'210',1,458,2),(459,'129',1,459,4),
(460,'211',1,460,2),(461,'212',1,461,2),(462,'213',1,462,2),(463,'130',1,463,4),(464,'131',1,464,4),(465,'214',1,465,2),(466,'215',1,466,2),(467,'132',1,467,4),(468,'109',1,468,3),(469,'133',1,469,4),
(470,'216',1,470,2),(471,'217',1,471,2),(472,'218',1,472,2),(473,'134',1,473,4),(474,'135',1,474,4),(475,'136',1,475,4),(476,'219',1,476,2),(477,'220',1,477,2),(478,'221',1,478,2),(479,'137',1,479,4),
(480,'138',1,480,4),(481,'139',1,481,4),(482,'140',1,482,4),(483,'222',1,483,2),(484,'223',1,484,2),(485,'224',1,485,2);

CREATE TABLE monto_carrier
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	monto INT UNSIGNED NOT NULL,
    carrier_id INT UNSIGNED NOT NULL REFERENCES carrier.id ON UPDATE CASCADE
);

-- Telcel
INSERT INTO monto_carrier(monto,carrier_id)VALUES(10,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(20,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(30,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(50,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(80,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(100,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(150,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(200,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(300,1);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(500,1);
-- Movistar
INSERT INTO monto_carrier(monto,carrier_id)VALUES(10,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(20,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(30,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(40,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(50,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(60,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(70,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(80,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(100,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(120,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(150,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(200,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(250,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(300,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(400,3);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(500,3);
-- Servicios Telcel
INSERT INTO monto_carrier(monto,carrier_id)VALUES(5,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(20,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(30,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(50,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(100,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(150,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(200,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(300,2);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(500,2);
-- ALO
INSERT INTO monto_carrier(monto,carrier_id)VALUES(10,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(20,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(30,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(50,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(100,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(150,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(200,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(300,6);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(500,6);
-- ATT
INSERT INTO monto_carrier(monto,carrier_id)VALUES(10,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(20,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(30,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(50,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(55,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(70,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(100,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(150,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(200,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(300,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(500,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(600,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(800,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(900,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(1000,4);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(1200,4);
-- Virgin
INSERT INTO monto_carrier(monto,carrier_id)VALUES(20,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(30,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(40,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(50,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(100,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(150,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(200,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(300,7);
INSERT INTO monto_carrier(monto,carrier_id)VALUES(500,7);