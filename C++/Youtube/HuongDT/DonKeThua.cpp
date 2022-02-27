/*
Don Ke Thua 
*/
#include <iostream>
using namespace std;
class SinhVien{
 protected: //bao ve
 string MaSV;
 string Ten;
};
//class HocSinh : private/public SinhVien (private-private;public-public)
class HocSinh : private  SinhVien{
	string Lop;
	public:
		HocSinh(){
			MaSV ="2509";
			Ten="Ha Duc";
			Lop="CNTT_K18";
		}
		void Xuat(){
			cout<<"Ma SV: "<<MaSV<<endl;
			cout<<"Ten SV: "<<Ten<<endl;
			cout<<"SV Lop: "<<Lop<<endl;
		}
};
int main(){
	HocSinh a;
	a.Xuat();
	
}
