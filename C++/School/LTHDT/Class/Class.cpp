//CACH 1
#include <iostream>
#include <cstring>

using namespace std;

class SINH_VIEN
{
	private: 
			char ma_SV[10];
			char ho_Ten[20];
			float diem_TB;
	public:
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ma sinh vien: ";
			cin.getline(ma_SV,10);
			fflush(stdin);
			cout<<"Nhap ho ten: ";
			cin.getline(ho_Ten,20);
			fflush(stdin);
			cout<<"Nhap DTB: ";
			cin>>diem_TB;
			fflush(stdin);
		}
		void xuat()
		{
			cout<<"Ma SV: "<<ma_SV<<endl;
			cout<<"Ten SV: "<<ho_Ten<<endl;
			cout<<"Diem TB: "<<diem_TB<<endl;
		}
};
int main()
{
	SINH_VIEN sv;
	sv.nhap();
	cout<<"THONG TIN SINH VIEN VUA NHAP LA \n";
	sv.xuat();
}
// CACH 2
/* 
#include <iostream>
#include <cstring>

using namespace std;

class SINH_VIEN
{
	private: 
			char ma_SV[10];
			char ho_Ten[20];
			float diem_TB;
	public:
		void nhap();
		void xuat();
};

void SINH_VIEN :: nhap()
{
			fflush(stdin);
			cout<<"Nhap ma sinh vien: ";
			cin.getline(ma_SV,10);
			fflush(stdin);
			cout<<"Nhap ho ten: ";
			cin.getline(ho_Ten,20);
			fflush(stdin);
			cout<<"Nhap DTB: ";
			cin>>diem_TB;
			fflush(stdin);
	
}

void SINH_VIEN :: xuat()
{
			cout<<"Ma SV: "<<ma_SV<<endl;
			cout<<"Ten SV: "<<ho_Ten<<endl;
			cout<<"Diem TB: "<<diem_TB<<endl;
}

int main()
{
	SINH_VIEN sv;
	sv.nhap();
	cout<<"THONG TIN SINH VIEN VUA NHAP LA \n";
	sv.xuat();
}
*/
