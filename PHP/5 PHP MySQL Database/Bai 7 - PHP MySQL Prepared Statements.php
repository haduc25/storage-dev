<?php 
echo "PHP MySQL Prepared Statements";
//-Prepared statements are very useful against SQL injections.
echo "<br> -Prepared Statements and Bound Parameters <br>";
/*
-A prepared statement is a feature used to execute the same (or similar) SQL statements repeatedly with high efficiency.

*Prepared statements basically work like this:
	+Prepare: An SQL statement template is created and sent to the database. Certain values are left unspecified, called parameters (labeled "?"). Example: INSERT INTO MyGuests VALUES(?, ?, ?)
	
	+The database parses, compiles, and performs query optimization on the SQL statement template, and stores the result without executing it
	
	+Execute: At a later time, the application binds the values to the parameters, and the database executes the statement. The application may execute the statement as many times as it wants with different values

*Compared to executing SQL statements directly, prepared statements have three main advantages:
	+Prepared statements reduce parsing time as the preparation on the query is done only once (although the statement is 
	 executed multiple times)
	+Bound parameters minimize bandwidth to the server as you need send only the parameters each time, and not the whole 
	 query
	+Prepared statements are very useful against SQL injections, because parameter values, which are transmitted later using 
	 a different protocol, need not be correctly escaped. If the original statement template is not derived from external input, SQL injection cannot occur.
*/

echo "-Prepared Statements in MySQLi <br>";

//Example (MySQLi with Prepared Statements) - The following example uses prepared statements and bound parameters in MySQLi:

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

//prepare and bind
$stmt = $conn -> prepare("INSERT INTO MyGuests (firstname, lastname, email) VALUES (?, ?, ?)");
$stmt -> bind_param("sss", $firstname, $lastname, $email); 

//set paremeters and execute
$firstname = "My";
$lastname = "Linh";
$email = "linhmy030502@example.com";
$stmt -> execute();

$firstname = "Hoang";
$lastname = "Son";
$email = "hoangson140901@example.com";
$stmt -> execute();

$firstname = "Minh";
$lastname = "Duc";
$email = "minhduc250901@example.com";
$stmt -> execute();

echo "New records created succesfully !!!";

$stmt -> close();
$conn -> close();

/*
*Code lines to explain from the example above:
		"INSERT INTO MyGuests (firstname, lastname, email) VALUES (?, ?, ?)"


-In our SQL, we insert a question mark (?) where we want to substitute in an integer, string, double or blob value.
-Then, have a look at the bind_param() function:
		$stmt->bind_param("sss", $firstname, $lastname, $email);


-This function binds the parameters to the SQL query and tells the database what the parameters are. The "sss" argument lists the types of data that the parameters are. The s character tells mysql that the parameter is a string.

*The argument may be one of four types:
	i - integer
	d - double
	s - string
	b - BLOB

-We must have one of these for each parameter.
-By telling mysql what type of data to expect, we minimize the risk of SQL injections.

*Note: If we want to insert any data from external sources (like user input), it is very important that the data is sanitized and validated.
*/
?>