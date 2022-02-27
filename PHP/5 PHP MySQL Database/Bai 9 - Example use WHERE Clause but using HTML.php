<!DOCTYPE html>
<html>
<head>
<style>
table, th, td {
  border: 1px solid black;
}
</style>
</head>
<body>

<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "MyDB";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT id, firstname, lastname, email FROM MyGuests WHERE lastname='Duc'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  echo "<table><tr><th>ID</th><th>Name</th><th>E-Mail</th></tr>";
  // output data of each row
  while($row = $result->fetch_assoc()) {
    echo "<tr><td>" . $row["id"]. "</td><td>" . $row["firstname"]. " " . $row["lastname"]."</td><td>" .$row["email"]. "</td></tr>";
  }
  echo "</table>";
} else {
  echo "0 results";
}

$conn->close();
?>

</body>
</html>