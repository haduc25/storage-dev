/*viet ham nhap vao 1 mang , ham xuat mang sau do in ra man hinh va xuat nhung SNT ra man hinh*/
 
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
int KTSNT(int x){
	int dem=0;
	for(int i=0;i<=x;i++){
		if(x%i==0){
			dem++;
		}
		}
		if(dem==2){
			return 1;
		}
		return 0;
	}

void XuatSNT(int a[], int n){
	for(int i=0;i<n;i++){
		if(KTSNT(a[i])==1){
			cout<<a[i];
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
	cout<<"\nSNT trong mang la :";
    XuatSNT(a,n);
}
