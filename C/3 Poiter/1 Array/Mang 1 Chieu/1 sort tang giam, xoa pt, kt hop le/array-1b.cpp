#include <stdio.h>
#include <stdlib.h>
#include <math.h>
int a[100], i,j,n,max,min, tg, so_pt_ln,so_pt_nn;
int *Empty;

int main()
{
	printf("Nhap so phan tu: ");
	scanf("%d",&n);
	for (i=0; i<n; i++)
	{
		printf("a[%d]= ",i);
		scanf("%d",&*(a+i));
		Empty = (int *)malloc(n * sizeof(int));
	}
if(Empty==NULL){
	    printf("Co loi! khong the cap phat bo nho.");
        exit(0);
}
else{
	so_pt_ln=so_pt_nn=0;
	max=min=a[0];
//Tim phan tu lon nhat va nho nhat
	for (i=0; i<n; i++)
	{
		if ( *(a+i)>max) max= *(a+i);
		if ( *(a+i)<min) min= *(a+i);
	}
//Tim so luong phan tu lon nhat, nho nhat
	for (i=0; i<n; i++)	
	{
		if ( *(a+i)==max) so_pt_ln++;
		if ( *(a+i)==min) so_pt_nn++;
	}
	printf("\nSo phan tu lon nhat la: %d",so_pt_ln);
	printf("\nSo phan tu nho nhat la: %d",so_pt_nn);
//Dua cac phan tu lon nhat len dau mang
	for (i=0; i<so_pt_ln; i++)
	for (j=i+1; j<=n;j++)	
	if ( *(a+i)<max)
	{
		tg= *(a+i);
	 *(a+i)=*(a+j);
		*(a+j)=tg;		
	}
//chen cac phan tu nho nhat len sau phan tu lon nhat
	for (i=so_pt_ln; i<so_pt_ln+so_pt_nn; i++)
	for (j=i+1; j<=n; j++)
	if ( *(a+i)>min)
	{
		tg= *(a+i);	
		 *(a+i)=*(a+j);
		*(a+j)=tg;
	}	
//Sap xep cac phan tu con lai giam dan
	for (i=so_pt_ln+so_pt_nn+1; i<n-1; i++)
	for (j=i+1; j<=n;j++)
	if ( *(a+i)<*(a+j))
	{
		tg= *(a+i);
		 *(a+i)=*(a+j);
		*(a+j)=tg;
	}
//In mang da sap xep ra man hinh
	printf("\nMang sau khi sap xep la:\n");
	for (i=0; i<n;i++) printf("%5d", *(a+i));

	int tongam=0, tongduong=0;
	for (i=0;i<n;i++)
	{
		if (*(a+i)>0) tongduong+= *(a+i);
		if (*(a+i)<0) tongam+= *(a+i);
	}
	int dem=0;
	if (abs(tongam)==tongduong) printf("\n Hop le.");
	for (i=0;i<n;i++) if (( *(a+i)>0)&&( *(a+i)%2==0))
	{
		for (j=i+1;j<=n;j++)  *(a+i)= *(a+j);
		dem++;
	}
	printf("\nMang sau khi xoa la:\n");
	for (i=0; i<n-dem;i++) printf("%5d", *(a+i));
	
}
    free(Empty);
    return 0;
}
