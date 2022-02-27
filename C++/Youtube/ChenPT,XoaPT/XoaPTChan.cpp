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
void XoaPTChan(int a[],int &n){
for(int i=0;i<n;i++){
	if(a[i]%2==0){
		XoaPT(a,n,i);
		i--; //luu y !
	}
  }
}
int main()
{
	int a[100];
	int n,vtcanxoa;
	cout<<"Nhap N = ";
	cin>>n;
	Nhap(a,n);
	cout<<"\nMang vua nhap la : \n";
	Xuat(a,n);
	XoaPTChan(a,n);
	cout<<"\nMang sau khi xoa so chan : \n";
	Xuat(a, n);
	system("pause");
}
