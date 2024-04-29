#include<stdio.h>
#include<stdlib.h>
// Node structure
    typedef struct node{
        int data;
        struct node *next;
    }node;

// Function to create a new node
    node* createNode(int Data){
        node *newNode=(node*)malloc(sizeof(node));
        newNode->data=Data;
        newNode->next=NULL;
        return newNode;
    }

// Insert Functions for linked list

    // Function to insert element at the start of the linked list
    void insertElementAtStart(node* head, node* tail, int Data){
        node* newNode=createNode(Data);
        if(head->next==NULL){
            head->next=newNode;
            tail->next=newNode;
        }
        else{
            newNode->next=head->next;
            head->next=newNode;
        }
    }

    //Function to insert element at the end of the linked list
    void insertElementAtEnd(node* head, node* tail, int Data){
        node* newNode=createNode(Data);
        if(head->next==NULL){
            head->next=newNode;
            tail->next=newNode;
        }
        else{
            tail->next->next=newNode;
            tail->next=newNode;
        }
    }

    //Function to insert element at a given position in the linked list
    void insertElementAtPosition(node* head, node* tail, int Data, int pos){
        if(pos==0){
            insertElementAtStart(head,tail,Data);
            return;
        }
        node* newNode=createNode(Data);
        int i=1;
        node* temp=head;
        while(temp!=NULL){
            if(i==pos){
                break;
            }
            temp=temp->next;
            i++;
        }
        newNode->next=temp->next->next;
        temp->next->next=newNode;
    }

// Delete Functions for linked list

    //Function to delete element at the start of the linked list
    void deleteElementAtStart(node* head, node* tail){
        printf("Node deleted with value: %d \n", head->next->data);
        head->next=head->next->next;
    }

    //Function to delete element at the end of the linked list
    void deleteElementAtEnd(node* head, node* tail){
        node* temp=head;
        while(temp->next!=tail->next){
            temp=temp->next;
        }
        printf("Node deleted with value: %d \n", temp->next->data);
        temp->next=NULL;
    }

    //Function to delete element at a given position in the linked list
    void deleteElementAtPosition(node* head, node* tail, int pos){
        node* temp=head;
        int i=0;
        while(temp!=NULL){
            if(i==pos){
                break;
            }
            temp=temp->next;
            i++;
        }
        printf("Node deleted with value: %d \n", temp->next->data);
        temp->next=temp->next->next;
    }

// Function to print element at a given position
void printElementAtPosition(node* head, int pos){
    node* temp=head;
    int i=0;
    while(temp!=NULL){
        if(i==pos+1){
            break;
        }
        temp=temp->next;
        i++;
    }
    printf("Element at position %d is: %d\n", pos, temp->data);
}

// Function to print the linked list    
void printList(node* head){
    node* temp=head->next;
    while(temp!=NULL){
        printf("%d -> ",temp->data);
        temp=temp->next;
    }
    printf("NULL\n");
}

// Main function
int main(){
    //Creating a linked list
    //Head and tail are dummy nodes
    node *head=createNode(0);
    node *tail=createNode(0);

    printList(head); //Printing the empty linked list

    insertElementAtStart(head,tail,3); //Inserting element at the start
    insertElementAtStart(head,tail,2); //Inserting element at the start
    insertElementAtStart(head,tail,1); //Inserting element at the start
    printList(head); //Printing the linked list
    
    insertElementAtEnd(head,tail,5); //Inserting element at the end
    insertElementAtEnd(head,tail,6); //Inserting element at the end
    insertElementAtEnd(head,tail,7); //Inserting element at the end
    printList(head); //Printing the linked list

    insertElementAtPosition(head, tail, 4,3); //Inserting element at a given position
    printList(head); //Printing the linked list

    deleteElementAtStart(head,tail); //Deleting element at the start
    printList(head); //Printing the linked list

    deleteElementAtEnd(head,tail); //Deleting element at the end
    printList(head); //Printing the linked list

    deleteElementAtPosition(head,tail,0); //Deleting element at a given position
    printList(head); //Printing the linked list
    
    printElementAtPosition(head,0); //Printing element at a given position
    printElementAtPosition(head,1); //Printing element at a given position
    printElementAtPosition(head,2); //Printing element at a given position
    
    return 0;
}
//Final output:

// NULL
// 1 -> 2 -> 3 -> NULL
// 1 -> 2 -> 3 -> 5 -> 6 -> 7 -> NULL
// 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> NULL
// Node deleted with value: 1 
// 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> NULL
// Node deleted with value: 7 
// 2 -> 3 -> 4 -> 5 -> 6 -> NULL
// Node deleted with value: 2 
// 3 -> 4 -> 5 -> 6 -> NULL
// Element at position 0 is: 3
// Element at position 1 is: 4
// Element at position 2 is: 5