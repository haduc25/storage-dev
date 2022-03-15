//Bai1
/*
#include <stdio.h>
#define MAX 100

struct Node
{
	int data; //data of the node
	struct Node* pNext; //Address of the next node	
};

//check isEmpty
bool isEmpty(Node* head)
{
	if (head == NULL){printf("Empty"); return true;}
	else
	{
		printf("Full");
		return false;
	}
}
int Lenght(Node* head)
{
	struct Node* temp = head; // gan temp = dau
	int leng=0;
	while(leng!=NULL)
	{
		leng=temp->pNext;
		leng++;
	}
	printf("\nLenght of The Node is %d",leng);
}
int main()
{
	Node* head = NULL;
	isEmpty(head);
	Lenght();
}
*/
#include <stdio.h>
#include <stdlib.h>
//linked list node structure
struct node{
int data;
struct node* next;
};
struct node* head;
void insert(int data){
/* Allocate memory*/
struct node* temp = (struct node*)malloc(sizeof(struct node));
temp->data = data;
temp->next = head;
head = temp;
}
void print(){
struct node* temp = head;
int count=0;
/* Traverse the linked list and maintain the count. */
while(temp != NULL){
temp = temp->next;
count++;
}
printf("\n Total no. of nodes is %d",count);
}
int main(){
head = NULL;
insert(2);
insert(4);
/* calling print function to print the count of node. */
print();
}
