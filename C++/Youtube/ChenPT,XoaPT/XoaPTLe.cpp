#include <iostream>
using namespace std;

void XoaPT(int a[],int &n,int vtcanxoa){
	for(int i=vtcanxoa;i<n;i++){
		a[i]=a[i+1];
	}
	n--;
}
void XoaPTLe(int a[],int &n){
	for(int i=0;i<n;i++){
		if(a[i]%2==1){
			XoaPT(a,n,i);
			i--;
		}
	}
}
void Nhap(int a[], int n){
	for(int i=0;i<n;i++){
		cout<<"Nhap A["<<i<<"]= ";
		cin>>a[i];
	}
}
void Xuat(int a[], int n)
{
	for (int i = 0; i < n; i++)
		cout << a[i] << "\t";
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
	XoaPTLe(a,n);
	cout<<"\nMang sau khi xoa so le : \n";
	Xuat(a, n);
	system("pause");
}


/*Cach 2
#include <iostream>
using namespace std;


void xoaPhanTuLe(int a[], int &n)
{
	int j = 0;
	for (int i = 0; i < n; i++)
		if (a[i] % 2 == 0){
		
			a[j++] = a[i];
}	n = j;
}
void Nhap(int a[], int n){
	for(int i=0;i<n;i++){
		cout<<"Nhap A["<<i<<"]= ";
		cin>>a[i];
	}
}
void Xuat(int a[], int n)
{
	for (int i = 0; i < n; i++)
		cout << a[i] << "\t";
}
int main()
{
	int a[100];
	int n;
	cout<<"Nhap N = ";
	cin>>n;
	Nhap(a,n);
	cout<<"\nMang vua nhap la : \n";
	Xuat(a,n);
	xoaPhanTuLe(a, n);
	cout<<"\nMang sau khi xoa so le : \n";
	Xuat(a, n);
	system("pause");
}*/
