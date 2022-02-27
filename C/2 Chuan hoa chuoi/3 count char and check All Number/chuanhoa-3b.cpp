//Kiem tra xem xau ki tu tat ca la so hay k?

#include <stdio.h>
#include <string.h>

int i,temp;
void Check(char s[])
{
	for(i=0;i<strlen(s);i++)
	{
		if(s[i]>= '0' && s[i]<= '9')
		{
			temp = 1;
		}
		else
		{
			temp=0;
			break;
		}
	}
	if(temp==1)
	{
		printf("Xau vua nhap is All Number.");
	}
	else
	{
		printf("Xau vua nhap is NOT All Number.");
	}
} 

int main()
{
char xau[100];
printf("Nhap xau: ");
fflush(stdin);
gets(xau);
Check(xau);
}
