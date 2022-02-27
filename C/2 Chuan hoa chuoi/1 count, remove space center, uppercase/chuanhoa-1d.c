/*xoa tat ca cac khoang trang thua o giua xau va viet in hoa tinh do dai */
#include <stdio.h>
#include <string.h>
int main(){
	int i,n;
	char s[100];
	puts("nhap va 1 xau bat ky: ");
	gets(s); 	//nhap xau 

	puts("\n /> Xau vua nhap: ");
	puts(s);	//xuat xau

	n=strlen(s); //tinh do dai
    printf("\n /> Do dai cua xau la (%d)",n);
    //puts(strlwr(s));
    
    //uppercase
    printf("\n /> Xau viet in hoa: ");
    for(i=0;i<n;i++);
    	if(s[i]>='A'&&s[i]<='Z')s[i]+=32;
    puts(strupr(s));
	
}
