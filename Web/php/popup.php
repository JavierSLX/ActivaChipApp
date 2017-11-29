<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Popup centrado en pantalla</title>
<script type="text/javascript">
function popup(url,ancho,alto) {
var posicion_x; 
var posicion_y; 
posicion_x=(screen.width/2)-(ancho/2); 
posicion_y=(screen.height/2)-(alto/2); 
window.open(url, "leonpurpura.com", "width="+ancho+",height="+alto+",menubar=0,toolbar=0,directories=0,scrollbars=no,resizable=no,left="+posicion_x+",top="+posicion_y+"");
}
<script>
function popUp(URL) {
day = new Date();
id = day.getTime();
eval(&quot;page&quot; + id + &quot; = window.open(URL, &#39;&quot; + id + &quot;&#39;, &#39;toolbar=0,scrollbars=0,location=0,statusbar=0,menubar=0,resizable=0,width=600,height=400,left=212,top=184&#39;);&quot;);
}
</script>
</script>
</head>
<body>
<a href="javascript:popup('popup.php',400,300)">abrir</a>
<a href="popup.php" target="_blank" onClick="window.open(this.href, 
this.target, 'width=300, height=400'); return false;">Abrir pop-up.</a>
</body>
</html>