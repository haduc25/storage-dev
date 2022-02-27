<?php 
echo "Date and Time <br>";
#1. Date and Time
/*
-The PHP date() function is used to format a date and/or a time.
*Syntax
date(format,timestamp)
Parameter						Description
format					Required. Specifies the format of the timestamp
timestamp				Optional. Specifies a timestamp. Default is the current date and time
*/

//Get a Date
/*
-Here are some characters that are commonly used for dates:

	d - Represents the day of the month (01 to 31)
	m - Represents a month (01 to 12)
	Y - Represents a year (in four digits)
	l (lowercase 'L') - Represents the day of the week
Other characters, like"/", ".", or "-" can also be inserted between the characters to add additional formatting.
*/

echo "<br> Get a Date <br>";
echo "Today is: ".date("Y/m/d")."<br>";
echo "Today is: ".date("Y.m.d")."<br>";
echo "Today is: ".date("Y-m-d")."<br>";
echo "Today is: ".date("l")."<br>"; //thu
echo "Today is: ".date("d/m/Y")."<br>";
echo "Perfect date: ".date("l d/m/Y h:i:sa");

//PHP Tip - Automatic Copyright Year - Use the date() function to automatically update the copyright year on your website:

echo "<br> Automatic Copyright Year <br>";
echo "© 2010-".date("Y")."<br>";

//Get a Time
/*
Here are some characters that are commonly used for times:

	H - 24-hour format of an hour (00 to 23)
	h - 12-hour format of an hour with leading zeros (01 to 12)
	i - Minutes with leading zeros (00 to 59)
	s - Seconds with leading zeros (00 to 59)
	a - Lowercase Ante meridiem and Post meridiem (am or pm)

Note that the PHP date() function will return the current date/time of the server!
*/

echo "<br> Get a Time <br>";
echo "The time is: ".date("h:i:sa")."<br>";

//Get Your Time Zone
/*
-If the time you got back from the code is not correct, it's probably because your server is in another country or set up for a different timezone.
-So, if you need the time to be correct according to a specific location, you can set the timezone you want to use.
*/
echo "<br> Get Your Time Zone <br>";
date_default_timezone_set("Asia/Ho_Chi_Minh");
echo "The time is: ".date("h:i:sa")."<br>";

//Create a Date With mktime()
/*
The PHP mktime() function returns the Unix timestamp for a date. The Unix timestamp contains the number of seconds between the Unix Epoch (January 1 1970 00:00:00 GMT) and the time specified.
*Syntax
	mktime(hour, minute, second, month, day, year)
*/
echo "<br> Create a Date With mktime() <br>";
$d = mktime(12,45,23,9,25,2021);
echo "Create data is: ".date("Y-m-d h:i:sa",$d)."<br>"; //time setup above
echo "Create data is: ".date("Y-m-d h:i:sa")."<br>";


//Create a Date From a String With strtotime()
/*
-The PHP strtotime() function is used to convert a human readable date string into a Unix timestamp (the number of seconds since January 1 1970 00:00:00 GMT).
*Syntax
	strtotime(time, now)
*/
echo "<br> Create a Date From a String With strtotime() <br>";
$d1 = strtotime("3:54pm July 19 2021");
echo "Created date is: ".date("Y-m-d h:i:sa",$d1)."<br>"; //time setup string above


echo "<br> Example for Date ! <br>";

//ex1
echo "<br> Example 1 <br>";
echo "Today is: ".date("Y-m-d h:i:sa")."<br>";

$d2 = strtotime("tomorrow");
echo "Tommorrow is: ".date("Y-m-d h:i:sa",$d2)."<br>";

$d2 = strtotime("Next Saturday");
echo "Tommorrow is: ".date("Y-m-d h:i:sa",$d2)."<br>";

$d2 = strtotime("+3 Months");
echo "Tommorrow is: ".date("Y-m-d h:i:sa",$d2)."<br>";

$d2 = strtotime("+1000 Years");
echo "Tommorrow is: ".date("Y-m-d h:i:sa",$d2)."<br>";

//ex2
echo "<br> Example 2 <br>";
$startdate = strtotime("Saturday");
$enddate = strtotime("+6 weeks", $startdate);

while ($startdate < $enddate)
{
	echo date("Y M d",$startdate)."<br>"; //output in ra 6 tuan tiep tiep theo
	$startdate	= strtotime("+1 week",$startdate);
}

//ex3
//ex2
echo "<br> Example 3 <br>";

$d3 = strtotime("Jul 30");
$d4 = ceil(($d3-time())/60/60/24); //ceil làm tròn số về 60s,60p,24h

echo "There are ".$d4." days until 30th of July."; //dem ngay tu hom nay den ngay duoc chi dinh ben tren, su dung countdown tet



?>