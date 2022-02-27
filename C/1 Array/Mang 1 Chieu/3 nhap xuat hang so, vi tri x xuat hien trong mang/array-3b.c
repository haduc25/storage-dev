#include <stdio.h>
#define MAX 100

void Nhap(int a[],int n){
	int i;
	for(i=0;i<n;i++){
		printf("Nhap a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}

void Xuat(int a[],int n){
  int i;
  printf("\n/===>Cac phan tu co trong mang la <===/ \n");
  for(i=0;i<n;i++){
  printf("a[%d] = %d\n",i,a[i]);
  }
}
  
  
 int main(){
  	int n,a[MAX];
  	printf("Nhap n= ");
  	scanf("%d",&n);
  	Nhap(a,n);
  	
    Xuat(a,n);
  }
  
