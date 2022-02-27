/*
1,   a,Nhap/Xuat mang
     b,chen 1 phan tu x vao vi tri k trong mang
     c,xap xep mang theo thu tu tang dan
*/ 
 
#include <stdio.h>
#define MAX 1000
 
 //nhap
void Nhap(int a[],int n){
	int i;
	for(i=0;i<n;i++){
		printf("Nhap a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}

//xuat
void Xuat(int a[],int n){
  int i;
  printf("\n /===> Cac phan tu trong mang la <===/ \n");
  for(i=0;i<n;i++) printf("a[%d] = %d\n",i,a[i]);
}

//chen
void ChenPT(int a[],int &n,int x,int k){
	int i;
    for(i=n;i>k;i--){
        a[i] = a[i-1];
    }
    a[k]=x;
    n++;
}
 
int main(){
  	int x,k,n,a[MAX];
  	//n
  	printf("Nhap n = ");
  	scanf("%d",&n);
  	Nhap(a,n);
    Xuat(a,n);
    
    //chen phan tu x
    printf("\nNhap x = ");
    scanf("%d",&x);
    
    //vi tri
    printf("Vi tri cua k la: ");
    scanf("%d",&k);
    ChenPT(a,n,x,k);
    
    //sau khi chen
    printf("\n /===> %d sau khi them vao vi tri thu %d la <===/ \n", x, k);
    Xuat(a,n);
    int z,i,j;
    
    //sort
    for(i = 0; i < n - 1; i++){
        for(j = i + 1; j < n; j++){
            if(a[i] > a[j]){
                z = a[i];
                a[i] = a[j];
                a[j] = z;        
            }
        }
    }
     printf("\n /> Mang theo thu tu tang dan la:\t");
    for(int i = 0; i < n; i++){
        printf("%d\t",a[i]);
    } 
}
