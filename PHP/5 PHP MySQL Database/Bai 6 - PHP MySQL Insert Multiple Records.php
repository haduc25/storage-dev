<?php 
echo "PHP MySQL Insert Multiple Records";
echo "<br> -Insert Multiple Records Into MySQL Using MySQLi <br>";
/*
-Multiple SQL statements must be executed with the mysqli_multi_query() function.
-The following examples add three new records to the "MyGuests" table:
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

//insert 3  cai vao database
$sql = "INSERT INTO MyGuests (firstname, lastname, email) VALUES ('Minh', 'Duc', 'minhduc25@example.com');";
$sql .= "INSERT INTO MyGuests (firstname, lastname, email) VALUES ('Minh', 'Duc', 'minhduc25@example.com');";
$sql .= "INSERT INTO MyGuests (firstname, lastname, email) VALUES ('Minh', 'Duc', 'minhduc25@example.com');";

//commit the transaction


if ($conn -> multi_query($sql) == TRUE) 
{
	echo "New records created succesfully !!!";
}else
{
	echo "Error: " .$sql . "<br>" .$conn -> error;
}

$conn -> close();

//Note that each SQL statement must be separated by a semicolon.

?>