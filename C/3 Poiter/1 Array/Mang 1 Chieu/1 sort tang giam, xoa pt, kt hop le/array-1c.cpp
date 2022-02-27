#include <stdio.h>
#include <stdlib.h>
#include<conio.h>
int *a,i,j,n;
int b[100];
int c = 0;
void inmang(int *x)
{
	for  (i=0; i<n; i++)
	printf("%5d",*(x+i));
}

int main()
{
	printf("Nhap so phan tu: ");
	scanf("%d",&n);
	a=new int[n];
//Nhap cac phan tu cho mang
	for (i=0; i<n;i++)
	{
		printf("a[%d]= ",i);
		scanf("%d",a+i);
	}	
//Kiem tra tinh hop le hay khong	
	int kt=1;
	for (i=0; i<n-1; i++)
	if (*(a+i)>a[i+1])
	{
		kt=0;
		break;
	}
	if (kt==1) printf("\nMang hop le");
	else printf("\nMang khong hop le");
//Sap xep mang theo chieu tang
	int tg;
	for (i=0; i<n-1; i++)
	for (j=i+1; j<n; j++)
	if (*(a+i)>*(a+j))
	{
		tg=*(a+i);
		*(a+i)=*(a+j);
		*(a+j)=tg;
	}
//Xoa di cac phan tu chan trong mang
 for (i = 0; i < n;i++)
 if (*(a+i) % 2 != 0)
 {
 	*(b+c) = *(a+i);
 	c++;
 }
for (i = 0; i < c; i++) *(a+i) = *(b+i);
printf("\nMang sau khi xoa so chan la:\n");
for (i = 0; i < c; i++) printf("%d\t", *(a+i));
//In ra mang
	printf("\nMang sau khi sap xep la: \n");
	inmang(a);
}
