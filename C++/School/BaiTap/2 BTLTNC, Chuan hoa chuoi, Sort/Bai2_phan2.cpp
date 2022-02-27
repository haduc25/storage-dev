#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
#include <math.h>
using namespace std;
FILE *f;
int *p, i,n;

//Ham nhap n phan tu tu ban phim
int *nhap(int x)
{
	int *kq=new int[x];
	ofstream f("C:\\Users\\Admin\\Desktop\\mang1.txt");
	for (i=1; i<=x; i++)
	{
		cout << "Gia tri phan tu thu "<<i<<" :"; cin>>kq[i];
		f<<setw(5)<<*(kq+i);
	}
	return kq;
	f.close();
}

//Ham doc du lieu tu file
void docfile()
{
	cout<<"Cac phan tu cua day doc tu file la:"<<endl;
	ifstream f("C:\\Users\\Admin\\Desktop\\mang1.txt");
	i=0;
	while (!f.eof())
	{
		f>>*(p+i);
		i++;
		cout<<setw(5)<<*(p+i);
	}
	cout<<endl;
}
//Ham kiem tra tinh nguyen to cua mot so nguyen
int Nguyento(int x)
{
    if (x < 2)    
        return 0;
    for (int j = 2; j <= sqrt(x); j ++)
    {
        if (x%j==0)
        {
            return 0;
        }
    }
    return 1;
}
//Chuong trinh chinh
int main()
{
	do
	{
		cout<<"Nhap so phan tu:"; cin>>n; cin.get();
	}
	while (n<5||n>20);
	p=nhap(n);
	docfile();
	cout<<"Cac so nguyen to trong day la:"<<endl;
	for (i=0; i<n; i++)
	if (Nguyento(p[i])) cout<<setw(5)<<*(p+i);
}
