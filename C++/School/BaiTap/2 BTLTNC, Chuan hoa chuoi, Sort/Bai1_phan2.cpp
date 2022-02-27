#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
using namespace std;
int i,n;
FILE *f;
int *p;

int main()
{
	cout<<"Nhap so phan tu cua mang:"; cin>>n;
	cin.get();
	p=new int[n];
	for (i=1; i<=n;i++)
	{
		cout<<"Nhap phan tu thu "<<i<<" :"; cin>>p[i];
		cin.get();	
	} 
	cout<<"Day so vua nhap la:"<<endl;
	for (i=1; i<=n; i++) 
	{
		cout<<setw(5)<<*(p+i);
	}
	cout<<endl;
	int kt=1;
	for (i=1; i<n; i++)
	for (int j=i+1; j<=n; j++)
	if (*(p+i)>*(p+j)) kt=0;
	if (kt==0) cout<<"mang khong hop le"; else cout<<"Mang hop le";
	ofstream f("C:/Users/Admin/Desktop/Daysotang.txt");
	for (i=1; i<=n; i++)
	{
		f<<setw(5)<<*(p+i);
	}
	f.close();
}


