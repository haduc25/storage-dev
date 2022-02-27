/*
private: Thuoc Tinh
public: Phuong Thuc
*/
#include <iostream>
using namespace std;

class SinhVien{
	private: //khong the truy xuat 
		string Masv;
		string Ten;
		string Lop;
		int Tuoi;
	public:
	SinhVien(){
		Masv ="123";
		Ten = "Ha Duc";
		Lop = "CNTTK18";
		Tuoi = 18;
	}
	void ChoiGame(){
	cout<<"Choi Game ^^"<<endl;
	}
	void HocBai(){
	cout<<"Hoc Bai"<<endl;
	}
	//truy xuat private:(bang ham)
	void ThongTin(){
		cout<<Masv<<"\n"<<Ten<<"\n"<<Lop<<"\n"<<Tuoi<<"\n";
	}
};

int main(){
	SinhVien a;
	//a.Ten; Khong the ttruy xuat private
	a.ChoiGame();
	a.ThongTin();
}
