/* a, Viet ham dem so tu trong xau */
#include <stdio.h>
#include <string.h>


int main(){
	char s[100];
	int n;
	puts("Nhap xau: ");
	gets(s);
    n=strlen(s);
    printf(" /> So tu trong xau la (%d) \n",n);
    puts(strlwr(s));
}
