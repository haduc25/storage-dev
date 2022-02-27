<?php declare(strict_types=1); // strict requirement
#1. Loops
/*
while 				- loops through a block of code as long as the specified condition is true
do...while 			- loops through a block of code once, and then repeats the loop as long as the specified condition is true
for 				- loops through a block of code a specified number of times
foreach 			- loops through a block of code for each element in an array
*/

#Foreach
echo "-Foreach <br>";
//ex1
$colors = array("red", "green", "blue", "yellow");

foreach ($colors as $value) 
{
	echo "$value <br>";
}

//ex2
$age = array("Peter" => "35", "Ben" => "37", "Joe" => "43");
foreach ($age as $x => $val) 
{
	echo "$x = $val <br>";
}


//Break and Continue

#Break
echo "-Break <br>";
for ($x=0; $x < 10; $x++)
{
	if($x==4)
	{
		break;
	}
	echo "The number's: $x <br>";
}

#Continue
echo "-Continue <br>";

for ($x1=0; $x1 < 10; $x1++) 
{ 
	if ($x1 == 4) 
	{
		Continue;
	}
	echo "The number's: $x1 <br>";
}

#Break and Continue in While Loop
#Break
echo "-Break in While Loop <br>";
$x2 = 0;

while ($x2 < 10) 
{
	if ($x2 == 4) 
	{
		break;
	}
	 echo "The number is: $x2 <br>";
 	 $x2++;
}



#Continue
echo "-Continue in While Loop <br>";
$x3 = 0;

while ($x3 < 10) 
{
	if ($x3 == 4) 
	{
		$x3++;
		Continue;
	}
	 echo "The number is: $x3 <br>";
 	 $x3++;
}

echo "<br> ------------------------------------- <br>";
#2. Functions

//Functions
echo "-Functions <br>";
/*
*Syntax
function functionName() {
  code to be executed;
}
*/

function writeMsg()
{
	echo "Hello World !";
}

writeMsg(); // call the function


//Function Arguments
/*
Information can be passed to functions through arguments. An argument is just like a variable.

Arguments are specified after the function name, inside the parentheses. You can add as many arguments as you want, just separate them with a comma.

The following example has a function with one argument ($fname). When the familyName() function is called, we also pass along a name (e.g. Jani), and the name is used inside the function, which outputs several different first names, but an equal last name:
*/
echo "-Function Arguments <br>";

function familyName($fname)
{
	echo "$fname Refsnes.<br>";
}

familyName("Ha");
familyName("Minh");
familyName("Duc");


//Function Arguments ($fname and $year):

function familyName1($fname1, $year1)
{
	echo "$fname1 Refsnes. Born in $year1 <br>";
}

familyName1("Ha Duc", "2001");
familyName1("Nguyen Mai", "2002");
familyName1("My Linh", "2001");


//PHP is a Loosely Typed Language
/*
In the example above, notice that we did not have to tell PHP which data type the variable is.

PHP automatically associates a data type to the variable, depending on its value. Since the data types are not set in a strict sense, you can do things like adding a string to an integer without causing an error.

In PHP 7, type declarations were added. This gives us an option to specify the expected data type when declaring a function, and by adding the strict declaration, it will throw a "Fatal Error" if the data type mismatches.

In the following example we try to send both a number and a string to the function without using strict:
*/

//<?php declare(strict_types=1); // strict requirement
function addNumbers(int $a, int $b)
{
	return $a + $b;
}

//echo addNumbers(5, "5 days"); // since strict is enabled and "5 days" is not an integer, an error will be thrown
echo "<br>";
//echo addNumbers(5, "5 days");  (fixed)
// since strict is NOT enabled "5 days" is changed to int(5), and it will return 10 (fixed)
// vì strict KHÔNG được bật "5 ngày" được đổi thành int (5) và nó sẽ trả về 10

//Default Argument Value
/*
The following example shows how to use a default parameter. If we call the function setHeight() without arguments it takes the default value as argument:
*/

//<?php declare(strict_types=1); // strict requirement
function setHeight(int $minHeight = 50)
{
	echo "The min height is: $minHeight <br>";
}

setHeight(350);
setHeight(); //will use the default value of 50
setHeight(150);
setHeight(25);


//Returning values

//<?php declare(strict_types=1); // strict requirement

function sum(int $x4, int $y4)
{
		$z = $x4 + $y4;
		return $z;
}

echo "5 + 10 = ".sum(5,10)."<br>";
echo "25 + 7 = ".sum(25,7)."<br>";
echo "45 + 8 = ".sum(45,8)."<br>";


//Return Type Declarations

//example float
//<?php declare(strict_types=1); // strict requirement
function addNumbers1(float $x5, float $y5) : float //giong ep kieu
{
	return $x5+$y5;
}

echo addNumbers1(2.7,3.5);

//example int
//example float
//<?php declare(strict_types=1); // strict requirement
function addNumbers2(float $x6, float $y6) : int //giong ep kieu
{
	return (int)($x6+$y6);
}

echo "<br>";
echo addNumbers2(2.2,3.9);


//Passing Arguments by Reference
/*
In PHP, arguments are usually passed by value, which means that a copy of the value is used in the function and the variable that was passed into the function cannot be changed.

When a function argument is passed by reference, changes to the argument also change the variable that was passed in. To turn a function argument into a reference, the & operator is used:
*/


//Use a pass-by-reference argument to update a variable:

function add_five(&$value)
{
	$value += 25; //$num + $value 
}

$num = 5;
add_five($num); //truyen value $num -> $value
echo "<br> Value of Num: $num";

//
?>