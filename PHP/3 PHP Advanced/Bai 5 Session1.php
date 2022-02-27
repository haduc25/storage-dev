<?php
//demo_session2.php = Bai 5 Session1.php
session_start();
?>
<!DOCTYPE html>
<html>
<body>
	<?php
	// Echo session variables that were set on previous page
	echo "Favorite color is ".$_SESSION["favColor"]."<br>";
	echo "Favorite animal is ".$_SESSION["favAnimal"];
	?>
</body>
</html>