/*Xap xep(sort) ham tu big to small*/
#include <iostream>
using namespace std;

void Nhap(int a[], int n){
	for(int i=0;i<n;i++){
		cout<<"Nhap A["<<i<<"] = ";
		cin>>a[i];
	}
}
void Xuat(int a[],int n){
	for(int i=0;i<n;i++){
		cout<<a[i]<<"\t";
	}
}
void Sort(int a[],int n){
	int i,j,temp;
	for(i=0;i<n-1;i++){
		for(j=i+1;j<n;j++){
			if(a[i]<a[j]){
			//doi cho
			temp=a[i];
			a[i]=a[j];
			a[j]=temp;
			}
		}
	}
}


int main(){
	int a[100];
	int n;
	cout<<"Nhap N = ";
	cin>>n;
	cout<<"Ham Nhap :"<<endl;
	Nhap(a,n);
	cout<<"Ham Xuat :"<<endl;
	Xuat(a,n);
	cout<<"\nXap Xep\n";
	cout<<"\nHam sau khi xap xep tu Lon den Be : \n";
	Sort(a,n);
	Xuat(a,n);
}
