<?php
#1. PHP Arrays
echo "PHP Arrays"; //An array stores multiple values in one single variable:

//ex1
$cars = array("BMW","Lamborghini","Mercedes");

echo "<br> I like ".$cars[0]." and ".$cars[1]. " Best choice is: ".$cars[2];

/*
In PHP, there are three types of arrays:

Indexed arrays 				- Arrays with a numeric index
Associative arrays 			- Arrays with named keys
Multidimensional arrays 	- Arrays containing one or more arrays

*/

/*Get The Length of an Array - The count() Function
The count() function is used to return the length (the number of elements) of an array:
*/

//ex

$cars1 = array("BMW","Lamborghini","Mercedes","Honda","Audi");
echo "<br> Value in Array Cars1 is: ".count($cars1);

echo "<br> ------------------------------------- <br>";
#2. PHP Indexed Arrays
echo "<br> PHP Indexed Arrays";
/*
There are two ways to create indexed arrays:
The index can be assigned automatically (index always starts at 0), like this:
*/

$fruits = ["Apple", "Banana", "Orange"];

echo "<br> I wanna eat ".$fruits[0]. " and ".$fruits[1].", ".$fruits[2];

//Loop Through an Indexed Array - To loop through and print all the values of an indexed array, you could use a for loop, like this:

//ex

$cars2 = array("Chevrolet","Ford", "Hyundai","Mazda","Suzuki");
$arr_length = count($cars2); //dem mang

for ($x=0; $x < $arr_length ; $x++) 
{ 
	echo $cars2[$x];
	echo "<br>";
}

#3. PHP Associative Arrays
echo "<br> PHP Associative Arrays";
/*
Associative arrays are arrays that use named keys that you assign to them.
There are two ways to create an associative array
*/

//ex
//solution 1
$age = array("Peter" => "19", "Ha Duc" => "20", "Joe" => "25");

echo "<br> Peter is ".$age['Peter']. " years old !";
echo "<br> Ha Duc is ".$age['Ha Duc']. " years old !";
echo "<br> Joe is ".$age['Joe']. " years old !";

//solution 2

$age1['Ha'] = "15";
$age1['Minh'] = "16";
$age1['Duc'] = "20";

echo "<br>";
echo "<br> Ha's ".$age1['Ha']. " years old !";
echo "<br> Minh's ".$age1['Minh']. " years old !";
echo "<br> Duc's ".$age1['Duc']. " years old !";
echo "<br>";
echo "<br>";	
//Loop Through an Associative Array - To loop through and print all the values of an associative array, you could use a foreach loop, like this:

//ex

$age2 = array("Linh" => "18", "Duc" => "21", "Mai Anh" => "15");

foreach ($age2 as $x1 => $x_value) 
{
	echo "Key= ".$x1.", Value= ".$x_value;
	echo "<br>";
}

#4. PHP Multidimensional Arrays
echo "<br> PHP Multidimensional Arrays";
/*
A multidimensional array is an array containing one or more arrays.

PHP supports multidimensional arrays that are two, three, four, five, or more levels deep. However, arrays more than three levels deep are hard to manage for most people.

//note
The dimension of an array indicates the number of indices you need to select an element.

For a two-dimensional array you need two indices to select an element
For a three-dimensional array you need three indices to select an element

//table example
Name				Stock			Sold
Volvo				22				18
BMW					15				13
Saab				5				2
Land Rover			17				15
*/
//We can store the data from the table above in a two-dimensional array, like this:

$cars3 = array
(
	array("Volvo", 22, 18),
	array("BMW", 15, 13),
	array("Saab", 5, 2),
	array("Land Rover", 17, 15)
);

//output
echo "<br>";
echo $cars3[0][0].": In Stock: ".$cars3[0][1].", Sold: ".$cars3[0][2]."<br>";
//echo $cars3[0][0](name).": In Stock: ".$cars3[0][1](stock).", Sold: ".$cars3[0][2](sold)."<br>";
echo $cars3[1][0].": In Stock: ".$cars3[1][1].", Sold: ".$cars3[1][2]."<br>";
echo $cars3[2][0].": In Stock: ".$cars3[2][1].", Sold: ".$cars3[2][2]."<br>";
echo $cars3[3][0].": In Stock: ".$cars3[3][1].", Sold: ".$cars3[3][2]."<br>";

