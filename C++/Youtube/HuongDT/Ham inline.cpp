/*
Ham inline
*/
#include <iostream>
using namespace std;

inline int TinhDienTich(int cd,int cr){
	return cd*cr;
}
int main(){
	int cd,cr;
	cout<<"Nhap Chieu Dai: "<<endl;
	cin>>cd;
	cout<<"Nhap Chieu Rong: "<<endl;
	cin>>cr;
	cout<<"Dien Tich HCN La: "<<TinhDienTich(cd,cr);
	
}

