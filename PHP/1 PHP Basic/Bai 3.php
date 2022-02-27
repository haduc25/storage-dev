<?php
#1.Constants (Constants are like variables except that once they are defined they cannot be changed or undefined.)
echo "-Constants (Constant Arrays, Constants are Global)<br><br>";

#1. Constants
/*
-Create a PHP Constant (To create a constant, use the define() function.)
*Systax
define(name, value, case-insensitive)

*Parameters:
name: Specifies the name of the constant
value: Specifies the value of the constant
case-insensitive: Specifies whether the constant name should be case-insensitive. Default is false
*/
#Create a constant with a case-sensitive name: /phan biet chu hoa,thuong
define("HaDuc", "Well, Have a good days"); //(ten ham, noi dung,false)
echo HaDuc;
echo "<br>";

#Create a constant with a case-insensitive name: /k phan biet chu hoa,thuong

define("MinhDuc","Good Morning !",''); //(ten ham, noi dung,true) ,(loi k ho tro)
echo MinhDuc;


#Constant Arrays
/*
-Create an Array constant using the define() function.
*/

echo "<br>";
define("cars",["BMW","Audi","Zenos"]);
echo cars[0];
echo "<br>";
echo cars[1];
echo "<br>";
echo cars[2];
echo "<br>";

#Constants are Global (Constants are automatically global and can be used across the entire script.)

define("Super","Welcome to My World !");
function myTest()
{
	echo Super;
}

myTest();

echo "<br> ------------------------------------- <br>";

#2. Operators (Operators are used to perform operations on variables and values.)
/*
PHP divides the operators in the following groups:

-Arithmetic operators
-Assignment operators
-Comparison operators
-Increment/Decrement operators
-Logical operators
-String operators
-Array operators
-Conditional assignment operators

*/

//Arithmetic Operators (+,-,*,/,%,**)
//**: Exponentiation (luy thua)
/*
+	Addition	$x + $y	Sum of $x and $y	
-	Subtraction	$x - $y	Difference of $x and $y	
*	Multiplication	$x * $y	Product of $x and $y	
/	Division	$x / $y	Quotient of $x and $y	
%	Modulus	$x % $y	Remainder of $x divided by $y	
**	Exponentiation	$x ** $y	Result of raising $x to the $y'th power
*/
echo "<br> Arithmetic Operators <br>";
#Exponentiation
$a1 = 10;
$a2 = 3;
echo "A1= $a1 & A2 = $a2";
echo " <br>";
echo "Result: ".$a1**$a2;
echo " <br>";

//Assignment Operators
/*
x = y	x = y	The left operand gets set to the value of the expression on the right	
x += y	x = x + y	Addition	
x -= y	x = x - y	Subtraction	
x *= y	x = x * y	Multiplication	
x /= y	x = x / y	Division	
x %= y	x = x % y	Modulus
*/
echo "<br> Assignment Operators <br>...";
//Comparison Operators
/*
==	Equal	$x == $y	Returns true if $x is equal to $y	
===	Identical	$x === $y	Returns true if $x is equal to $y, and they are of the same type	
!=	Not equal	$x != $y	Returns true if $x is not equal to $y	
<>	Not equal	$x <> $y	Returns true if $x is not equal to $y	
!==	Not identical	$x !== $y	Returns true if $x is not equal to $y, or they are not of the same type	
>	Greater than	$x > $y	Returns true if $x is greater than $y	
<	Less than	$x < $y	Returns true if $x is less than $y	
>=	Greater than or equal to	$x >= $y	Returns true if $x is greater than or equal to $y	
<=	Less than or equal to	$x <= $y	Returns true if $x is less than or equal to $y	
<=>	Spaceship	$x <=> $y	Returns an integer less than, equal to, or greater than zero, depending on if $x is less than, equal to, or greater than $y. Introduced in PHP 7.
*/
echo "<br> Comparison Operators <br>...";

#Identical
echo "<br> === (Identical) <br>";
$x11 = 155;
$y11 = "155";

