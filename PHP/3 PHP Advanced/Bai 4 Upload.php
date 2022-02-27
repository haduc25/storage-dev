<?php
$target_dir = "uploads/";
$target_file = $target_dir . basename($_FILES["fileToUpload"]["name"]);
$uploadOk = 1;
$imageFileType = strtolower(pathinfo($target_file,PATHINFO_EXTENSION));

// Check if image file is a actual image or fake image
if(isset($_POST["submit"])) {
  $check = getimagesize($_FILES["fileToUpload"]["tmp_name"]);
  if($check !== false) {
    echo "File is an image - " . $check["mime"] . ".";
    $uploadOk = 1;
  } else {
    echo "File is not an image.";
    $uploadOk = 0;
  }
}

/*
-PHP script explained:

	$target_dir = "uploads/" 			-specifies the directory where the file is going to be placed
	$target_file 						-specifies the path of the file to be uploaded
	$uploadOk=1 						-is not used yet (will be used later)
	$imageFileType 						-holds the file extension of the file (in lower case)
										Next, check if the image file is an actual image or a fake image

Note: You will need to create a new directory called "uploads" in the directory where "upload.php" file resides. The uploaded files will be saved there
*/

//Check if file already exists;
if (file_exists($target_file)) 
{
	echo "<br> Sorry, file already Exists. <br>";
	$uploadOk = 0;
}

//Check file size
if($_FILES["fileToUpload"]["size"] > 500000) //500KB
{
	echo "<br> Sorry, your file is too large. <br>";
	$uploadOk = 0;
}

//Allow certain file formats
if($imageFileType != "jpg" && $imageFileType != "jpeg" && $imageFileType != "png" && $imageFileType != "gif")
{
	echo "<br> Sorry, only JPG, JPEG, PNG & GIF files are allowed. <br>";
	$uploadOk = 0;
}

//Check if uploadOk is set to 0 by an error
if($uploadOk == 0)
{
	echo "<br> Sorry, your file was not uploaded. <br>";
}else 
{
	//if everything is ok,try to upload file.
	if(move_uploaded_file($_FILES["fileToUpload"]["tmp_name"], $target_file))
	{
		echo "<br> The file ".htmlspecialchars(basename($_FILES["fileToUpload"]["name"])). "has been uploaded. <br>";
	}else
	{
		echo "<br> Sorry, there was an error uploading your file. <br>";
	}
}



?>