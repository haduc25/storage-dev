<?php 
//Example 2 - Use classes from the Html namespace without the need for the Html\qualifier:

namespace Html;
include "Bai_7_Html2.php"; //nhap file tu "Bai_7_Html2.php";

$table2 = new Table2();
$table2 -> title2 = "My Table2";
$table2 -> numRows2 = 10;

$row2 = new Row2();
$row2 -> numCells2 = 5;

//Output, Call mess
$table2 -> message2();
$row2 -> message2();
?>