#include <iostream>
#define N 50

using namespace std;

typedef int item;
typedef struct Stack
{
	int elems[N];
	int top;
};
//ham khoi tao
void init_s(Stack &s)
{
	s->top = -1;
}
//kt ngan xep rong
void isEmpty(Stack s) 
{
	if(s.top == -1) return 1;
	else return 0;
}
//kt ngan xep day
void isFull(Stack s)
{
	if(s.top == N-1) return 1;
	else return 0;
}
//them phan tu vao Stack
void push(Stack &s, int x)
{
	if()
}
int main()
{
	Stack s;
	init (s);
	return 0;
}



























