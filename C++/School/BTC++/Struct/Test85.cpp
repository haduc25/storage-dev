#include <stdio.h>
#include <iostream>
#include <iomanip>
using namespace std;
struct Bongda
{
	char name[20];
	int thang,hoa,thua,diem;
};

//Khai báo a,b kieu Bongda
Bongda a,b,*p;
int n,i;

int main()
{
	cout<<"Nhap so doi bong: ";
	cin>>n;
	cin.get(); //xoa bo nho dem ban phim
	p= new Bongda[n]; //use poiter

	//Nhap
for(i=1;i<=n;i++)
{
	cout<<"\n\nNhap thong tin doi bong";
	cout<<"\nTen doi bong: ";cin.getline((p+i)->name,20); //p+i == p[i] 
	cout<<"So tran thang: ";
	cin>>(p+i)->thang;
	cout<<"So tran hoa: ";
	cin>>(p+i)->hoa;
	cout<<"So tran thua: ";
	cin>>(p+i)->thua;
	cout<<"Diem: ";
	cin>>(p+i)->diem;
	cin.get();
}

	//Xuat
	cout<<"Thong tin vua nhap\n";
	for(i=1;i<=n;i++)
	{
	//setw(): cap phat o nho
	cout<<setw(20)<<"Ten doi: "<<(p+i)->name; 
	cout<<setw(5)<<"\nTran thang: "<<(p+i)->name;
	cout<<setw(5)<<"\nTran hoa: "<<(p+i)->thang;
	cout<<setw(5)<<"\nTran thua: "<<(p+i)->thua;
	cout<<setw(5)<<"\nDiem: "<<(p+i)->diem;
	}
}
