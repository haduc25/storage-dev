<?php
#1. PHP OOP - Class Constants
echo "PHP OOP - Class Constants";
/*
-Constants cannot be changed once it is declared.
-Class constants can be useful if you need to define some constant data within a class.
-A class constant is declared inside a class with the "const" keyword.
-Class constants are case-sensitive. However, it is recommended to name the constants in all uppercase letters.(nen dinh nghia 1 hang so bang chu hoa)
-We can access a constant from outside the class by using the class name followed by the scope resolution operator (::) followed by the constant name, like here:
*/

//Example 1 - Su dung (::) 
echo "<br><br> Example 1 <br>";

class Goodbye
{
	const LEAVING_MESSAGE = "Thank you for visiting www.HaDuc25.com !"; //Hang so
}

echo Goodbye::LEAVING_MESSAGE;


//Example 2 - use Self
echo "<br><br> Example 2 <br>";

class Goodbye1
{
	const LEAVING_MESSAGE1 = "Thank you for visiting www.HaDuc25.com !"; //Hang so
	public function byebye()
	{
		echo self::LEAVING_MESSAGE1;
	}
}

$goodbye =  new Goodbye1();
$goodbye -> byebye(); // goi function byebye();


echo "<br>--------------------------------------------<br>";
#2. PHP OOP - Abstract Classes
echo "<br> PHP OOP - Abstract Classes <br>";

//PHP - What are Abstract Classes and Methods?
echo "-What are Abstract Classes and Methods? <br>";

/*
-Abstract classes and methods are when the parent class has a named method, but need its child class(es) to fill out the tasks.
-An abstract class is a class that contains at least one abstract method. An abstract method is a method that is declared, but not implemented in the code.
-An abstract class or method is defined with the "abstract" keyword:

*Syntax
		<?php
		abstract class ParentClass {
		  abstract public function someMethod1();
		  abstract public function someMethod2($name, $color);
		  abstract public function someMethod3() : string;
		}
		?>

-When inheriting from an abstract class, the child class method must be defined with the same name, and the same or a less restricted access modifier. So, if the abstract method is defined as protected, the child class method must be defined as either protected or public, but not private. Also, the type and number of required arguments must be the same. However, the child classes may have optional arguments in addition.
-So, when a child class is inherited from an abstract class, we have the following rules:
	+The child class method must be defined with the same name and it redeclares the parent abstract method
	+The child class method must be defined with the same or a less restricted access modifier
	+The number of required arguments must be the same. However, the child class may have optional arguments in addition
*/


//Code Example


//Parent Class
	abstract class Cars
	{
		public $name;
		public function __construct($name)
		{
			$this -> name = $name;
		}
		abstract public function intro() : string;
	}

//Child Classes
class Audi extends Cars
{
	public function intro() : string
	{
		return "Choose German quality! I'm an $this->name !";
	}
}

class BMW extends Cars //Volvo
{
	public function intro() : string
	{
		return "Proud to be Swedish! I'm a $this->name!"; 
	}
}

class Mercedes extends Cars //Citroen
{
	public function intro() : string 
	{
		return "German extravagance! I'm a $this->name!";
	}
}


//Create object from the child classes
$audi = new Audi("Audi");
echo $audi->intro();
echo "<br>";

$bmw = new BMW("BMW");
echo $bmw->intro();
echo "<br>";

$mercedes = new Mercedes("Mercedes");
echo $mercedes->intro();
echo "<br>";

/*
//Example Explained
-The Audi, Volvo, and Citroen classes are inherited from the Car class. This means that the Audi, Volvo, and Citroen classes can use the public $name property as well as the public __construct() method from the Car class because of inheritance.
-But, intro() is an abstract method that should be defined in all the child classes and they should return a string.
*/

echo "<br> PHP - More Abstract Class Examples <br>";


//Example 1 - Let's look at another example where the abstract method has an argument:
echo "Example 1 <br>";

abstract class ParentClass
{
	//Abstract method with an argument
	abstract protected function prefixName($name1);
}

class ChildClass extends ParentClass
{
	public function prefixName($name1)
	{
		if ($name1 == "Ha Duc") 
		{
			$prefix = "Hello Mr.";
		}elseif ($name1 == "Nguyen Thuy") 
		{
			$prefix = "Welcome Mrs.";
		}else
		{
			$prefix = "";
		}
		return "{$prefix} {$name1}";
	}
}

$classTest = new ChildClass;
echo $classTest -> prefixName("Ha Duc");
echo "<br>";
echo $classTest -> prefixName("Nguyen Thuy");
echo "<br>";
echo $classTest -> prefixName("Hoang Son");
echo "<br>";


//Example 2 - Let's look at another example where the abstract method has an argument, and the child class has two optional arguments that are not defined in the parent's abstract method:
echo "<br> Example 2 <br>";


abstract class ParentClass2
{
	//Abstract method with an argument
	abstract protected function prefixName2($name2);
}

class ChildClass2 extends ParentClass2
{
	//The child class may define optinal arguments that is not in the parent's abstract method.
	public function prefixName2($name2, $separator2 = ".", $greet = "Dear")
	{
		if ($name2 == "Ha Duc") 
		{
			$prefix2 = "Mr";
		}elseif ($name2 == "Nguyen Thuy") 
		{
			$prefix2 = "Mrs";
		}else
		{
			$prefix2 = "";
		}
		return "{$greet} {$prefix2}{$separator2} {$name2}";
	}
}

$classTest2 = new ChildClass2;
echo $classTest2 -> prefixName2("Ha Duc");
echo "<br>";
echo $classTest2 -> prefixName2("Nguyen Thuy");
echo "<br>";
echo $classTest2 -> prefixName2("Hoang Son");
echo "<br>";
?>