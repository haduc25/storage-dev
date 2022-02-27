/*Toan Tu New,delete trong C++
New: Cap phat bo nho
Delete: Giai phong bo nho
*/
//Ex: Trong C:
/*#include <stdio.h>
#include <malloc.h>
int main(){
	int *p;
	p = (int*)malloc(sizeof(int));
	free(p);
}*/
//Trong C++
#include <iostream>
using namespace std;
int main(){
	int *p;
	p = new int;
	delete p;
}
