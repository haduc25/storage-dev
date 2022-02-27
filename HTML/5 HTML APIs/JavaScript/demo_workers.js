var i = 0;

function timedCount()
{
	i++;
	postMessage(i);
	setTimeout("timedCount()",500);

	/*That worked so i can break down for i*/
	if(i == 100)
	{
		i = 0;
	}
}

timedCount();