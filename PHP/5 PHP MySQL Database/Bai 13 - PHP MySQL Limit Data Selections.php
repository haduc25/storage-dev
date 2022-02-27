<?php 
echo "PHP MySQL Limit Data Selections";
echo "<br> -Limit Data Selections From a MySQL Database <br>";

/*
-MySQL provides a LIMIT clause that is used to specify the number of records to return.
-The LIMIT clause makes it easy to code multi page results or pagination with SQL, and is very useful on large tables. Returning a large number of records can impact on performance.
-Assume we wish to select all records from 1 - 30 (inclusive) from a table called "Orders". The SQL query would then look like this:
		$sql = "SELECT * FROM Orders LIMIT 30";

-When the SQL query above is run, it will return the first 30 records.
-What if we want to select records 16 - 25 (inclusive)?
-The SQL query below says "return only 10 records, start on record 16 (OFFSET 15)":
		$sql = "SELECT * FROM Orders LIMIT 10 OFFSET 15";

-You could also use a shorter syntax to achieve the same result:
		$sql = "SELECT * FROM Orders LIMIT 15, 10";

*Notice that the numbers are reversed when you use a comma.
*/
//Example:

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

$sql = "SELECT * FROM MyGuests LIMIT 3"; //ex1
//$sql = "SELECT * FROM MyGuests LIMIT 2 OFFSET 5"; //ex2
$result = $conn -> query($sql);

if ($result -> num_rows > 0) 
{
	// output data of each row
	while($row = $result -> fetch_assoc())
	{
		echo "<br> id: ". $row["id"]. " -Name: ". $row['firstname']. " " .$row["lastname"] . "<br>";
	}
}else
{
	echo "0 results";
}

$conn -> close();
?>