var_dump($x11 === $y11); // returns false because types are not equal

#Not equal
echo "<br> !=,<> (Inequality) <br>";
$x6 = 100;
$y6 = "100";

var_dump($x6 != $y6); // returns false because values are equal
echo "<br>";

$x7 = 50;
$y7 = "50";

var_dump($x7 <> $y7); // returns false because values are equal

#Not identical
echo "<br> !==	(Not identical) <br>";
$x12 = 100;  
$y12 = "100";

var_dump($x12 !== $y12); // returns true because types are not equal

#Spaceship
echo "<br> <=> (Spaceship) <br>";
$x8 = 15;
$y8 = 20;

echo ($x8 <=> $y8); // returns -1 because $x8 is less than $y8
echo "<br>";

$x9 = 25;
$y9 = 25;

echo ($x9 <=> $y9); // returns 0 because values are equal
echo "<br>";

$x10 = 35;
$y10 = 30;

echo ($x10 <=> $y10); // returns +1 because $x10 is greater than $y110
echo "<br>";
// Increment / Decrement Operators
/*
++$x	Pre-increment	Increments $x by one, then returns $x	
$x++	Post-increment	Returns $x, then increments $x by one	
--$x	Pre-decrement	Decrements $x by one, then returns $x	
$x--	Post-decrement	Returns $x, then decrements $x by one
*/
echo "<br> Increment / Decrement Operators <br>";
#++$x	(Pre-increment)
$a = 10;
echo "value a=$a <br>";
echo ++$a;

#$x++	(Pre-increment)
$a1 = 5;
echo "<br> value a1=$a1 <br>";
echo $a1++;
echo "<br>";
echo $a1++;
echo "<br>...";
//--$x, $x-- (same)

//Logical Operators
/*
and	And	$x and $y	True if both $x and $y are true	
or	Or	$x or $y	True if either $x or $y is true	
xor	Xor	$x xor $y	True if either $x or $y is true, but not both	
&&	And	$x && $y	True if both $x and $y are true	
||	Or	$x || $y	True if either $x or $y is true	
!	Not	!$x	True if $x is not true
*/
echo "<br> Logical Operators <br>";
#And
$a2 = 10;
$b2 = 5;
 if($a2 == 10 and $b2 == 5)
 {
 	echo "<br> hello a2[$a2] & b2[$b2] <br>";
 }
 #(Or same And)
 #Xor (giong toan tu || neu 1 trong 2 dung thi chay)
 $a3 = 100;
 $b3 = 50;

 if($a3 == 100 xor $b3 == 80)  //o day a3 dung
 {
 	echo "<br> hello a3[$a3] & b3[$b3] <br>";
 }
#&&, || dung nhu bt
 #! 
 $a4 = 25;
 if($a4 !== 30)
 {
 	echo "<br> a4 khac 30, value of a4=$a4 <br>";
 }

//String Operators
/*
.	Concatenation	$txt1 . $txt2	Concatenation of $txt1 and $txt2	
.=	Concatenation assignment	$txt1 .= $txt2	Appends $txt2 to $txt1
*/
echo "<br> String Operators <br>";
$txt1 = "Welcome ";
$txt2 = "to VietNam !";
$txt1.=$txt2;
echo $txt1;

//Array Operators (The PHP array operators are used to compare arrays.)
/*
+	Union	$x + $y	Union of $x and $y	
==	Equality	$x == $y	Returns true if $x and $y have the same key/value pairs	
===	Identity	$x === $y	Returns true if $x and $y have the same key/value pairs in the same order and of the same types	
!=	Inequality	$x != $y	Returns true if $x is not equal to $y	
<>	Inequality	$x <> $y	Returns true if $x is not equal to $y	
!==	Non-identity	$x !== $y	Returns true if $x is not identical to $y
*/
echo "<br> Array Operators <br>";
#Union
echo "<br> + (Union) <br>";
$x1 = array("a" => "red", "b" => "green");
$y1 = array("c" => "blue", "d" => "yellow");

