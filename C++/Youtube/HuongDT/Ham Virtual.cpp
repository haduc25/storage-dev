/*
Virtual: Ham Ao
*/
#include <iostream>
using namespace std;
class Hinh{
	public:
	virtual void Ve(){ //use: dat ham Virtual truoc Ham 
	cout<<"Ve Hinh "<<endl;
}
};
class HinhTron : public Hinh{
	int BanKinh;
	public:
		void Ve(){
			cout<<"Ve Hinh Tron "<<endl;
		}
};
int main(){
	Hinh *p = new HinhTron;
	p->Ve();
}
