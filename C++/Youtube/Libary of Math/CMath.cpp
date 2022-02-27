/*
ham mu : pow(x,n);
ham tinh can bac 2 : sqrt();
ham tinh tri tuyet doi : abs();
ham tinh tri tuyet doi so thuc : fabs();
ham tinh e mu x : exp();
ham luong giac : sin(),cos(),tan(),1/tan(),ln(),log(),log10() 

*/
#include <iostream>
#include <cmath>

using namespace std;

int main(){
	int x,y,n;
	cout<<"Nhap X = ";
	cin>>x;
	cout<<"Nhap N = ";
	cin>>n;
	cout<<"Nhap Y = ";
	cin>>y;
	cout<<"KQ Tinh Mu = "<<pow(x,n)<<endl;
	cout<<"KQ Tinh Can Bac 2 = "<<sqrt(y)<<endl; //(cua Y)
	cout<<"KQ Tinh Tri Tuyet Doi = "<<abs(y)<<endl;   //(cua Y)
	cout<<"KQ Tinh Tri Tuyet Doi So Thuc = "<<fabs(-y)<<endl; //(cua Y)
	cout<<"KQ Tinh E Mu X = "<<exp(y)<<endl; //(cua Y)
	cout<<"KQ Tinh Sin X = "<<sin(y)<<endl; //(cua Y)
    cout<<"KQ Tinh Cos X = "<<cos(y)<<endl; //(cua Y)
	cout<<"KQ Tinh Tan X = "<<tan(y)<<endl; //(cua Y)
	cout<<"KQ Tinh Cot X = "<<1/tan(y)<<endl; //(cua Y)
//	cout<<"KQ Tinh ln X = "<<ln(y)<<endl; //(cua Y)
	cout<<"KQ Tinh log X = "<<log(y)<<endl; //(cua Y)
	cout<<"KQ Tinh log10 X = "<<log10(y)<<endl; //(cua Y)
}
