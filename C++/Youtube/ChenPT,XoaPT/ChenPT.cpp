#include <iostream>
using namespace std;

void Nhap(int a[], int n){
	for(int i=0;i<n;i++){
		cout<<"Nhap A["<<i<<"]= ";
		cin>>a[i];
	}
}
void Xuat(int a[],int n){
	for(int i=0;i<n;i++){
		cout<<a[i]<<"\t";
	}
}
void ChenPT(int a[],int &n,int Vitricanchen,int Socanchen){
	for(int i=n;i>=Vitricanchen;i--){
		a[i]=a[i-1];
	}
	a[Vitricanchen] = Socanchen;
	n++;
}
int main(){
	int a[100];
	int n,vitri,x;
	cout<<"Nhap N : ";
	cin>>n;
	Nhap(a,n);
	Xuat(a,n);
	cout<<"\nCHEN PHAN TU\n";
	cout<<"\nNhap vi tri chen : ";
	cin>>vitri;
	cout<<"So can chen : ";
	cin>>x;
	ChenPT(a,n,vitri,x);
	Xuat(a,n);
}
