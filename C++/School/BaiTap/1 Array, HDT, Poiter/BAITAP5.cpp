#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>

using namespace std;

struct CANBO
{
	char ma[10];
	char hoten[20];
	float luong;
};
CANBO ds[5],temp;
int i,n;

int main()
{
	cout<<"So can bo 1<n<5: ";
	cin>>n;
 	cin.get();
 	for(i=0;i<n;i++)
	 {
	 	cout<<"NHAP THONG TIN CUA CAN BO ["<<i+1<<"]\n";
	 	cout<<"Nhap ma can bo: ";
	 	cin.getline(ds[i].ma,10);
	 	cout<<"Nhap ho ten: ";
	 	cin.getline(ds[i].hoten,20);
	 	cout<<"Muc luong can bo: ";
	 	cin>>ds[i].luong;
	 	cin.get();
	 }
	 //In Du lieu
	 ofstream ofs("d:/folder/danhsach.txt",ios::out);
	 if(!ofs)
	 {
	 	cout<<"Loi khong the mo tep";
	 }
	 else
	 {
	 	for(i=0;i<n;i++)
		 {
		 	if(ds[i].luong>500000)
			 {
			 	ofs<<ds[i].ma<<','<<ds[i].hoten<<',';
			 	ofs<<setw(10)<<ds[i].luong<<endl;
			 }
		 }
	 }
	ofs.close();
	//doc du lieu file
	ifstream ifs("d:/folder/danhsach.txt",ios::in);
	cout<<"DANH SACH CAN BO CO LUONG TREN 500.000VND LA: "<<endl;
	//eof(): doc den cuoi file
	while(!ifs.eof())
	{
		ifs.getline(temp.ma,10,',');
		ifs.getline(temp.hoten,20,',');
		ifs>>temp.luong;
		cout<<setw(5)<<temp.ma<<setw(20)<<temp.hoten<<setw(10)<<temp.luong;
	}
	ifs.close();
}




























