#include <iostream>
#include <cstdio>
#include <fstream>
#include <iomanip>

using namespace std;

struct MAY_TINH
{
	char ten[20];	
	int cpu,ram,gia,ma;
};

MAY_TINH *p;
int n,temp,j,i;

int main()
{
	//ma may
 	cout<<"NHAP MA MAY: ";
 	cin>>n;
 	cout<<endl;
 	cin.get();
	p = new MAY_TINH[n];
	temp = n;
	
	for(i=0;i<n;i++)
	{
	    cout<<"MA MAY ["<<temp<<"]";
		cout<<"\nTEN MAY: ";
		cin.getline(p[i].ten,20);
		cout<<"TOC DO CPU: ";
		cin>>p[i].cpu;
		cout<<"DUNG LUONG RAM: ";
		cin>>p[i].ram;
		cout<<"DON GIA: ";
		cin>>p[i].gia;
		cout<<endl;
		temp--;
		if(temp == 0)
		{
			// ma may=0
			cout<<"DA HET SO LUONG MAY !!!";
		}
		cin.get();
	}
	cout<<"\nBEFORE SORT \n";
	for(i=0;i<n;q++)
	{
		cout<<setw(3)<<i+1<<setw(20)<<p[i].ten<<setw(10)<<p[i].cpu<<setw(10)<<p[i].ram<<setw(10)<<p[i].gia<<endl;
	}
	
	for(i=0;i<n-1;i++)
	{
		for(j=i+1;j<n;j++)
		{
			MAY_TINH empty;
			if(p[i].cpu < p[j].cpu)
			{
				empty = p[i];
				p[i] = p[j];
				p[j]= empty;
			}	
		}
	}
	cout<<"AFTER SORT\n";
	for(i=0;i<n;i++)
	{
		cout<<setw(3)<<i+1<<setw(20)<<p[i].ten<<setw(10)<<p[i].cpu<<setw(10)<<p[i].ram<<setw(10)<<p[i].gia<<endl;
	}
	//xuat
	ofstream ofs;
	ofs.open("C:\\Users\\Admin\\Desktop\\MAY_TINH.txt",ios::out);
	if(!ofs)
	{
		cout<<"ERROR !!! ";
	}
	else
	{
		cout<<"\nSUCCESSFULLY !!!\n";
		ofs<<"DANH SACH MAY TINH SAU KHI SAP XEP THEO CPU:\n";
		for(i=0;i<n;i++)
		{
		ofs<<setw(3)<<i+1<<setw(20)<<p[i].ten<<setw(10)<<p[i].cpu<<setw(10)<<p[i].ram<<setw(10)<<p[i].gia<<endl;
		}	
	}
	ofs.close();
}
