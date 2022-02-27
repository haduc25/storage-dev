<?php 
echo "PHP MySQL Select Data";
echo "<br> -Select Data From a MySQL Database";
/*
-The SELECT statement is used to select data from one or more tables:
		SELECT column_name(s) FROM table_name

-or we can use the * character to select ALL columns from a table:
		SELECT * FROM table_name
*/

echo "<br> -Select Data With MySQLi <br>";
//Example (MySQLi Object-oriented) - The following example selects the id, firstname and lastname columns from the MyGuests table and displays it on the page:

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

//Select data from database
$sql = "SELECT id, firstname, lastname FROM MyGuests";
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

/*
*Code lines to explain from the example above:

-First, we set up an SQL query that selects the id, firstname and lastname columns from the MyGuests table. The next line of code runs the query and puts the resulting data into a variable called $result.
-Then, the function "num_rows()" checks if there are more than zero rows returned.
-If there are more than zero rows returned, the function "fetch_assoc()" puts all the results into an associative array that we can loop through. The "while()" loop loops through the result set and outputs the data from the id, firstname and lastname columns.
*/
?>