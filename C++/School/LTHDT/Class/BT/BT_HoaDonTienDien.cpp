#include <iostream>
#include <cstring>

using namespace std;

class KHACH
{
	private: 
			char ten_khach[25];
			int so_nha, so_ct;
	public:
			void nhap()
			{
				fflush(stdin);
				cout<<"Nhap ten khach hang: ";
				cin.getline(ten_khach,25);
				fflush(stdin);
				cout<<"Nhap so nha: ";
				cin>>so_nha;
				fflush(stdin);
				cout<<"Nhap so cong to: ";
				cin>>so_ct;
				fflush(stdin);
			}
			void xuat()
			{
				cout<<ten_khach<<", "<<so_nha<<", "<<so_ct<<", ";
			}
};

class BIEN_LAI : public KHACH
{
	private:
			int cs_cu, cs_moi, temp;
	public:
			void nhap_bl()
			{
				KHACH::nhap();
				fflush(stdin);
				cout<<"Nhap chi so cu: ";
				cin>>cs_cu;
				fflush(stdin);
				cout<<"Nhap chi so moi: ";
				cin>>cs_moi;
				fflush(stdin);
			}
			void xuat_bl()
			{
				KHACH::xuat();
				cout<<cs_cu<<", "<<cs_moi<<endl;
				//so tien can thanh toan
				temp=(cs_moi-cs_cu)*8.500;
				cout<<"Tong so tien can thanh toan: "<<temp<<endl;
			}
};

class QUAN_LY
{
	private:
		BIEN_LAI bl[100];
		int i,j,n;
	public:
		void nhap_ds()
		{
			cout<<"Thong tin khach"<<endl;
			cout<<"So luong khach: ";			
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"\nKhach thu ["<<i+1<<"]"<<endl;
				bl[i].nhap_bl();
			}
		}
		void xuat_ds()
		{
			for(i=0;i<n;i++)
			{
				cout<<"\nKhach thu ["<<i+1<<"]"<<endl;
				bl[i].xuat_bl();
			}
		}
};
int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_ds();
	ql.xuat_ds();
}
