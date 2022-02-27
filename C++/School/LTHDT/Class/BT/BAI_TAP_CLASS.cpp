#include <iostream>
#include <cstring>

using namespace std;

class SACH
{
	private:
		char ten_Sach[50];
		char tac_Gia[20];
		int nam_XB;
	public:
		int temp;
		string ten;
		
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ten sach: ";
			cin.getline(ten_Sach,50);
			fflush(stdin);
			cout<<"Nhap ten tac gia: ";
			cin.getline(tac_Gia,20);
			fflush(stdin);
			cout<<"Nhap nam xuat ban: ";
			cin>>nam_XB;
			fflush(stdin);
			temp = nam_XB;
			ten = ten_Sach;
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
		int n = 3,i,j,check;
		SACH sach[100];
		
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
				//xuat
				sach[i].xuat();
			}
		}
		void sort()
		{
				//sort
				for(i=0;i<n-1;i++)
				{
					for(j=i+1;j<n;j++)
					{
						if(sach[i].temp < sach[j].temp)
						{
							SACH helo;
							helo = sach[i];
		  					sach[i] = sach[j];		 
							sach[j] = helo;
						}
					}
				}
		}
		void name_Book()
		{
			for(i=0;i<n;i++)
			{
				if(sach[i].ten == "Lap trinh huong doi tuong")
				{
					cout<<"Info is: "<<sach[i].ten<<endl;
				}
				else
				{
					cout<<"K co sach nao ten nhu vay";
				}
			}
		}
};

int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_DS();
	cout<<"\nDS vua nhap\n";
	ql.xuat_DS();
	cout<<"\nDS xap xe theo lon den be\n";
	ql.sort();
	ql.xuat_DS();
	cout<<"\nSACH CO TEN LAP TRINH HDT"<<endl;
	ql.name_Book();
}
