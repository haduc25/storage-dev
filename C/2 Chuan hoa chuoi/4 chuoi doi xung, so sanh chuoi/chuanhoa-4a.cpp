/* a,(0,5)Nhap va in ra 1 xau s co toi da 100 ki tu
   b,1,5)Viet ham kiem tra chuoi s co phai la chuoi doi xung hay khong?
   Vd:s="abcdcba" -> s chuoi doi xung
      s="abdfghc" -> s khong la chuoi doi xung */
      
#include <stdio.h>
#include <string.h>
char CheckDx(char s[100]){
	int i;
	for(i=0;i<strlen(s)/2;i++){
		if(s[i]!=s[strlen(s)-i-1]){
			return 0;
		}
	}
	   return 1;
}
    int main(){
 	char s[100];
 	puts("Nhap vao 1 xau");
 	gets(s);
 	if(CheckDx(s)==0){printf("/> Khong la chuoi doi xung\n");
	 }if(CheckDx(s)==1){
	 printf("/> Chuoi doi xung\n");
	 }
	 return 0;
 }   