//use for - We can also put a for loop inside another for loop to get the elements of the $cars array (we still have to point to the two indices):

for ($row=0; $row < 4; $row++) //row: hang, col: cot 
{ 
	echo "<p><b>Row number $row </b></p>";
	echo "<ul>";
	for ($col=0; $col < 3; $col++) { 
		echo "<li>".$cars3[$row][$col]."</li>";
	}
	echo "</ul>";
}

#5. PHP Sorting Arrays
echo "<br> PHP Sorting Arrays <br>";

/*
In this chapter, we will go through the following PHP array sort functions:
	-sort() - sort arrays in ascending order
	-rsort() - sort arrays in descending order
	-asort() - sort associative arrays in ascending order, according to the value
	-ksort() - sort associative arrays in ascending order, according to the key
	-arsort() - sort associative arrays in descending order, according to the value
	-krsort() - sort associative arrays in descending order, according to the key
*/

//Sort Array in Ascending Order - sort();

//sort tang dan (alphabet)

echo "<br> Sort() <br>";
$cars4 = array("Mercedes","Audi","BMW");
echo "Cars4 list before sort: ".$cars4[0].", ".$cars4[1].", ".$cars4[2].". <br>";
sort($cars4);

$c_length = count($cars4); //dem so cars

echo "After sort: <br>";
for ($x=0; $x < $c_length; $x++) 
{ 
	echo $cars4[$x];
	echo "<br>";
}
// sorts the elements of the $numbers array in ascending numerical order
//number (1-9)

$numb1 = array(7,15,84,25,9,24,75,1);
sort($numb1);

$numb_length = count($numb1); //dem so cars

for ($x1=0; $x1 < $numb_length; $x1++) 
{ 
	echo $numb1[$x1];
	echo "<br>";
}

//Sort Array in Descending Order - rsort()


//sort giam dan (alphabet)
echo "<br> Ksort() <br>";
$cars5 = array("Mercedes","Audi","BMW");
echo "Cars5 list before sort: ".$cars5[0].", ".$cars5[1].", ".$cars5[2].". <br>";
rsort($cars5);

$c_length = count($cars5); //dem so cars

echo "After sort: <br>";
for ($x=0; $x < $c_length; $x++) 
{ 
	echo $cars5[$x];
	echo "<br>";
}


//number (9-1)

$numb2 = array(7,15,84,25,9,24,75,1);
rsort($numb2);

$numb_length = count($numb2); //dem so cars

for ($x1=0; $x1 < $numb_length; $x1++) 
{ 
	echo $numb2[$x1];
	echo "<br>";
}

//Sort Array (Ascending Order), According to Value - asort() 
// sorts an associative array in ascending order, according to the value:

echo "<br> Asort() <br>";
$age3 = array("Peter" => "45", "Ha Duc" => "20", "Mai Ngoc" => "19");
asort($age3);

foreach ($age3 as $x => $x_value) 
{
	echo "Key= ".$x.", Value= ".$x_value;
	echo "<br>";
}


//Sort Array (Ascending Order), According to Key - ksort()
// sorts an associative array in ascending order, according to the key

echo "<br> Ksort() <br>";
$age4 = array("Peter" => "45", "Ha Duc" => "20", "Mai Ngoc" => "19");
ksort($age4);

foreach ($age4 as $x => $x_value) 
{
	echo "Key= ".$x.", Value= ".$x_value;
	echo "<br>";
}

//Sort Array (Descending Order), According to Value - arsort()
//sorts an associative array in descending order, according to the value:

echo "<br> Arsort() <br>";
$age5 = array("Peter" => "45", "Ha Duc" => "20", "Mai Ngoc" => "19");
arsort($age5);

foreach ($age5 as $x => $x_value) 
{
	echo "Key= ".$x.", Value= ".$x_value;
	echo "<br>";
}

//Sort Array (Descending Order), According to Key - krsort()
//sorts an associative array in descending order, according to the key:

echo "<br> Krsort() <br>";
$age6 = array("Peter" => "21", "Ha Duc" => "25", "Mai Ngoc" => "29");
krsort($age6);

foreach ($age6 as $x => $x_value) 
{
	echo "Key= ".$x.", Value= ".$x_value;
	echo "<br>";
}

?>