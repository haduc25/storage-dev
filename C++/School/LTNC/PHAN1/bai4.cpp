#include <iostream>
#include <cstdio>
#include <iomanip>
#include <fstream>

using namespace std;

struct BENH_NHAN
{
	char ten[20];
	char diaChi[20];
	char khoa[20];
	int ngaynamvien;
};

BENH_NHAN *p;
int i,n;

int main()
{
	//nhap n ds
	cout<<"SO LUONG DS BENH NHAN: ";
	cin>>n;
	cin.get();
	p = new BENH_NHAN[n];
	//nhap thong tin
	for(i=0;i<n;i++)
	{
		cout<<"BENH NHAN ["<<i+1<<"]";
		cout<<"\nHO TEN: ";
		cin.getline(p[i].ten,20);
		cout<<"DIA CHI: ";
		cin.getline(p[i].diaChi,20);
		cout<<"KHOA DIEU TRI: ";
		cin.getline(p[i].khoa,20);
		cout<<"SO NGAY NAM VIEN: ";
		cin>>p[i].ngaynamvien;
		cout<<endl;
		cin.get();
	}
	//tim max
	int temp = 0,max = 0;
	for(i=0;i<n;i++)
	{
		if(p[i].ngaynamvien > max)
		{
			max=p[i].ngaynamvien;
			temp = i;
		}
	}
    //xuat file
    ofstream ofs;
    ofs.open("C:/Users/Admin/Desktop/Ngayvien.txt",ios::out);
    if(!ofs)
	{
		cout<<"ERROR [1]";
	}
	else
	{
	//xuat
	cout<<"DS VUA NHAP LA: "<<endl;
	ofs<<"DS BENH NHAN: \n";
	for(i=0;i<n;i++)
	{
		cout<<setw(3)<<i+1<<setw(20)<<p[i].ten<<setw(10)<<p[i].diaChi<<setw(10)<<p[i].khoa<<setw(10)<<p[i].ngaynamvien<<endl;
		ofs<<setw(3)<<i+1<<setw(20)<<p[i].ten<<setw(10)<<p[i].diaChi<<setw(10)<<p[i].khoa<<setw(10)<<p[i].ngaynamvien<<endl;
	}
	//max
	cout<<"BENH NHAN CO SO NGAY NAM VIEN LON NHAT:\n";
    cout<<setw(3)<<temp+1<<setw(20)<<p[temp].ten<<setw(10)<<p[temp].diaChi<<setw(10)<<p[temp].khoa<<setw(10)<<p[temp].ngaynamvien<<endl;
    ofs<<"BENH NHAN CO SO NGAY NAM VIEN LON NHAT:\n";
    ofs<<setw(3)<<temp<<setw(20)<<p[temp].ten<<setw(10)<<p[temp].diaChi<<setw(10)<<p[temp].khoa<<setw(10)<<p[temp].ngaynamvien<<endl;
    cout<<"\nSUCCESSFULLY !!!\n";
	}
	ofs.close();
}
