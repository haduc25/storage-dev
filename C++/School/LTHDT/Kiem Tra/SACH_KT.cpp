#include <iostream>
#include <cstring>

using namespace std;
//cau1
class SACH
{
	private:
		string ten_sach,ten_tg;
		int nam_xb;
	public:
		SACH()
		{
			ten_sach="";
			ten_tg="";
		}
		SACH(string ten_sach1, string ten_tg1, int nam_xb1)
		{
			ten_sach=ten_sach1;
			ten_tg=ten_tg1;
			nam_xb=nam_xb1;
		}
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ten sach: ";
			getline(cin,ten_sach);
			fflush(stdin);
			cout<<"Nhap ten tac gia: ";
			getline(cin,ten_tg);
			fflush(stdin);
			cout<<"Nhap nam xb: ";
			cin>>nam_xb;
			fflush(stdin);
		}
		void xuat()
		{
			cout<<ten_sach<<", "<<ten_tg<<", "<<nam_xb<<", ";
		}
};
//cau 2
class TRUYEN : public SACH
{
	private:
		string the_loai;
		int gia;
	public:
		TRUYEN()
		{
			the_loai="";
		}
		TRUYEN(string ten_sach1, string ten_tg1, int nam_xb1, string the_loai1, int gia1):SACH(ten_sach1,ten_tg1,nam_xb1)
		{
			the_loai=the_loai1;
			gia=gia1;
		}
		void nhap_t()
		{
			SACH::nhap();
			fflush(stdin);
			cout<<"Nhap the loai: ";
			getline(cin,the_loai);
			fflush(stdin);
			cout<<"Nhap gia: ";
			cin>>gia;
			fflush(stdin);
		}
		void xuat_t()
		{
			SACH::xuat();
			cout<<the_loai<<", "<<gia<<endl;
		}
};
//cau3
class QUAN_LY
{
	private:
		TRUYEN truyen[1000];
		int n,i;
	public:
		//nhap
		void nhap_ql()
		{
			cout<<"Nhap n: ";
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"\nTRUYEN THU ["<<i+1<<"]"<<endl;
				truyen[i].nhap_t();
			}
		}
		//xuat
		void xuat_ql()
		{
			for(i=0;i<n;i++)
			{
				cout<<"\nTRUYEN THU ["<<i+1<<"]"<<endl;
				truyen[i].xuat_t();			}
		}
};

int main()
{
	QUAN_LY ql;
	ql.nhap_ql();
	ql.xuat_ql();
	return 0;
}
















