#include<stdio.h>
#include<stdlib.h>

typedef int item;
typedef struct Node
{
	item key;
	Node *left, *right;
}Node;

typedef Node *Tree;

void Init(Tree &t)
{
	t = NULL;
}

//insert
void insertNode(Tree &t,item x)
{
	if (t != NULL)
	{
		if(t->key == x)
		{
			printf("[%d] da ton tai\n",x);
			
		}
		else
		{
		
		
			if(t->key > x)
			{
				insertNode(t->left,x);
			}
			if(t->key < x)
			{
				insertNode(t->right, x);
			}
		}
	}
	if(t == NULL)
	{
		t = (Node*)malloc(sizeof(Node));
		t->key = x;
		t->left = t->right = NULL;
	}
	
}
//input
void nhap(Tree &t,int n)
{
	int i;
	item x;
	for(i=0;i<n;i++)
	{
		printf("Node thu [%d]= ",i+1);
		scanf("%d",&x);
		insertNode(t,x);
	}
}
//duyet truoc NLR
void tNLR(Tree t)
{
	if(t != NULL)
	{
		printf("%d\t", t->key);
		tNLR(t->left);
		tNLR(t->right);
	}
}
//duyet giua LNR
void gLNR(Tree t)
{
	if(t != NULL)
	{
		gLNR(t->left);
		printf("%d\t",t->key);
		gLNR(t->right);
	}
}
//duyet sau LRN
void sLRN(Tree t)
{
	if(t != NULL)
	{
		sLRN(t->left);
		sLRN(t->right);
		printf("%d\t",t->key);
		
	}
}
//dem so nut la tren cay
int so_nut_la(Tree t)
{
	if(t == NULL) return 0;
	else
	{
		if(t->left == NULL && t->right == NULL) return 1;
		else
		{
			return so_nut_la(t->left)+so_nut_la(t->right);
		}
	}
}
//tim kiem (search)
void timKiem(Tree t, int x)
{
	if(t == NULL) printf("Khong tim thay [%d]",x);
	else
	{
		if(x== t->key) printf("Da tim thay [%d]",x);
		else
		{
			if(x < t->key) timKiem(t->left,x);
			else if(x > t->key)	timKiem(t->right,x);
		}
	}
}
//xuat
void xuat(Tree t)
{
	//duyet truoc
	printf("\nDuyet cay truoc NLR:\t");
	tNLR(t);
	//duyet giua
	printf("\nDuyet cay giua LNR:\t");
	gLNR(t);
	//duyet sau
	printf("\nDuyet cay sau LRN:\t");
	sLRN(t);
}
int main()
{
	int n,x,y;
	Tree(t);
	Init(t);
	printf("Nhap so Node: ");
	scanf("%d",&n);
	system("cls");
	nhap(t,n);
	printf("------------------------");
	//duyet truoc
	printf("\nDuyet cay truoc NLR:\t");
	tNLR(t);
	//duyet giua
	printf("\nDuyet cay giua LNR:\t");
	gLNR(t);
	//duyet sau
	printf("\nDuyet cay sau LRN:\t");
	sLRN(t);
	//so nut tren cay
	printf("\nSo nut la tren cay:\t[%d]",so_nut_la(t));
	printf("\nNhap so can Tim Kiem: ");
	scanf("%d",&x);
	timKiem(t,x);
	printf("\nNhap so can Chen: ");
	scanf("%d",&y);
	insertNode(t,y);
	printf("\n----------Sau khi Chen----------\n");
	xuat(t);
	return 0;
}
