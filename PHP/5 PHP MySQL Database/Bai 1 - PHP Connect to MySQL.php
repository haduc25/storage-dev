<?php 
echo "1. PHP MySQL Database";
/*
-With PHP, you can connect to and manipulate databases.
-MySQL is the most popular database system used with PHP.

//What is MySQL?

	+MySQL is a database system used on the web
	+MySQL is a database system that runs on a server
	+MySQL is ideal for both small and large applications
	+MySQL is very fast, reliable, and easy to use
	+MySQL uses standard SQL
	+MySQL compiles on a number of platforms
	+MySQL is free to download and use
	+MySQL is developed, distributed, and supported by Oracle Corporation
	+MySQL is named after co-founder Monty Widenius's daughter: My

-The data in a MySQL database are stored in tables. A table is a collection of related data, and it consists of columns and rows.
-Databases are useful for storing information categorically. A company may have a database with the following tables:
	+Employees
	+Products
	+Customers
	+Orders
*/

//PHP + MySQL Database System
echo "<br> PHP + MySQL Database System";
/*
-PHP combined with MySQL are cross-platform (you can develop in Windows and serve on a Unix platform)
*/

//Database Queries
echo "<br> Database Queries";
/*
-A query is a question or a request.
-We can query a database for specific information and have a recordset returned.
-Look at the following query (using standard SQL):
	
	SELECT LastName FROM Employees //cau lenh

-The query above selects all the data in the "LastName" column from the "Employees" table.
-To learn more about SQL, please visit our SQL tutorial.
*/

//My Sql local: http://localhost/phpmyadmin/server_databases.php?server=1
echo "<br> My Sql local: http://localhost/phpmyadmin/server_databases.php?server=1";


echo "<br>--------------------------------------------<br>";

echo "2. PHP Connect to MySQL";

//Open a Connection to MySQL
echo "<br> Open a Connection to MySQL <br>";
/*
-Before we can access data in the MySQL database, we need to be able to connect to the server:
*/

//*Code Example: (MySQLi Object-Oriented)

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

echo "Connected successfully !!!";
/*
*Note on the object-oriented example above:

$connect_error was broken until PHP 5.2.9 and 5.3.0. If you need to ensure compatibility with PHP versions prior to 5.2.9 and 5.3.0, use the following code instead:

		// Check connection
		if (mysqli_connect_error()) {
		  die("Database connection failed: " . mysqli_connect_error());
		}
*/

//Close the Connection
echo "<br><br> Close the Connection";
/*
-The connection will be closed automatically when the script ends. To close the connection before, use the following:
*/

$conn -> close();
?>