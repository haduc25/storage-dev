//Chu cai dau viet hoa
#include <stdio.h>
#include <string.h>

int i,j;
void swapText(char s[]) 
{
	if(s[0]==' ')
	{
		for(i=0;i<strlen(s);i++)
		{
			if(s[i]==' ' && s[i+1] != ' ')
			{
				s[i+1] = s[i+1] - 32;
			}
		}
	}
	else
	{
		s[0] = s[0] - 32;
		for(j=1;j<strlen(s);j++)
		{
			if(s[j]==' ' && s[j+1] != ' ')
			{
				s[j+1]=s[j+1] - 32;
			}
		}
	}
}

int main() 
{
	char xau[100];
	printf("nhap xau: ");
	gets(xau);
	swapText(xau);
	puts(xau);
}
