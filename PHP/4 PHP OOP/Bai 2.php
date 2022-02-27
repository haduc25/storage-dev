<?php
#1. PHP OOP - Constructor
echo "PHP OOP - Constructor";
/*
-A constructor allows you to initialize an object's properties upon creation of the object.
-If you create a __construct() function, PHP will automatically call this function when you create an object from a class.
-Notice that the construct function starts with two underscores (__)!
-We see in the example below, that using a constructor saves us from calling the set_name() method which reduces the amount of code:
*/

//Example 1
echo "<br> Example 1 <br>";

class Fruit
{
	public $name;
	public $color;

	//create ham tao (construct same index)
	function __construct($name)
	{
		$this -> name = $name;
	}

	function get_name()
	{
		return $this->name;
	}
}

$apple = new Fruit("Apple"); //construct thay cho set name
echo "Name Fruit is: " .$apple->get_name();

//Example 2
echo "<br><br> Example 2 <br>";

class Fruit1
{
	public $name1;
	public $color1;

	//set
	function __construct($name1, $color1)
	{
		$this -> name1 = $name1;
		$this -> color1 = $color1;
	}

	//get
	function get_name1()
	{
		return $this->name1;
	}

	function get_color1()
	{
		return $this->color1;
	}
}


$apple1 =  new Fruit1("Banana","Yellow");
echo "Name Fruit is: " .$apple1->get_name1();
echo "<br>";
echo "Color Fruit is: " .$apple1->get_color1();

echo "<br>--------------------------------------------<br>";
#2. PHP OOP - Destructor
echo "PHP OOP - Destructor";

echo "<br> -The __destruct Function";
/*
-A destructor is called when the object is destructed or the script is stopped or exited.
-If you create a __destruct() function, PHP will automatically call this function at the end of the script.
-Notice that the destruct function starts with two underscores (__)!
-The example below has a __construct() function that is automatically called when you create an object from a class, and a __destruct() function that is automatically called at the end of the script:
*/

//Example 1
echo "<br> Example 1 <br>";

class Fruit2
{
	public $name2;
	public $color2;

	function __construct($name2)
	{
		$this->name2 = $name2;
	}

	function __destruct()
	{
		echo "<br>Ex1: The fruit is {$this -> name2}.";
	}
}

$apple2 = new Fruit2("Apple");


//Example 2
echo "<br> Example 2 <br>";

class Fruit3
{
	//Properties
	public $name3;
	public $color3;

	//Methods
	function __construct($name3, $color3)
	{
		$this -> name3 = $name3;
		$this -> color3 = $color3;
	}

	//des
	function __destruct()
	{
		echo "Ex2: The fruit is {$this -> name3} and the color is {$this -> color3}.";
	}
}

$apple3 = new Fruit3("Mango","Green");	


//Tip: As constructors and destructors helps reducing the amount of code, they are very useful!
?>