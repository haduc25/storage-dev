<?php
echo "PHP MySQL Use The ORDER BY Clause";
echo "<br> -Select and Order Data From a MySQL Database";
/*
-The ORDER BY clause is used to sort the result-set in ascending or descending order.
-The ORDER BY clause sorts the records in ascending order by default. To sort the records in descending order, use the "DESC" keyword.
		SELECT column_name(s) FROM table_name ORDER BY column_name(s) ASC|DESC 
*/

echo "<br> -Select and Order Data With MySQLi <br>";

//Example (MySQLi Object-oriented) - The following example selects the id, firstname and lastname columns from the MyGuests table. The records will be ordered by the lastname column:

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

//oder (sort by lastname)
$sql = "SELECT id, firstname, lastname, email FROM MyGuests ORDER BY lastname";
$result = $conn -> query($sql);

if($result -> num_rows > 0)
{
	//output data of each row
	while ($row = $result -> fetch_assoc())
	{
		echo "<br> id: ". $row["id"] . " -Name: " .$row["firstname"] . " " . $row["lastname"] . " E-mail: " . $row["email"] . "<br>";
	}
}else
{
	echo "0 results";
}

$conn -> close();

/*
*Code lines to explain from the example above:

-First, we set up the SQL query that selects the id, firstname and lastname columns from the MyGuests table. The records will be ordered by the lastname column. The next line of code runs the query and puts the resulting data into a variable called $result.
-Then, the function "num_rows()" checks if there are more than zero rows returned.
-If there are more than zero rows returned, the function "fetch_assoc()" puts all the results into an associative array that we can loop through. The "while()" loop loops through the result set and outputs the data from the id, firstname and lastname columns.
*/
?>