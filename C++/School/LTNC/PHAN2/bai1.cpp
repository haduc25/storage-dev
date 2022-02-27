#include <cstdio>
#include <iostream>
#include <cstdlib>

using namespace std;


int i,j,n,*p,temp=0;

int main()
{
	//nhap n
   cout<<"NHAP N: ";
   cin>>n;
   cin.get();
   p = new int[n];
   //nhap arr
   cout<<"NHAP VAO MANG "<<endl;
   for(i=0;i<n;i++)
   {
   	cout<<"ARR["<<i+1<<"]= ";
   	cin>>*(p+i);
   }
   //xuat mang
   cout<<"\nMANG VUA NHAP LA: ";
   for(i=0;i<n;i++)
   {
   	cout<<"\t"<<*(p+i);
   }
   //kiem tra
   for(i=0;i<n-1;i++)
   {
   	for(j=i+i;j<n;j++)
	   {
	   	if(*(p+i) > *(p+j))
		   {
		   	temp = 1;
		   }
	   }
   }
   	if(temp==0)
	   {
	   	cout<<"\nMANG VUA NHAP HOP LE."<<endl;
	   }
	else
		{
		cout<<"\nMANG VUA NHAP KHONG HOP LE."<<endl;
		}
}
