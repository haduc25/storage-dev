#include <iostream>
using namespace std;
/*Giai Thua (!)
5!=5*4*3*2*1
De quy(De quy tinh n giai thua (!))
5!=5*4!
4!=4*3!
3!=3*2!
2!=2*1!
1!=1
0!=1
*/

int GiaiThua(int n){
	if(n==0){
		return 1;
	}
	else{
		return n*GiaiThua(n-1);
	}
}
int main(){
	int n;
	cout<<"Nhap N: ";
	cin>>n;
	cout<<"Giai thua (!) cua "<<n<<" la: "<<GiaiThua(n);
	
}
