#include <iostream>
#include <cstdio>
#include <queue>
using namespace std;

struct SinhVien{
	int MaSV;
	char Lop[10];
	string HoTen;
	
};
void NhapSV(SinhVien &x){
	cout<<"\n\nNhap Ma Sinh Vien: "<<endl;
	fflush(stdin);
	cin>>x.MaSV;
	cout<<"Nhap Lop: "<<endl;
	fflush(stdin);
	gets(x.Lop);
	cout<<"Nhap Ho va Ten: "<<endl;
	fflush(stdin); 
	getline(cin, x.HoTen);//getline(): de chuyen vao string (New)
}
void XuatSV(SinhVien x){
    cout<<"\n\nThong Tin SV\n";
	cout<<"\nMa SV la: "<<x.MaSV;
	cout<<"\nLop la: "<<x.Lop;
	cout<<"\nHo va Ten la: "<<x.HoTen;
}
int main(){
	SinhVien a,b,x;
	queue<SinhVien> DSSV; 
	NhapSV(a);
	NhapSV(b);	
	NhapSV(x);
	DSSV.push(a);
	DSSV.push(b);
	DSSV.push(x);
	cout<<"Sinh Vien Dau";
	XuatSV(DSSV.front());
	cout<<"Sinh Vien Cuoi";
	XuatSV(DSSV.back());
	
}