print_r($x1 + $y1); //union of $x1 and y1	

#Equality
echo "<br> == (Equality) <br>";
$x2 = array("a" => "white", "b" => "gray"); 
$y2 = array("a" => "white", "b" => "gray");
$x3 = array("a" => "white", "b" => "gray"); 
$y3 = array("c" => "black", "d" => "lime");

var_dump($x2 == $y2); //output: true
echo "<br>";	
var_dump($x3 == $y3); //output: false

#Identity
echo "<br> === (Identity) <br>";
$x4 = array("a" => "blue", "b" => "orange");
$y4 = array("a" => "blue", "b" => "orange");
$x5 = array("a" => "purple", "b" => "green");
$y5 = array("c" => "maroon", "d" => "silver");

var_dump($x4 === $y4); //output: true
echo "<br>";	
var_dump($x5 === $y5); //output: false



#Non-identity
echo "<br> !== (Non-identity) <br>";
 
$x8 = array("a" => "white", "b" => "black");
$y8 = array("c" => "pink", "d" => "yellow");

var_dump($x8 !==$y8);

//Conditional Assignment Operators
/*
?:		Ternary				$x = expr1 ? expr2 : expr3			Returns the value of $x.
																The value of $x is expr2 if expr1 = TRUE.
																The value of $x is expr3 if expr1 = FALSE	

??		Null coalescing		$x = expr1 ?? expr2					Returns the value of $x.
																The value of $x is expr1 if expr1 exists, and is not NULL.
																If expr1 does not exist, or is NULL, the value of $x is expr2.
																Introduced in PHP 7
*/


#Ternary
echo "<br> ?: (Ternary) <br>";
	//if empty($user) = TRUE, set $status = "anonymous";
echo $status = (empty($user)) ? "anonymous" : "logged in"; //if user empty thi chay vao anonymous
echo "<br>";

$user = "Ha Duc"; //them user
	//if empty($user) = FALSE, set $status = "logged in";
echo $status = (empty($user)) ? "anonymous" : "logged in"; //if them user chay vao logged in


#Null coalescing
echo "<br> ??	Null coalescing <br>";
   // variable $user is the value of $_GET['user']
   // and 'anonymous' if it does not exist
echo $user1 = $_GET['user1'] ?? "anonymous";
echo "<br>";

   // variable $color is "red" if $color does not exist or is null
echo $color = $color ?? "red";

echo "<br> ------------------------------------- <br>";
#3. if...else...elseif Statements


#The if Statement
/*
*Syntax: 
	if (condition) {
  	code to be executed if condition is true;
	}
*/

//example:
$t = date("H");
echo $t."<br>";
if($t < "20")
{
	 echo "Have a good day!";
}else
{
	echo "Have a good night!";
}


#The if...elseif...else Statement
/*
*Syntax:
	if (condition) {
  		code to be executed if this condition is true;
	} elseif (condition) {
  		code to be executed if first condition is false and this condition is true;
	} else {
  		code to be executed if all conditions are false;
	}
*/

//example:
$t1 = date("H");
echo "<br>";
echo $t."<br>";
if($t1 < "10")
{
	echo "Have a good morning!";
}elseif($t1 < "20")
{
	echo "Have a good day!";
}else
{
	echo "Have a good night!";
}
echo "<br>";
#Switch Statement
/*
Syntax
switch (n) {
  case label1:
    code to be executed if n=label1;
    break;
  case label2:
    code to be executed if n=label2;
    break;
  case label3:
    code to be executed if n=label3;
    break;
    ...
  default:
    code to be executed if n is different from all labels;
}
*/

//example:
$favcolor = "yellow";

switch ($favcolor) 
{
	case 'red':
		  echo "Your favorite color is red!";
		  break;
	case 'blue':
		  echo "Your favorite color is blue!";
		  break;
    case 'yellow':
    	   echo "Your favorite color is yellow!";
		  break;
	default:
		 echo "Your favorite color is neither red, blue, nor yellow!";
		  break;
}

?>