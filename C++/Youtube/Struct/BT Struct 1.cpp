/*BT:
a,-Nhap vao 1 DS n doanh nghiep bao gom thong tin:
+ma doanh nghiep(char)
+giam doc(char)
+von dieu le(float)
+so nhan vien(int)
 -Xuat danh sach n doanh nghiep ra man hinh
b,-Sap xep danh sach theo chieu tang dan cua von dieu le cua doanh nghiep
c.-In ra ma doanh nghiep, so nhan vien cua moi doanh nghiep co ma bat dau bang chu 'DN' va co nhieu hon 300 nhan vien
d,-1 doanh nghiep duoc goi la 'Khong hop le' neu ma doanh nghiep co chua it nhat 1 dau cach (ki tu trong) hoac von dieu
 le nho hon 10.Hay cho biet co bao nhieu doanh nghiep khong hop le trong doanh sach n doanh nghiep tren.
*/
#include <iostream>
#include <cstdio>
#include <cstring>
using namespace std;
struct DoanhNghiep{
	char MaDN[20];
	char GiamDoc[20];
	float VonDL;
	int SoNV;
};
void NhapDN(DoanhNghiep &a){
	fflush(stdin);
	cout<<"\n\n\nNhap Ma DN: "<<endl;
	fflush(stdin);
	gets(a.MaDN);
	cout<<"Nhap Giam Doc: "<<endl;
	fflush(stdin);
	gets(a.GiamDoc);
	cout<<"Nhap Von Dieu Le: "<<endl;
	fflush(stdin);
	cin>>a.VonDL;
	cout<<"Nhap So Nhan Vien: "<<endl;
	fflush(stdin);
	cin>>a.SoNV;
}
void XuatDN(DoanhNghiep b){
	cout<<"\nMa DN: "<<b.MaDN<<endl;
	cout<<"Giam Doc: "<<b.GiamDoc<<endl;
	cout<<"Von Dieu Le: "<<b.VonDL<<endl;
	cout<<"So Nhan Vien: "<<b.SoNV<<endl;
	cout<<endl;
}
void NhapDSDN(DoanhNghiep x[],int n){
	for(int i=0;i<n;i++){
		NhapDN(x[i]);
	}
}
void XuatDSDN(DoanhNghiep x[],int n){
	for(int i=0;i<n;i++){
		XuatDN(x[i]);
	}
}
void Sort(DoanhNghiep x[],int n){
	int i,j;
	DoanhNghiep Temp;
	for(i=0;i<n-1;i++){
		for(j=i+1;j<n;j++){
			if(x[i].VonDL>x[j].VonDL){
				//Doi Cho
				Temp=x[i];
				x[i]=x[j];
				x[j]=Temp;
			}
		}
	}
}
void PrintDN(DoanhNghiep x){
	cout<<"\nMa DN: "<<x.MaDN<<endl;
	cout<<"\nSo Nhan Vien: "<<x.SoNV<<endl;
}
void PrintDNDK(DoanhNghiep x[],int n){
	for(int i=0;i<n;i++){
		if(x[i].SoNV>300&&x[i].MaDN[0]=='D'&&x[i].MaDN[1]=='N'){
			PrintDN(x[i]);
		}
	}
}
int CheckSpace(char MaDN[]){
	for(int i=0;i<strlen(MaDN);i++){
		if(MaDN[i]==' '){
			return 1;
		}
		return 0;
	}
}
void DNKhongHopLe(DoanhNghiep x[],int n){
	int dem=0;
	for(int i=0;i<1;i++){
		if(x[i].VonDL<10||CheckSpace(x[i].MaDN)==1){
			dem++;
		}
		cout<<"\nDoanh Nghiep Khong Hop Le: "<<dem<<endl;
	}
}
int main(){
	DoanhNghiep x[100];
	int n;
	cout<<"Nhap N: ";
	cin>>n;
	NhapDSDN(x,n);
    cout<<"\nDANH SACH SAU KHI NHAP LA: ";
    XuatDSDN(x,n);
    Sort(x,n);
    cout<<"\nDANH SACH SAU KHI SAP XEP LA: ";
    XuatDSDN(x,n);
    cout<<"\nDANH SACH DN CO HON 300NV VA DN BAT DAU BANG 'DN' LA: ";
    PrintDNDK(x,n);
    DNKhongHopLe(x,n);
}
