<?php
#1. PHP OOP - Interfaces
echo "PHP OOP - Interfaces";
/*
//PHP - What are Interfaces?
-Interfaces allow you to specify what methods a class should implement.
-Interfaces make it easy to use a variety of different classes in the same way. When one or more classes use the same interface, it is referred to as "polymorphism".
-Interfaces are declared with the "interface" keyword:

*Syntax
		<?php
		interface InterfaceName {
		  public function someMethod1();
		  public function someMethod2($name, $color);
		  public function someMethod3() : string;
		}
		?>
*/
//PHP - Interfaces vs. Abstract Classes
echo "<br> -Interfaces vs. Abstract Classes";
/*
-Interface are similar to abstract classes. The difference between interfaces and abstract classes are:
	+Interfaces cannot have properties, while abstract classes can
	+All interface methods must be public, while abstract class methods is public or protected
	+All methods in an interface are abstract, so they cannot be implemented in code and the abstract keyword is not  necessary
	+Classes can implement an interface while inheriting from another class at the same time
*/

//PHP - Using Interfaces
echo "<br> -Using Interfaces <br>";
/*
-To implement an interface, a class must use the "implements" keyword.
-A class that implements an interface must implement all of the interface's methods.
*/

//Example 1 
echo "Example 1 <br>";

interface Animal
{
	public function makeSound();
}

class Cat implements Animal //same ke thua 
{
	public function makeSound()
	{
		echo "Meow";
	}
}

$animal = new Cat();
$animal -> makeSound();

/*
-From the example above, let's say that we would like to write software which manages a group of animals. There are actions that all of the animals can do, but each animal does it in its own way.
-Using interfaces, we can write some code which can work for all of the animals even if each animal behaves differently:
*/

//Example 2 - Manager Animal
echo "<br><br> Example 2 <br>";

//Interface Definition
interface Animal1
{
	public function makeSound1();
}

//Class Definitions
class Cat1 implements Animal1
{
	public function makeSound1()
	{
		echo "Meow";
	}
}

class Dog1 implements Animal1
{
	public function makeSound1()
	{
		echo "Brak";
	}
}

class Mouse1 implements Animal1
{
	public function makeSound1()
	{
		echo "Squeak";
	}
}

//Create a list of animals
$cat1 = new Cat1();
$dog1 = new Dog1();
$mouse1 = new Mouse1();
$animals = array($cat1, $dog1, $mouse1);

//Tell the animals to make a sound
foreach ($animals as $animals1)
{
	$animals1 -> makeSound1();
	echo "<br>";
}

echo "--------------------------------------------<br>";

#2. PHP OOP - Traits
echo "<br> PHP OOP - Traits";

//PHP - What are Traits?
echo "<br> -What are Traits? <br>";
/*
-PHP only supports single inheritance: a child class can inherit only from one single parent.
-So, what if a class needs to inherit multiple behaviors? OOP traits solve this problem.
-Traits are used to declare methods that can be used in multiple classes. Traits can have methods and abstract methods that can be used in multiple classes, and the methods can have any access modifier (public, private, or protected).
-Traits are declared with the "trait" keyword:

*Syntax
		<?php
		trait TraitName {
		  // some code...
		}
		?>

//To use a trait in a class, use the "use" keyword:

*Syntax
		<?php
		class MyClass {
		  use TraitName;
		}
		?>
*/

//Example

trait message
{
	public function msg()
	{
		echo "OOP is have fun!";
	}
}

class Welcome 
{
	use message; //use trait message
}

$obj = new Welcome();
$obj -> msg();

//=> co the dung thay ke thua

/*
*Example Explained
-Here, we declare one trait: message1. Then, we create a class: Welcome. The class uses the trait, and all the methods in the trait will be available in the class.
-If other classes need to use the msg1() function, simply use the message1 trait in those classes. This reduces code duplication, because there is no need to redeclare the same method over and over again.
*/

//PHP - Using Multiple Traits
echo "<br><br> -Using Multiple Traits <br>";

trait message1
{
	public function msg1()
	{
		echo "I learing OOP it's so fun! ";
	}
}

trait message2
{
	public function msg2()
	{
		echo "OOP reduces code duplication!";
	}
}

class Welcome1
{
	use message1;
}

class Welcome2
{
	use message1, message2;
}

$obj1 = new Welcome1();
$obj1 -> msg1();
echo "<br>";

$obj2 = new Welcome2();
$obj2 -> msg1();
$obj2 -> msg2();
echo "<br>";


/*
*Example Explained
-Here, we declare two traits: message1 and message2. Then, we create two classes: Welcome and Welcome2. The first class (Welcome) uses the message1 trait, and the second class (Welcome2) uses both message1 and message2 traits (multiple traits are separated by comma).
*/
?>