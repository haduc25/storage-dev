#include <iostream>
#include <iomanip>
#include <cstdio>
#include <fstream>

using namespace std;

struct HOC_SINH
{
	char maHS[20];
	char ten[20];
	char diaChi[20];
	char sex[10];
	float diemTB;
	int day,month,year;
};

HOC_SINH  *p;
int n,i,j;

int main()
{
	//nhap n ds
	cout<<"NHAP DS HOC SINH: ";
	cin>>n;
	cin.get();
	p = new HOC_SINH[n];
	//nhap info of hs
	for(i=0;i<n;i++)
	{
		cout<<"DS HOC SINH ["<<i+1<<"]";
		cout<<"\nHO TEN: ";
		fflush(stdin);
		cin.getline(p[i].ten,20);
		cout<<"NGAY SINH: \n";
		cin>>p[i].day>>p[i].month>>p[i].year;
		cin.get();
		cout<<"DIA CHI: ";
		cin.getline(p[i].diaChi,20);
		cout<<"GIOI TINH: ";
		cin.getline(p[i].sex,10);
		cout<<"DIEM TB: ";
		cin>>p[i].diemTB;
		cout<<endl<<endl;
		cin.get();
	}
	//sort
	for(i=0;i<n-1;i++)
	{
	for(j=i-1;j<n;j++)
	{
		HOC_SINH temp;
		if(p[i].diemTB > p[j].diemTB)
		{
			temp = p[i];
			p[i] = p[j];
			p[j] = temp;
		}
	}
	}
	//xuat file
	ofstream ofs;
	ofs.open("C:\\Users\\Admin\\Desktop\\HOC_SINH.txt",ios::out);
	if(!ofs)
	{
		cout<<"ERROR !!";
	}
	else
	{
	for(i=0;i<n;i++)
	{
	cout<<"SORT\n";
	ofs<<"DANH SACH HS"<<endl;
	cout<<setw(3)<<i+1<<setw(20)<<p[i].ten<<setw(10)<<p[i].day<<"/"<<p[i].month<<"/"<<p[i].year<<setw(20)<<p[i].diaChi<<setw(10)<<p[i].sex<<setw(10)<<fixed<<setprecision(2)<<(p[i].diemTB - 0.005)<<endl;
	ofs<<setw(3)<<i+1<<setw(20)<<p[i].ten<<setw(10)<<p[i].day<<"/"<<p[i].month<<"/"<<p[i].year<<setw(20)<<p[i].diaChi<<setw(10)<<p[i].sex<<setw(10)<<fixed<<setprecision(2)<<(p[i].diemTB - 0.005)<<endl;
	}
	cout<<"SUCCESFULLY !!!";
	}
	ofs.close();
}
