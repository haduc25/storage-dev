var i = 0;

function timedCount()
{
	i++;
	postMessage(i);
	setTimeout("timedCount()",500);

	if (typeof(w) == "undefined")
	{
	  w = new Worker("demo_workers1.js");
	}
}

timedCount();