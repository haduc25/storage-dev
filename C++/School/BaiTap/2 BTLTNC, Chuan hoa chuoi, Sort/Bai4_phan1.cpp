#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string.h>
using namespace std;
struct Benhnhan{
	char hoten[20];
	char diachi[20];
	char khoa[10];
	int songay;
};
FILE *f;
Benhnhan *p;
int i,n;
//Ham nhap benh nhan, tra lai du lieu dang con tro
Benhnhan *nhap()
{
	Benhnhan *x=new Benhnhan[1];
	cout<<"Ho ten:"; cin.getline(x->hoten,20);
	cout<<"Dai chi:"; cin.getline(x->diachi,20);
	cout<<"Khoa dieu tri:"; cin.getline(x->khoa,10);
	cout<<"So ngay nam vien:"; cin>>x->songay;
	cin.get();
	return x;
}
//Ham in thong tin benh nhan ra man hinh
void in_bn(Benhnhan &x)
{
	cout<<setw(20)<<x.hoten<<setw(20)<<x.diachi<<setw(10)<<x.khoa<<setw(5)<<x.songay<<endl;
}
//Ham ghi thong tin benh nhan ra file
void ghifile(Benhnhan &x, char *fname)
{
	ofstream f(fname,ios::app);
	f<<x.hoten<<','<<x.diachi<<','<<x.khoa<<','<<x.songay<<endl;
	f.close();
}


int main()
{
	char *st;
	strcpy(st,"ngoai");
	cout<<"Nhap so benh nhan:"; cin>>n; cin.get();
	p=new Benhnhan[n];
	for (i=1; i<=n;i++)
	{
		cout<<"Thong tin benh nhan thu "<<i<<":"<<endl;
		p[i]=*nhap();
		if (strcmp(p[i].khoa,st)==0) ghifile(*(p+i),"c:\\data\\benhnhan1.txt");
	}
	int max_ngay=0, vt=0;
	for (i=1; i<=n; i++)
	if (p[i].songay>max_ngay)
	{
		max_ngay=p[i].songay;
		vt=i;
	}
	ghifile(*(p+vt),"c:\\data\\ngayvien.txt");
	cout<<"Thong tin cac benh nhan:"<<endl;
	for (i=1; i<=n;i++)
	in_bn(*(p+i));
}
