<?php 
//Example 3 - Give a namespace an alias:

include "Bai_7_Html3.php";
use Html as H;

$table3 = new H\Table3();
$table3 -> title3 = "My Table3";
$table3 -> numRows3 = 25;

$row3 = new H\Row3();
$row3 -> numCells3 = 15;

//Output, Call mess
$table3 -> message3();
$row3 -> message3();

?>