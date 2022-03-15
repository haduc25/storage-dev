#include <stdio.h>
#include <stdlib.h>


typedef struct Node
{
	int Data;
	Node* Left;
	Node* Right;
};

typedef struct Node* binaryTree; //cây Binary

//Khoi Tao
void Init(binaryTree &t)
{
	t = NULL;
}

//kt rong
bool isEmpty(binaryTree &t)
{
	return (t==NULL);
}
//tao Node
Node* addNode(Node* p, int x)
{
	p = (Node*)malloc(sizeof(Node));
	p->Data = x;
	p->Left = NULL;
	p->Right = NULL;
	return p;
}

//Them vao nut La (La: Leaf)
void addTree(binaryTree &t, int x)
{
	Node* p = addNode(p,x);
	if(isEmpty(t))	t=p;
	else
	{
		Node* m = t;
		Node* q = NULL;
		while(m != NULL)
		{
			q = m;
			if(m->Data < x)	m = m->Right;
			else m = m->Left;
		}
		if(q->Data < x) q->Right = p;
		else q->Left = p;
	}
}
//input
void nhap(binaryTree &t, int n)
{
	int x,i;
	for(i=0;i<n;i++)
	{
		printf("Value [%d]\n",i+1);
		scanf("%d",&x);
		addTree(t,x);
	}
}
//duyet truoc 
void duyetTruoc(binaryTree t)
{
	Node* m = t;
	if(m != NULL)
	{
		printf("%d\t",m->Data);
		duyetTruoc(m->Left);
		duyetTruoc(m->Right);
	}
}
//duyet giua
void duyetGiua(binaryTree &t)
{
	Node* m = t;
	if( m!= NULL)
	{
		duyetGiua(m->Left);
		printf("%d\t",m->Data);
		duyetGiua(m->Right);
	}
}
//duyet sau
void duyetSau(binaryTree &t)
{
	Node* m = t;
	if(m!= NULL)
	{
		duyetSau(m->Left);
		duyetSau(m->Right);
		printf("%d\t",m->Data);	
	}
}
//tim kiem (search)
Node* timKiem(binaryTree t, int x)
{
	if(isEmpty(t)) return NULL;
	else
	{
		Node* m=t;
		if(m->Data > x) timKiem(m->Left,x);
		else if(m->Data < x) timKiem(m->Right,x);
		else return m;
	}
}
//check search
void ktSearch(binaryTree t, int x)
{
	if(timKiem(t,x) != NULL) printf("[%d]\tCo trong cay\n",x);
	else printf("[%d]\tK co trong cay\n",x);
}

//chen (insert)
int insertTree(binaryTree &t,int x)
{
	Node* p = addNode(p,x);
	if(isEmpty(t))
	{
		p->Left = NULL;
		p->Right = NULL;
		t = p;
	}else
	{
		if(t->Data > x) insertTree(t->Left, x);
		else
		{
			if(t->Data < x)	insertTree(t->Right, x);
			else printf("[%d]\tDa co trong cay\n",x);
		}
	}
}
//tim cha mot nut (find Parent)
Node* timCha(binaryTree t, int x)
{
	Node* m=t;
	if(isEmpty(t)) return NULL;
	else
	{
		//chua xong
	}
}
//xoa (delete)
void deleteTree(binaryTree &t, int x)
{
	Node* m=t;
	if(m != NULL)
	{
		if(m->Left != NULL && m->Left->Data == x)
		{
			//nut cua la
			if(m->Left->Left == NULL && m->Left->Right == NULL)	m->Left = NULL;
			else
			{
				//nut co 1 con
				if(m->Left->Left != NULL && m->Left->Right == NULL) m->Right = m->Left->Left;
				if(m->Left->Left == NULL && m->Left->Right != NULL) m->Left = m->Left->Right;
			}
		}
		if(m->Right != NULL && m->Right->Data == x)
		{
			if(m->Right->Left == NULL && m->Right->Right == NULL) m->Right = NULL;
			else
			{
				if(m->Right->Left != NULL && m->Right->Right == NULL) m->Right = m->Left->Left;
				if(m->Right->Left == NULL && m->Right->Right != NULL) m->Left = m->Left->Right;
			}
		}
		if(m->Data == x)
		{
			//nut co 2 con
			if(m->Left != NULL && m->Right != NULL)
			{
				if(m->Right->Right == NULL && m->Left->Left == NULL)
				{
					m->Data = m->Right->Data;
					m->Right = NULL;
				}
				else
				{
					Node* q = m->Right;
					while(q->Left->Left != NULL)
					{
						q = q->Left;
					}
					if(q->Left != NULL)
					{
						m->Data = q->Left->Data;
						deleteTree(m->Left,q->Left->Data);
						deleteTree(m->Right,q->Left->Data);
					}
					else
					{
						m->Data = q->Right->Data;
						deleteTree(m->Left,q->Right->Data);
						deleteTree(m->Right,q->Right->Data);
					}
				}
			}
		}
		deleteTree(m->Left,x);
		deleteTree(m->Right,x);
	}
}

//so nut la
int so_nut_la(binaryTree t)
{
	if(isEmpty(t)) return 0;
	else
	{
		if(t->Left == NULL && t->Right == NULL) return 1;
		else
		{
			return so_nut_la(t->Left)+so_nut_la(t->Right);
		}
	}
}
//so nut trong cay (count)
int dem(binaryTree t)
{
	if(isEmpty(t)) return 0;
	else return 1+dem(t->Left) + dem(t->Right);
}
//max
int max(int x, int y)
{
	if(x>y) return x;
	else return y;
}
//chieu cao cua cay (Height)
int chieuCao(binaryTree t)
{
	if(isEmpty(t)) return 0;
	else return max(chieuCao(t->Left),chieuCao(t->Right))+1;
}



//output
void xuat(binaryTree t)
{
	printf("\n--------------------------------\n");
	printf("Duyet Truoc:\t");
	duyetTruoc(t);
	printf("\nDuyet Giua:\t");
	duyetGiua(t);
	printf("\nDuyet Sau:\t");
	duyetSau(t);
}

int main()
{
	binaryTree(t);
	Init(t);
	int n,x,y,z;
	printf("Nhap so luong: ");
	scanf("%d",&n);
	system("cls");
	nhap(t,n);
	xuat(t);
	//so nut la
	printf("\nSo nut la:\t\t[%d]",so_nut_la(t));
	//so nut trong cay
	printf("\nSo nut trong cay:\t[%d]",dem(t));
	//so nut la
	printf("\nChieu cao:\t\t[%d]",chieuCao(t));
	//search
	printf("\nNhap so can Tim Kiem: ");
	scanf("%d",&x);
	ktSearch(t,x);
	//insert
	printf("\nNhap so can Chen: ");
	scanf("%d",&y);
	insertTree(t,y);
	printf("\n----------Sau khi Chen----------\n");
	xuat(t);
	//delete
	printf("\nNhap so can Xoa: ");
	scanf("%d",&z);
	deleteTree(t,z);
	printf("\n----------Sau khi Xoa----------\n");
	xuat(t);
	//tim cha mot nut ?
	
}





































