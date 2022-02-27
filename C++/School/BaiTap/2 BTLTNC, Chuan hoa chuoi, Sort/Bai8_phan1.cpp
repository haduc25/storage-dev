#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string.h>
using namespace std;
//Khai bao cau truc Hang
struct Hang {
	char Mah[10];
	char Tenh[20];
	int sl, dg, ton, bhanh;
};
Hang *p;
int i,n;
char *fname;
//Ham nhap thong tin 1 mat hang
Hang *nhap()
{
	Hang *x=new Hang[1];
	cout<<"Ma hang:"; cin.getline(x->Mah,10);
	cout<<"Ten hang:"; cin.getline(x->Tenh,20);
	cout<<"So luong:"; cin>>x->sl; cin.get();
	cout<<"Don gia:"; cin>>x->dg; cin.get();
	cout<<"Ton kho:"; cin>> x->ton; cin.get();
	cout<<"T/g bao hanh:"; cin>>x->bhanh; cin.get();
	return x;
}
//Ham doi cho 2 mat hang trong danh sach dang con tro
void doicho(Hang &x, Hang &y)
{
	Hang z;
	z=x;
	x=y;
	y=z;
}
//Ham in thong tin 1 mat hang trong ds ra man hinh
void in_hang(Hang &x)
{
	cout<<setw(6)<<x.Mah<<setw(20)<<x.Tenh<<setw(5)<<x.sl<<setw(15)<<x.dg<<setw(5)<<x.ton<<setw(6)<<x.bhanh<<endl;
}

int main()
{
	cout<<"Nhap so mat hang:"; cin>>n; cin.get();
	p=new Hang[n];
	for (i=1; i<=n; i++)
	p[i]=*nhap();
//Sap sep cac mat hang theo chieu tang cua hang ton	
	for (i=1; i<n; i++)	
	for (int j=i+1; j<=n; j++)	
	if (p[i].ton>p[j].ton) doicho(*(p+i),*(p+j));
//in ra nam hinh mat hang co hang ton nhieu nhat
	cout<<"Mat hang ton nhieu nhat la:"<<endl;
	in_hang(*(p+n));
//Ghi thong tin mat hang ra file	
	fname=new char[50];
	cout<<"Nhap ten file can ghi ds hang:"	; cin.getline(fname,50);
	ofstream f(fname, ios::out);
	f<<"Danh sach cac mat hang sap xep theo chieu tang cua hang ton:"<<endl;
	for (i=1; i<=n; i++)
	{
		f<<p[i].Mah<<','<<p[i].Tenh<<','<<p[i].sl<<','<<p[i].dg<<','<<p[i].ton<<endl;
	}
	f.close();
}
