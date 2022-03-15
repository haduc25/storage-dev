#include<stdio.h>
#include<stdlib.h>

typedef int item;
typedef struct Node
{
	item key;
	Node *left, *right;
}Node;
typedef Node *Tree;

void Innit(Tree &T)
{
	T = NULL;
}

void insertNode(Tree &T,item x)
{
	if (T != NULL)
	{
		if(T->key == x)
		{
			printf("x da ton tai\n");
			
		}
		else
		{
		
		
			if(T->key > x)
			{
				insertNode(T->left,x);
			}
			if(T->key < x)
			{
				insertNode(T->right, x);
			}
		}
	}
	if(T == NULL)
	{
		T = (Node*)malloc(sizeof(Node));
		T->key = x;
		T->left = T->right = NULL;
	}
	
}

void nhap(Tree &T)
{
	item x;
	while(1)
	{
		printf("nhap Node: ");
		scanf("%d", &x);
		if(x == 0)
		{
			break;
		}
		else
		{
			insertNode(T,x);
		}
		
	}
}
void NLR(Tree T)
{

	if(T != NULL)
	{
		
		printf("%d\t", T->key);
		NLR(T->left);
		NLR(T->right);
	}
}
void LNR(Tree T)
{
	if(T != NULL)
	{
		LNR(T->left);
		printf("%d\t", T->key); 
		LNR(T->right);
	}
}
void LRN(Tree T)
{
	if(T != NULL)
	{
		LRN(T->left);
		LRN(T->right);
		printf("%d\t", T->key);
	}
}
void seach(Tree T, item x)
{

	if(T == NULL)
	{
		printf("cay rong");
	}
	else
	{
		if(x == T->key)
		{
			printf("tim thay %d",x);
		}
		else
		{
			if(x < T->key)
			{
				seach(T->left,x);
			}
			if(x > T->key)
			{
				seach(T->right,x);
			}
		}
		
		
	}
}



int main()
{
	Tree T;
	Innit(T);
	nhap(T);
	printf("duyet cay theo NLR:\n");
	NLR(T);
	printf("\nduyet cay theo LNR:\n");
	LNR(T);
	printf("\nduyet cay theo LRN:\n");
	LRN(T);
	item x;
	printf("\nnhap gia tri can tim kiem: ");
	scanf("%d", &x);
	seach(T,x);
	item a;
	printf("nhap gia tri can xoa: ");
	scanf("%d", &a);
	return 0;
}

