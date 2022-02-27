#include <iostream>
#include <cstring>

using namespace std;

class SACH
{
	private:
		char ten_Sach[20];
		char tac_Gia[20];
		int nam_XB;
	public:
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ten sach: ";
			cin.getline(ten_Sach,20);
			fflush(stdin);
			cout<<"Nhap ten tac gia: ";
			cin.getline(tac_Gia,20);
			fflush(stdin);
			cout<<"Nhap nam xuat ban: ";
			cin>>nam_XB;
			fflush(stdin);
			cout<<endl;		
		}
		void xuat()
		{
			cout<<"Ten sach: "<<ten_Sach<<endl;
			cout<<"Ten tac gia: "<<tac_Gia<<endl;
			cout<<"Nam xuat ban: "<<nam_XB<<endl;
			cout<<"\n";
		}
		
};

class QUAN_LY
{
	private:
		int n = 3,i;
		SACH sach[10];
		
	public:
		void nhap_DS()
		{
			cout<<"Nhap thong tin sach"<<endl;
			for(i=0;i<n;i++)
			{
				cout<<"Sach thu ["<<i+1<<"]"<<endl;
				sach[i].nhap();
			}
		}
		void xuat_DS()
		{
			for(i=0;i<n;i++)
			{
				cout<<"Sach thu ["<<i+1<<"]"<<endl;
				sach[i].xuat();
			}	
		}
};

int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_DS();
	cout<<"\nDS vua nhap\n";
	ql.xuat_DS();
}
