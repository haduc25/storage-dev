#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>
 using namespace std;
 
 struct video
 {
 	char tenphim[20];
 	char theloai[10];
 	char daodien[20];
 	char namchinh[20];
 	char nuchinh[20];
 	char hangsx[20];
 	int namsx;
 };
 video *p;
 int i,n;
 int main()
 {
 	cout<<"Nhap so luong bo phim: ";
 	cin>>n;
 	cin.get();
 	p = new video[n];
 	for(i=0;i<n;i++)
	 {
	 	cout<<"\nBO PHIM ["<<i+1<<"]";
	 	cout<<"\nTen phim: ";
	 	cin.getline(p[i].tenphim,20);
	 	cout<<"The loai: ";
	 	cin.getline(p[i].theloai,10);
	 	cout<<"Ten dao dien: ";
	 	cin.getline(p[i].daodien,20);
	 	cout<<"Ten nam chinh: ";
	 	cin.getline(p[i].namchinh,20);
	 	cout<<"Ten nu chinh: ";
	 	cin.getline(p[i].nuchinh,20);
	 	cout<<"Hang phim san xuat: ";
	 	cin.getline(p[i].hangsx,20);
	 	cout<<"Nam san xuat: ";
	 	cin>>(p[i].namsx);
	 	cin.get();
	 }
	 for(i=0;i<n;i++)
	 {
	 	cout<<setw(3)<<i+1<<setw(10)<<p[i].tenphim<<setw(10)<<p[i].theloai<<setw(20)<<p[i].daodien;
		cout<<setw(10)<<p[i].namchinh<<setw(10)<<p[i].nuchinh<<setw(10)<<p[i].hangsx<<setw(10)<<p[i].namsx<<endl;
	 }
	 ofstream ofs("C:\\Users\\Admin\\Desktop\\bophim.txt",ios::out);
	 if(!ofs)
	 {
	 	cout<<"Loi khong the mo file";
	 }
	 else
	 {
	 	for(i=0;i<n;i++)
		 {
	 	ofs<<"DANH SACH CAC BO PHIM";
	 	ofs<<setw(3)<<i+1<<setw(10)<<p[i].tenphim<<setw(20)<<p[i].theloai;
	 	ofs<<p[i].daodien<<"\t"<<p[i].namchinh<<"\t"<<p[i].nuchinh<<"\t"<<p[i].hangsx<<"\t"<<p[i].namsx<<endl;
	 	}
	 	ofs.close();
	 }
 }
