<?php 
echo "PHP MySQL Update Data";
echo "<br> -Update Data In a MySQL Table Using MySQLi <br>";

/*
-The UPDATE statement is used to update existing records in a table:
		UPDATE table_name
		SET column1=value, column2=value2,...
		WHERE some_column=some_value 

-Notice the WHERE clause in the UPDATE syntax: The WHERE clause specifies which record or records that should be updated. If you omit the WHERE clause, all records will be updated!

-Let's look at the "MyGuests" table:

		id		firstname		 lastname			 email					 reg_date
		1		John			Doe					john@example.com		2014-10-22 14:26:15
		2		Mary			Moe					mary@example.com		2014-10-23 10:22:30
*/

//Example (MySQLi Object-oriented) - The following examples update the record with id=2 in the "MyGuests" table:

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

//Update
$sql = "UPDATE MyGuests SET lastname = 'Duc25' WHERE id=14";

if($conn -> query($sql) == TRUE)
{
	echo "Record updated successfully !!!";
}else
{
	echo "Error updating record: ".$conn -> error;
}

$conn -> close();

/*
-After the record is updated, the table will look like this:

		id		firstname		 lastname			 email					 reg_date
		1		John			Doe					john@example.com		2014-10-22 14:26:15
		2		Mary			Duc25					mary@example.com		2014-10-23 10:22:30
*/

//Lưu ý: chỉ update dc khi mà có id này trong database
?>