//Can tao thu muc c:\Data truoc khi chay chuong trinh
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string.h>
#include <iomanip>
using namespace std;
FILE *f;
char *st;
int i;
int a[26];

//Ham nhap 1 xau tu ban phim toi da 100 ky tu
char *nhap()
{
	char *s=new char[100];
	cout<<"Nhap xau:"; cin.getline(s,100);
	return s;
}
//Ham dem so tu trong xau
int demtu(char *s)
{
	int stu;
	if (strlen(s)!=0) stu=1; else stu=0;
	for (i=1; i<strlen(s);i++)
	if ((s[i]==' ')&&s[i+1]!=' ') stu++;
	return stu;
}
void dem(char *s) //Ham dem so lan xuat hien cua cac chu cai tu a->z trong xau
{
	char str[]="abcdefghijklmnopqrstuvxywz";
	ofstream f("c:\\data\\tansuat.txt");
	int j,k=0 ;
	for (i='a'; i<='z';i++)
	f<<setw(4)<<char(i);
	f<<endl;
	for (int j=0; j<=strlen(s);j++)
	for (int k=0; k<=26;k++)
		if (s[j]==str[k]) a[k]++;
	for (j=0; j<26;j++)
		f<<setw(4)<<a[j];
		f<<endl;
	f.close();
}

int main()
{
	st=nhap();
	cout<<"Xau vua nhap: "<<st<<endl;
	cout <<"So tu trong xau la:"<<demtu(st);
	
	ofstream f("c:\\data\\Tansuat.txt");
	for (i='a'; i<='z';i++)
	f<<setw(4)<<char(i);
	f<<endl;
	strlwr(st);
	dem(st);	
}
