/*
Thu vien Truong DH KHTN co nhu cau quan ly viec muon sach, sih vien ddang ki tham gia muon sach thong qua cac the muon ma thu vien da thiet ke
-moi the muon co: +phieu muon
				  +ngay muon
				  +han tra
				  +so hieu sach
				  +thong tin SV
-thong tin SV: Ho ten, nam sinh, tuoi, lop, 
1.xay dung cac lop sinh vien de quan ly cac thong tin rieng ve moi sinh vien, lop THE_MUON de quan ly viec muon sach cuoi moi doc gia
2.viet chuong trinh nhap va hien thi thong tin cua moi the muon.				  
*/
#include <iostream>
#include <cstring>

using namespace std;

class THE_MUON
{
	private:
		char ho_Ten[25];
		char lop[10];
		char so_hieu_sach[20];
		int nam_Sinh,tuoi,so_Phieu,ngay_Muon,han_Tra;
	public:	
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ho va ten SV: ";
			cin.getline(ho_Ten,25);
			fflush(stdin);
			cout<<"Nhap lop SV: ";
			cin.getline(lop,10);
			fflush(stdin);
			cout<<"Nhap nam sinh cua SV: ";
			cin>>nam_Sinh;
			fflush(stdin);
			cout<<"Nhap tuoi Sv: ";
			cin>>tuoi;
			fflush(stdin);
			cout<<"Nhap so hieu sach: ";
			cin.getline(so_hieu_sach,20);
			fflush(stdin);
			cout<<"Nhap so phieu: ";
			cin>>so_Phieu;
			fflush(stdin);
			cout<<"Nhap ngay muon: ";
			cin>>ngay_Muon;
			fflush(stdin);
			cout<<"Nhap han tra: ";
			cin>>han_Tra;
			fflush(stdin);
			
		}
		void xuat()
		{
			cout<<"Ho va ten: "<<ho_Ten<<endl;
			cout<<"Lop: "<<lop<<endl;
			cout<<"Nam sinh: "<<nam_Sinh<<endl;
			cout<<"Tuoi: "<<tuoi<<endl;
			cout<<"So hieu sach: "<<so_hieu_sach<<endl;
			cout<<"So phieu: "<<so_Phieu<<endl;
			cout<<"Ngay muon: "<<ngay_Muon<<endl;
			cout<<"Han tra: "<<han_Tra<<endl;
		}		
};

class QUAN_LY
{
	private:
		int n,i;
		THE_MUON tm[100];
	public:
		void nhap_DS()
		{
			cout<<"NHAP THONG TIN CUA THE MUON"<<endl;
			cout<<"So the muon n= ";
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"\nThe muon ["<<i+1<<"]"<<endl;
				tm[i].nhap();
			}
		}
		void xuat_DS()
		{
			for(i=0;i<n;i++)
			{
				cout<<"\nThe muon ["<<i+1<<"]"<<endl;
				tm[i].xuat();
			}
		}
	
};

int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_DS();
	cout<<"\nTHONG TIN CUA THE MUON"<<endl;	
	ql.xuat_DS();
}








