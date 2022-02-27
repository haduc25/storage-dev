#include <iostream>
#include <cstring>

using namespace std;
//1
class PERSON
{
	private:
		string so_cmnd, ho_ten, nghe_nghiep;
	public:
		PERSON()
		{
			so_cmnd="";
			ho_ten="";
			nghe_nghiep="";
		}
		PERSON(string so_cmnd1, string ho_ten1, string nghe_nghiep1)
		{
			so_cmnd=so_cmnd1;
			ho_ten=ho_ten1;
			nghe_nghiep=nghe_nghiep1;
		}
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ho ten: ";
		 	getline(cin,ho_ten);
		 	fflush(stdin);
		 	cout<<"Nhap so cmnd: ";
		 	getline(cin,so_cmnd);
		 	fflush(stdin);
		 	cout<<"Nhap nghe nghiep: ";
		 	getline(cin,nghe_nghiep);
		 	fflush(stdin);
		}
		void xuat()
		{
			cout<<"Ho ten: "<<ho_ten<<endl;
			cout<<"So cmnd: "<<so_cmnd<<endl;
			cout<<"Nghe nghiep: "<<nghe_nghiep<<endl;
		}
};
//2
class HO_DAN : public PERSON
{
	private:
		int so_nguoi;
		string so_nha;
	public:
		HO_DAN()
		{
			so_nha="";
		}
		HO_DAN(string so_cmnd1, string ho_ten1, string nghe_nghiep1, int so_nguoi1, string so_nha1):PERSON(so_cmnd1, ho_ten1, nghe_nghiep1)
		{
			so_nguoi=so_nguoi1;
			so_nha=so_nha1;
		}
		void nhap_hd()
		{
			PERSON::nhap();
			fflush(stdin);
			cout<<"Nhap so nguoi: ";
			cin>>so_nguoi;
			fflush(stdin);
			cout<<"Nhap so nha: ";
			getline(cin,so_nha);
			fflush(stdin);
		}
		void xuat_hd()
		{
			PERSON::xuat();
			cout<<"So nguoi: "<<so_nguoi<<endl;
			cout<<"So nha: "<<so_nha<<endl;
		}
};

//3
class DSHD
{
	private:
		HO_DAN hd[1000];
		int i,n;
	public: 
		//nhap
		void nhap_ds()
		{
			cout<<"THONG TIN HO DAN\nNhap so ho dan: ";
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"\nHo dan thu ["<<i+1<<"]"<<endl;
				hd[i].nhap_hd();
			}
		}
		//xuat
		void xuat_ds()
		{
			cout<<"\nTHONG TIN HO DAN"<<endl;
			for(i=0;i<n;i++)
			{
				cout<<"\nHo dan thu ["<<i+1<<"]"<<endl;
				hd[i].xuat_hd();
			}
		}
};
int main()
{
	DSHD ds;
	ds.nhap_ds();
	ds.xuat_ds();
}

































