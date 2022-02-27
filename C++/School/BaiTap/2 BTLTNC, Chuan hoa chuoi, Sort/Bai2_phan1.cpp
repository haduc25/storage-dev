#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string.h>

using namespace std;
struct Mathang{
	int ma;
	string ten;
	int soluong;
};
FILE *f;
Mathang *p, temp;
int i,n;
Mathang *nhap()
{
	Mathang *temp=new Mathang[1];
	cout<<"Ma hang:"; cin>>temp->ma; cin.ignore();
	cout<<"Ten hang:"; getline(std::cin,temp->ten);
	cout<<"So luong:"; cin>>temp->soluong; cin.get();
	return temp;
}

void ghifile()
{
	p=new Mathang[n];
	ofstream f("c:\\data\\Mathang.txt");
	for (i=1; i<=n; i++)
	{
		cout<<"Nhap mat hang thu "<<i<<endl;
		p=nhap();
		f<<p->ten<<endl;
		f<<p->ma<<endl;
		f<<p->soluong<<endl;
	}
	f.close();
	delete p;
}

void docfile()
{
	fstream f("c:\\data\\Mathang.txt");
	cout<<"Du lieu trong file la:"<<endl;
	cout<<"STT  Ma hang          Ten hang  S.luong"<<endl;
	for (i=1; i<=n; i++)
	{
		getline(f,temp.ten);
		f>>temp.ma;f.get();
		f>>temp.soluong;f.get();
		cout<<i<<". "<<setw(5)<<temp.ma<<setw(20)<<temp.ten<<setw(5)<<temp.soluong<<endl;
	}
	f.close();
}
int main()
{
	do{
		cout<<"Nhap so mat hang:"; cin>>n; cin.get();
	}
	while (n<0);
	ghifile();
	cout<<endl;
	docfile();
}
