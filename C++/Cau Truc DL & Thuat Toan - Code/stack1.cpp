#include<stdio.h>
 
#define N 50 
  
int top=-1, mang[N];
void push()
{
    int x,i,n;
    if(top==N-1)
    {
        printf("\nNgan xep day!!");
    }
    else
    {
    	do
		{
			printf("Nhap so pt push luong [Max la 50]: ");
    		scanf("%d",&n);
		} 
    	while(n>N);
	    for(i=0;i<n;i++)
		{
			printf("Nhap pt push vao stack: ");
		    scanf("%d",&x);
	        top++;
		    mang[top]=x;
		}
    }
}
  
void pop()
{
    if(top==-1)
    {
       printf("\nStack rong!!");
    }
    else
    {
		printf("\npt da xoa la:  %d",mang[top]);
       	top--;
    }
}
  
void show()
{
    if(top==-1)
    {
        printf("\nStack rong!!");
    }
    else
    {
        printf("\nPhan tu trong Stack: \n");
        for(int i=top;i>=0;--i)
            printf("%d\n",mang[i]);
    }
}
void so_nguyen()
{
	int x;
	printf("\nNhap 1 so nguyen: ");
	scanf("%d",&x);
	while(x!=0)
	{
		int a;
		a=x%2;
	    top++;
		mang[top]=a;
		x=x/2;
	}
}
void clear()
{
		 top=-1;
}
int main()
{
	int n,i;
	push();
	show();
	printf("\n===Sau khi xoa khoi ngan xep===\n");
	pop();
	show();
	clear();
	printf("\n===Doi so nguyen sang he nhi phan===\n");
	so_nguyen();
	show();
	
}













