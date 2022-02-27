<?php 
echo "1. PHP MySQL Get Last Inserted ID";
echo "<br> -Get ID of The Last Inserted Record <br>";
/*
-If we perform an INSERT or UPDATE on a table with an AUTO_INCREMENT field, we can get the ID of the last inserted/updated record immediately.
-In the table "MyGuests", the "id" column is an AUTO_INCREMENT field:

		CREATE TABLE MyGuests (
		id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
		firstname VARCHAR(30) NOT NULL,
		lastname VARCHAR(30) NOT NULL,
		email VARCHAR(50),
		reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
		)

-The following examples are equal to the examples from the previous page (PHP Insert Data Into MySQL), except that we have added one single line of code to retrieve the ID of the last inserted record. We also echo the last inserted ID:
*/


//Example (MySQLi Object-oriented)

$severname = "localhost";
$username = "root";
$password = "";
$database = "MyDB";


//Create connection
$conn = new mysqli($severname, $username, $password, $database);

//Check connection
if($conn -> connect_error)
{
	die("Connection failed: ". $conn->connect_error);	
}
echo "Connected successfully ! <br>";

//Get id
$sql = "INSERT INTO MyGuests (firstname, lastname, email) VALUES ('Nguyen', 'Linh', 'nguyenlinh123@example.com')";

if ($conn -> query($sql) == TRUE)
{
	$last_id = $conn -> insert_id;
	echo "New record created succesfully. Last inserted ID is: " . $last_id;
}else
{
	echo "Error: " .$sql . "<br>" .$conn->error;
}

$conn -> close();
?>