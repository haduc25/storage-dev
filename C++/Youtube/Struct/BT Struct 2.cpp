/*
a,-Viet ham nhap vao 1 vecto X gom 3 thanh phan(x1,x2,x3)
Viet ham tinh tich vo huong T cua 2 vecto X(x1,x2,x3) va Y(y1,y2,y3)
b,-Viet ham tinh gia tri bieu thuc Q voi (x thuoc R) va n (thuoc Z+)
-Viet ham main, su dung cac ham o tren nhap vao 2 vecto X va Y.Nhap vao 
1 so thuc X va 1 so nguyen n, tinh va in ra man hinh gia tri cua Q(x,n).
(Giai de ki thuat tinh gia tri bieu thuc phan 6 (C++), (YT: Nguyen Son)
*/
#include <iostream>
#include <cmath>

using namespace std;

void NhapVTX(int &x1, int &x2,int &x3){
   cout<<"Nhap X1,X2,X3: \n";
   cin>>x1>>x2>>x3;	
}
void NhapVTY(int &y1,int &y2,int &y3){
	cout<<"Nhap Y1,Y2,Y3: \n";
   cin>>y1>>y2>>y3;	
}
int TinhTVH(int x1, int x2,int x3,int y1,int y2,int y3){ //TVH: tich vo huong
return x1*y1+x2*y2+x3*y3; //CT: x1*y1+x2*y2+x3*y3
}
double Q(float x,int n){
	double Tong = sqrt(exp(x)+n);{ //(Chu y Ham Thu Vien math.h)#include <cmath>
		for(int i=1;i<=n;i++){ //sqrt(): Tinh can bac 2
			Tong+=(x/pow(5,i));//exp(): Tinh E mu X
		}                      //pow(x,n): Tinh so mu
		return Tong;
	}
}
int main(){
	int x1,x2,x3,y1,y2,y3,n;
	float x;
	NhapVTX(x1,x2,x3);
	NhapVTY(y1,y2,y3);
	cout<<"Tich Vo Huong La: "<<TinhTVH(x1,x2,x3,y1,y2,y3);
	cout<<"\nNhap N: ";
	cin>>n;
	cout<<"\nNhap X: ";
	cin>>x;
	cout<<"Gia Tri Cua Q la: "<<Q(x,n);
}
