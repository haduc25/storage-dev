<!-- 1.PHP Form Validation -->
<!--
	These pages will show how to process PHP forms with security in mind. Proper validation of form data is important to protect your form from hackers and spammers!
-->

<!--The validation rules for the form above are as follows:
	Field						Validation Rules
Name					Required. + Must only contain letters and whitespace
E-mail					Required. + Must contain a valid email address (with @ and .)
Website					Optional. If present, it must contain a valid URL
Comment					Optional. Multi-line input field (textarea)
Gender					Required. Must select one

*Text Fields
The name, email, and website fields are text input elements, and the comment field is a textarea. The HTML code looks like this:

Name: <input type="text" name="name">
E-mail: <input type="text" name="email">
Website: <input type="text" name="website">
Comment: <textarea name="comment" rows="5" cols="40"></textarea>

*Radio Buttons
The gender fields are radio buttons and the HTML code looks like this:

Gender:
<input type="radio" name="gender" value="female">Female
<input type="radio" name="gender" value="male">Male
<input type="radio" name="gender" value="other">Other

*The Form Element
The HTML code of the form looks like this

<form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
When the form is submitted, the form data is sent with method="post".

-What is the $_SERVER["PHP_SELF"] variable?
The $_SERVER["PHP_SELF"] is a super global variable that returns the filename of the currently executing script.

-What is the htmlspecialchars() function?

The htmlspecialchars() function converts special characters to HTML entities. This means that it will replace HTML characters like < and > with &lt; and &gt;. This prevents attackers from exploiting the code by injecting HTML or Javascript code (Cross-site Scripting attacks) in forms.

-Big Note on PHP Form Security
The $_SERVER["PHP_SELF"] variable can be used by hackers!

If PHP_SELF is used in your page then a user can enter a slash (/) and then some Cross Site Scripting (XSS) commands to execute.
 
 more: https://www.w3schools.com/php/php_form_validation.asp


*Validate Form Data With PHP
-The first thing we will do is to pass all variables through PHP's htmlspecialchars() function.
-When we use the htmlspecialchars() function; then if a user tries to submit the following in a text field:
<script>location.href('http://www.hacked.com')</script>

-this would not be executed, because it would be saved as HTML escaped code, like this:

&lt;script&gt;location.href('http://www.hacked.com')&lt;/script&gt;

-The code is now safe to be displayed on a page or inside an e-mail.
-We will also do two more things when the user submits the form:
1. Strip unnecessary characters (extra space, tab, newline) from the user input data (with the PHP trim() function)
2.Remove backslashes (\) from the user input data (with the PHP stripslashes() function)

-The next step is to create a function that will do all the checking for us (which is much more convenient than writing the same code over and over again).

We will name the function test_input().

Now, we can check each $_POST variable with the test_input() function, and the script looks like this:
-->

<!DOCTYPE html>
<html>
<body>

	<?php 
	//define variables and set to empty values 
	$name = $email = $website = $comment = $gender = "";

	if($_SERVER["REQUEST_METHOD"] == "POST")
	{
		$name = test_input($_POST["name"]);
		$email = test_input($_POST["email"]);
		$website = test_input($_POST["website"]);
		$comment = test_input($_POST["comment"]);
		$gender = test_input($_POST["gender"]);

	}

	function test_input($data)
	{
		$data = trim($data);
		$data = stripcslashes($data);
		$data = htmlspecialchars($data);
		return $data;
	}
	?>
	<!--Text Fields -->
	<h2>PHP Form Validation Example</h2>
	<form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>">
		Name: <input type="text" name="name">
		<br><br>
		E-mail: <input type="text" name="email">
		<br><br>
		Website: <input type="text" name="website">
		<br><br>
		Comment: <textarea name="comment" rows="5" cols="40" ></textarea>
		<br><br>
	<!-- Radio Buttons -->
		Gender:
		<input type="radio" name="gender" value="female">Female
		<input type="radio" name="gender" value="male">Male
		<input type="radio" name="gender" value="other">Other
		<br><br>
		<input type="submit" name="submit" value="Submit">
	</form>

	<?php 
	echo "<h2> Your Input </h2>";
	echo $name;
	echo "<br>";
	echo $email;
	echo "<br>";
	echo $website;
	echo "<br>";
	echo $comment;
	echo "<br>";
	echo $gender;
	?>
</body>
</html>
