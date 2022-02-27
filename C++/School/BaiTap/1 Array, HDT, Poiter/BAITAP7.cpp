#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>

using namespace std;

struct THUEBAO
{
	char tenKH[20];
	char maKV[20];
	int soTB,ngay,thang,nam;
};
THUEBAO tb[100];
int i;

int main()
{
	i =0;
	while(true)
	{
		cout<<"\nNHAP THONG TIN CUA THUE BAO ["<<i+1<<"]"<<endl;
		cout<<"Ma khu vuc: ";
		cin.getline(tb[i].ma, 10);
		if (strlen(tb[i].maKV) == 0) break;
		cout<<"Ten khach hang: ";
		cin.getline(p[i].tenKH,20);
		cout<<"So thue bao: ";
		cin>>tb[i].soTB;
		cin.ignore();
		cout<<"NGAY/THANG/NAM: \n";
		cin>>tb[i].ngay>>p[i].thang>>p[i].nam;
		cin.get();
		cin.ignore();
		i++;
	}
	cout<<"\nTHONG TIN VUA NHAP LA: "<<endl;
	for(i=0;i<n;i++)
	{
 		cout<<setw(3)<<i+1<<setw(10)<<temp<<setw(10)<<p[i].tenKH<<setw(20)<<setw(10)<<p[i].soTB;
		cout<<p[i].ngay<<"/"<<p[i].thang<<"/"<<setw[10]<<p[i].nam<<endl;
	}
	ofstream ofs("d:/folder/dulieuhotro.txt",ios::out);
	if(!ofs)
	{
		cout<<"khong mo duoc file !";
	}
	else
	{
	    ofs<<"THONG TIN VUA NHAP"<<endl;
		for(i=0;i<n;i++)
		{		
	  	ofs<<setw(3)<<i+1<<setw(10)<<p[i].tenKH<<setw(20)<<setw(10)<<p[i].soTB;
		ofs<<p[i].ngay<<"/"<<p[i].thang<<"/"<<setw[10]<<p[i].nam<<endl;
		}	
		ofs.close();
	}
}
