#include <iostream>
#include <cstdio>
#include <fstream>
#include <iomanip>
#include <cstring>

using namespace std;

struct VIDEO
{
	char Phim[20];
	char daoDien[20];
	char namChinh[20];
	char nuChinh[20];
	char hangSX[20];
	char theloai[10];
	int namSX;
};
int temp = 0;
char empty[10];
VIDEO *p;
int n,i;

int main()
{
	cout<<"NHAP SO LUONG DANH SACH VIDEO: ";
	cin>>n;
	cin.get();
	p = new VIDEO[n];
	
	for(i=0;i<n;i++)
	{
	  cout<<"DS VIDEO ["<<i+1<<"]"<<endl;
	  cout<<"PHIM: ";
	  cin.getline(p[i].Phim,20);
	  //the loai
	  cout<<"CHON THE LOAI PHIM: ";
	  cin.getline(p[i].theloai,10);
	  cout<<"DAO DIEN: ";
	  cin.getline(p[i].daoDien,20);
	  cout<<"NAM CHINH: ";
	  cin.getline(p[i].namChinh,20);
	  cout<<"NU CHINH: ";
	  cin.getline(p[i].nuChinh,20);
	  cout<<"HANG SX: ";
	  cin.getline(p[i].nuChinh,20);
	  cout<<"NAM SX: ";
	  cin>>p[i].namSX;
	  cin.get();
	  cout<<endl;
	}
	//in ra cac tl = nhau
	cout<<"NHAP THE LOAI CAN TIM: ";
	cin.getline(empty,10);
	for(i=0;i<n;i++)
	{
		//strcmp: so sanh chuoi a > b return 1
		//						a = b return 0
		// 						a < b return -1
		//so sanh theloai vs empty
		if(strcmp(p[i].theloai,empty)==0)
		{
			cout<<"DANH SACH PHIM THE LOAI PHIM VUA NHAP LA:\n";
			cout<<setw(3)<<i+1<<setw(20)<<p[i].Phim<<setw(10)<<p[i].theloai<<setw(10)<<p[i].daoDien<<setw(10)<<p[i].namChinh<<setw(10)<<p[i].nuChinh<<setw(10)<<p[i].hangSX<<setw(10)<<p[i].namSX<<endl;
			temp = 1;
		}
		
	}
	if(temp == 0)
	{
		cout<<"KHONG TIM THAY PHIM BAN VUA NHAP !";
	}
	//xuat file
	ofstream ofs;
	ofs.open("C:\\Users\\Admin\\Desktop\\VIDEO.txt",ios::out);
	if(!ofs)
	{
		cout<<"ERROR !! [1]";
	}
	else
	{
		cout<<"\nSUCCESSFULLY !!!";
		ofs<<"DANH SACH PHIM LA:"<<endl;
		for(i=0;i<n;i++)
		{
		ofs<<setw(3)<<i+1<<setw(20)<<p[i].Phim<<setw(10)<<p[i].theloai<<setw(10)<<p[i].daoDien<<setw(10)<<p[i].namChinh<<setw(10)<<p[i].nuChinh<<setw(10)<<p[i].hangSX<<setw(10)<<p[i].namSX<<endl;
		}
	}
	ofs.close();
}

