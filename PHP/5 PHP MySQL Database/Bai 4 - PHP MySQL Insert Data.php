<?php 
echo "1. PHP MySQL Insert Data";
echo "<br> -Insert Data Into MySQL Using MySQLi <br>";
/*
-After a database and a table have been created, we can start adding data in them.

*Here are some syntax rules to follow:
	+The SQL query must be quoted in PHP
	+String values inside the SQL query must be quoted
	+Numeric values must not be quoted
	+The word NULL must not be quoted

-The INSERT INTO statement is used to add new records to a MySQL table:
	
		INSERT INTO table_name (column1, column2, column3,...)
		VALUES (value1, value2, value3,...)

-In the previous chapter we created an empty table named "MyGuests" with five columns: "id", "firstname", "lastname", "email" and "reg_date". Now, let us fill the table with data.

*Note: If a column is AUTO_INCREMENT (like the "id" column) or TIMESTAMP with default update of current_timesamp (like the "reg_date" column), it is no need to be specified in the SQL query; MySQL will automatically add the value.
*/

//Example (MySQLi Object-oriented) - The following examples add a new record to the 'MyGuests' table:

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

$sql = "INSERT INTO MyGuests (firstname, lastname, email) VALUES ('Ha', 'Duc', 'haduc25@gmail.com')";

if ($conn -> query($sql) == TRUE)
{
	echo "New record created succesfully !!!";
}else
{
	echo "Error: " . $sql . "<br>" . $conn -> error;
}

$conn -> close();
?>