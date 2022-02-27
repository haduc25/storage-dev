<?php
#1. PHP File Handling
echo "PHP File Handling";
/*
-File handling is an important part of any web application. You often need to open and process a file for different tasks.

//PHP Manipulating Files
-PHP has several functions for creating, reading, uploading, and editing files.
*/


//PHP readfile() Function
echo "<br> PHP readfile() Function <br>";
/*
-The readfile() function reads a file and writes it to the output buffer.
-Assume we have a text file called "webdictionary.txt", stored on the server, that looks like this:
	
	AJAX = Asynchronous JavaScript and XML
	CSS = Cascading Style Sheets
	HTML = Hyper Text Markup Language
	PHP = PHP Hypertext Preprocessor
	SQL = Structured Query Language
	SVG = Scalable Vector Graphics
	XML = EXtensible Markup Language
*/

echo readfile("Bai 3 webdictionary.txt"); //doc file va dem ki tu
//The readfile() function is useful if all you want to do is open up a file and read its contents.

#2. PHP File Open/Read/Close
echo "<br><br> PHP File Open/Read/Close <br>";

//PHP Open File - fopen()
echo "PHP Open File - fopen() <br>";
/*
-A better method to open files is with the fopen() function. This function gives you more options than the readfile() function.
-The first parameter of fopen() contains the name of the file to be opened and the second parameter specifies in which mode the file should be opened. The following example also generates a message if the fopen() function is unable to open the specified file:
*/

$myfile = fopen("Bai 3 webdictionary.txt", "r") or die ("Unable to open file!");
echo fread($myfile, filesize("Bai 3 webdictionary.txt"));
fclose($myfile);

/*
-The file may be opened in one of the following modes:

Modes										Description
r						Open a file for read only. File pointer starts at the beginning of the file
w						Open a file for write only. Erases the contents of the file or creates a new file if it doesn't exist. File 						pointer starts at the beginning of the file
a						Open a file for write only. The existing data in file is preserved. File pointer starts at the end of the 							file. Creates a new file if the file doesn't exist
x						Creates a new file for write only. Returns FALSE and an error if file already exists
r+						Open a file for read/write. File pointer starts at the beginning of the file
w+						Open a file for read/write. Erases the contents of the file or creates a new file if it doesn't exist. File 						pointer starts at the beginning of the file
a+						Open a file for read/write. The existing data in file is preserved. File pointer starts at the end of the 						    file. Creates a new file if the file doesn't exist
x+						Creates a new file for read/write. Returns FALSE and an error if file already exists
*/


//PHP Read File - fread()
echo "<br><br> PHP Read File - fread()";
/*
-The fread() function reads from an open file.
-The first parameter of fread() contains the name of the file to read from and the second parameter specifies the maximum number of bytes to read.
*Syntax:
	fread($myfile,filesize(namefile));

*Above
	fread($myfile,filesize("webdictionary.txt"));
*/

//PHP Close File - fclose()
echo "<br> PHP Close File - fclose()";
/*
-The fclose() function is used to close an open file.
-It's a good programming practice to close all files after you have finished with them. You don't want an open file running around on your server taking up resources!

-The fclose() requires the name of the file (or a variable that holds the filename) we want to close:

<?php
$myfile = fopen("webdictionary.txt", "r");
// some code to be executed....
fclose($myfile);
?>
*/

//PHP Read Single Line - fgets()
echo "<br> PHP Read Single Line - fgets() <br>";
/*
The fgets() function is used to read a single line from a file.
*/

$myfile1 = fopen("Bai 3 webdictionary.txt", "r") or die("Unable to open file!");
echo fgets($myfile1);
fclose($myfile1);

//After a call to the fgets() function, the file pointer has moved to the next line. 1-2

//PHP Check End-Of-File - feof()
echo "<br><br> PHP Check End-Of-File - feof() <br>";
/*
-The feof() function checks if the "end-of-file" (EOF) has been reached.
-The feof() function is useful for looping through data of unknown length.
*/

$myfile2 = fopen("Bai 3 webdictionary.txt", "r") or die("Unable to open file!"); 
//Output one line until end-of-line

while (!feof($myfile2)) //doc tung dong 1 cho den line cuoi
{
	echo fgets($myfile2)."<br>"; 
}
fclose($myfile2);


//PHP Read Single Character - fgetc()
echo "<br> PHP Read Single Character - fgetc() <br>";
/*
-The fgetc() function is used to read a single character from a file.
*/

$myfile3 = fopen("Bai 3 webdictionary.txt", "r") or die("Unable to open file!");
// Output one character until end-of-file

while(!feof($myfile3)) {
  echo fgetc($myfile3);
}
fclose($myfile3);
?>