#include <iostream>
#include <cstdio>
#include <cstring>
#include <fstream>
#include <iomanip>

using namespace std;

struct THU_VIEN
{
	char ma[20];
	char ten[20];
	char tenTG[20];
	int sl;
};

THU_VIEN *p;
int i,n,empty =0;
char temp[20];

int main()
{
  do
  {
  	//max = 100
	cout<<"NHAP SO LUONG CUA THU VIEN: ";
	cin>>n;
	p =new THU_VIEN[n];
	cin.get();
  }while(n > 100);
  //nhap
  for(i=0;i<n;i++)
  {
  	cout<<"THU VIEN ["<<i+1<<"]";
  	cout<<"\nMA SACH: ";
  	cin.getline(p[i].ma,20);
  	cout<<"TEN SACH: ";
  	cin.getline(p[i].ten,20);
  	cout<<"TEN TAC GIA: ";
  	cin.getline(p[i].tenTG,20);
  	cout<<"SO LUONG: ";
  	cin>>p[i].sl;
  	cout<<endl;
  	cin.get();
  }
  	//xuat
  	cout<<"DS VUA NHAP LA: "<<endl;
     for(i=0;i<n;i++)
    {
		cout<<setw(3)<<i+1<<setw(20)<<p[i].ma<<setw(10)<<p[i].ten<<setw(10)<<p[i].tenTG<<setw(10)<<p[i].sl<<endl;
   	}
	//xuat file
	ofstream ofs;
	ofs.open("C:/Users/Admin/Desktop/THU_VIEN.txt",ios::out);
	if(!ofs)
	{
		cout<<"ERROR !!!";
	}
	else
	{
	  //tim sach
  		cout<<"NHAP TEN SACH CAN TIM: "<<endl;
        cin>>temp;
  		for(i=0;i<n;i++)
  		{
  		if(strcmp(p[i].ten,temp) == 0)
	  	  {
	  	cout<<"\nDS TEN SACH VUA NHAP LA: \n";
	  	cout<<setw(3)<<i+1<<setw(20)<<p[i].ma<<setw(10)<<p[i].ten<<setw(10)<<p[i].tenTG<<setw(10)<<p[i].sl<<endl;
	  	ofs<<"DS TEN SACH VUA NHAP LA: \n";
	  	ofs<<setw(3)<<i+1<<setw(20)<<p[i].ma<<setw(10)<<p[i].ten<<setw(10)<<p[i].tenTG<<setw(10)<<p[i].sl<<endl;
	  	cout<<"\nSUCCESSFULLY !!!\n";
	   	empty = 1;
		  }
  		}
  		if(empty == 0)
		{
		cout<<"\nKHONG TIM THAY !!!\n";
		}	
	}
	ofs.close();
}
