#include <iostream>

using namespace std;

class phan_so
{
	private:
	int tu,mau;
	public:
		void nhap();
		void xuat();
		//phan_so tong(phan_so);
		phan_so operator + (phan_so);
};

void phan_so::nhap()
{
	cout<<"Nhap tu: ";
	cin>>this->tu;
	do
	{
	cout<<"Nhap mau: ";
	cin>>this->mau;
	}
	while(this->mau==0);
}
void phan_so::xuat()
{
cout<<tu<<"/"<<mau;
}
//phan_so phan_so::tong(phan_so a)
phan_so phan_so::operator+(phan_so a)
{
	phan_so kq;
	kq.tu=this->tu*a.mau+this->mau*a.tu;
	kq.mau=this->mau*a.mau;
	return kq;
}
int main()
{
	phan_so p1,p2,kq;
	p1.nhap();
	p2.nhap();
	p1.xuat();
	cout<<"+";
	p2.xuat();
	cout<<"=";
	kq=p1+p2;
//	kq=p1.tong(p2);
	kq.xuat();
	return 0;
}
