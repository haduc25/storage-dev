#include<stdio.h>
#include<conio.h>
int a[100], b[100];
int main()
{
 int i, n, k=0;
 printf("nhap so phan tu cua mang: ");
 scanf("%d", &n);
 
 //nhap
 for (i = 0; i < n; i++)
 {
  printf("a[%d]= ", i + 1);
  scanf("%d", &a[i]);
 }
 
 //xuat
 printf("\n /===> Cac phan tu trong mang la <===/ \n");
 for (i = 0; i < n; i++) printf(" %d ", a[i]);
 
 //kt so chan
 for (i = 0; i < n;i++)
 if (a[i] % 2 != 0)
 {
	  b[k] = a[i];
	  k++;
 }
 for (i = 0; i < k; i++) a[i] = b[i];
 printf("\n\n /> Mang sau khi xoa cac so chan la: \n");
 for (i = 0; i < k; i++) printf(" %d ", a[i]);
 _getch();
}
