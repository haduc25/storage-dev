#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>

using namespace std;
int i,j,n,wow;
int temp = 0;
float *p,empty;

void in_phan_tu_am(int x[])
{
	ofstream f("c:\\hello\\bai2.txt");
	for (i=0; i<=n;i++)
	if (x[i]<0) 
	{
		f<<setw(5)<<x[i];
	}
	f.close();
}
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
			wow=*(p+i);
			temp=1;
		}
	}
	if(temp==1)
	{
		cout<<"Mang co phan tu am\n"<<wow;
	}
	else
	{
		cout<<"Mang khong co phan tu am\n";
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
	cout<<"\nphan tu sau khi xap xep";
	for(i=0;i<n;i++)
	{
		cout<<"\t"<<*(p+i);
	}
	//in pt
	ofstream ofs("c:\\hello\\bai2.txt",ios::out);
	if(!ofs)
	{
		cout<<"khong mo duoc file";
	}
	else
	{
		ofs<<"hello";
		ofs.close();
	}
}
