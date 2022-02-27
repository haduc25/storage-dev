/*Friend
*/
/*
Friend: de trich xuat du lieu hide (du lieu tu ham (private))
*/
#include <iostream>
using namespace std;
class SoPhuc{
	private:
		int SoT; //Thuc
		int SoA; ///Ao
	public:
		SoPhuc(){
			SoT=5;
			SoA=10;
		}
		void Xuat(){
			cout<<"KQ So Phuc Thuc la: "<<SoT<<endl;
			cout<<"KQ So Phuc Ao la: "<<SoA;
		}
	friend void CongSP(SoPhuc a,SoPhuc b);
};
void CongSP(SoPhuc a,SoPhuc b){
	SoPhuc c;
	c.SoT=a.SoT+b.SoT;
	c.SoA=a.SoA+b.SoA;
	c.Xuat();
}
int main(){
	SoPhuc a,b,c;
	CongSP (a,b);
}
