#include <iostream>
#include <stdio.h>
#include <fstream>
#include <iomanip>

using namespace std;

int m,i;
int a[100];
int temp;
int main()
{
	//NHAP PHAN TU
	cout<<"Nhap m: ";
	cin>>m;
	cin.get();
	for(i=0;i<m;i++)
	{
		cout<<"a["<<i+1<<"]= ";
		cin>>*(a+i);
	}
	//XUAT PHAN TU RA MAN HINH
	cout<<"Mang vua nhap la: "<<endl;
	for(i=0;i<m;i++)
	{
		cout<<"\t"<<*(a+i);
	}
	//CAC PHAN TU SO CHAN
	cout<<"\nCac phan tu chan la:";
	for(i=0;i<m;i++)
	{
		if(*(a+i)%2 == 0)
		{
			temp = *(a+i);
			cout<<"\t"<<temp;
		}
	}
	ofstream ofs("d:/folder/Sochan.txt",ios::out);
	if(!ofs)
	{
		cout<<"Loi khong mo duoc file !!!";
	}
	else
	{
		ofs<<"Cac phan tu Chan la: "<<endl;
		for(i=0;i<m;i++)
		{		
		if(*(a+i)%2 == 0)
		{
			temp=*(a+i);
			ofs<<setw(5)<<temp;
		}
		}	
		ofs.close();
	}
}
