#include <cstdio>
#include <iostream>
#include <fstream>
#include <iomanip>

using namespace std;

struct HANG_HOA
{
	char ma[20];
	char ten[20];
    int sl,time;
};

HANG_HOA *p;
int n,i,empty,temp = 0;

int main()
{
	cout<<"DANH SACH HANG HOA: ";
	cin>>n;
	cin.get();
	p = new HANG_HOA[n];
	for(i=0;i<n;i++)
	{
		cout<<"DS HANG HOA ["<<i+1<<"]";
		cout<<"\nMA HANG HOA: ";
		cin.getline(p[i].ma,20);
		cout<<"TEN HANG HOA: ";
		cin.getline(p[i].ten,20);
		cout<<"SO LUONG HANG: ";
		cin>>p[i].sl;
		cout<<"THOI GIAN BAO HANH: ";
		cin>>p[i].time;
		cout<<endl;
		cin.get();
	}
	//max
	int max;
	for(i=0;i<n;i++)
	{
		if(p[i].time > temp)
		{
			max = p[i].time;
			empty = i;
		}
	}
	//xuat file
	ofstream ofs;
	ofs.open("C:/Users/Admin/Desktop/HANG_HOA.txt",ios::out);
	if(!ofs)
	{
		cout<<"ERROR !!! ";
	}
	else
	{
		for(i=0;i<n;i++)
		{
		   cout<<setw(3)<<i+1<<setw(20)<<p[i].ma<<setw(10)<<p[i].ten<<setw(10)<<p[i].sl<<setw(10)<<p[i].time<<endl;	
		}
		cout<<"\nMAT HANG CO SO LUONG TON KHO NHIEU NHAT: \n";
		cout<<setw(3)<<empty+1<<setw(20)<<p[empty].ma<<setw(10)<<p[empty].ten<<setw(10)<<p[empty].sl<<setw(10)<<p[empty].time<<endl;
		ofs<<"\nMAT HANG CO SO LUONG TON KHO NHIEU NHAT: \n";
		ofs<<setw(3)<<empty+1<<setw(20)<<p[empty].ma<<setw(10)<<p[empty].ten<<setw(10)<<p[empty].sl<<setw(10)<<p[empty].time<<endl;
		cout<<"\nSUCCESSFUULY !!!\n";	
	}
}
