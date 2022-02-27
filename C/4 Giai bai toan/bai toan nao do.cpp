#include <stdio.h>
 
 void Nhap(int a[],int n){
 	for(int i;i<n;i++){
 		printf("a[%d]=",i);
		scanf("%d",&a[i]);
	 }
 }
// Ki?m tra theo ki?u bài toán thu?n
bool IsASC1(int a[], int n)
{
    int dem = 0;
    for (int i = 0; i < n - 1; i++)
    {
        if (a[i + 1] >= a[i])
            dem++;
    }
    if (dem == n - 1)
        return true;
    else
        return false;
}
 
// Ki?m tra theo ki?u bài toán ng?ch
bool IsASC2(int a[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (a[i] > a[i + 1])
            return false;
    }
    return true;
}
 
// Ki?m tra theo ki?u bài toán thu?n
bool IsDESC1(int a[], int n)
{
    int dem = 0;
    for (int i = 0; i < n - 1; i++)
    {
        if (a[i + 1] <= a[i])
            dem++;
    }
    if (dem == n - 1)
        return true;
    else
        return false;
}
 
// Ki?m tra theo ki?u bài toán ng?ch
bool IsDESC2(int a[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (a[i] < a[i + 1])
            return false;
    }
    return true;
}
 
void check(int a[], int n){
    if(IsASC1(a, n)){
        printf("\nDay so tang dan!");
    }else if(IsDESC1(a, n)){
        printf("\nDay so giam dan!");
    }

}
 
int main()
{
    int a[100];
    int a2[100];
    int n;
    printf("Nhap PT= ");
    scanf("&d",&n);

 	Nhap(a,n);
    check(a, sizeof(a)/ sizeof(int));
    check(a2, sizeof(a2)/ sizeof(int));
}
