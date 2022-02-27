/* a, ham doi tat ca chua hoa thanh chu thuong (k dung strlwr)*/

#include <stdio.h>
#include <string.h>
#define max 100

int i;
char swapText(char s[])
{
	for(i=0;i<strlen(s);i++)
	{
		if(s[i]>= 'A' && s[i]<= 'Z')
		{
			s[i]=s[i]+32;
		}
	}
	printf("%s",s);
}
int main()
{
	char s[max];
	printf("Nhap chuoi: ");
	gets(s);
	swapText(s);
}
