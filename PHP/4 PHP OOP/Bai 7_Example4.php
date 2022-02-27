<?php 
//Example 4 - Give a class an alias:

include "Bai_7_Html4.php";
use Html\Table4 as T; //T = table
use Html\Row4 as R; //R = row

$table4 = new T();
$table4 -> title4 = "My Table4";
$table4 -> numRows4 = 50;

$row4 = new R();
$row4 -> numCells4 = 25;

//Output, Call mess
$table4 -> message4();
$row4 -> message4();
?>