#include <stdio.h>
#include <stdlib.h>
 
int main()
{
    int n, i, *ptr, sum = 0;
    printf("Nhap so luong phan tu: ");
    scanf("%d", &n);
    ptr = (int *)malloc(n * sizeof(int));
 
    // N?u kh�ng th? c?p ph�t, 
    // h�m malloc s? tr? v? con tr? NULL
    if (ptr == NULL)
    {
        printf("Co loi! khong the cap phat bo nho.");
        exit(0);
    }
    printf("Nhap cac gia tri: \n");
    for (i = 0; i < n; ++i)
    {
        scanf("%d", ptr + i);
        sum += *(ptr + i);
    }
    printf(" /> Tong = %d", sum);
 
    // Giai ph�ng v�ng nh? cho con tr?
    free(ptr);
    return 0;
}
