/*
a, Viet ham nhap/xuat mang a cac so nguyen co n phan tu tu ban phim dieu kien gia tri cua n phai thoa man 1<n<100 
	neu khong thoa man dieu kien tren thi yeu cau nhap lai 
b, Viet ham tinh gia tri trung binh cac phan tu co gia tri tuong duong trong mang 1 chieu a co n phan tu. 
	Ham tra ve gia tri trung binh cac phan tu co gia tri duong. Nguoc lai ham tra ve gia tri 0
*/

#include <stdio.h>

void nhap(int a[],int n){
	int i;
	for(i=0;i<n;i++){
		printf("Nhap a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}

void xuat(int a[],int n){
	int i;	
	printf("\n\t /===> Cac phan tu trong mang la <===/ \n");
	for(i=0;i<n;i++) printf ("a[%d] = %d\n",i,a[i]);
}

void TBDuong(int a[],int n){
	int i;
	float s = 0,dem = 0 ,tb;
	for(i=0;i<n;i++){
		if(a[i]>0){
			s = s + a[i];
			dem++;
		}
	}
	
	tb = s/dem;
	
	printf("\n");
	if(dem != 0)
		printf(" /> Gia tri tb cua cac pt duong la: %.2f ",tb);
	else
		printf(" /> K co pt duong !");
   
}

int main(){
	
	int n,a[100];
	
	//kt dk (1<n<100)
	printf("Nhap n (1<n<100): ");
	do{
		scanf("%d",&n);
		if(n<2 || n>99) printf(" /> Nhap lai n (1<n<100): ");
	}while(n<2 || n>99);
	
	nhap(a,n);
	xuat(a,n);
	TBDuong(a ,n);
}

