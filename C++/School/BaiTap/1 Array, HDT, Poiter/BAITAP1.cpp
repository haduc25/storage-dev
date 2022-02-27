#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>
#include <windows.h>

using namespace std;

struct HOCSINH
{
	char hoTen[20];
	char maHS[20];
	float diemToan,diemLy,diemHoa;
}; 
HOCSINH *p;
int i,n;
int main()
{
	cout<<"Nhap so hoc sinh: ";
	cin>>n;
	cin.get();
	p = new HOCSINH[n];
	for(i=0;i<n;i++)
	{
		cout<<"DANH SACH HOC SINH ["<<i+1<<"]: "<<endl;
		cout<<"Ten hoc sinh: ";
		cin.getline((p+i)->hoTen,20);
		cout<<"Ma hoc sinh: ";
		cin.getline((p+i)->maHS,20);
		cout<<"Diem toan: ";
		cin>>(p+i)->diemToan;
		cout<<"Diem ly: ";
		cin>>(p+i)->diemLy;
		cout<<"Diem hoa: ";
		cin>>(p+i)->diemHoa;
		cin.get();
	}
	system("cls"); // xoa man hinh
	cout<<"DANH SACH VUA NHAP LA: "<<endl;
	for(i=0;i<n;i++)
	{
		cout<<setw(3)<<i+1<<setw(10)<<p[i].maHS<<setw(20)<<p[i].hoTen;
		cout<<setw(5)<<p[i].diemToan<<setw(5)<<p[i].diemLy<<setw(5)<<p[i].diemHoa<<endl;
		/*
		cout<<"\nDANH SACH ["<<i<<"]: "<<endl;
		cout<<"\nTen hoc sinh: "<<(p+i)->hoTen;
		cout<<"\nMa hoc sinh: "<<(p+i)->maHS;
		cout<<"\nDiem toan: "<<(p+i)->diemToan;
		cout<<"\nDiem ly: "<<(p+i)->diemLy;
		cout<<"\nDiem hoa: "<<(p+i)->diemHoa;
		cout<<endl<<endl;
		*/
	}
	ofstream f("d:\\Folder\\diem.txt",ios::out);
	if (!f) cout<<"Khong mo duoc file !";
    else
	{
		for (i=0; i<n; i++)
		if (((p[i].diemToan+p[i].diemLy+p[i].diemHoa)/3)>7 && ((p[i].diemToan+p[i].diemLy+p[i].diemHoa)/3)<8.4)
		{
			f<<setw(3)<<i+1<<setw(10)<<p[i].maHS<<setw(20)<<p[i].hoTen;
			f<<p[i].diemToan<<" "<<p[i].diemLy<<" "<<p[i].diemHoa<<endl;
		}
		f.close();
	}
	
}
