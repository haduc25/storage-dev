/*fflush: Xoa bo dem ban phim
*/
#include <iostream>
#include <cstdio>
using namespace std;

struct sinhvien{
	char Masv[15];
	char HoTen[20];
	char Gioitinh[10];
	int Tuoi;
	float Diem;
};

int main(){
	sinhvien x;
	cout<<"\nMa Sinh Vien: ";
	gets(x.Masv);
	cout<<"Ho va Ten: ";
	gets(x.HoTen);
	cout<<"Gioi Tinh: ";
	gets(x.Gioitinh);
	cout<<"Tuoi: ";
	cin>>x.Tuoi;
	cout<<"Diem: ";
	cin>>x.Diem;
	//Xuat du lieu
	cout<<"\nDU LIEU SV X XUAT:\n";
	cout<<"\nMa Sinh Vien: "<<x.Masv<<endl;
	cout<<"Ho va Ten: "<<x.HoTen<<endl;
	cout<<"Gioi Tinh: "<<x.Gioitinh<<endl;
	cout<<"Tuoi: "<<x.Tuoi<<endl;
	cout<<"Diem: "<<x.Diem<<endl;
}
