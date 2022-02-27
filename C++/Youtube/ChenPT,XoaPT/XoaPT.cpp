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
void XoaPT(int a[],int &n,int vtcanxoa){
	for(int i=vtcanxoa;i<n;i++){
		a[i]=a[i+1];
	}
	n--;
}
int main(){
	int a[100];
	int n,vtcanxoa,x;
	cout<<"Nhap N : ";
	cin>>n;
	Nhap(a,n);
	Xuat(a,n);
	cout<<"\nNhap vi tri can xoa : ";
	cin>>vtcanxoa;
	XoaPT(a,n,vtcanxoa);
	Xuat(a,n);
}
