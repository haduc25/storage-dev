<!-- Validate E-mail and URL -->
<!-- 
#Validate Name
-The code below shows a simple way to check if the name field only contains letters, dashes, apostrophes and whitespaces. If the value of the name field is not valid, then store an error message:
*Code Example:
	$name = test_input($_POST["name"]);
	if (!preg_match("/^[a-zA-Z-' ]*$/",$name)) 
	{
 	 $nameErr = "Only letters and white space allowed";
	}
	//The preg_match() function searches a string for pattern, returning true if the pattern exists, and false otherwise.

#Validate E-mail
-The easiest and safest way to check whether an email address is well-formed is to use PHP's filter_var() function. In the code below, if the e-mail address is not well-formed, then store an error message:
*Code Example:
	$email = test_input($_POST["email"]);
	if (!filter_var($email, FILTER_VALIDATE_EMAIL)) 
	{
	  $emailErr = "Invalid email format";
	}

#Validate URL
-The code below shows a way to check if a URL address syntax is valid (this regular expression also allows dashes in the URL). If the URL address syntax is not valid, then store an error message:
*Code Example:
	$website = test_input($_POST["website"]);
	if (!preg_match("/\b(?:(?:https?|ftp):\/\/|www\.)[-a-z0-9+&@#\/%?=~_|!:,.;]*[-a-z0-9+&@#\/%=~_|]/i",$website)) 
	{
	  $websiteErr = "Invalid URL";
	}
-->

<!-- Validate Name, E-mail, and URL -->


<!DOCTYPE html>
<html>
<style>
  .error {color:  #FF0000; }
</style>
<body>

  <?php
      //define variables and set to empty values  
    $nameERR = $emailERR = $websiteERR = $genderERR = ""; //*bat buoc
    $name = $email = $website = $comment = $gender = "";
    $check_name = "/^[a-zA-Z-' ]*$/";
    $check_web = "/\b(?:(?:https?|ftp):\/\/|www\.)[-a-z0-9+&@#\/%?=~_|!:,.;]*[-a-z0-9+&@#\/%=~_|]/i";

    if($_SERVER["REQUEST_METHOD"] == "POST")
    {
      if(empty($_POST["name"])) //neu name empty
      {
        //show tb loi name trong
        $nameERR = "Name is required";
      }else
      {
      	//nguoc lai kt tra name bang ham test_input
      	$name = test_input($_POST["name"]);
      	//check if name only contains letters and whitespace
      	if(!preg_match($check_name, $name)) //check khoang trang
      	{
      		$nameERR = "Only letters and white space allowed";
      	}
      }if(empty($_POST["email"]))
      {
        $emailERR = "E-mail is required";
      }else
      {
        $email = test_input($_POST["email"]);
        //check if e-mail address is well-formed
        if(!filter_var($email, FILTER_VALIDATE_EMAIL))
        {
        	$emailERR = "Invalid email format";
        }
      }if(empty($_POST["website"]))
      {
	        //vi web k bat buoc neu k co thi reset web = "";
	        $website = "";
      }else
      {
        $website = test_input($_POST["website"]);
        // check if URL address syntax is vaild
        if (!preg_match($check_web,$website)) 
        {
        	$websiteERR	= "Invalid URL";
        }
      }if(empty($_POST["comment"]))
      {
        $comment = "";
      }else
      {
        $comment = test_input($_POST["comment"]);
      }if(empty($_POST["gender"]))
      {
        $genderERR = "Gender is required";
      }else
      {
        $gender = test_input($_POST["gender"]);
      }
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
  <p><span class="error">* reqiured field</span></p>  <!--  create class -->
  
  <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>">
    Name: <input type="text" name="name">
    <span class="error">* <?php echo $nameERR; ?></span>
    <br><br>
    E-mail: <input type="text" name="email">
    <span class="error">* <?php echo $emailERR; ?></span>
    <br><br>
    Website: <input type="text" name="website">
    <span class="error"> <?php echo $websiteERR; ?></span>
    <br><br>
    Comment: <textarea name="comment" rows="5" cols="40" ></textarea>
    <br><br>
  <!-- Radio Buttons -->
    Gender:
    <input type="radio" name="gender" value="female">Female
    <input type="radio" name="gender" value="male">Male
    <input type="radio" name="gender" value="other">Other
    <span class="error">* <?php echo $genderERR; ?></span>
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
