<?php 
#1. PHP OOP - Access Modifiers
echo "PHP OOP - Access Modifiers";

/*
-Properties and methods can have access modifiers which control where they can be accessed.
-There are three access modifiers:
	+public 				-the property or method can be accessed from everywhere. This is default
	+protected 				-the property or method can be accessed within the class and by classes derived from that class
	+private 				-the property or method can ONLY be accessed within the class

-In the following example we have added three different access modifiers to the three properties. Here, if you try to set the name property it will work fine (because the name property is public). However, if you try to set the color or weight property it will result in a fatal error (because the color and weight property are protected and private):
*/

//Example 1
echo "<br><br> Example 1 <br>";

class Fruit
{
	public $name;
	protected $color;
	private $weight;
}

$mango = new Fruit();
echo $mango -> name = 'Mango'; //OK
echo $mango -> $color = 'Yellow'; //ERROR
echo $mango -> $weight = "300"; // ERROR

/*
-In the next example we have added access modifiers to two methods. Here, if you try to call the set_color() or the set_weight() function it will result in a fatal error (because the two functions are considered protected and private), even if all the properties are public:
*/

//Example 2
echo "<br><br> Example 2 <br>";

class Fruit1
{
	public $name1;
	public $color1;
	public $weight1;

	function set_name($n) //default public
	{
		//a public function (default)
		$this -> name1 = $n;
	}

	protected function set_color($n)
	{
		//a protected function
		$this -> color1 = $n;
	}

	private function set_weight($n)
	{
		//a private function
		$this -> weight1 = $n;
	}
}

$mango1 = new Fruit1();
echo $mango1 -> set_name('Mango'); //OK
//$mango1 -> set_color('Yellow'); //ERROR
//$mango1 -> set_weight('300'); //ERROR


//=> khong the truy cap vao dl cho du cac thuoc tinh la public

echo "<br>--------------------------------------------<br>";
#2. PHP OOP - Inheritance
echo "PHP OOP - Inheritance";
/*
//PHP - What is Inheritance?
-Inheritance in OOP = When a class derives from another class.
-The child class will inherit all the public and protected properties and methods from the parent class. In addition, it can 	have its own properties and methods.
-An inherited class is defined by using the "extends" keyword.
*/

//Code Example

class Fruit2
{
	public $name2;
	public $color2;
	public function __construct($name2, $color2)
	{
		$this -> name2 = $name2;
		$this -> color2 = $color2;
	}

	public function intro()
	{
		echo "<br> The fruit is: {$this -> name2} and the color is {$this -> color2}.";
	}
}

//Strawberry is inherited from Fruit (dau ke thua tu Fruit)
class Strawberry extends Fruit2 //Strawberry ke thua tu Fruit2
{
	public function message()
	{
		echo "<br> Am I a fruit or a berry?";
	}
}

//start
$strawberry = new Strawberry("Strawberry", "Red");
$strawberry->message();
$strawberry->intro();  //tu strawberry co the truy cap intro tu Fruit2


//Example Explained
/*
-The Strawberry class is inherited from the Fruit class.
-This means that the Strawberry class can use the public $name and $color properties as well as the public __construct() and intro() methods from the Fruit class because of inheritance.
-The Strawberry class also has its own method: message().
*/

//PHP - Inheritance and the Protected Access Modifier
echo "<br><br> -Inheritance and the Protected Access Modifier";
/*
-In the previous chapter we learned that protected properties or methods can be accessed within the class and by classes derived from that class. What does that mean?
Let's look at an example:
*/

//Example 1
echo "<br> Example 1";

class Fruit3
{
	public $name3;
	public $color3;
	public function __construct($name3, $color3)
	{
		$this -> name3 = $name3;
		$this -> color3 = $color3;
	}
	protected function intro3()
	{
		echo "<br> The fruit is: {$this -> name3} and the color is {$this -> color3}.";
	}
}
//Ke thua

class Strawberry3 extends Fruit3
{
	public function message3()
	{
		echo "<br> Am I a fruit or berry? ";
	}
}

