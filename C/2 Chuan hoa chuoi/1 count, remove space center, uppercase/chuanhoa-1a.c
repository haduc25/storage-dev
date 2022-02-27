// a, viet ham nhap xuat 1 xau bat ki, tinh do dai, viet hoa xau vua nhap

#include <stdio.h>
#include <string.h>

int main(){
	int i,n;
	char s[100];
	
	//nhap
	puts("Nhap vao mot xau bat ki: ");
    gets(s);
    //xuat
	puts("\n /> Xau vua nhap la: ");
	puts(s);
	
	n=strlen(s); //tinh do dai
    printf("\n /> Do dai cua xau la: %d",n);
    
    for(i=0;i<n;i++);
    	if(s[i]>='A'&&s[i]<='Z')s[i]+=32;
    	
    printf("\n /> Viet hoa cua xau la: ",s);
    puts(strupr(s));
	
}
