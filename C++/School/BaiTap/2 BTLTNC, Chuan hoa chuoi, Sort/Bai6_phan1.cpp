#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string.h>
using namespace std;
struct Maytinh{
	char mamay[10];
	char tenmay[20];
	float cpu;
	int gia, ram;
};
FILE *f;
Maytinh *p;
int i,n;

void doicho(Maytinh &x, Maytinh &y)
{
	Maytinh z;
	z=x;
	x=y;
	y=z;
}

void in_ds(Maytinh &x)
{
	cout<<setw(5)<<x.mamay<<setw(20)<<x.tenmay<<setw(6)<<x.cpu<<setw(6)<<x.ram<<setw(15)<<x.gia<<endl;
}

int main()
{
//	cout<<"So may tinh la:"; cin>>n; cin.get();
	p=new Maytinh[100];
	i=1;
	while (1)
	{
	cout<<"Ma may:"; cin.getline((p+i)->mamay,10);
	if (p[i].mamay[0]==0) break;
	cout<<"Ten may:"; cin.getline((p+i)->tenmay,20);
	cout<<"Toc do CPU:"; scanf("%f", &(p+i)->cpu);
	cout<<"Dung luong RAM:"; cin>>(p+i)->ram;
	cout<<"Gia ban:"; cin>>(p+i)->gia; cin.get();
	i++;n=i-1;
	}
	cout<<"Thong tin cac may tinh la:"<<endl;
	for (i=1; i<=n; i++)
	{
		in_ds(*(p+i));
	}
	for (i=1; i<n; i++)
	for (int j=i+1; j<=n; j++)
	if (p[i].cpu<p[j].cpu) doicho(*(p+i), *(p+j));
	cout<<"Thong tin cac may tinh sau khi sap xep la:"<<endl;
	for (i=1; i<=n; i++)
	{
		in_ds(*(p+i));
	}
}
