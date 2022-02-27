//sap xep mang tang dan

#include <stdio.h>
#include <stdlib.h>
int *a,*kt,i,j,n, min, max;

int main()
{
	printf("Nhap so phan tu: ");
	scanf("%d",&n);
	a=new int[n]; //Cap phat bo nho
	for (i=0; i<n; i++)
	{
		printf("a[%d]=",i);
		scanf("%d",(a+i)); //scanf("&d",&a[i]);
		kt = (int *)malloc(n * sizeof(int));
	}
	for (i=0; i<n;i++)
	if (*(a+i)<0) kt++;
	if(kt == NULL)
	{
		printf("\nKhong hop le\n");
	}
	else
	{
			printf("\nHop le"); 
		int tg=0;
		for (i=0; i<n-1; i++)
		for (j=i+1; j<n; j++)
		if (*(a+i)>a[j])
		{
			tg= *(a+i);
			 *(a+i)=*(a+j);
			*(a+j)=tg;	
		}
		printf("\nMang sau khi sap xep tang dan la: \n");
		for (i=0;i<n;i++) printf("%5d",*(a+i));
	}
}
