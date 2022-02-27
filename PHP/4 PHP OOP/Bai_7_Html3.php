<?php 
namespace Html;

class Table3
{
	public $title3 = "";
	public $numRows3 = 0;

	public function message3()
	{
		echo "<p>Table '{$this->title3}' has {$this->numRows3} rows. </p>";
	}
}

class Row3
{
	public $numCells3 = 0;
	public function message3()
	{
		 echo "<p>The row has {$this->numCells3} cells.</p>";
	}
}
?>