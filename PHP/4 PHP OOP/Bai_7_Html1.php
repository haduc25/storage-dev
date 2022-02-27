<?php

namespace Html;

class Table1
{
	public $title1 = "";
	public $numRows1 = 0;

	public function message1()
	{
		echo "<p> Table '{$this -> title1}' has {$this -> numRows1} rows. </p>";
	}
}

class Row1
{
	public $numCells1 = 0;
	public function message1()
	{
		echo "<p> The row has {$this -> numCells1} cells. </p>";
	}

}
?>