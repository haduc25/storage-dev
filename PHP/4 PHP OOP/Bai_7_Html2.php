<?php 
namespace Html;

class Table2
{
	public $title2 = "";
	public $numRows2 = 0;

	public function message2()
	{
		echo "<p>Table '{$this->title2}' has {$this->numRows2} rows. </p>";
	}
}

class Row2
{
	public $numCells2 = 0;
	public function message2()
	{
		 echo "<p>The row has {$this->numCells2} cells.</p>";
	}
}
?>