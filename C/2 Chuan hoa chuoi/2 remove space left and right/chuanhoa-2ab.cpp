/* 
	a, Nhap va in ra 1 xau s co toi da 100 ki tu
    b, Viet ham tra ve xau sau khi da xoa cac khoang trang ben trai va ben phai cua xau s
*/

#include <stdio.h>
#include <string.h>
 
void RemoveSpace(char s[], int a)
{
    int RemoveFirst = 0,RemoveLast = a - 1;
    while (RemoveFirst < RemoveLast && s[RemoveFirst] == ' ')
        RemoveFirst++;
    while (RemoveLast > RemoveFirst && s[RemoveLast] == ' ')
        RemoveLast--;
    for (int i = RemoveFirst; i <= RemoveLast; i++){
     if (i + 1 <= RemoveLast)
        {
            if (s[i] == s[i + 1] && s[i] == ' ')
            {
                continue;
            }
        }
        printf("%c", s[i]);
    }
}
 
int main()
{
    char s[100];
    printf("Nhap va xau s: ");
    fgets(s, sizeof s, stdin);
    int a = strlen(s) - 1; 
    s[a] = '\0';
    printf("/> s = ");
    RemoveSpace(s,a);
}
