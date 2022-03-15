#include <iostream>

using namespace std;

struct Node{
    int data;
    Node *next;
};

bool isEmpty(Node *head){
    if (head == NULL){
        return true;
    }
    else{
        return false;
    }
}

void append(Node *head, Node *last, int data){
    Node *newNode = new Node;
    newNode->data = data;
    newNode->next = NULL;
    if (isEmpty(head)){
        head = newNode;
        last= newNode;
    }
    else{
        last->next = newNode;
        last= newNode;
    }

}

void printList(Node *current){
    if (isEmpty(current)){
        cout << "List is empty." << endl;
    }
    else{
        int i = 1;
        while (current != NULL){
            cout << i << ". Node: " << endl;
            cout << current->data << endl;
            current = current->next;
            i++;
        }
    }
}

int main()
{
    Node *head = NULL;
    Node *last = NULL;
    append(head, last, 53);
    append(head, last, 5512);
    append(head, last, 13);
    append(head, last, 522);
    append(head, last, 55);
    printList(head);
}
