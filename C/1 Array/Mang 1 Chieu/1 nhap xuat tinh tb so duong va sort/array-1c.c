/*
	Viet ham nhap vao so nguyen x gom 3 chu so va xuat ra man hinh theo thu tu tang dan cua cac chu so 
	VD : x = 291. xuat ra 129 
*/

#include <stdio.h>

int main(){
	int a,b,c,d,x;
	printf("Nhap so nguyen x (gom 3 chu so) : ");
	scanf("%d",&x);
	a = x/100;
	b = ((x%100)/10);
	c = x%10;
	
	//sort
	if(a>b)
	{
		d=a;
		a=b;
		b=d;	
	}
	
	if(b>c)
	{
	   	d=b;
	   	b=c;
	   	c=d;   	
	}
	
	if(a>b)
	{
		d=a;
		a=b;
		b=d;
	}
	
	printf("%d%d%d", a, b, c);

}
