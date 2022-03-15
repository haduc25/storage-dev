#include <iostream>

using namespace std;

typedef struct note
{
	int data;
    note *next;
};
typedef note Node;

struct LinkedList
{
	struct node *pHead;
	struct node *pTail;	
};typedef LinkedList List;
 
//tao 1 ds rong
void create(List &l)
{
	l.pHead = NULL;
	l.pTail = NULL;
}
//kiem tra ds rong
int isEmpty(List l)
{
	return (l.pHead == NULL && l.pTail == NULL);
}

//tinh do dai ds
int Lengh(List l)
{
	note *m=l;
	int dem=0;
	while(m!=NULL)
	{
		m=m->next;
		dem++;
	}return dem;
}
//
Node *getNode(int x)
{
	Node *p = new Node;
	if(p == NULL)
	{
		return NULL;
	}
	p->data=x; //sava vao data
	p->next = NULL;
	return p;
}
//them pt co gt x
void add_first(List &l, Node *p)
{
		
	if(l.pHead == NULL)
	{
		l.pHead = p;
		l.pTail = p;
	}else
	{
		p->next = l.pHead; //p=head
		l.pHead = p; //add
	}
}
//inout
void nhap(List &l, int n)
{
	int x,i;
	List l;
	for(i=0;i<n;i++)
	{
		cout<<"Nhap Node thu ["<<i+1<<"]= ";
		cin>>x;
		Node *p = getNode(x);
		add_first(l,p);
	}
}
int main()
{
	List l;
	int n;
	cout<<"Nhap so luong Node: ";
	cin>>n;
	nhap(l,n);
	/*
	create(l);
	isEmpty(l);
	getNode(3);
	*/
}





























