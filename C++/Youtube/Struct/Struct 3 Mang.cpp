/*Mang struct*/
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
    fflush(stdin); //xoa bo dem ban phim
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
	cout<<"\nMa Sinh Vien: "<<b.Masv<<endl;
	cout<<"Ho va Ten: "<<b.HoTen<<endl;
	cout<<"Gioi Tinh: "<<b.Gioitinh<<endl;
	cout<<"Tuoi: "<<b.Tuoi<<endl;
	cout<<"Diem: "<<b.Diem<<endl;
}
void NhapDSSV(sinhvien a[], int n){
	for(int i=0;i<n;i++){
		NhapSV(a[i]);
	}
}
void XuatDSSV(sinhvien a[],int n){
	for(int i=0;i<n;i++){
		XuatSV(a[i]);
	}
}

int main(){
	sinhvien a[100]; //x la tham so chinh
	int n;
	cout<<"NHAP N: ";
	cin>>n;
	NhapDSSV(a,n);
	cout<<"\nDU LIEU CUA SV KHI XUAT:\n";
	XuatDSSV(a,n);
}

