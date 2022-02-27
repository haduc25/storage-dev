<?php 
echo "1. PHP MySQL Create Table";
/*
-A database table has its own unique name and consists of columns and rows.
*/

//Create a MySQL Table Using MySQLi
echo "<br> Create a MySQL Table Using MySQLi <br>";
/*
-The CREATE TABLE statement is used to create a table in MySQL.
-We will create a table named "MyGuests", with five columns: "id", "firstname", "lastname", "email" and "reg_date":

*Code Example

		CREATE TABLE MyGuests (
		id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
		firstname VARCHAR(30) NOT NULL,
		lastname VARCHAR(30) NOT NULL,
		email VARCHAR(50),
		reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
		)

//Notes on the table above:

-The data type specifies what type of data the column can hold. For a complete reference of all the available data types, go to our Data Types reference.
-After the data type, you can specify other optional attributes for each column:

		+NOT NULL 				- Each row must contain a value for that column, null values are not allowed
		+DEFAULT value 			- Set a default value that is added when no other value is passed
		+UNSIGNED 				- Used for number types, limits the stored data to positive numbers and zero
		+AUTO INCREMENT 		- MySQL automatically increases the value of the field by 1 each time a new record is added
		+PRIMARY KEY 			- Used to uniquely identify the rows in a table. The column with PRIMARY KEY setting is often an ID
								   number, and is often used with AUTO_INCREMENT

-Each table should have a primary key column (in this case: the "id" column). Its value must be unique for each record in the table.
*/

//Example - The following examples shows how to create the table in PHP:

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
/*
$sql = "CREATE TABLE MyGuests (
id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
firstname VARCHAR(30) NOT NULL,
lastname VARCHAR(30) NOT NULL,
email VARCHAR(50),
reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
)";
*/
//sql to create table
$sql = "CREATE TABLE MyGuests (
		
	id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY, /*khoa chinh*/
	firstname VARCHAR(30) NOT NULL,
	lastname VARCHAR(30) NOT NULL,
	email VARCHAR(50), 
	reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
)";
	

if ($conn -> query($sql) == TRUE)
{
	echo "Table MyGuests created succesfully !!!";
}else
{
	echo "Error creating table: ". $conn -> error;
}

$conn -> close();
?>