#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
using namespace std;
FILE *f;
int *a, *b,m,i,j;

int *nhap()
{
	int *kq=new int[1];
	cin>>*kq;
	cin.get();
	return kq;
}

void ptuam(int x[], int y[])
{
	ofstream f("c:\\data\\soam.txt");
	for (i=0; i<m;i++)
	if (x[i]<0) 
	{
		y[i]=x[i];
		f<<setw(5)<<x[i];
	}
	f.close();
}
void xuat(int x[], char st)
{
	if (st=='-')
	{
		cout<<endl<<"Cac phan tu am trong mang la:"<<endl;
		for (i=0; i<m; i++)
		if (x[i]<0)
		{
			cout<<setw(5)<<x[i];
		}
	}
	if (st!='-')
	{
		cout<<"Cac phan tu trong mang la:"<<endl;
		for (i=0; i<m; i++)
		cout<<setw(5)<<x[i];
	}
}

int main()
{
	cout<<"Nhap so phan tu cua mang:"; cin>>m; cin.get();
	a=new int[m];
	b=new int[m];
	for (i=0; i<m; i++)
	{
		cout<<"Nhap phan tu thu "<<i+1<<":";
		a[i]=*nhap();	
	}
	xuat(a,'+');
	ptuam(a,b);
	xuat(b,'-');
}
