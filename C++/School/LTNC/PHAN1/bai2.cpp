#include <iostream>
#include <cstdio>
#include <iomanip>
#include <fstream>

using namespace std;

struct MAT_HANG
{
	char maHang[20];
	char tenHang[20];
	char donViTinh[10];
	int soLuong,gia;
};

MAT_HANG *p;
int i,n;

int main()
{
	//dk n>0
	do
	{
	   cout<<"NHAP SO LUONG DANH SACH (N>0): ";
	   cin>>n;
	   cin.get();
	   p =new MAT_HANG[n];
	}while(n<=0);
	//nhap
	for(i=0;i<n;i++)
	{
		cout<<"\nDANH SACH MAT HANG THU "<<i+1<<endl;
		cout<<"MA HANG: ";
		cin.getline(p[i].maHang,20);
		cout<<"TEN HANG: ";
		cin.getline(p[i].tenHang,20);
		cout<<"DON VI TINH: ";
		cin.getline(p[i].donViTinh,10);
		cout<<"SO LUONG: ";
		cin>>p[i].soLuong;
		cout<<"GIA: ";
		cin>>p[i].gia;
		cin.get();
	}
	//ghi ra file
	ofstream ofs;
	ofs.open("C:\\Users\\Admin\\Desktop\\MAT_HANG.txt",ios::out);
	if(!ofs)
	{
		cout<<"\nERROR !!!";
	}
	else
	{
		cout<<"\nSuccessfully !";
		for(i=0;i<n;i++)
		{
			ofs<<setw(5)<<i+1<<setw(20)<<p[i].maHang<<setw(10)<<p[i].tenHang<<setw(10)<<p[i].donViTinh<<setw(10)<<p[i].soLuong<<setw(10)<<p[i].gia<<endl;
		}
	}
	ofs.close();
}
