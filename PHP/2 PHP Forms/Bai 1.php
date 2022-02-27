<?php
#1. PHP Form Handling
//PHP - A Simple HTML Form 
//The PHP superglobals $_GET and $_POST are used to collect form-data.
?>
	<!-- POST,GET: su dung de truyen dl, post k gioi han, get gioi han va k use de tryen passwork-->

	<!-- POST-->
<!DOCTYPE html>
<html>
<body>
	<form action="Bai 1 URL.php" method="post">
		Name: <input type="text" name="name"><br>
		E-mail: <input type="text" name="email"><br>
		<input type="submit">
	</form>
</body>
</html>
	
	<!-- GET-->
<!--
<!DOCTYPE html>
<html>
<body>
	<form action="Bai 1 URL.php" method="get">
		Name: <input type="text" name="name"><br>
		E-mail: <input type="text" name="email"><br>
		<input type="submit">
	</form>
</body>
</html>
-->