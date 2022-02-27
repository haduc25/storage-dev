#include <iostream>
using namespace std;

struct sinhvien{
	char Masv[15];
	char HoTen[20];
	char Gioitinh[10];
	int Tuoi;
	float Diem;
};

void NhapSV(sinhvien &a){ //bien &
	cout<<"\nMa Sinh Vien: ";
	gets(a.Masv);
	cout<<"Ho va Ten: ";
	gets(a.HoTen);
	cout<<"Gioi Tinh: ";
	gets(a.Gioitinh);
	cout<<"Tuoi: ";
	cin>>a.Tuoi;
	cout<<"Diem: ";
	cin>>a.Diem;
}

void XuatSV(sinhvien b){ //a,b la tham so hinh thuc
	cout<<"\nDU LIEU CUA SV KHI XUAT:\n";
	cout<<"\nMa Sinh Vien: "<<b.Masv<<endl;
	cout<<"Ho va Ten: "<<b.HoTen<<endl;
	cout<<"Gioi Tinh: "<<b.Gioitinh<<endl;
	cout<<"Tuoi: "<<b.Tuoi<<endl;
	cout<<"Diem: "<<b.Diem<<endl;
}
int main(){
	sinhvien x; //x la tham so chinh
	NhapSV(x);
	XuatSV(x);
}
