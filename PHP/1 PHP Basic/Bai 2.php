<?php
#1. String
echo "<br> -String(strlen, str_word_count, strrev, strpos, str_replace) <br>";

//strlen (Return the Length of a String)
echo strlen("Ha Minh Duc"); //dem chu
echo "<br>";

//str_word_count (Count Words in a String)
echo str_word_count("Ha Minh Duc"); //dem tu
echo "<br>";

//strrev (Reverse a String)
echo strrev("Ha Minh Duc"); //dem tu
echo "<br>";

//strpos (Search For a Text Within a String)
echo strpos("Ha Minh Duc","Duc"); //tim kiem text trong 1 chuoi -> output: 8
echo "<br>";

//str_replace (Replace Text Within a String), str_replace() function replaces some characters with some other characters in a string.
//Replace the text "world" with "Dolly":
echo str_replace("world", "Dolly", "Hello world!"); //thay the van ban khi giong nhau
echo "<br>";

echo "<br> ------------------------------------- <br>";

#2. Numbers
echo "<br> -Numbers(Integers, Floats, Infinity, NaN, Numerical Strings, PHP Casting Strings and Floats to Integers) <br><br>";

//Integers
/*
#PHP has the following predefined constants for integers:
-PHP_INT_MAX - The largest integer supported
-PHP_INT_MIN - The smallest integer supported
-PHP_INT_SIZE -  The size of an integer in bytes

#PHP has the following functions to check if the type of a variable is integer:
-is_int()
-is_integer() - alias of is_int()
-is_long() - alias of is_int()
*/

$a = 2509;
var_dump(is_int($a)); //kiem tra so nguyen, output -> true
echo "<br>";
$a = 25.09;
var_dump(is_int($a)); //false
echo "<br>";


//Floats
/*
#PHP has the following predefined constants for floats (from PHP 7.2):
-PHP_FLOAT_MAX - The largest representable floating point number
-PHP_FLOAT_MIN - The smallest representable positive floating point number
-PHP_FLOAT_MAX - The smallest representable negative floating point number
-PHP_FLOAT_DIG - The number of decimal digits that can be rounded into a float and back without precision loss
-PHP_FLOAT_EPSILON - The smallest representable positive number x, so that x + 1.0 != 1.0

#PHP has the following functions to check if the type of a variable is float:
-is_float()
-is_double() - alias of is_float()
*/
echo "<br>";
$a1 = 2509;
var_dump(is_float($a1)); //kiem tra so thuc, output -> false
echo "<br>";
$a1 = 25.09;
var_dump(is_float($a1)); //true
echo "<br>";

//Infinity (A numeric value that is larger than PHP_FLOAT_MAX is considered infinite.)
/*
#PHP has the following functions to check if a numeric value is finite or infinite:
-is_finite()
-is_infinite()
*/

echo "<br>";
$a2 = 1.9e2509;
var_dump($a2);
echo "<br>";
var_dump(is_finite($a2));
echo "<br>";
var_dump(is_infinite($a2));
echo "<br>";

//NaN (NaN stands for Not a Number, NaN is used for impossible mathematical operations.)
/*
#PHP has the following functions to check if a value is not a number:
-is_nan()
*/
//acos()	Trả về cung cosin của một số

echo "<br>";
$a3 = acos(9);
var_dump($a3);
echo "<br>";
var_dump(is_nan($a3));
echo "<br>";

//Numerical Strings
/*
The PHP is_numeric() function can be used to find whether a variable is numeric. The function returns true if the variable is a number or a numeric string, false otherwise.
*/

echo "<br>";
$a4 = 2509;
var_dump(is_numeric($a4));
echo "<br>";
$a4 = "2509";
var_dump(is_numeric($a4));
echo "<br>";
$a4 = 25.09;
var_dump(is_numeric($a4));
echo "<br>";
$a4 = "Ha Duc";
var_dump(is_numeric($a4));
echo "<br>";

//PHP Casting Strings and Floats to Integers (The (int), (integer), or intval() function are often used to convert a value to an integer.) --> (Ep Kieu)


echo "<br>";
//Cast Float to Int (Ep kieu)
$a5 = 25.09;
echo "value a5= $a5";
$int_cast = (int)$a5; //float -> int
echo "<br> value a5 when cast: ".$int_cast;

//Cast String to Int (Ep kieu)
$a6 = "20.01";
echo "<br> value a6= $a6";
$int_cast = (int)$a6; //string -> int
echo "<br> value a6 when cast: ".$int_cast;
 
echo "<br> ------------------------------------- <br>";

#3. Math 
echo "<br> -Math(Pi, Min, Max, Abs, Sqrt, Round, Rand) <br><br>";

//Pi: The pi() function returns the value of PI

echo (pi()); //gia tri cua pi, output: 3.1415926535898;

//Min, Max: The min() and max() functions can be used to find the lowest or highest value in a list of arguments:

echo "<br>";
echo(min(0,5,10,15,-100,-10,-5,25)); //output -100
echo "<br>";
echo(max(0,5,10,15,-100,-10,-5,25)); //output 25

echo "<br> so nho nhat la: ".(min(-10,-5,0,5,2,7,125));
echo "<br> so lon nhat la: ".(max(-10,-5,0,5,2,7,125));

//Abs: The abs() function returns the absolute (positive) value of a number
//gia tri tuyet doi, tra ve so duong

echo "<br>";
echo(abs(-2.5));

//Sqrt: The sqrt() function returns the square root of a number:

echo "<br>";
echo(sqrt(64));
echo "<br>";
echo(sqrt(256));

//Round: The round() function rounds a floating-point number to its nearest integer:

echo "<br>";
echo(round(0.5));
echo "<br>";
echo(round(1.5));
echo "<br>";
echo(round(5.5));

//Random: The rand() function generates a random number:

echo "<br>";
echo(rand());
echo "<br>";
echo(rand(0,100));

 ?>