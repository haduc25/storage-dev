#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string.h>
using namespace std;
FILE *f;
char *st;
int i;
//Ham nhap 1 xau tu ban phim
char *nhap()
{
	char *s=new char[30];
	cout<<"Nhap ho ten:"; cin.getline(s,30);
	return s;
}
//Ham xoa di 1 ky tu tai vitrixoa
void xoa(char *s,int vitrixoa)
{
	int n=strlen(s); 
    for(int i=vitrixoa;i<n;i++)
     s[i]=s[i+1];
	s[n-1]='\0'; 
}
//Ham xoa cac khoang trang thua trong xau
void xoakt(char *s)
{
    for(int i=0;i<strlen(s);i++)
		if(s[i]==' '&& s[i+1]==' ')
		{
			xoa(s,i);
			i--;
		}
    if(s[0]==' ')
		xoa(s,0);
    if(s[strlen(s)-1]==' ')
		xoa(s,strlen(s)-1);
}
//Ham chuyen cac chu cai dau sang chu hoa
void chuanxau(char *s)
{
	if ((s[0]>='a')&&(s[0]<='z')) s[0]-=32;
	for (i=1; i<=strlen(s);i++)
	if ((s[i]==' ') && (s[i+1]>='a') && (s[i+1]<='z')) s[i+1]-=32;
}

int main()
{
	ofstream f("C:/Users/Admin/Desktop/chuanhoa.txt");
	st=nhap();
	f<<st<<endl;
	xoakt(st);
	f<<st<<endl;
	chuanxau(st);
	f<<st<<endl;
	f.close();
}
	

