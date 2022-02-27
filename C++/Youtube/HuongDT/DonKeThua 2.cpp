/*
Don Ke Thua 
Toan Tu : -> || chi dung trong pointer
*/
#include <iostream>
using namespace std;
class SinhVien{
 protected: //bao ve
 string MaSV;
 string Ten;
 public:
 	 void HocBai(){
 	 	cout<<"Dang Hoc "<<endl;
	  }
};
//class HocSinh : private/public SinhVien (private-private;public-public)
class HocSinh : public SinhVien{
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
	SinhVien *p = new HocSinh;
    p->HocBai();
   ((HocSinh*)p)->Xuat();//ep kieu con tro(pointer)
}
