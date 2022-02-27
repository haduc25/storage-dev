#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>

using namespace std;
int i,j,n;
int temp = 0;
float *p,empty;

int main()
{
	cout<<"Nhap n: ";
	cin>>n;
	p = new float[n];
	cin.get();
	for(i=0;i<n;i++)
	{
		cout<<"a["<<i+1<<"]= ";
		cin>>*(p+i);
		if(*(p+i)<0)
		{
			temp=1;
		}
	}
	if(temp==1)
	{
		cout<<"Mang co phan tu am";
	}
	else
	{
		cout<<"Mang khong co phan tu am";
	}
	for(i=0;i<n;i++)
	{
		for(j=i+1;j<n;j++)
		{
			if(*(p+i)>0 && *(p+j)>0 && *(p+i) > *(p+j))
			{
				empty = *(p+i);
				*(p+i) = *(p+j);
				*(p+j) = empty;
				
			}
		}
	}
	cout<<"\nphan tu sau khi xap xep la: ";
	for(i=0;i<n;i++)
	{
		cout<<"\t"<<*(p+i);
	}
	ofstream ofs("d:/Folder/hello.txt",ios::out);
	if(!ofs)
	{
		cout<<"Khong mo duoc file !!!";
	}
	else
	{
		ofs<<"Danh sach sau khi sap xep va in ra file la: ";
		for(i=0;i<n;i++)
		{
			ofs<<"\t"<<*(p+i);
		}
		ofs.close();
		}
}
