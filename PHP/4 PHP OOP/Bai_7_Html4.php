<?php 
namespace Html;

class Table4
{
	public $title4 = "";
	public $numRows4 = 0;

	public function message4()
	{
		echo "<p>Table '{$this->title4}' has {$this->numRows4} rows. </p>";
	}
}

class Row4
{
	public $numCells4 = 0;
	public function message4()
	{
		 echo "<p>The row has {$this->numCells4} cells.</p>";
	}
}
?>