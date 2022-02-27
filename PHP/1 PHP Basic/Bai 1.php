<?php
#Comments (use "#" or "//" and "/**/")

#1. Variables

$txt = "hello";
$a = 10;
$b = 10.5;

echo "$txt <br>";
echo "$a <br>";

echo "<br> ------------------------------------- <br>";
#2. Variables Scope (local, global, static)

echo "<br> -Global Score <br>";
$a1 = 5; //global score

function myTest()
{
	// using a1 inside this function will generate an error
	echo "<br> Variables a1 inside function is: $a1"; 
}
myTest();
echo "<br> Variables a1 outsite function is: $a1 <br>";

echo "<br> -Local Score <br>";
function myTest1()
{
	$a2 = 5; //local score
	echo "<br> Variables a2 inside function is: $a2"; 
}
myTest1();
// using a2 outside the function will generate an error
echo "Variables a2 outside function is: $a2 <br>";

echo "<br> -The Global Keyword <br>";
#Solution 1
$a3 = 10;
$b3 = 15;

echo "Variables a3 & b3 is: $a3 & $b3<br>";
function myTest2()
{
	global $a3, $b3;
	$b3 = $a3 + $b3; 
}
myTest2();
echo "Variables b3 is: $b3 <br>";

#Solution 2
$a4 = 20;
$b4 = 5;

echo "Variables a4 & b4 is: $a4 & $b4<br>";
function myTest3()
{
	$GLOBALS['b4'] = $GLOBALS['a4'] + $GLOBALS['b4'];
}
myTest3();
echo "Variables b4 is: $b4 <br>";

echo "<br> -The static Keyword <br>";
function myTest4()
{
	static $a5 = 0;
	echo "$a5 <br>";
	$a5++;
}
myTest4();
myTest4();
myTest4();

echo "<br> ------------------------------------- <br>";
#3. Echo/Print (Can use "echo" or "print")

echo "<br> -Display Text <br>";
echo "<h2> PHP's fun ! <br> </h2>";
print "i'm about to learning PHP ! <br>";
echo "welcome ", "to ", "my ", "world <br>";

echo "<br> -Display Variables <br>";
$txt1 = "Learning PHP";
$txt2 = "It's too Hard?";
$a6 = 10;
$b6 = 100;

echo "<h2>".$txt1."</h2>";
echo "PHP is: ".$txt2."<br>";
echo "Variables a6 & b6 is: $a6 & $b6 <br>";
echo "total: ".$a6+$b6;

echo "<br> ------------------------------------- <br>";
#4. Data Types (String, Integer, Float (floating point numbers - also called double), Boolean, Array, Object, NULL, Resource)

echo "<br> -String <br>";
$a7 = "Hello from a7";
$b7 = "Hello from b7";
echo "$a7 "."&"." $b7"."<br>";

echo "<br> -Integer (So Nguyen) <br>";
#var_dump() function returns the data type and value
$a8 = 2509;
var_dump($a8); //hien thi ra dl va kieu dl

echo "<br> -Float (So Thuc) <br>";
$a9 = 25.09;
var_dump($a9);

echo "<br> -Boolean (True or False) <br>";
#su dung de kiem tra
$a10 = true;
$b10 = false;

echo "<br> -Array (An array stores multiple values in one single variable.) <br>";
$cars = array("Mercedes","Lamborghini","BMW");
var_dump($cars);

echo "<br> - Object (When the individual objects are created, they inherit all the properties and behaviors from the class, but each object will have different values for the properties.

Let's assume we have a class named Car. A Car can have properties like model, color, etc. We can define variables like model, color, and so on, to hold the values of these properties.

When the individual objects (Mercedes, BMW, Lamborghini, etc.) are created, they inherit all the properties and behaviors from the class, but each object will have different values for the properties.

If you create a __construct() function, PHP will automatically call this function when you create an object from a class.) <br><br>";
#__construct(): PHP tu dong goi ham nay giong index 

class Cars
{
	public $color;
	public $model;

	public function __construct($color,$model)
	{
		$this->color=$color;
		$this->model=$model;
	}
	public function message()
	{
		return "My car is a ".$this->color.", ".$this->model."!";
	}
}

$myCar = new Cars("Yellow", "Mercedes"); //khoi tao bien ("color","model")
echo $myCar->message();
echo "<br>";
$myCar = new Cars("Pink", "BMW");
echo $myCar->message();
echo "<br>";


echo "<br><br> -NULL Value (Null is a special data type which can have only one value: NULL, A variable of data type NULL is a variable that has no value assigned to it.) <br>";
$a11 = "This's Text";
$a11 = null;
var_dump($a11);

?>