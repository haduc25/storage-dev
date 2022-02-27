<!-- Required Fields -->
<!-- 
#Required Fields
	-In the following code we have added some new variables: $nameErr, $emailErr, $genderErr, and $websiteErr. These error variables will hold error messages for the required fields. We have also added an if else statement for each $_POST variable. This checks if the $_POST variable is empty (with the PHP empty() function). If it is empty, an error message is stored in the different error variables, and if it is not empty, it sends the user input data through the test_input() function:

*Code Example:
//php
// define variables and set to empty values
$nameErr = $emailErr = $genderErr = $websiteErr = "";
$name = $email = $gender = $comment = $website = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
  if (empty($_POST["name"])) {
    $nameErr = "Name is required";
  } else {
    $name = test_input($_POST["name"]);
  }

  if (empty($_POST["email"])) {
    $emailErr = "Email is required";
  } else {
    $email = test_input($_POST["email"]);
  }

  if (empty($_POST["website"])) {
    $website = "";
  } else {
    $website = test_input($_POST["website"]);
  }

  if (empty($_POST["comment"])) {
    $comment = "";
  } else {
    $comment = test_input($_POST["comment"]);
  }

  if (empty($_POST["gender"])) {
    $genderErr = "Gender is required";
  } else {
    $gender = test_input($_POST["gender"]);
  }
}

#PHP - Display The Error Messages
-Then in the HTML form, we add a little script after each required field, which generates the correct error message if needed (that is if the user tries to submit the form without filling out the required fields):

*Code Example
//html
<form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">

Name: <input type="text" name="name">
<span class="error">* <?php echo $nameErr;?></span>
<br><br>
E-mail:
<input type="text" name="email">
<span class="error">* <?php echo $emailErr;?></span>
<br><br>
Website:
<input type="text" name="website">
<span class="error"><?php echo $websiteErr;?></span>
<br><br>
Comment: <textarea name="comment" rows="5" cols="40"></textarea>
<br><br>
Gender:
<input type="radio" name="gender" value="female">Female
<input type="radio" name="gender" value="male">Male
<input type="radio" name="gender" value="other">Other
<span class="error">* <?php echo $genderErr;?></span>
<br><br>
<input type="submit" name="submit" value="Submit">

</form>
-->

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
      }if(empty($_POST["email"]))
      {
        $emailERR = "E-mail is required";
      }else
      {
        $email = test_input($_POST["email"]);
      }if(empty($_POST["website"]))
      {
        //vi web k bat buoc neu k co thi reset web = "";
        $website = "";
      }else
      {
        $website = test_input($_POST["website"]);
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
