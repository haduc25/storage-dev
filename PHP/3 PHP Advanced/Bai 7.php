<?php 
#1. PHP Callback Functions

//Callback Functions
echo "Callback Functions <br>";
/*
-A callback function (often referred to as just "callback") is a function which is passed as an argument into another function.
-Any existing function can be used as a callback function. To use a function as a callback function, pass a string containing the name of the function as the argument of another function:
*/

//Example 1 - Pass a callback to PHP's array_map() function to calculate the length of every string in an array:
echo "<br> Example 1 <br>";

function my_callback($item)
{
	return strlen($item); //dem so tu
	//return $item; //tra ve dl trong $item
}

$strings =["apple", "orange", "banana", "coconut"];
$lengths = array_map("my_callback", $strings);
print_r($lengths);

//Example 2 - Use an anonymous function as a callback for PHP's array_map() function:
echo "<br><br> Example 2 <br>";


$strings1 = ["coconut", "watermelon", "lemon", "kiwi"];
$lengths1 = array_map(function($item1){ return strlen($item1); /*dem so tu */}, $strings1);
print_r($lengths1);

//Callbacks in User Defined Functions
echo "<br><br> -Callbacks in User Defined Functions <br>";
/*
-User-defined functions and methods can also take callback functions as arguments. To use callback functions inside a user-defined function or method, call it by adding parentheses to the variable and pass arguments as with normal functions:
*/

//Example - Run a callback from a user-defined function
echo "<br> Example 1 <br>";


function exclaim($str)
{
	return $str . "!". "<br>";
}

function ask($str)
{
	return $str . "?" . "<br>";
}

function print_Formatted($str, $format)
{
	//Calling the $format callback function
	echo $format($str);
}

//Pass "exclaim" and "ask" as callback functions to print_Formatted()
print_Formatted("Hello World", "exclaim"); //print_Formatted("str", "user-defined functions");
print_Formatted("Hello World", "ask");


//Example 2 - Run a callback from a user-defined function
echo "<br> Example 2 <br>";

function myCars($str1)
{
	return $str1 . " have a Mescedes and BMW ! <br>";
}

function myHouse($str1)
{
	return $str1 . " have a House prince 100 bilion dollas ! <br>";
}

function print_Formatted1($str1, $format1)
{
	echo $format1($str1);
}

print_Formatted1("Ha Duc","myCars");
print_Formatted1("Ha Duc","myHouse");


echo "<br>--------------------------------------------<br>";

#2. PHP and JSON
echo "PHP and JSON";
/*
//What is JSON?
-JSON stands for JavaScript Object Notation, and is a syntax for storing and exchanging data.
-Since the JSON format is a text-based format, it can easily be sent to and from a server, and used as a data format by any programming language.
*/

//PHP and JSON
/*
-PHP has some built-in functions to handle JSON.
-First, we will look at the following two functions:
	+json_encode()
	+json_decode()
*/

//PHP - json_encode()
echo "<br> -PHP - json_encode()";
/*
-The json_encode() function is used to encode a value to JSON format.
*/

//Example 1 - This example shows how to encode an associative array into a JSON object:
echo "<br> Example 1 <br>";

$age = array("Peter" => 25, "Ha Duc" => 20, "Joe" => 35);

echo json_encode($age); //ma hoa $age qua json

//Example 2 - This example shows how to encode an indexed array into a JSON array:
echo "<br><br> Example 2 <br>";

$cars = array("BMW", "Volvo", "Mescedes");

echo json_encode($cars); //ma hoa $age qua json

//PHP - json_decode()
echo "<br><br> -PHP - json_decode() <br>";
/*
-The json_decode() function is used to decode a JSON object into a PHP object or an associative array.
*/

//Example 1 - This example decodes JSON data into a PHP object:
echo "Example 1 <br>";

$json_obj = '{"Minh Duc":25, "Ben":20, "Joe":40}';

var_dump(json_decode($json_obj));

/*
-The json_decode() function returns an object by default.
-The json_decode() function has a second parameter, and when set to true, JSON objects are decoded into associative arrays.
*/

//Example 2 - This example decodes JSON data into a PHP associative array:
echo "<br><br> Example 2 <br>";

$json_obj1 = '{"Ha Duc":20, "Ben":15, "Linh":18}';

var_dump(json_decode($json_obj1,true));

//PHP - Accessing the Decoded Values
echo "<br><br> -PHP - Accessing the Decoded Values <br>";
/*
-Here are two examples of how to access the decoded values from an object and from an associative array:
*/

//Example 1 - This example shows how to access the values from a PHP object:
echo "Example 1 <br>";

$json_obj2 = '{"Duc":20, "Ben":15, "Linh":18}';

$obj = json_decode($json_obj2);

echo $obj->Duc;  //output 20
echo "<br>";
echo $obj->Ben;  //output 15
echo "<br>";
echo $obj->Linh; //output 18

//Example 2 - This example decodes JSON data into a PHP associative array:
echo "<br><br> Example 2 <br>";

$json_obj3 = '{"Duc":24, "Ben":17, "Linh":20}';

$arr = json_decode($json_obj3, true);

echo $arr["Duc"];
echo "<br>";
echo $arr["Ben"];
echo "<br>";
echo $arr["Linh"];

//PHP - Looping Through the Values
echo "<br><br> -PHP - Looping Through the Values";
/*
-You can also loop through the values with a foreach() loop:
*/

//Example 1 - This example shows how to loop through the values of a PHP object:
echo "<br> Example 1 <br>";

$json_obj4 = '{"Duc":16, "Mai":41, "Hong":21}';

$obj1 =json_decode($json_obj4);

//loops
foreach ($obj1 as $key => $value) 
{
	//in dl trong obj1 -> json_obj4
	echo $key . " => " . $value . "<br>";
}


//Example 2 - This example shows how to loop through the values of a PHP associative array:
echo "<br> Example 2 <br>";

$json_obj5 = '{"Minh":25, "Lien":14, "Giang":58}';

$arr1 = json_decode($json_obj5, true);

//loops
foreach ($arr1 as $key1 => $value1) 
{
	echo $key1 . " => " . $value1 . "<br>";
}



?>