<?php 
#1. PHP Include Files
/*
-The include (or require) statement takes all the text/code/markup that exists in the specified file and copies it into the file that uses the include statement.
-Including files is very useful when you want to include the same PHP, HTML, or text on multiple pages of a website.

//PHP include and require Statements
-The include and require statements are identical, except upon failure:
		require 		will produce a fatal error (E_COMPILE_ERROR) and stop the script
		include 		will only produce a warning (E_WARNING) and the script will continue

*Syntax
		include 'filename';

or

		require 'filename';
*/

//PHP include Examples
echo "PHP include Examples <br>";
echo "Example 1 <br>"; ?>

<!DOCTYPE html>
<html>
<body>
	<h1>Welcome to my home page!</h1>
	<p>Ha Minh Duc - 250901</p>
	<p>Cao Ky - Ban Pho - Bac Kan</p>
	<!-- use Include -->
	<?php include 'Bai 2 Footer.php'; ?>
</body>
</html>

<?php 
echo "Example 2 <br>";
?>
<!DOCTYPE html>
<html>
<body>
	<div class="menu">
		<?php include 'Bai 2 Menu.php' ?>
	</div>

	<h1>Welcome to my home page!</h1>
	<p>Ha Minh Duc - 250901</p>
	<p>Cao Ky - Ban Pho - Bac Kan</p>

</body>
</html>

<?php 
echo "Example 3 <br>";
?>

<!DOCTYPE html>
<html>
<body>

	<h1>Welcome my Page!</h1>
	<?php include 'Bai 2 Cars.php';
	echo "I have a $color $car."; ?>
</body>
</html>


<?php 
//PHP include vs. require
echo "<br> PHP include vs. require <br>";
?>

<?php echo "<br>--------------------------------------------<br><br> Include <br><br>"; ?>
<!-- ex include -->
<html>
<body>

<h1>Welcome to my home page!</h1>
<?php include 'noFileExists.php';
echo "I have a $color1 $car1.";
?>

</body>
</html>

<?php echo "<br>--------------------------------------------<br><br> Require <br><br>"; ?>
<!-- ex require -->
<html>
<body>

<h1>Welcome to my home page!</h1>
<?php require 'noFileExists.php';
echo "I have a $color1 $car1.";
?>

</body>
</html>

<?php
/*
-Use require when the file is required by the application.
-Use include when the file is not required and application should continue when file is not found.
*/
?>

