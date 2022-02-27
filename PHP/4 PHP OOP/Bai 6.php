<?php
#1. PHP OOP - Static Methods
echo "PHP OOP - Static Methods <br>";
/*
-Static methods can be called directly - without creating an instance of the class first.
-Static methods are declared with the "static" keyword:

*Syntax
		<?php
		class ClassName {
		  public static function staticMethod() {
		    echo "Hello World!";
		  }
		}
		?>


//To access a static method use the class name, double colon (::), and the method name:

*Syntax
		ClassName::staticMethod();
*/

//Example

class Greeting
{
	public static function welcome()
	{
		echo "Hello World !!!";
	}
}

//Call static method
Greeting::welcome();  

/*
*Example Explained
Here, we declare a static method: welcome(). Then, we call the static method by using the class name, double colon (::), and the method name (without creating an instance of the class first).
*/

//PHP - More on Static Methods
echo "<br> -More on Static Methods <br>";
/*
-A class can have both static and non-static methods. A static method can be accessed from a method in the same class using the "self" keyword and double colon (::):
*/


//Example 1 - Manager Animal
echo "Example 1 <br>";

class Greeting1
{
	public static function welcome1()
	{
		echo "Hello Ha Duc";
	}
	//construct
	public function __construct()
	{
		self::welcome1(); //same __construct::welcome();
	}
}

new Greeting1();	


//Example 2 - Static methods can also be called from methods in other classes. To do this, the static method should be public:
echo "<br><br> Example 2 <br>";

class greeting2
{
	public static function welcome2()
	{
		echo "Love all !!!";
	}
}

class SomeOtherClass
{
	public function message2()
	{
		greeting2::welcome2();
	}
}

//Example 3 - To call a static method from a child class, use the parent keyword inside the child class. Here, the static method can be public or protected.
echo "<br> Example 3 <br>";

class domain
{
	protected static function getWebsiteName()
	{
		return "HaDuc25LearningPHP.com";
	}
}

class domainHD25 extends domain
{
	public $WebsiteName;
	public function __construct()
	{
		$this -> WebsiteName = parent::getWebsiteName(); 
	}
}


$domainTest = new domainHD25;
echo $domainTest -> WebsiteName;


echo "<br>--------------------------------------------<br>";

#2. PHP OOP - Static Properties
echo "<br> PHP OOP - Static Properties <br>";
echo "-Static Properties <br>";
/*
-Static properties can be called directly - without creating an instance of a class.
-Static properties are declared with the "static" keyword:

*Syntax
		<?php
		class ClassName {
		  public static $staticProp = "W3Schools";
		}
		?>

//To access a static property use the class name, double colon (::), and the property name:

*Syntax
		ClassName::staticProp;
*/

//Example

class pi
{
	public static $value = 3.1459;
}

//Get static property
echo pi::$value; //ten class + ten static function

/*
*Example Explained
-Here, we declare a static property: $value. Then, we echo the value of the static property by using the class name, double colon (::), and the property name (without creating a class first).
*/

//PHP - More on Static Properties
echo "<br><br> PHP - More on Static Properties <br>";
/*
-A class can have both static and non-static properties. A static property can be accessed from a method in the same class using the self keyword and double colon (::):
*/

//Example 1
echo "Example 1 <br>";

class pi1
{
	public static $value1 = 3.14159;
	public function staticValue()
	{
		return self::$value1; //self truy cap den value1
	}
}

//Get static property
$pi1 = new pi1();
echo "Value of pi1 is: " . $pi1 -> staticValue() . "<br>";

/*
-To call a static property from a child class, use the parent keyword inside the child class:
*/

//Example 2
echo "<br> Example 2 <br>";

class pi2
{
	public static $value2 = 3.14159;
}

class x extends pi2 //x ke thua tu pi2
{
	public function xStatic()
	{
		return parent::$value2; //tra ve gia tri value2 trong pi2
	}
}

//solution 1
//Get value of static property directly via child class
echo "Solution 1: Value of x is: " . x::$value2 . "<br>";

//solution 2
//Get value of static property via xStatic() method
$x = new x();
echo "Solution 2: Value of x is: " . $x -> xStatic() . "<br>";
?>