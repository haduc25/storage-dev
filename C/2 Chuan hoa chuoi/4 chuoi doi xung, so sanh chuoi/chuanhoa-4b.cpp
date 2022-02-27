/* a,(0.5)Nhap va in ra 1 xau co toi da 100 ki tu
   b,(1.5)Viet ham kiem tra xau s1 co trung khop voi xau s2 hay khong,
   ham tra ve gia tri 1 neu trung khop nguoc lai tra ve 0 */
   #include <stdio.h>
   #include <string.h>
   #include<conio.h>
   
   int Strcmp(char s1[], char s2[]){
	int dodai_min = strlen(s1) < strlen(s2) ? strlen(s1) : strlen(s2);

	for(int i = 0; i < dodai_min; i++)
	{
		if(s1[i] > s2[i])
		{
			return 1;
		}
		else if(s1[i] < s2[i])
		{
			return -1;
		}
	}if(strlen(s1) > strlen(s2))
	{
	return 1;
	}else if(strlen(s1) < strlen(s2))
	{
	return -1;
	}return 0;
}
   

int main(){
    char s1[100];
	char s2[100];
	puts("Nhap s1: ");
	gets(s1);
	puts("Nhap s2: ");
	gets(s2);
    if(Strcmp(s1, s2) > 0){	printf("\nS1>S2");
	}
	else if(Strcmp(s1, s2) < 0){
	printf("\nS2>S1");
	//printf("0");
	}
	else{
		//printf("0");
		printf("\nS2=S1");
	}
     getch();
	return 0;
}
