/*
1. xay dung lop nguoi gom (ho ten, dia chi, nam sinh)
-cac phuong thuc: void nhap TT(){//thong tin cho NGUOI}
----------------:void inTT(//in thong tin cho NGUOI)
2. xay dung lop VATDUNG chua phuong thuc main(): cho phep truy cap thong tin cua n nguoi va hien thi thong tin cua n nguoi vua nhap ra man hinh.
*/
#include <cstring>
#include <iostream>

using namespace std;

class NGUOI
{
	private:
		char ho_ten[25];
		char dia_chi[25];
		int nam;
	public:
		void nhap()
{
			fflush(stdin);
			cout<<"Nhap ho ten: ";
			cin.getline(ho_ten,25);
			fflush(stdin);
			cout<<"Nhap dia chi: ";
			cin.getline(dia_chi,25);
			fflush(stdin);
			cout<<"Nhap nam sinh: ";
			cin>>nam;
			fflush(stdin);
}
		void xuat()
		{
			cout<<"Ho ten: "<<ho_ten<<endl;
			cout<<"Dia chi: "<<dia_chi<<endl;
			cout<<"Nam sinh: "<<nam<<endl;
			cout<<endl;
		}
		void check()
		{
			if(nam >=2000){xuat();}
		}
};
class QUAN_LY
{
	private:
		int n,i;
		NGUOI ng[100];
	public:
		void nhap_Ng()
		{
			cout<<"Nhap n"<<endl;
			cin>>n;
			for(i=0;i<n;i++)
			{
			cout<<"Nhap thong tin ["<<i+1<<"]"<<endl;
			ng[i].nhap();
			}
		}
		void xuat_Ng()
		{
			for(i=0;i<n;i++)
			{
			cout<<"Xuat thong tin []"<<i+1<<"]"<<endl;
			ng[i].xuat();
			}
		}
		void check_Ng()
		{
			for(i=0;i<n;i++)
			{
				ng[i].check();
			}
		}
};
int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_Ng();
	cout<<"XUAT\n";
	ql.xuat_Ng();
	cout<<"CHECK\n";
	ql.check_Ng();
}


