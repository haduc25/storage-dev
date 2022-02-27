/* a,(0,5)Nhap vao 1 xau in ra 100 ki tu
   b,Viet ham doi ki tu co trog xau s thanh chu HOA(khong dung ham "strupr")
   vi du: "Nhap Mon LAP Trinh C"
   ket qua la : "NHAP MON LAP TRINH C" */          
#include <stdio.h>
#include <string.h>
#define MAX 100


char DoiChuHoa(char s[]) {int i;
for(i=0; i<strlen(s); i++)
{if(s[i] >='a' && s[i] <='z')
s[i] = s[i] - 32;
 }
}

int main(){
	char s[MAX];
	puts("Nhap xau s");
	gets(s);
    puts("Xau vua nhap la :");
    DoiChuHoa(s);
    puts(s);
}
