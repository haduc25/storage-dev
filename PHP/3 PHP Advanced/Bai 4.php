<?php
#1. PHP File Create/Write

//PHP Create File - fopen()
echo "PHP Create File - fopen()";

/*
-The fopen() function is also used to create a file. Maybe a little confusing, but in PHP, a file is created using the same function used to open files.
-If you use fopen() on a file that does not exist, it will create it, given that the file is opened for writing (w) or appending (a).
-The example below creates a new file called "testfile.txt". The file will be created in the same directory where the PHP code resides:

*Example
	$myfile = fopen("testfile.txt", "w")
*/

//PHP File Permissions
echo "<br> PHP File Permissions";
/*
If you are having errors when trying to get this code to run, check that you have granted your PHP file access to write information to the hard drive.
*/

//PHP Write to File - fwrite()
echo "<br> PHP Write to File - fwrite() <br>";
/*
-The fwrite() function is used to write to a file.
-The first parameter of fwrite() contains the name of the file to write to and the second parameter is the string to be written.
-The example below writes a couple of names into a new file called "newfile.txt":
*/

$myfile = fopen("Bai 4 newfile.txt","w") or die("Unable to open file!");
$txt = "Ha Duc\n";
fwrite($myfile, $txt); //noi dung file
$txt = "Ha Duc\n";
fwrite($myfile, $txt); //noi dung file
fclose($myfile);

//PHP Overwriting
echo "PHP Overwriting <br>"; // ghi de file
/*
-Now that "newfile.txt" contains some data we can show what happens when we open an existing file for writing. All the existing data will be ERASED and we start with an empty file.
-In the example below we open our existing file "newfile.txt", and write some new data into it:
*/

$myfile1 = fopen("Bai 4 newfile.txt","w") or die("Unable to open file!");
$txt = "File nay da bi Overwriting\n";
fwrite($myfile1, $txt); //noi dung file
$txt = "File nay da bi Overwriting\n";
fwrite($myfile1, $txt); //noi dung file
fclose($myfile1);

echo "--------------------------------------------";

#2. PHP File Upload
echo "<br> PHP File Upload <br>";

//Configure The "php.ini" File
echo "Configure The (php.ini) File <br>";
/*
-First, ensure that PHP is configured to allow file uploads.
-In your "php.ini" file, search for the file_uploads directive, and set it to On:
	
	file_uploads = On
*/

//Create The HTML Form
echo "Create The HTML Form <br>";
/*
Next, create an HTML form that allow users to choose the image file they want to upload:
*/
?>

<!DOCTYPE html>
<html>
<body>
	<form action="Bai 4 Upload.php" method="post" enctype="multipart/form-data">
		Select image to upload:
		<input type="file" name="fileToUpload" id="fileToUpload">
		<input type="submit" value="Upload Image" name="submit">
	</form>
</body>
</html>

<!--
-Some rules to follow for the HTML form above:
	Make sure that the form uses method="post"
	The form also needs the following attribute: enctype="multipart/form-data". It specifies which content-type to use when submitting the form
-Without the requirements above, the file upload will not work.
-Other things to notice:
-The type="file" attribute of the <input> tag shows the input field as a file-select control, with a "Browse" button next to the   	
 input control
-The form above sends data to a file called "upload.php", which we will create next.
-->

<?php
//Create The Upload File PHP Script
echo "<br> Create The Upload File PHP Script <br>";
//The "upload.php" file contains the code for uploading a file:

//Check if File Already Exists
echo "Check if File Already Exists <br>";
/*
-Now we can add some restrictions.
-First, we will check if the file already exists in the "uploads" folder. If it does, an error message is displayed, and $uploadOk is set to 0:

*Code Example:
	//check if file already exists
	if(file_exists($target_file))
	{
		echo "Sorry, file is already exists.";
		$uploadOk = 0;
	}
*/

//Limit File Size
echo "Limit File Size <br>";
/*
-The file input field in our HTML form above is named "fileToUpload".
-Now, we want to check the size of the file. If the file is larger than 500KB, an error message is displayed, and $uploadOk is set to 0:

*Code Example:
	//check file size
	if($_FILES["fileToUpload"]["size"] > 500000) //500KB
	{
		echo "Sorry, your file is too large.";
		$uploadOk = 0;
	}


//Limit File Type
-The code below only allows users to upload JPG, JPEG, PNG, and GIF files. All other file types gives an error message before setting $uploadOk to 0:

*Code Example:
	//Allow certain file formats
	if($imageFileType != "jpg" && $imageFileType != "png" && $imageFileType != "jpeg" && $imageFileType != "gif")
	{
		echo "Sorry, only JPG, JPEG, PNG & GIF files are allowed.";
		$uploadOk = 0;
	}
*/

//Complete Upload File PHP Script
echo "Complete Upload File PHP Script <br> !";
?>