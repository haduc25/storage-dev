<?php
#1. PHP - What is OOP?
echo "PHP - What is OOP?";
/*
-From PHP5, you can also write PHP code in an object-oriented style.
-Object-Oriented programming is faster and easier to execute.

//What is OOP?
-OOP stands for Object-Oriented Programming.
-Procedural programming is about writing procedures or functions that perform operations on the data, while object-oriented programming is about creating objects that contain both data and functions.
-Object-oriented programming has several advantages over procedural programming:
	+OOP is faster and easier to execute
	+OOP provides a clear structure for the programs
	+OOP helps to keep the PHP code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
	+OOP makes it possible to create full reusable applications with less code and shorter development time

-Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.

//PHP - What are Classes and Objects?
-Classes and objects are the two main aspects of object-oriented programming.
-Look at the following illustration to see the difference between class and objects:

Example 1:
					 class 							|								 object
					 								|
					Fruit 							|								Apple
													|								Banana
													|								Mango	

Example 2:
					 class 							|								 object
					 								|
					Car 							|								Volvo
													|								Audi
													|								Toyota


-So, a class is a template for objects, and an object is an instance of a class.
-When the individual objects are created, they inherit all the properties and behaviors from the class, but each object will have different values for the properties.
*/

echo "<br>--------------------------------------------<br>";
#2. PHP OOP - Classes and Objects
echo "PHP OOP - Classes and Objects";
/*
-A class is a template for objects, and an object is an instance of class.
*/

//OOP Case
/*
-Let's assume we have a class named Fruit. A Fruit can have properties like name, color1, weight, etc. We can define variables like $name, $color, and $weight to hold the values of these properties.
-When the individual objects (apple, banana, etc.) are created, they inherit all the properties and behaviors from the class, but each object will have different values for the properties.
*/

//Define a Class
echo "<br> -Define a Class";
/*
-A class is defined by using the class keyword, followed by the name of the class and a pair of curly braces ({}). All its properties and methods go inside the braces:

*Syntax
		class Fruit 
		{
		  // code goes here...
		}


Below we declare a class named Fruit consisting of two properties ($name and $color) and two methods set_name() and get_name() for setting and getting the $name property:
*/

//Example

class Fruit
{
	//Properties
	public $name;
	public $color;

	//Method
	function set_name($name)
	{
		$this->name = $name;
	}

	function get_name()
	{
		return $this->name;
	}
}
//Note: In a class, variables are called properties and functions are called methods!

//Define Objects
echo "<br><br> -Define Object";
/*
-Classes are nothing without objects! We can create multiple objects from a class. Each object has all the properties and methods defined in the class, but they will have different property values.
-Objects of a class is created using the "new" keyword.
-In the example below, $apple and $banana are instances of the class Fruit:
*/

//Example 1
echo "<br>Example 1 <br>";

class Fruit1
{
	//Properties
	public $name1;
	public $color1;

	//Method
	function set_name1($name1)
	{
		$this->name1 = $name1;
	}

	function get_name1()
	{
		return $this->name1;
	}
}

$apple = new Fruit1();
$banana = new Fruit1();
//set
$apple -> set_name1('Apple');
$banana -> set_name1('Banana');

//get
echo $apple -> get_name1(); //output apple
echo "<br>";
echo $banana -> get_name1(); //banana



//Example 2 - we add two more methods to class Fruit, for setting and getting the $color property:
echo "<br><br> Example 2 <br>";

class Fruit2
{
	//Properties
	public $name2;
	public $color2;

	//Method
	function set_name2($name2)
	{
		$this->name2 = $name2;
	}

	function get_name2()
	{
		return $this->name2;
	}

	//color
	function set_color2($color2)
	{
		$this -> color2 = $color2;
	}

	function get_color2()
	{
		return $this -> color2;
	}
}


$apple2 = new Fruit2();
//set
$apple2 -> set_name2('Banana');
$apple2 -> set_color2('Yellow');
//get
echo "Name Fruit: ".$apple2->get_name2();	
echo "<br>";
echo "Color Fruit: ".$apple2->get_color2();

//PHP - The $this Keyword
echo "<br><br> -The 'this' Keyword <br>";
/*
-The $this keyword refers to the current object, and is only available inside methods.
*/

//Example 1
echo "Example 1 <br>";

class Fruit3
{
	public $name3;
}

$apple3 = new Fruit3();

//So, where can we change the value of the $name property? There are two ways:

//Example 2 - 1. Inside the class (by adding a set_name() method and use $this):
echo "Example 2 <br>";

class Fruit4
{
	public $name4;
	//set
	function set_name4($name4)
	{
		$this -> name4 = $name4;
	}
}

$apple4 = new Fruit4();
$apple4 -> set_name4('Lemon'); //set name

//Example 3 - 2. Outside the class (by directly changing the property value):
echo "Example 3 <br>";

class Fruit5
{
	public $name5;
}

$apple5 = new Fruit5();
$apple5 -> name5 = "Apple"; //set name cho name5


//instanceof
echo "<br> -Instanceof";
/*
-You can use the "instanceof" keyword to check if an object belongs to a specific class:
*/

//ex

class Fruit6
{
	public $name6;

	//Methods
	//set
	function set_name6($name6)
	{
		$this -> name6 = $name6;
	}

	//get
	function get_name6()
	{
		return $this -> name6;
	}
}

$apple6 = new Fruit6();
echo "<br>";
var_dump($apple6 instanceof Fruit6) //kiem tra apple6 co thuoc fruit6 hay k (true or false)
?>