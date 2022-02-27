<?php
echo "PHP MySQL Delete Data";
echo "<br> -Delete Data From a MySQL Table Using MySQLi <br>";
/*
-The DELETE statement is used to delete records from a table:
		DELETE FROM table_name
		WHERE some_column = some_value

-Notice the WHERE clause in the DELETE syntax: The WHERE clause specifies which record or records that should be deleted. If you omit the WHERE clause, all records will be deleted!

-Let's look at the "MyGuests" table:

		id		firstname		 lastname			 email					 reg_date
		1		John			Doe					john@example.com		2014-10-22 14:26:15
		2		Mary			Moe					mary@example.com		2014-10-23 10:22:30
		3		Julie			Dooley				julie@example.com		2014-10-26 10:48:23
*/

//Example (MySQLi Object-oriented) - The following examples delete the record with id=3 in the "MyGuests" table:

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

$sql = "DELETE FROM MyGuests WHERE id=17";

if($conn->query($sql) == TRUE)
{
	echo "Record deleted successfully !!!";
}else
{
	echo "Error deleting record: " .$conn -> error;
}

$conn -> close();

/*
-After the record is deleted, the table will look like this:

		id		firstname		 lastname			 email					 reg_date
		1		John			Doe					john@example.com		2014-10-22 14:26:15
		2		Mary			Moe					mary@example.com		2014-10-23 10:22:30
*/
?>