#include <iostream>
#include <cstdio>
#include <windows.h>
using namespace std;
struct Info
{
	char Hoten[10];
	char Diachi[10];
	char Khoa[5];
	int Date;
};
Info *p;
int i,j,n;
void Check(Info x)
{
	if(x.Khoa == "Ngoai")
	{
		cout<<"Yes";
	}else
	{
		cout<<"No";
	}
}
void NhapBN(Info &x)
{
	cout<<"Nhap Ho va Ten: ";
	cin.getline(x.Hoten,20);
	cout<<"Nhap Dia Chi: ";
	cin.getline(x.Diachi,10);
	cout<<"Nhap Khoa dieu tri: ";
	cin.getline(x.Khoa,5);
	cout<<"So ngay nam vien: ";
	cin>>x.Date;
	cin.get();
}
void XuatBN(Info x)
{
	cout.width(2);cout<<x.Hoten;
	cout<<"\t"<<x.Diachi<<"\t"<<x.Khoa<<"\t| "<<x.Date<<"\n";
}
void Sort(Info &x, Info &y,int n)
{
	Info temp;
		temp=x;
		x=y;
		y=temp;
}

int main()
{
	cout<<"Nhap so benh nhan: ";
	cin>>n;
	cin.get();
	p=new Info[n];
	cout<<"\tNhap thong tin \n";
		for (i=1; i<=n;i++)
	{
		cout<<"Benh nhan "<<i<<endl;
		NhapBN(*(p+i));
	}
	system("cls");
	cout<<"Thong tin BN vua nhap:"<<endl<<endl;
	for (i=1; i<=n;i++)
	{
		XuatBN(*(p+i));
	}
	for (i=1; i<n; i++)
	{
	for (j=i+1; j<=n; j++)
		{
			if (p[i].Date<p[j].Date) 
			{
				Sort(*(p+i),*(p+j),n);
			}
		}
	}
	Check(*(p+i));
	cout<<"Sau khi xap xep \n";
	for(int i=1;i<=n;i++)
	{
		cout<<i<<"\t";
		XuatBN(*(p+i));
	}
}
