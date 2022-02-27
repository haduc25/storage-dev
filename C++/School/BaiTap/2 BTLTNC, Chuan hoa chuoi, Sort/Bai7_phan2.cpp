//Can tao thu muc c:\Data truoc khi chay chuong trinh
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string.h>
using namespace std;
FILE *f;
char *st;
int i;
//Ham nhap 1 xau tu ban phim toi da 100 ky tu
char *nhap()
{
	char *s=new char[100];
	cout<<"Nhap xau:"; cin.getline(s,100);
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
//Ham chuyen cac chu thuong sang chu hoa
void chuanxau(char *s)
{
	xoakt(s);
	for (i=0; i<=strlen(s);i++)
	if ((s[i]>='a') && (s[i]<='z')) s[i]-=32;
}

int main()
{
	ofstream f("c:\\data\\Chuhoa.txt");
	st=nhap();
	f<<st<<endl;
	cout<<"xau vua nhap la:"<<st<<endl;
	chuanxau(st);
	f<<st<<endl;
	f.close();
}
	

