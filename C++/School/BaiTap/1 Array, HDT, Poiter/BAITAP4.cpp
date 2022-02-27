#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>
using namespace std;

struct Thongtinbenhnhan
{
	char hoten[20];
	char diachi[20];
	char khoa[10];
	int ngaynamvien;
};
Thongtinbenhnhan *p;
int i,n;

int main()
{
	cout<<"So benh nhan la: ";
	cin>>n;
	cin.get();
	p = new Thongtinbenhnhan[n];
	for(i=0;i<n;i++)
	{
		cout<<"\nBENH NHAN ["<<i+1<<"]"<<endl;
		cout<<"Ho ten benh nhan: ";
		cin.getline(p[i].hoten,20);
		cout<<"Dia chi: ";
		cin.getline(p[i].diachi,20);
		cout<<"Khoa dieu tri: ";
		cin.getline(p[i].khoa,10);
		cout<<"So ngay nam vien: ";
		cin>>p[i].ngaynamvien;
		cin.get();
		
	}
	cout<<"DANH SACH BENH NHAN VUA NHAP LA\n";
	for(i=0;i<n;i++)
	{
		cout<<setw(3)<<i+1<<setw(10)<<p[i].hoten<<setw(20)<<p[i].diachi<<setw(5)<<p[i].khoa<<setw(5)<<p[i].ngaynamvien<<endl;
		
	}
	int max = 0;
	for(i=max+1;i<n;i++)
	{

			if(p[max].ngaynamvien<p[i].ngaynamvien)
			{
				max = i;		
			}
	}
	//cout<<"Benh nhan nam nam vien lau nhat"<<p[max].ngaynamvien<<endl;
	ofstream ofs("d:/folder/ngayvien.txt",ios::out);
	if(!ofs)
	{
		cout<<"loi file";
	}
	else
	{
		cout<<"BENH NHAN NAM VIEN LAU NHAT\n";
		for(i=1;i<n;i++)
		{
			cout<<setw(3)<<i+1<<setw(10)<<p[max].hoten<<setw(20)<<p[max].diachi<<setw(10)<<p[max].khoa<<setw(10)<<p[max].ngaynamvien<<endl;
			ofs<<setw(3)<<i+1<<setw(10)<<p[max].hoten<<setw(20)<<p[max].diachi<<setw(10)<<p[max].khoa<<setw(10)<<p[max].ngaynamvien<<endl;
		}
		ofs.close();
	}
}
