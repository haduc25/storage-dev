/* a,(3)Viet ham nhap/xuat mang a cac so nguyen co n phan tu tu ban phim dieu kien gia tri 
   cua n phai thoa man 1<n<100 neu khong thoa man dieu kien tren thi yeu cau nhap lai  
   b,(3)Viet ham tra ve gia tri cuoi cung cua x xuat hien trong mang 1 chieu a co n phan tu*/
#include <stdio.h>
#define MAX 100 

void Nhap(int a[], int n){
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
	printf("a[%d] = %d\n",i, a[i]);
		}
}
int Find(int a[], int x, int len)
{
    int i, b = -1;
    for (i = 0; i < len; i++)
        if (x == a[i])
            b = i+1;
    return b;
}

int main()
{
    int a[MAX];
    int n,x,i,b;
	do{
	printf("Nhap n: ",n);
     scanf("%d",&n);
    }while(n<2 || n>99);
    Nhap(a,n);
    Xuat(a,n);
    printf("\nNhap x: ");
    scanf("%d", &x);
 
    b = Find(a, x, n);
    if(b != -1)
        printf("\n%d xuat hien tai vi tri cuoi mang A la: %d", x, b);
    else
        printf("\n%d khong xuat hien trong mang A", x);
}

 

