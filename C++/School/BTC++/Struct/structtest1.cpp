#include <stdio.h>
#include <iostream>
using namespace std;
struct Bangxephang{
	char ten[20];
	int thang, thua, hoa, diem;
};
Bangxephang *p;
int i,j,n;

int nhap(Bangxephang &x)
{
	cout <<"Nhap ten doi bong:"; cin.getline(x.ten,20);
	cout<<"So tran thang: "; cin>>x.thang;
	cout<<"So tran hoa: "; cin>>x.hoa;
	cout<<"So tran thua: "; cin>>x.thua;
	x.diem=3*x.thang+1*x.hoa;
	cin.get();
}
int xuat(Bangxephang &x)
{
	cout.width(20); cout<<x.ten;
	cout<<"    "<<x.thang<<"     "<<x.hoa<<"     "<<x.thua<<"    "<<x.diem<<endl;
}
int doicho(Bangxephang &x, Bangxephang &y)
{
	Bangxephang temp;
	temp=x;
	x=y;
	y=temp;
}

int main()
{
	cout<<"Nhap so doi bong: "; cin>>n;
	cin.get();
	p=new Bangxephang[n];
	cout<<"NHAP THONG TIN CAC DOI BONG"<<endl;
	for (i=1; i<=n;i++)
	{
		cout<<"Nhap doi bong thu "<<i<<endl;
		nhap(*(p+i));
	}
	cout<<"Thong tin cac doi bong vua nhap"<<endl<<endl;
	for (i=1; i<n; i++)
	for (j=i+1; j<=n; j++)
	if (p[i].diem<p[j].diem) doicho(*(p+i),*(p+j));
	cout<<"Du lieu sau khi sap xep la:"<<endl<<endl;
	for (i=1; i<=n;i++)
	{
		xuat(*(p+i));
	}
}
