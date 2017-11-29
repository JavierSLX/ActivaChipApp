use recargasatc;

INSERT INTO empresa(nombre, direccion, telefono, activo) VALUES ('ATC', 'Arteaga 32', '4661271818', true);
INSERT INTO empresa(nombre, direccion, telefono, activo) VALUES ('Marquesada', 'Juárez 212', '4612876507', true);

INSERT INTO acceso_empresa(wsdl, usuario, pass, clave_operador, empresa_id) VALUES ('http://test.xtremecard.com.mx:8081/hub/Listener?WSDL', 'MARQUESADA', '123456', 'Ma12', 1);

INSERT INTO administrador(nombre, empresa_id) VALUES ('Javier Serrano', 1);

INSERT INTO permiso_administrador(nickname, pass, activo, administrador_id, permiso_id) VALUES ('javiersl', '1987', true, 1, 4);

INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('R1', true, 1);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('R2', true, 1);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('R3', true, 1);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('Zaragoza', true, 2);
INSERT INTO punto_venta(tipo, activo, empresa_id) VALUES ('Juarez', true, 2);

INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Fidel Paredes', 'Niños Héroes #5', '4661000900', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('María Vázquez', 'M. De la Piedra #31', '4661000901', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Natalia Reyes', 'Morelos #98', '4661000902', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Leidy Anahí', 'Leandro Valle #112', '4661000903', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Filiberto Parédez', 'J. Jesús Montaño #12', '4661000904', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Alfredo Villalón', 'Urrutia #70', '4661000905', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Antonio Murillo', 'San Miguel #26', '4661000906', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('José Luis Morales', '5 de Mayo #8', '4661000907', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Carlos Plancarte', '5 de Mayo #1', '4661000908', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Eduardo', 'Hidalgo #72', '4661000909', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Yolanda Orozco', '12 de Octubre y Abasolo', '4661000913', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Alfonso Chávez', '5 de Mayo', '4661000911', 'S/C', true, 1);
INSERT INTO cliente(nombre, direccion, telefono, email, activo, empresa_id) VALUES ('Maricela Aguilar', 'Fernando Núñez #5', '4661000912', 'S/C', true, 1);

INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('1', true, 1, 1);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('2', true, 2, 1);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('3', true, 3, 1);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('1', true, 4, 2);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('2', true, 5, 2);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('3', true, 6, 2);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('1', true, 7, 3);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('2', true, 8, 3);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('3', true, 9, 3);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('1', true, 10, 4);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('2', true, 11, 4);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('1', true, 12, 5);
INSERT INTO clave_cliente(numero, activo, cliente_id, puntoventa_id) VALUES ('2', true, 13, 5);

INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('fidel', 'zl2Aip4KqgclGDodLnVGNu0YLwc/5iRVeP+Gnb6bnfA=', true, 1);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('maria', 's70PC/RPMq+j/UU2dUow/AWs6zfC92qdRhJXWhMaXjQ=', true, 2);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('natalia', 'hcgOh2j5aR+gD9nkHfc2QeHM/PekHAv//7zQCj4QB9M=', true, 3);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('leidy', 'Yx7v/5wEskadVscUQiK1E+vwegW/pmWEsJjDJBTr7vs=', true, 4);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('filiberto', 'Q5/gMhfqvTJKQshpNG7b3bo6/GiqBxrJki8gA4bAGAA=', true, 5);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('alfredo', 'lfXD2QGGWlOT3s9T/jkOgGs99hh6HEQT6bPnKVgx+bE=', true, 6);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('antonio', 'M3pltbIXGsLuZoqxoRACDve2pK9ElKeO/Tl/pOBOwIY=', true, 7);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('jose', '+W6XQx0PYKEWsc4Lirmx/vLnzI8Pq0LKAZ1Sxcfi7dk=', true, 8);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('carlos', 'yrhSX8dOSU/pHbNz3B9AIu7WKnLCUyTsbAmqDDDFs78=', true, 9);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('eduardo', 'eduardo10', true, 10);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('yolanda', 'yolanda11', true, 11);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('alfonso', 'alfonso12', true, 12);
INSERT INTO permiso_cliente(nickname, pass, activo, cliente_id) VALUES ('maricela', 'maricela13', true, 1);

INSERT INTO carrier(nombre, activo) VALUES ('TELCEL', true);
INSERT INTO carrier(nombre, activo) VALUES ('SERVICIOS TELCEL', true);
INSERT INTO carrier(nombre, activo) VALUES ('MOVISTAR', true);
INSERT INTO carrier(nombre, activo) VALUES ('AT&T', true);
INSERT INTO carrier(nombre, activo) VALUES ('UNEFON', true);
INSERT INTO carrier(nombre, activo) VALUES ('ALÓ', true);
INSERT INTO carrier(nombre, activo) VALUES ('VIRGIN', true);
INSERT INTO carrier(nombre, activo) VALUES ('TEST', true);

INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 1);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 2);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 3);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 4);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (1, 5);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (2, 1);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (2, 2);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (2, 3);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (2, 4);
INSERT INTO empresa_carrier(empresa_id, carrier_id) VALUES (2, 5);

INSERT INTO recarga_carrier(monto, empresa_id, carrier_id) VALUES (50, 1, 1);
INSERT INTO recarga_carrier(monto, empresa_id, carrier_id) VALUES (50, 1, 2);
INSERT INTO recarga_carrier(monto, empresa_id, carrier_id) VALUES (50, 1, 3);
INSERT INTO recarga_carrier(monto, empresa_id, carrier_id) VALUES (50, 1, 4);
INSERT INTO recarga_carrier(monto, empresa_id, carrier_id) VALUES (50, 1, 5);
INSERT INTO recarga_carrier(monto, empresa_id, carrier_id) VALUES (50, 1, 6);
INSERT INTO recarga_carrier(monto, empresa_id, carrier_id) VALUES (50, 1, 7);

INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC002', '4661104295', '2017-07-15', 10, 1, 4);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC003', '4661104296', '2017-10-30', 50, 5, 2); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC004', '4661104297', '2017-11-01', 100, 4, 3); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC005', '4661104298', '2017-09-28', 20, 2, 2); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC006', '4661104299', '2017-06-30', 10, 6, 5);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC007', '4661104284', '2017-11-06', 50, 1, 1);  
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC008', '4661104274', '2017-05-12', 200, 4, 2);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC009', '4661104264', '2017-10-15', 100, 3, 4);   
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC010', '4661104254', '2017-10-21', 500, 2, 6);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC011', '4661114294', '2017-09-26', 50, 1, 7); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC012', '4661124295', '2017-07-17', 10, 1, 8);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC013', '4661134296', '2017-10-24', 20, 2, 4); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC014', '4661144297', '2017-11-06', 100, 3, 3); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC015', '4661154298', '2017-09-22', 200, 2, 9); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC016', '4661164299', '2017-06-27', 500, 5, 2);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC017', '4661174284', '2017-11-08', 10, 6, 10);  
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC018', '4661184274', '2017-05-17', 20, 6, 11);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC019', '4661194264', '2017-10-13', 50, 2, 1);   
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC020', '4661204254', '2017-10-23', 100, 1, 7); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC021', '4661014294', '2017-09-26', 50, 1, 7); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC022', '4661324295', '2017-07-17', 10, 1, 8);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC023', '4661434296', '2017-10-24', 20, 2, 4); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC024', '4661544297', '2017-11-06', 100, 3, 3); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC025', '4661654298', '2017-09-22', 200, 2, 9); 
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC026', '4661764299', '2017-06-27', 500, 5, 2);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC027', '4661874284', '2017-11-08', 10, 6, 10);  
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC028', '4661984274', '2017-05-17', 20, 6, 11);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC029', '4661904264', '2017-10-13', 50, 2, 1);   
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC030', '4661914254', '2017-10-23', 100, 1, 7); 

INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC031', '4661250669', '2017-11-22', 20, 1, 1);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC032', '4661165435', '2017-11-15', 20, 1, 1);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC033', '4661344799', '2017-11-10', 20, 1, 1);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC034', '4661104294', '2017-11-5', 20, 1, 1); 

INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC035', '4661057813', '2017-11-8', 20, 1, 2);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC036', '4661272909', '2017-11-22', 20, 3, 2);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC037', '4661127482', '2017-11-22', 20, 5, 2);
INSERT INTO numero(folio, digitos, fecha, monto, carrier_id, cliente_id) VALUES ('ATC038', '4612649791', '2017-11-19', 20, 4, 2);

INSERT INTO activado(cantidad, folio, idRecargas, fecha, estado, numero_id) VALUES (20, 'R1-002/000001/2017', '000', '2017-09-30', true, 5);
INSERT INTO activado(cantidad, folio, idRecargas, fecha, estado, numero_id) VALUES (10, 'R3-002/000002/2017', '001', '2017-07-25', true, 8);
INSERT INTO activado(cantidad, folio, idRecargas, fecha, estado, numero_id) VALUES (20, 'ZR-002/000003/2017', '002', '2017-05-29', true, 11);
INSERT INTO activado(cantidad, folio, idRecargas, fecha, estado, numero_id) VALUES (100, 'R2-001/000004/2017', '003', '2017-11-01', true, 4);

INSERT INTO notificaciones(email, activo, empresa_id) VALUES ('javier.serrano@marquesadacelular.com', true, 1);
INSERT INTO notificaciones(email, activo, empresa_id) VALUES ('legend87jea@gmail.com', true, 2);

INSERT INTO alerta_notificaciones(activo, notificaciones_id) VALUES (true, 1);
INSERT INTO alerta_notificaciones(activo, notificaciones_id) VALUES (false, 2);