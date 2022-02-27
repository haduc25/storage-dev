<?php
#1. PHP Cookies
echo "PHP Cookies <br>";

//What is a Cookie?
/*
-A cookie is often used to identify a user. A cookie is a small file that the server embeds on the user's computer. Each time the same computer requests a page with a browser, it will send the cookie too. With PHP, you can both create and retrieve cookie values.
*/

//Create Cookies With PHP
/*
-A cookie is created with the setcookie() function.

*Syntax
	setcookie(name, value, expire, path, domain, secure, httponly);

-Only the name parameter is required. All other parameters are optional.
*/

//PHP Create/Retrieve a Cookie
/*
-The following example creates a cookie named "user" with the value "John Doe". The cookie will expire after 30 days (86400 * 30). The "/" means that the cookie is available in entire website (otherwise, select the directory you prefer).
-We then retrieve the value of the cookie "user" (using the global variable $_COOKIE). We also use the isset() function to find out if the cookie is set:
*/

//Example 1

$cookie_name = "user";
$cookie_value = "Ha Duc"; //John Doe

setcookie($cookie_name,$cookie_value,time()+(86400*30),"/"); //1 day = 86 400 seconds, (senconds/day * day)
?>

<!DOCTYPE html>
<html>
<body>

<?php 
	if(!isset($_COOKIE["$cookie_name"]))
	{
		echo "Cookie named: '".$cookie_name."' is not set!";
	}else
	{
		echo "Cookie '".$cookie_name."' is set! <br>";
		echo "Value is: ".$_COOKIE[$cookie_name];
	}
?>

<p><strong>Note:</strong> You might have to reload the page to see the value of the cookie.</p>

<!-- Note: -The setcookie() function must appear BEFORE the <html> tag.
		   -The value of the cookie is automatically URLencoded when sending the cookie, and automatically decoded    when received (to prevent URLencoding, use setrawcookie() instead).
-->
</body>
</html>

<?php 
//Modify a Cookie Value
echo "Modify a Cookie Value <br>";
/*
-To modify a cookie, just set (again) the cookie using the setcookie() function:
*/

//Example 2

$cookie_name = "user";
$cookie_value = "Nguyet Anh"; //Alex Porter

setcookie($cookie_name,$cookie_value,time()+(86400*30),"/"); //1 day = 86 400 seconds, (senconds/day * day)
?>

<!DOCTYPE html>
<html>
<body>

<?php 
	if(!isset($_COOKIE["$cookie_name"]))
	{
		echo "Cookie named: '".$cookie_name."' is not set!";
	}else
	{
		echo "Cookie '".$cookie_name."' is set! <br>";
		echo "Value is: ".$_COOKIE[$cookie_name];
	}
?>

<p><strong>Note:</strong> You might have to reload the page to see the new value of the cookie.</p>

</body>
</html>

<?php
//Delete a Cookie
/*
-To delete a cookie, use the setcookie() function with an expiration date in the past:
*/
 
 //set the expiration date to one hour ago (cho cookie het han)

setcookie("user", "", time() - 3600); //1h = 3600s

echo "Cookie 'user' is deleted. ";

//Check if Cookies are Enabled
/*
-The following example creates a small script that checks whether cookies are enabled. First, try to create a test cookie with the setcookie() function, then count the $_COOKIE array variable:
*/
$test_cookie = "user1";
$test = "ha duc1";
setcookie("test_cookie", "test", time() + 3600, '/');

if(count($_COOKIE) > 0)
{
	echo "<br> Cookie are Enabled";
}else
{
	echo "<br> Cookies are Disabled.";
}

echo "<br>--------------------------------------------";

#2. PHP Sessions
echo "<br>  PHP Sessions <br>";
/*
-A session is a way to store information (in variables) to be used across multiple pages.
-Unlike a cookie, the information is not stored on the users computer.

//What is a PHP Session?
-When you work with an application, you open it, do some changes, and then you close it. This is much like a Session. The computer knows who you are. It knows when you start the application and when you end. But on the internet there is one problem: the web server does not know who you are or what you do, because the HTTP address doesn't maintain state.
-Session variables solve this problem by storing user information to be used across multiple pages (e.g. username, favorite color, etc). By default, session variables last until the user closes the browser.
-So, Session variables hold information about one single user, and are available to all pages in one application.

-Tip: If you need a permanent storage, you may want to store the data in a database.
*/

//Start a PHP Session
echo "Start a PHP Session <br>";
/*
-A session is started with the session_start() function.
-Session variables are set with the PHP global variable: $_SESSION.
-Now, let's create a new page called "demo_session1.php". In this page, we start a new PHP session and set some session variables:
*/

//Example 1:

//Start the session
session_start();

//Set session variables
$_SESSION["favColor"] = "green";
$_SESSION["favAnimal"] = "cat";

echo "Session variables are set. <br>";

//Note: The session_start() function must be the very first thing in your document. Before any HTML tags.


//Get PHP Session Variable Values
echo "<br> Get PHP Session Variable Values <br>"; //demo_session2.php = Bai 5 Session1.php
/*
-Next, we create another page called "demo_session2.php". From this page, we will access the session information we set on the first page ("demo_session1.php").
-Notice that session variables are not passed individually to each new page, instead they are retrieved from the session we open at the beginning of each page (session_start()).
-Also notice that all session variable values are stored in the global $_SESSION variable:

//Bai 5 Session1.php co the truy cap seesion tu Bai 5

*Code Example 1: (Bai 5 Session1.php )
<?php
session_start();
?>
<!DOCTYPE html>
<html>
<body>

<?php
// Echo session variables that were set on previous page
echo "Favorite color is " . $_SESSION["favcolor"] . ".<br>";
echo "Favorite animal is " . $_SESSION["favanimal"] . ".";
?>

</body>
</html>

-Another way to show all the session variable values for a user session is to run the following code:

*Code Example 2: (Bai 5 Session2.php )
<?php
session_start();
?>
<!DOCTYPE html>
<html>
<body>

<?php
print_r($_SESSION);
?>

</body>
</html>

//How does it work? How does it know it's me?
-Most sessions set a user-key on the user's computer that looks something like this: 765487cf34ert8dede5a562e4f3a7e12. Then, when a session is opened on another page, it scans the computer for a user-key. If there is a match, it accesses that session, if not, it starts a new session.
*/

//Modify a PHP Session Variable
echo "Modify a PHP Session Variable <br>";
//To change a session variable, just overwrite it:

//session_start(); //vi ben tren da start

//to change a session variables, just overwrite it 
$_SESSION["favColor"] = "Red";
print_r($_SESSION); //in session

//Destroy a PHP Session
echo "<br><br> Destroy a PHP Session <br>";
/*
-To remove all global session variables and destroy the session, use session_unset() and session_destroy():
*/

//session_start(); //vi ben tren da start

//remove all session variables
session_unset();
echo "Session removed.";

//destroy the session
session_destroy();
echo "<br> Session destroyed. <br>";

//check session
print_r($_SESSION);
?>