//Try to call all three methods from outside class
$strawberry3 = new Strawberry3("Strawberry", "Red"); //OK. __construct is public
$strawberry3 -> message3(); //OK. message() is public
//$strawberry3 -> intro3(); //ERROR. intro() is protected

/*
-In the example above we see that if we try to call a protected method (intro()) from outside the class, we will receive an error. public methods will work fine!
*/

//Example 2
echo "<br><br> Example 2 <br>";

class Fruit4
{
	public $name4;
	public $color4;
	public function __construct($name4, $color4)
	{
		$this -> name4 = $name4;
		$this -> color4 = $color4;
	}
	protected function intro4()
	{
		echo "<br> The fruit is: {$this -> name4} and the color is {$this -> color4}.";
	}
}

//Ke thua
class Strawberry4 extends Fruit4
{
	public function message4()
	{
		echo "Am I a fruit or berry? ";
		//Call protected function from within derived class - OK
		//goi ham intro4() qua mess4 (public)
		$this -> intro4();
	}
}

$strawberry4 = new Strawberry4("Strawberry","Red"); //OK. __construct is public
$strawberry4 -> message4(); //OK. mess4() is public and it call intro() (which is protected) from within the derived class

//In the example above we see that all works fine! It is because we call the protected method (intro()) from inside the derived class.

//PHP - Overriding Inherited Methods
echo "<br><br> PHP - Overriding Inherited Methods <br>";
/*
-Inherited methods can be overridden by redefining the methods (use the same name) in the child class.
-Look at the example below. The __construct() and intro() methods in the child class (Strawberry) will override the __construct() and intro() methods in the parent class (Fruit):
*/

//Example

class Fruit5
{
	public $name5;
	public $color5;
	public function __construct($name5, $color5)
	{
		$this -> name5 = $name5;
		$this -> color5 = $color5;
	}
	public function intro5() 
	{
		echo "<br> The fruit is: {$this->name5} and the color is {$this->color5}.";
	}
}

class Strawberry5 extends Fruit5
{
	public $weight5;
	public function __construct($name5, $color5, $weight5) //voi name, color lay tu Fruit
	{
		$this -> name5 =$name5;
		$this -> color5 = $color5;
		$this -> weight5 = $weight5;
	}
	//intro but of straw
	public function intro5() //Overriding from straw5 to fruit5
	{
		echo "The fruit is {$this->name5}, the color is {$this->color5}, and the weight is {$this->weight5} gram.";
	}
}

$strawberry5 = new Strawberry5("Lemon","Yellow",85);
$strawberry5 -> intro5();

//PHP - The final Keyword
echo "<br><br> PHP - The final Keyword";
/*
-The "final" keyword can be used to prevent class inheritance or to prevent method overriding.
*/

//Example 1 - The following example shows how to prevent class inheritance:
echo "<br> Example 1 <br>";

final class Fruit6
{
	//code..
}
/*
class Strawberry6 extends Fruit6
{
	//code...
}
*/
//output: Fatal error: Class Strawberry6 may not inherit from final class (Fruit6) in E:\Xampp Real\htdocs\PHP Training\4 PHP OOP\Bai 3.php on line 258

echo "Loi k the ke thua: <br>Fatal error: Class Strawberry6 may not inherit from final class (Fruit6) in E:\Xampp Real\htdocs\PHP Training\4 PHP OOP\Bai 3.php on line 258";



//Example 2 - The following example shows how to prevent method overriding:
echo "<br><br> Example 2 <br>";

class Fruit7
{
	final public function intro7()
	{
		//code...
	}
}
/*
class Strawberry7 extends Fruit7
{
	//will result i error
	public function intro7() //Cant Overriding
	{
		//some code
	}
}
*/
//output: Fatal error: Cannot override final method Fruit7::intro7() in E:\Xampp Real\htdocs\PHP Training\4 PHP OOP\Bai 3.php on line 280

echo "Loi k the ghi de: <br>Fatal error: Cannot override final method Fruit7::intro7() in E:\Xampp Real\htdocs\PHP Training\4 PHP OOP\Bai 3.php on line 280";
?>