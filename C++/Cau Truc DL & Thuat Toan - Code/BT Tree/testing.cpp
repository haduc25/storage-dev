//ds ke tiep => array
//ds lien tiep => poiter

//ds ke tiep
typedef int item; //khoi tao item kieu dl int
typedef struct
{
	item elems[N]; //mang elems
	int size; //so pt toi da array
}List;

//ds lien ket
typedef int item;
typedef struct Node
{
	item data; //data co kieu dl item
	Node *next; //create poiter "next"	
};
typedef Node *List; //create ds cac node

//stack use ds ke tiep
#define N 50// so pt toi da cua stack
typedef int item; //create item kieu ds int
struct stack
{
	int top; //vi tri them vao va lay ra
	item data[N]; //mang cac pt
}; 
//dang ngan xep lien ket
typedef int item;
struct node
{
	item data;
	node *next;
};

struct stack
{
	Node *top;
};
//hang doi queue => ds ke tiep
#define N 100;
typedef int item;
typedef struct queue
{
	item elems[N]; //array save pt in queue
	int size; //luu so luong pt trong queue
	int front,rear; //su dung lay ra va them vao trong queue
};

//hang doi queue => ds lien ket
typedef int item;
typedef struct node
{
	item data;
	node *next;
};
struct queue
{
	node *front,*rear; // node dau & node cuoi
	int count; // dem so pt
};
//binary tree => ds ke tiep
#define N 100 ;//phan tu toi da cua cay
typedef struct Node
{
	Item info;
	int parent;
}Node;
typedef struct Tree
{
	struct Node elems[N];
	int size;
}Tree;
//binary tree => ds lien ket
typedef int item;
typedef struct node
{
	item data;
	node *right,*left;
};
typedef struct *node Tree; //tao cay
//NPTK => ds ke tiep (array)

//NPTK => ds lien tiep (pointer)
typedef int item;
typedef struct node
{
	item data;
	node *left,*right;
}node;
typedef node *tree;


