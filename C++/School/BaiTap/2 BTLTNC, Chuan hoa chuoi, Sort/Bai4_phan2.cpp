#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
using namespace std;
int *a,i,n;
//Ham nhap 1 so nguyen su dung con tro
int *nhap()
{
	int *kq=new int[1];
	cin>>*kq;
	return kq;
}
//Ham doc so chan tu file, sap xep va in ra ket qua
void sapxep(int x[])
{
	int temp,m;
	ifstream f("C:/Users/Admin/Desktop/hello.txt");
	i=0;
	while (!f.eof())
	{
		f>>setw(5)>>x[i];
		i++;
		m=i;
	}
	f.close();
	for (i=0;i<m-1;i++)
	for (int j=i+1; j<m; j++)
	if (x[i]<x[j])
	{
		temp=x[i];
		x[i]=x[j];
		x[j]=temp;
	}
	cout<<"Cac phan tu chan doc tu file Sochan.txt la:"<<endl;
	for (i=0; i<m; i++)
	cout<<setw(5)<<x[i];
}

int main()
{
	do
	{
		cout<<"Nhap n=";
		cin>>n;
		cin.get();
	}		
	while (n>50 || n<5);
//Khai bao mang dong, nhap cac phan tu, dua so chan ra file Sochan.txt	
	a=new int[n];
	ofstream f("C:/Users/Admin/Desktop/hello.txt");
	for (i=0; i<n; i++)
	{
		cout<<"Phan tu thu "<<i+1<<":";
		a[i]=*nhap();
		if (a[i]%2==0) f<<setw(5)<<a[i];
	}	
	f.close();
	sapxep(a);
}
