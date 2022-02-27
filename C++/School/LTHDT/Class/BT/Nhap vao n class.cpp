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
			cout<<"\n";
		}
		void xuat()
		{
			cout<<"Ma SV: "<<ma_SV<<endl;
			cout<<"Ten SV: "<<ho_Ten<<endl;
			cout<<"Diem TB: "<<diem_TB<<endl;
			cout<<endl;
		}
};

class QUAN_LY
{
	private:
		int n,i;
		SINH_VIEN sv[100]; //tao 100 sv
	public:
		void nhap_DS()
		{
			cout<<"NHAP THONG TIN SV\n";
			cout<<"N= ?";
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"sinh vien thu ["<<i+1<<"]"<<endl;
				sv[i].nhap();
			}
		}
		void xuat_DS()
		{
			for(i=0;i<n;i++)
			{
				cout<<"sinh vien thu ["<<i+1<<"]"<<endl;
				sv[i].xuat();
			}
		}	
};

int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_DS();
	ql.xuat_DS();
}
