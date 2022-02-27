/* 
a, Viet ham nhap/xuat mang a cac so nguyen co n phan tu tu ban phim dieu kien gia tri 
  	cua n phai thoa man (1<n<100) neu khong thoa man dieu kien tren thi yeu cau nhap lai  
b, Viet ham tinh gia tri trung binh cac so nguyen to trong mang mot chieu a co 
   	 n phan tu. Ham tra ve gia tri trung binh cua cac phan tu la so nguyen to
*/
 
#include <stdio.h>
#include <math.h>
#define MAX 1000 //hang so

//ham nhap
void nhap(int a[],int n){
	printf("\n");
	for(int i=0;i<n;i++){
		printf("Nhap a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}

//ham xuat
void xuat(int a[],int n){
	printf("\n\t /===> Cac phan tu trong mang la <===/ \n");
	for(int i=0;i<n;i++) printf ("a[%d] = %d\n",i,a[i]);
}

//kt snt
bool snt(int x){
    if(x < 2) return false;
    for(int i = 2; i <= sqrt(x); ++i) 
		if(x % i == 0) return false;
    return true;
}

//dem snt
void demSNT(int a[], int n){
	int tong = 0, dem = 0;
    for(int i = 0; i < n; i++)
	   {
	     if(snt(a[i])){
	     	printf("%d \t",a[i]);
	     	tong = tong+a[i];
	     	dem++;
	     }
	   }
   float TBCong = (float) tong / (float)dem;
   printf("\n /> Gia tri tb cua cac so nguyen to trong mang la : %.2f",TBCong);
}


int main() {

	int n, tong = 0, a[MAX];
	
	//kt dk (1<n<100)
	printf("Nhap n (1<n<100): ");
	do{
		scanf("%d",&n);
		if(n<2 || n>99) printf(" /> Nhap lai n (1<n<100): ");
	}while(n<2 || n>99);
	
	//nhap
	nhap(a,n);
	//xuat
	xuat(a,n);
	printf("\n /> Cac snt trong mang la : " );
    demSNT(a, n);
}
