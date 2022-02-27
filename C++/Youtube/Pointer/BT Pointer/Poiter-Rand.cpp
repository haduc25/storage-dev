/*
swap(): ham doi cho (#include <time.h>
rand(): ham rand(#include <stdlib.h> || 
ex use: srand((unsigned)time(NULL));
	for(i=0;i<n;i++){
		*(p+i)=rand()%99+1;
	}
*/
#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;

/*void Nhap(int a[],int n,int *p){
	int i;
	//int *p;
	p = new int(n);
	
	for(int i=0;i<n;i++){
		cout<<"A["<<i<<"]= ";
		cin>>*(p+i);// use pointer
	}
}
void Xuat(int a[],int n,int *p){
	int i;
	//int *p;
	p = new int(n);
	for(i=0;i<n;i++){
	cout<<*(p+i)<<"\t";
	}
}*/
/*void Sort(int a[],int n){
	int *p;
	p = new int(n);
	int i,j;
	for(i=0;i<n-1;i++){
		for(j=i+1;j<n;j++){
			if(*(p+i)>*(p+j)){
				swap(*(p+i),*(p+j));
			}
		}
	}
}*/
int main(){
	int n,i,j;
	int a[100];
	int *p;
	p = new int(n);
	cout<<"Nhap N: ";
	cin>>n;
	//Random
	srand((unsigned)time(NULL));
	for(i=0;i<n;i++){
		*(p+i)=rand()%5+1;//neu muoc rand den 100 thi lay 100+1
	}
	/*
	//Nhap
	for(i=0;i<n;i++){
	cout<<"A["<<i<<"]= ";
	cin>>*(p+i);// use pointer
	
}  */
     //Xuat
    cout<<"\nKet Qua: "<<endl;
	for(i=0;i<n;i++){
	cout<<*(p+i)<<"\t";}
	//Sort
	for(i=0;i<n-1;i++){
	for(j=i+1;j<n;j++){
	if(*(p+i)>*(p+j)){
	swap(*(p+i),*(p+j));
	}
	}
	}

	//Xuat Last
	cout<<"\nSau Khi Sort: "<<endl;
	for(i=0;i<n;i++){
	cout<<*(p+i)<<"\t";}
/*	Nhap(a,n,p);
	Xuat(a,n,p);*/
	
	
}
