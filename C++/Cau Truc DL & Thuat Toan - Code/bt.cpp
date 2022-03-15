#include <iostream>
#include <cstdlib>

using namespace std;

typedef struct node
{
	int data;
	node *next;
};typedef node *List;

//khoi tao ds rong
void create(List &l)
{
	l = NULL;
}
//kiem tra ds rong
int isEmpty(List l)
{
	return (l==NULL);
}

//tinh do dai ds
int Length(List l)
{
	List m=l;
	int dem=0;
	while(m!=NULL)
	{
		m=m->next;
		dem++;
	}return dem;
}

//tao note P chua dl X
List *create_node(List *p, int x) //note p, dl x
{
	p=(List*)malloc(sizeof(List)); //cap phat bo nho
	p->data = x;
	p->next = NULL;
	return p;
}

//them pt co gt x vap dau ds lk
void insert_first(item x, List &L)
{
	node *p;
	p=create_node(p,x);
	p->pnext = L;
	L=P;
}
//them pt co gt x vao  cuoi ds lk
void insert_last(item x, List &L)
{
	node *M=L; //tao node M
	while(M->pnext != NULL)
	{
		M=M.pnext;
	}node *p;
	p=create_note(p,x);
	M->pnext=p;
}
//them pt co gt x vao vt k ds lk
void insert_k(item x, List &L,int k)
{
	node *M=L;
	node *p;
	int dem=0;
	p=create_node(p,x);
	while(M!=NULL && dem != k-1)
	{
		dem++;
		M=M->pnext;
	}
	p->pnext=M->pnext;
	M->pnext=P;
}
//xoa pt vt dau
void remove_first(item x, List &L)
{
	node *s=L->date; // save data
	L=L->pnext;
	p=create_node(p,x);
	p->pnext = L;
	L=P;
}
//remove vt k
void remove_k(List &L,int k)
{
	node M=L;
	int dem=1;
	while(M!=NULL && dem != k-1)
	{
		dem++;
		M=M->pnext;
		M->next=M->next->next;
		insert_k(l,x,k)
		Lengh(L)+1;
		while(M!=NULL && k-1)
			M->data==x;
	}
}
int main()
{
	List l;
	int x,k;
	create(l);
	isEmpty(l);
	Length(l);
	cout<<"Nhap x: ";
	cin>>x;
	cout<<"Nhap k: ";
	cin>>k;
	insert_first(x,l);
	insert_last(x,l);
	insert_k(x,l,k);
	remove_first(x,l);
	remove_k(l,k);
}



















