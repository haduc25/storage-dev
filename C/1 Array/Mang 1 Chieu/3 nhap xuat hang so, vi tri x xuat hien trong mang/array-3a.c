#include <stdio.h>


void Nhap(int a[],int n){
	int i;
	for(i=0;i<n;i++){
		printf("Nhap a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}
void Xuat(int a[],int n){
	printf("\n/===>Cac phan tu co trong mang la <===/ \n");
	int i;
	for(i=0;i<n;i++){
		printf ("a[%d] = %d\n",i,a[i]);
	
	
	}
}
int main(){
	
	int n,a[n];
	do{
		printf("Nhap n: ");
		scanf("%d",&n);
	}while(n<2 || n>99);
	Nhap(a,n);
	Xuat(a,n);
}
