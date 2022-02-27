<?php
#1. PHP Filters
echo "PHP Filters <br><br>";
/*
-Validating data = Determine if the data is in proper form.
-Sanitizing data = Remove any illegal character from the data.
*/


//The PHP Filter Extension
/*
-PHP filters are used to validate and sanitize external input.
-The PHP filter extension has many of the functions needed for checking user input, and is designed to make data validation easier and quicker.
-The filter_list() function can be used to list what the PHP filter extension offers:
*/

//Example: (use php,html,css)
?>

<!DOCTYPE html>
<html>
<head>
	<style>
		table, th, td
		{
			border: 1px solid black;
			border-collapse: collapse;
		}
		th, td 
		{
			padding: 5px;
		}
	</style>
</head>
<body>
	<table>	
		<tr>
			<td>Filter Name</td>
			<td>Filter ID</td>
		</tr>

		<?php
		foreach (filter_list() as $id => $filter) 
		{
			echo '<tr><td>' . $filter . '</td><td>' . filter_id($filter) . '</td></tr>';
			//<tr1><td1>.....</td1><td2>.....</td2></tr1>
		}
		?>
	</table>
</body>
</html>

<?php
//Why Use Filters?
/*
-Many web applications receive external input. External input/data can be:
+User input from a form
+Cookies
+Web services data
+Server variables
+Database query results

//You should always validate external data!
-Invalid submitted data can lead to security problems and break your webpage!
-By using PHP filters you can be sure your application gets the correct input!
*/

//PHP filter_var() Function
echo "<br> -PHP filter_var() Function <br>";
/*
-The filter_var() function both validate and sanitize data.
-The filter_var() function filters a single variable with a specified filter. It takes two pieces of data:
	+The variable you want to check
	+The type of check to use
*/

//Sanitize a String
echo "-Sanitize a String <br>";
/*
The following example uses the filter_var() function to remove all HTML tags from a string:	
*/

$str = "<h1> Hello World! </h1>";
$newStr = filter_var($str, FILTER_SANITIZE_STRING); //lam sach chuoi
echo $newStr;

//Validate an Integer
echo "<br><br> -Validate an Integer <br>";
/*
-The following example uses the filter_var() function to check if the variable $int is an integer. If $int is an integer, the output of the code below will be: "Integer is valid". If $int is not an integer, the output will be: "Integer is not valid":
*/

$int = 100;

//===    Giống nhau		$x===$y		Trả về true nếu $x và $y có key/value tương tự và cùng loại.

if(!filter_var($int, FILTER_VALIDATE_INT) === false)
{
	echo ("Integer is valid.");
}else
{
	echo ("Integer is not valid.");
}

//Tip: filter_var() and Problem With 0
echo "<br><br> -Tip: filter_var() and Problem With 0 <br>";
/*
In the example above, if $int was set to 0, the function above will return "Integer is not valid". To solve this problem, use the code below:
*/

$int1 = 0;

if(filter_var($int1, FILTER_VALIDATE_INT) === 0 || !filter_var($int1,FILTER_VALIDATE_INT) === false)
{
	echo ("Integer is valid.");
}else
{
	echo ("Integer is not valid.");
}


//Validate an IP Address
echo "<br><br> -Validate an IP Address <br>";
/*
-The following example uses the filter_var() function to check if the variable $ip is a valid IP address:
*/

$ip = "127.0.0.1";

if(!filter_var($ip, FILTER_VALIDATE_IP) === false)
{
	echo "$ip is a valid IP address.";
}else
{
	echo "$ip is not a valid IP address.";
}

//Sanitize and Validate an Email Address
echo "<br><br> -Sanitize and Validate an Email Address <br>";
/*
-The following example uses the filter_var() function to first remove all illegal characters from the $email variable, then check if it is a valid email address:
*/

$email = "haduc25@example.com";

//Remove all illegal characters from email
$email = filter_var($email, FILTER_SANITIZE_EMAIL);
	

//Validate E-mail
if(!filter_var($email,FILTER_VALIDATE_EMAIL) === false)
{
	echo "$email is a valid E-mail address.";
}else
{
	echo "$email is not a valid E-mail address.";
}

//Sanitize and Validate a URL
echo "<br><br> -Sanitize and Validate a URL <br>";
/*
-The following example uses the filter_var() function to first remove all illegal characters from a URL, then check if $url is a valid URL:
*/

$url = "https://www.haduc25.com";


//Remove all illegal characters from a url
$url = filter_var($url, FILTER_SANITIZE_URL);

//Validate URL
if(!filter_var($url, FILTER_VALIDATE_URL) === false)
{
	echo "$url is a valid URL.";
}else
{
	echo "$url is not a valid URL.";
}

echo "<br>--------------------------------------------";

#2. PHP Filters Advanced
echo "<br> PHP Filters Advanced <br>";

//Validate an Integer Within a Range
echo "<br> -Validate an Integer Within a Range <br>";
/*
-The following example uses the filter_var() function to check if a variable is both of type INT, and between 1 and 200:
*/

$int1 = 122;
$min1 = 10;
$max1 = 200;

if(filter_var($int1, FILTER_VALIDATE_INT, array("options" => array("min_range" => $min1, "max_range" => $max1))) === false)
{
	echo ("Variable value is not within the legal range.");
}else
{
	echo ("Variable value is within the legal range.");
}

//Validate IPv6 Address
echo "<br><br> -Validate IPv6 Address <br>";
/*
-The following example uses the filter_var() function to check if the variable $ip is a valid IPv6 address:
*/

// Variable to check
$ip1 = "2001:0db8:85a3:08d3:1319:8a2e:0370:7334";


//check validate ip
if(!filter_var($ip1,FILTER_VALIDATE_IP, FILTER_FLAG_IPV6) === false)
{
	echo "$ip1 is a valid IPv6 Address.";
}else
{
	echo "$ip1 is not a valid IPv6 Address.";
}

//Validate URL - Must Contain QueryString
echo "<br><br> Validate URL - Must Contain QueryString <br>";
/*
-The following example uses the filter_var() function to check if the variable $url is a URL with a querystring:
*/
// Variable to check
$url1 = "https://www.haduc25.com";

if (!filter_var($url1,FILTER_VALIDATE_URL,FILTER_FLAG_QUERY_REQUIRED) === false) 
{
	echo "$url1 is a valid URL with a query string.";
}else
{
	echo "$url1 is not a valid URL with a query string.";
}

//Remove Characters With ASCII Value > 127
echo "<br><br> Remove Characters With ASCII Value > 127 <br>";
/*
-The following example uses the filter_var() function to sanitize a string. It will both remove all HTML tags, and all characters with ASCII value > 127, from the string:
*/

// Variable to check
$str1 = "<h1> Hello WorldÆØÅ! </h1>"; //Before

//Remove HTML tags and all characters with ASCII value > 127
$newStr1 = filter_var($str1,FILTER_SANITIZE_STRING, FILTER_FLAG_STRIP_HIGH);
//After
echo $newStr1;
?>