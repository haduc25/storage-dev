#include <iostream>

using namespace std;

void Nhap(int a[],int n){
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
int Search(int a[], int n, int x){
	for(int i=0;i<n;i++){
		if(a[i]==x){
			return 1;
		}
	}return 0;
}

int main(){
	int a[100];
	int n,x;
	cout<<"Nhap N = ";
	cin>>n;
	cout<<"Mang Nhap :\n";
	Nhap(a,n);
	cout<<"Mang Xuat :\n";
	Xuat(a,n);
    cout<<"\nNhap X :\n";
    cin>>x;
    if(Search(a,n,x)==1){
    cout<<"X co trong mang";
	}else{
	cout<<"X khong co trong mang";
	}
}
