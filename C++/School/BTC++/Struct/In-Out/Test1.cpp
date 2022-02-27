//VD1:
/*#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>

//su dung con tro voi file
using namespace std;
//Khai boa con tro
int *a,i,n;
int main()
{
cout<<"Nhap so luong phan tu: ";
cin>>n;
cin.get();
a=new int [n];
ofstream ofs("D:\\Hola.txt",ios::out);
for(i=1;i<=n;i++)
{
	cout<<"a["<<i<<"]=";
	cin>>a[i];
	if((a[i]%2) == 0)
	{
		ofs<<a[i]<<"\t";
	}
}
ofs.close();
}*/

//VD2:
/*
#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>

//su dung con tro voi file
using namespace std;
//Khai boa con tro
int *a,i,n;
int main()
{
cout<<"Nhap so luong phan tu: ";
cin>>n;
cin.get();
a=new int [n];
ofstream ofs("D:\\Hola.txt",ios::out);
for(i=1;i<=n;i++)
{
	cout<<"a["<<i<<"]=";
	cin>>a[i];
	ofs<<a[i]<<"\t";
}
cout<<"\n";
for(i=1;i<=n;i++)
{
	if((a[i]%2) == 0)
	{
		ofs<<a[i]<<"\t";
	}
	else
	{
		ofs<<"Khong co";
	}
	ofs.close();
}
}
*/
//VD3
#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>
#include <math.h>

//su dung con tro voi file
using namespace std;
//Khai boa con tro
int *a,i,n;
int nto(int &x)
{
	if(x<2)
	{
		return (0);
	}else
	{
		for(int j=2;j<=sqrt(x);j++)
		{
			if(x%j==0)
			{
				break;	
			}
			else
			{
				return (1);
			}
		}
	}
}
int main()
{
cout<<"Nhap so luong phan tu: ";
cin>>n;
cin.get();
a=new int [n];
ofstream ofs("D:\\Hola.txt",ios::out);
for(i=1;i<=n;i++)
{
	cout<<"a["<<i<<"]=";
	cin>>a[i];
	ofs<<a[i]<<"\t";
}
cout<<"\n";
for(i=1;i<=n;i++)
{
	if((a[i]%2) == 0)
	{
		ofs<<a[i]<<"\t";
	}
	else
	{
		ofs<<"Khong co";
	}
	ofs.close();
}
}
