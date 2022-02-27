#include <stdio.h>
#include <iostream>
#include <windows.h>
using namespace std;
struct Bangxephang{
	char tendoi[20];
	unsigned int thang, hoa, thua, diem;
};
FILE *f;
Bangxephang *p,x,y;
int i,j,n;
//Ham nhap thong tin doi bong
int nhap(Bangxephang *x)
{
	cout <<"Ten doi: "; cin.getline(x->tendoi,30);
	cout <<"So tran thang: "; cin >> x->thang;
	cout <<"So tran hoa: "; cin >>x->hoa;
	cout <<"So tran thua: "; cin >>x->thua;
	x->diem=3*x->thang+1*x->hoa;
	cin.get();
}
//Ham sap xep diem cua doi bong giam dan
int sapxep(Bangxephang &x, Bangxephang &y)
{
	Bangxephang temp;
	if (x.diem < y.diem) 
	{
		temp=x;
		x=y;
		y=temp;
	}
}
//Ham in danh sach doi bong
int indanhsach(Bangxephang *x)
{
	cout.width(20);
	cout <<x->tendoi<<"        "<<x->thang<<"              "<<x->hoa<<"              "<<x->thua<<"              "<<x->diem<<endl;
}

//Ham xuat thong tin doi bong ra file
void xuatfile(Bangxephang *x)
{
	fprintf(f,"%30s %5d %5d %5d %5d\n",x->tendoi,x->thang,x->hoa,x->thua,x->diem);
}

int main()
{
	cout<<"Nhap so doi bong: "; cin>>n;
	cin.get();
	p=new Bangxephang[n];
	cout<<"Nhap thong tin cac doi bong:"<<endl;
	for (i=1; i<=n; i++)
	{
		cout<<"Doi bong thu "<<i<<":"<<endl;
		nhap((p+i));
	}
	cout.width(80);
	cout <<"DANH SACH CAC DOI BONG"<<endl<<endl;
	cout<<"         Ten doi        Tran thang    Tran thua       Tran hoa          Diem so"<<endl;
	for (i=1; i<=n; i++)
	{
		indanhsach(p+i);
	}
	for (i=1; i<n; i++)
	for (j=i+1; j<=n;j++)
	if (p[i].diem<p[j].diem) sapxep(p[i], p[j]);
	cout<<endl<<endl<<endl;
	f=fopen("c:\\Kiem tra TDC\\danhsach.txt","a+");	
	cout.width(80);
	cout <<"DANH SACH XEP HANG CAC DOI BONG"<<endl;
	for (i=1; i<=n; i++)
	{
		indanhsach(p+i);
		xuatfile(p+i);
	}
	fclose(f);
}

