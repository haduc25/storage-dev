<?php 
//Example 1 - Use classes from the Html namespace:

include "Bai_7_Html1.php"; //nhap tu file "Bai 7 Html.php"

$table1 = new Html\Table1();
$table1 -> title1 = "My Table1";
$table1 -> numRows1 = 5;

$row1 = new Html\Row1();
$row1 -> numCells1 = 3;

//output, call mess
$table1 -> message1();
$row1 -> message1();
?>