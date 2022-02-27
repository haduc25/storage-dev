#include <iostream>
#include <cstring>

using namespace std;

class KHACH_HANG
{
	private:
		char ho_Ten[25];
		char ma_so_cong_to[10];
		int so_nha;
	public:
	void nhap_KH()
		{
			fflush(stdin);
			cout<<"Nhap ho va ten chu ho: ";
			cin.getline(ho_Ten,25);
			fflush(stdin);
			cout<<"Nhap so nha: ";
			cin>>so_nha;
			fflush(stdin);
			cout<<"Nhap ma so cong to: ";
			cin.getline(ma_so_cong_to,10);
			fflush(stdin);
		}
		void xuat_KH()
		{
			cout<<"Ho va ten: "<<ho_Ten<<endl;
			cout<<"So nha: "<<so_nha<<endl;
			cout<<"Ma so cong to: "<<ma_so_cong_to<<endl;
		}		
};

class BIEN_LAI
{
	private:
		int so_moi,so_cu,so_tien_phai_tra;
	public:
		void nhap_BL()
		{
			cout<<"Nhap chi so moi: ";
			cin>>so_moi;
			cout<<"Nhap chi so cu: ";
			cin>>so_cu;
		}
		void xuat_BL()
		{
			cout<<"Chi so moi: "<<so_moi<<endl;
			cout<<"Chi so cu: "<<so_cu<<endl;
			so_tien_phai_tra = ((so_moi - so_cu)*850000);
			cout<<"So tien phai tra: "<<so_tien_phai_tra<<"vnd"<<endl;
		}
	
};
//so tien phai tra =(so moi-so cu)*850.000
class QUAN_LY
{
	private: 
		KHACH_HANG kh[100];
		BIEN_LAI bl[100];
		int n,i;
	public:
		void nhap_DS()
		{
		cout<<"Nhap thong tin khach hang\n";
		cout<<"So luong khach hang n= ";
		cin>>n;
		cout<<"\tNHAP THONG TIN KHACH HANG"<<endl;
		for(i=0;i<n;i++)
		{
			cout<<"\nKhach hang thu ["<<i+1<<"]"<<endl;
			kh[i].nhap_KH();
			cout<<"Bien lai thu ["<<i+1<<"]"<<endl;
			bl[i].nhap_BL();
		}
		}
		void xuat_DS()
		{
			cout<<"KHACH HANG"<<endl;
			for(i=0;i<n;i++)
			{
				cout<<"Khach hang thu ["<<i+1<<"]"<<endl;
				kh[i].xuat_KH();
				cout<<"Bien lai thu ["<<i+1<<"]"<<endl;
				bl[i].xuat_BL();
			}
		}
};
int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_DS();
	cout<<"Xuat "<<endl;
	ql.xuat_DS();
}
