/*
:: Toan tu xac dinh pham vi
*/
#include <iostream>
using namespace std;

int x=100;
int main(){
	int x=10;
	cout<<"X o trong Main: "<<x<<endl;
	cout<<"X o ngoai Main: "<<::x<<endl;
}

