<?php 
#1. PHP Iterables
echo "PHP Iterables";

//PHP - What is an Iterable?
/*
-An iterable is any value which can be looped through with a foreach() loop.
-The iterable pseudo-type was introduced in PHP 7.1, and it can be used as a data type for function arguments and function return values.
*/

//PHP - Using Iterables
echo "<br> -Using Iterables <br>";
/*
-The "iterable" keyword can be used as a data type of a function argument or as the return type of a function:
*/

//Example 1 - Use an iterable function argument:
echo "Example 1 <br>";

function print_Iterable(iterable $myIterable)
{
	foreach ($myIterable as $item) 
	{
		echo $item . "<br>";
	}
}

$arr = ["a", "b", "c", "d"];
print_Iterable($arr);


//Example 2 - Return an iterable:
echo "<br> Example 2 <br>";

function get_Iterable():iterable
{
	return ["a", "b", "c", "d", "e"];
}

$myIterable2 = get_Iterable();
foreach ($myIterable2 as $item2)
{
	echo $item2 . "<br>";
}


//PHP - Creating Iterables
echo "-Creating Iterables <br>";
/*
*Arrays
-All arrays are iterables, so any array can be used as an argument of a function that requires an iterable.

*Iterators
-Any object that implements the Iterator interface can be used as an argument of a function that requires an iterable.
-An iterator contains a list of items and provides methods to loop through them. It keeps a pointer to one of the elements in the list. Each item in the list should have a key which can be used to find the item.

*An iterator must have these methods:
	+current() 			-Returns the element that the pointer is currently pointing to. It can be any data type
	+key() 				-Returns the key associated with the current element in the list. It can only be an integer, float, 
						 boolean or string
	+next() 			-Moves the pointer to the next element in the list
	+rewind() 			-Moves the pointer to the first element in the list
	+valid() 			-If the internal pointer is not pointing to any element (for example, if next() was called at the
						  end of the list), this should return false. It returns true in any other case
*/

//Code Example - Implement the Iterator interface and use it as an iterable:

//Create an Iterator
class my_Iterator implements Iterator //same ke thua
{
	private $items = [];
	private $pointer = 0;

	
	public function __construct($items)
	{
		//array_value() makes sure that keys are numbers
		$this -> items = array_values($items); //all la numbers
	}
	
	//current
	public function current()
	{
		return $this -> items[$this -> pointer];
	}
	
	//key
	public function key()
	{
		return $this -> pointer;
	}

	//next
	public function next()
	{
		$this -> pointer++;
	}

	//rewind
	public function rewind()
	{
		$this -> pointer = 0;
	}
	
	//vaild
	public function valid()
	{
		//count() indicates how many items are in the list // đếm
		return $this -> pointer < count($this -> items);
	}
}

//A function that uses iterables
function print_Iterable1(iterable $myIterable1)
{
	foreach ($myIterable1 as $item1) {
		echo $item1 . "<br>";
	}
}

//Use the iterator as an iterable
$iterator = new my_Iterator(["a", "b", "c", "d", "e", "f"]);
print_Iterable1($iterator);

?>