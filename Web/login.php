<!DOCTYPE html>
<html lang="en" class="no-js">
<html>
<head>
    <meta charset="UTF-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
<link rel="stylesheet"  href="css/estilo.css">
    <link rel="stylesheet" href="css/principal.css">
    <title></title>
</head>

<div class = "fondo">
<body>

    <section>
                <div id="container_demo" >
                    <div id="wrapper">
                        <div id="login" class="animateForm">
                            <form  method='post' action="inicioLogin.php" autocomplete="on">
                                <h1><img src="img/atc1.png" alt="" class="titulo">ctivaChip</h1>
                                <p>
                                  <label  for="username" class="uname"> Usuario </label>
                                  <input class="user" id="nick" name="nick" required="required" type="text" placeholder="Usuario:" autofocus/>
                                </p>
                                <p>
                                    <label for="password" class="youpasswd"> Contraseña </label>
                                    <input class="password" id="pass" name="pass" required="required" type="password" placeholder="Contraseña:"/>
                                </p>
                                <p class="loginButto">
                                    <input type="submit" id="loginButton" name="enviar" value="Ingresar" />
                                </p>
                            </form>
                        </div>
                    </div>
                </div>
    </section> 
    <footer>
    <p class="pie">
        Contacto: webmaster.atc.mx@gmail.com<br>
        Copyright© 2017-2018. Morpheus DSS
    </p>
</footer>      
</body>
</div>

</html>
