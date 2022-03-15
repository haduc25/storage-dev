#include <stdio.h>
#include <unistd.h>

int gt=0;
void isLoop()
{
	sleep(1);
	gt++;
	printf("Value [%d]\n",gt);
	isLoop();
}
int main()
{
	isLoop();
	return 0;
}
