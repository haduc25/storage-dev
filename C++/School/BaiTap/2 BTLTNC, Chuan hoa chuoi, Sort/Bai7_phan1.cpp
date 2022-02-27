#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string.h>
using namespace std;
struct Sach {
	char Mas[10];
	char Tens[20];
	char Tacgia[20];
	int sl;
} DMsach[100];
Sach *p;
int i,n;
char *fname, *bname;
Sach *nhap()
{
	Sach *x=new Sach[1];
	cout<<"Ma sach:"; cin.getline(x->Mas,10) ;
	cout<<"Ten sach:"; cin.getline(x->Tens,20);
	cout<<"Ten tac gia:"; cin.getline(x->Tacgia,20);
	cout<<"So luong ban:"; cin>>x->sl;
	cin.get();
	return x;
}

void in_sach(Sach &x)
{
	cout<<setw(10)<<x.Mas<<setw(20)<<x.Tens<<setw(20)<<x.Tacgia<<setw(5)<<x.sl<<endl;
}


int main()
{
	cout<<"Nhap so luong sach:"; cin >>n; cin.get();
	p=new Sach[n];
	bname=new char[20];
	fname=new char[50];
	cout<<"Nhap thong tin sach:"<<endl;
	for (i=1; i<=n; i++)
	p[i]=*nhap();
	cout<<"Nhap ten sach can tim:"; cin.getline(bname,20);
	cout<<"Nhap duong dan va ten file can ghi:"; cin.getline(fname,50);
	ofstream f(fname, ios::out);
	f<<"Sach can tim:"<<bname<<endl;
	for (i=1; i<=n; i++)
	if (strcmp(p[i].Tens,bname)==0)
	{
		f<<p[i].Mas<<','<<p[i].Tens<<','<<p[i].Tacgia<<','<<p[i].sl<<endl;
	}
	else 
	cout<<"Khong tim thay sach ban can !";
	f.close();
	
}
