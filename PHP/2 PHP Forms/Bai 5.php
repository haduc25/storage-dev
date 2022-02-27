<!-- Complete Form Example -->
<!--
#Keep The Values in The Form
-To show the values in the input fields after the user hits the submit button, we add a little PHP script inside the value attribute of the following input fields: name, email, and website. In the comment textarea field, we put the script between the <textarea> and </textarea> tags. The little script outputs the value of the $name, $email, $website, and $comment variables. 
-Then, we also need to show which radio button that was checked. For this, we must manipulate the checked attribute (not the value attribute for radio buttons):

*Code Example:
	Name: <input type="text" name="name" value="<?php echo $name;?>">

	E-mail: <input type="text" name="email" value="<?php echo $email;?>">

	Website: <input type="text" name="website" value="<?php echo $website;?>">

	Comment: <textarea name="comment" rows="5" cols="40"><?php echo $comment;?></textarea>

	Gender:
	<input type="radio" name="gender"
	<?php if (isset($gender) && $gender=="female") echo "checked";?>
	value="female">Female
	<input type="radio" name="gender"
	<?php if (isset($gender) && $gender=="male") echo "checked";?>
	value="male">Male
	<input type="radio" name="gender"
	<?php if (isset($gender) && $gender=="other") echo "checked";?>
	value="other">Other


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
    <!-- isset() được dùng để kiểm tra một biến nào đó đã được khởi tạo trong bộ nhớ của máy tính hay chưa, nếu nó đã khởi tạo (tồn tại) thì sẽ trả về TRUE và ngược lại sẽ trả về FALSE. -->
    <input type="radio" name="gender" <?php if(isset($gender) && $gender == "female")echo "checked"; ?> value="female">Female
    <input type="radio" name="gender" <?php if(isset($gender) && $gender == "male")echo "checked"; ?> value="male">Male
    <input type="radio" name="gender" <?php if(isset($gender) && $gender == "other")echo "checked"; ?> value="other">Other
    <span class="error">* <?php echo $genderERR; ?></span>
    <br><br>
    <input type="submit" name="submit" value="Submit">
  </form>
 	<!-- luu lai gia tri khi da chon -->
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
