<?php
echo "1. PHP Create a MySQL Database";
/*
-A database consists of one or more tables.
-You will need special CREATE privileges to create or to delete a MySQL database.
*/

//Create a MySQL Database Using MySQLi
echo "<br> Create a MySQL Database Using MySQLi <br>";
/*
-The CREATE DATABASE statement is used to create a database in MySQL.
-The following examples create a database named "myDB":
*/

//Example (MySQLi Object-oriented)


$severname = "localhost";
$usename = "root";
$password = "";
$database = "haduc25";

//Create connection
$conn = new mysqli($severname, $usename, $password, $database);

//Check connnection
if($conn -> connect_error)
{
	die("Connection Failed: " . $conn->connect_error);
}

echo "Connected successfully !!! <br>";
/*
//Create database
$sql = "CREATE DATABASE MyDB";
if($conn->query($sql) == TRUE)
{
	echo "Database created successfully !";
}else
{
	echo "Error creating database: " . $conn->error;
}

//Close database
$conn -> close();
*/
/*
-Note: When you create a new database, you must only specify the first three arguments to the mysqli object (servername, username and password).
-Tip: If you have to use a specific port, add an empty string for the database-name argument, like this: new mysqli("localhost", "username", "password", "", port)
*/
?>