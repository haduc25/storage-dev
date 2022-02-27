#include <iostream>
#include <cstring>

using namespace std;

class CONG_NHAN
{
	private:
		char ma_CN[15];
		char ho_Ten[25];
		char que_quan[20];
		int nam_sinh;
	public:
		int temp;
		string que;
	void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ma cong nhan: ";
			cin.getline(ma_CN,15);
			fflush(stdin);
			cout<<"Nhap ho va ten: ";
			cin.getline(ho_Ten,25);
			fflush(stdin);
			cout<<"Nhap que quan: ";
			cin.getline(que_quan,20);
			fflush(stdin);
			cout<<"Nhap nam sinh: ";
			cin>>nam_sinh;
			temp=nam_sinh;
			que=que_quan;
			fflush(stdin);
		}
		void xuat()
		{
			cout<<"Ma cong nhan: "<<ma_CN<<endl;
			cout<<"Ho va ten: "<<ho_Ten<<endl;
			cout<<"Que quan: "<<que_quan<<endl;
			cout<<"Nam Sinh: "<<nam_sinh<<endl;
		}		
};

class QUAN_LY
{
	private:
		int n,i;
		CONG_NHAN cn [100];
	public:
		void nhap_DS()
		{
			cout<<"NHAP THONG TIN CONG NHAN\n";
			cout<<"N= ";
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"cong nhan thu ["<<i+1<<"]"<<endl;
				cn[i].nhap();
			}
		}
		void xuat_DS()
		{
			for(i=0;i<n;i++)
			{
				cout<<"cong nhan thu ["<<i+1<<"]"<<endl;
				cn[i].xuat();
			}
		}
		void sort()
		{
			for(i=0;i<n;i++)
			{
				if(cn[i].temp>1980)
				{
					cout<<"\nCong nhan co nam sinh lon hon 1980: "<<cn[i].temp;
				}
			}
		}
		void que_HD()
		{
			for(i=0;i<n;i++)
			{
				if(cn[i].que == "Hai Duong" || cn[i].que == "hai duong")
				{
					cout<<"\nCo cong nhan que o hai duong"<<cn[i].que;
				}
				else
				{
					cout<<"\nK co cong nhan que o hai duong";
				}
			}
		}
	
};

int main()
{
	QUAN_LY ql = QUAN_LY();
	ql.nhap_DS();
	ql.sort();
	cout<<"Xuat "<<endl;
	ql.xuat_DS();
	cout<<"\nQue tai Hai Duong: "<<endl;
	ql.que_HD();
}
