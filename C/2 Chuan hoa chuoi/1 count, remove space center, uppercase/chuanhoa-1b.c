/*b, Viet ham tra ve xau tuong ung sau khi da xoa cac khoang trang giua cac tu trong xau s
  	 (chi giu lai mot khoang trang phan cach giua cac tu)
   	 vi du : s = " Nhap  Mon  Lap  Trinh  C "
     ket qua s = "Nhap Mon Lap Trinh C "
*/

#include <stdio.h>
#include <string.h>
#include <stdbool.h>

bool isSpace(char a){
	return a==' ';
}

void removeSpace(char*s){
	int i,j;
	int n = strlen(s);
	for(i=0;i<n;i++){
		if(isSpace(s[i]) && isSpace(s[i+1])){
			for(j=i+1;j<n;j++){
				s[j]=s[j+1];
			}
			i--;
			n--;
		}
	}
}

int main(){
	char s[100];
	puts("Nhap vao s = ");
	gets(s);
	removeSpace(s);
	printf("/> s = %s",s);
	return 0;
}

