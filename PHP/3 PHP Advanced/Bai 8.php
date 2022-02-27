<?php
#1. PHP Exceptions
echo "PHP Exceptions";
/*
//What is an Exception?
-An exception is an object that describes an error or unexpected behaviour of a PHP script.
-Exceptions are thrown by many PHP functions and classes.
-User defined functions and classes can also throw exceptions.
-Exceptions are a good way to stop a function when it comes across data that it cannot use
*/

//Throwing an Exception
echo "<br> -Throwing an Exception";
/*
-The "throw" statement allows a user defined function or method to throw an exception. When an exception is thrown, the code following it will not be executed.
-If an exception is not caught, a fatal error will occur with an "Uncaught Exception" message.
-Lets try to throw an exception without catching it:
*/
function divie($dividend, $divisor)
{
	if($divisor == 0)
	{
		throw new Exception("Division by zero.");
	}
	return $dividend / $divisor;
}

//echo divie(5,0); //error

/*
//The result will look something like this:

	Fatal error: Uncaught Exception: Division by zero in C:\webfolder\test.php:4
	Stack trace: #0 C:\webfolder\test.php(9):
	divide(5, 0) #1 {main} thrown in C:\webfolder\test.php on line 4
*/

//The try...catch Statement
echo "<br><br> -The try...catch Statement <br>";
/*
-To avoid the error from the example above, we can use the try...catch statement to catch exceptions and continue the process.

*Syntax
		try {
		  code that can throw exceptions
		} catch(Exception $e) {
		  code that runs when an exception is caught
		}
*/

//Example - Show a message when an exception is thrown:

function divide1($dividend1, $divisor1)
{
	if($divisor1 == 0)
	{
		throw new Exception("Division by Zero.");
	}
	return $dividend1 / $divisor1;
}


//use try, catch
try
{
	echo divide1(5,0);
}catch(Exception $e)
{
	echo "Unable to divide1. <br> Error: " . $e . "<br>";
}

/*
-The catch block indicates what type of exception should be caught and the name of the variable which can be used to access the exception. In the example above, the type of exception is Exception and the variable name is $e.
*/

//The try...catch...finally Statement
echo "<br>-The try...catch...finally Statement<br>";
/*
-The try...catch...finally statement can be used to catch exceptions. Code in the finally block will always run regardless of whether an exception was caught. If finally is present, the catch block is optional.

*Syntax
		try {
		  code that can throw exceptions
		} catch(Exception $e) {
		  code that runs when an exception is caught
		} finally {
		  code that always runs regardless of whether an exception was caught //alway run code regardless error
		}
*/

//Example 1 - Show a message when an exception is thrown and then indicate that the process has ended:
echo "<br> Example 1 <br>";

function divide2($dividend2, $divisor2)
{
	if($divisor2 == 0)
	{
		throw new Exception("Division by Zero.");
	}
	return $dividend2 / $divisor2;
}


//use try, catch
try
{
	echo divide2(5,0);
}catch(Exception $e)
{
	echo "Unable to divide2. <br> Error: " . $e . "<br>";
}finally
{
	//chay cho du loi hay k loi
	echo "Process complete.";
}


//Example 2 - Output a string even if an exception was not caught:
echo "<br><br> Example 2 <br>";

function divide3($dividend3, $divisor3)
{
	if($divisor3 == 0)
	{
		throw new Exception("Division by Zero.");
	}
	return $dividend3 / $divisor3;
}

//use try, catch
try
{
	//echo divide3(5,0); //Error
}finally
{
	//chay cho du loi hay k loi
	echo "Process complete.";
}


//The Exception Object
echo "<br><br> -The Exception Object <br>";
/*
-The Exception Object contains information about the error or unexpected behaviour that the function encountered.
*Syntax
	new Exception(message, code, previous)

*Parameter Values
	 
			   Parameter							Description
			message							Optional. A string describing why the exception was thrown
			code 							Optional. An integer that can be used used to easily distinguish this exception 								from others of the same type
			previous						Optional. If this exception was thrown in a catch block of another exception, 									it is recommended to pass that exception into this parameter


*Methods
-When catching an exception, the following table shows some of the methods that can be used to get information about the exception:

			   Methods								Description
			getMessage()					Returns a string describing why the exception was thrown
			getPrevious()					If this exception was triggered by another one, this method returns the 										previous exception. If not, then it returns null
			getCode()						Returns the exception code
			getFile()						Returns the full path of the file in which the exception was thrown
			getLine()						Returns the line number of the line of code which threw the exception

*/

//Example: - Output information about an exception that was thrown:
echo "Example <br>";

function divide4($dividend4, $divisor4)
{
	if($divisor4 == 0)
	{
		throw new Exception("Division by Zero.");
	}
	return $dividend4 / $divisor4;
}


//use try, catch
try
{
	echo divide4(5,0);
}catch(Exception $ex)
{
	$code = $ex->getCode(); // code -> getCode(); 	
	$message = $ex->getMessage(); //mess -> getMess();
	$file = $ex->getFile(); //file -> getFile();
	$line = $ex->getLine(); //line -> getLine();

	echo "Exception thrown in $file on line $line, [Code $code] $message";
	//file =  path, libe, code, mess;
}
?>