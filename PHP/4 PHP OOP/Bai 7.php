<?php
namespace Html;

#1. PHP Namespaces
echo "PHP Namespaces <br>";
/*
-Namespaces are qualifiers that solve two different problems:
	+They allow for better organization by grouping classes that work together to perform a task
	+They allow the same name to be used for more than one class

-For example, you may have a set of classes which describe an HTML table, such as Table, Row and Cell while also having another set of classes to describe furniture, such as Table, Chair and Bed. Namespaces can be used to organize the classes into two different groups while also preventing the two classes Table and Table from being mixed up.
*/

//Declaring a Namespace
echo "-Declaring a Namespace <br>";
/*
-Namespaces are declared at the beginning of a file using the "namespace" keyword:

*Syntax - Declare a namespace called Html:
		
		namespace Html;

//Note: A namespace declaration must be the first thing in the PHP file. The following code would be invalid:

//Example: -> ERROR

		<?php
		echo "Hello World!";
		namespace Html;
		...
		?>

Constants, classes and functions declared in this file will belong to the Html namespace:
*/

//Example - Create a Table class in the Html namespace:

//namespace Html; //declare đầu file
class Table 
{
	public $title = "";
	public $numRows = 0;
	public function message()
	{
		echo "<p>Table '{$this -> title}' has  {$this -> numRows} rows.</p>";
	}
}

$table = new Table();
$table -> title = "My table";
$table -> numRows = 5;
//Call mess
$table -> message();


/*
-For further organization, it is possible to have nested namespaces:

*Syntax - Declare a namespace called Html inside a namespace called Code:

		namespace Code\Html;
*/


//Using Namespaces
echo "-Using Namespaces <br>";

/*
-Any code that follows a namespace declaration is operating inside the namespace, so classes that belong to the namespace can be instantiated without any qualifiers. To access classes from outside a namespace, the class needs to have the namespace attached to it.
*/


//Example 1 - Use classes from the Html namespace:
echo "Example 1 <br>";
echo "Path Example1: E:\Xampp Real\htdocs\PHP Training\ 4 PHP OOP\Bai 7_Example1.php <br> Path Local: http://localhost/PHP%20Training/4%20PHP%20OOP/Bai%207_Example1.php";


/*
-When many classes from the same namespace are being used at the same time, it is easier to use the namespace keyword:
*/

//Example 2 - Use classes from the Html namespace without the need for the Html\qualifier:
echo "<br><br> Example 2 <br>";
echo "Path Example2: E:\Xampp Real\htdocs\PHP Training\ 4 PHP OOP\Bai 7_Example2.php <br> Path Local: http://localhost/PHP%20Training/4%20PHP%20OOP/Bai%207_Example2.php";

//Namespace Alias
echo "<br><br> -Namespace Alias";
/*
-It can be useful to give a namespace or class an alias to make it easier to write. This is done with the "use" keyword:
*/

//Example 3 - Give a namespace an alias:
echo "<br> Example 3 <br>";
echo "Path Example3: E:\Xampp Real\htdocs\PHP Training\ 4 PHP OOP\Bai 7_Example3.php <br> Path Local: http://localhost/PHP%20Training/4%20PHP%20OOP/Bai%207_Example3.php";


//Example 4 - Give a class an alias:
echo "<br><br> Example 4 <br>";
echo "Path Example4: E:\Xampp Real\htdocs\PHP Training\4 PHP OOP\Bai 7_Example4.php <br> Path Local: http://localhost/PHP%20Training/4%20PHP%20OOP/Bai%207_Example4.php";


?>