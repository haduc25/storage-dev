/*
Noi Chuoi bang con tro
*/
#include <stdio.h>
#include <conio.h>
#include <string.h>

char st1[50],st2[100],st3[100];
char *s1,*s2,*s3;
int main(){
	
	printf("Nhap Xau st1: ");
	gets(st1);
	printf("Nhap Xau st2: ");
	gets(st2);
	s1 = st1;
	s2=st2;
	s3=st3;
	//Noi chuoi
	strcpy(s3,s1); //sao chep xau s1 sang s3
	strcat(s3,s2); //noi chuoi
	puts(s3);
    return 0;
    
}
	

