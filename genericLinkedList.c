#include<stdio.h>
#include<stdlib.h>
// Node structure
    typedef struct node{
        void* data;
        struct node *next;
    }node;

// Function to create a new node
    node* createNode(void* Data, int size){
        node *newNode=(node*)malloc(sizeof(node));
        newNode->data=Data;
        newNode->next=NULL;
        return newNode;
    }

// Function to print the linked list    
void printList(node* head, void(*print)(void*)){
    node* temp=head->next;
    while(temp!=NULL){
        // printf("%d ",*(int*)temp->data);
        print(temp->data);
        printf(" -> ");
        temp=temp->next;
    }
    printf("NULL\n");
}

// Function to print element at a given position
void printElementAtPosition(node* head, int pos, void (*print)(void*)){
    node* temp=head;
    int i=0;
    while(temp!=NULL){
        if(i==pos+1){
            break;
        }
        temp=temp->next;
        i++;
    }
    printf("Element at position %d is: ", pos);
    print(temp->data);
    printf("\n");
}

void printInteger(void* data){
    printf("%d",*(int*)data);
}

// Insert Functions for linked list

    // Function to insert element at the start of the linked list
    void insertElementAtStart(node* head, node* tail, void* Data, int size){
        node* newNode=createNode(Data, size);

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
    void insertElementAtEnd(node* head, node* tail, void* Data, int size){
        node* newNode=createNode(Data, size);
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
    void insertElementAtPosition(node* head, node* tail, void* Data, int size, int pos){
        if(pos==0){
            insertElementAtStart(head,tail,Data,size);
            return;
        }
        node* newNode=createNode(Data,size);
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
    void deleteElementAtStart(node* head, node* tail, void (*print)(void*)){
        printf("Node deleted with value: ");
        print(head->next->data);
        printf("\n");
        head->next=head->next->next;
    }

    //Function to delete element at the end of the linked list
    void deleteElementAtEnd(node* head, node* tail, void (*print)(void*)){
        node* temp=head;
        while(temp->next->next){
            temp=temp->next;
        }
        printf("Node deleted with value: ");
        print(temp->next->data);
        printf("\n");
        temp->next=NULL;
    }

    //Function to delete element at a given position in the linked list
    void deleteElementAtPosition(node* head, node* tail, int pos, void (*print)(void*)){
        node* temp=head;
        int i=0;
        while(temp!=NULL){
            if(i==pos){
                break;
            }
            temp=temp->next;
            i++;
        }
        printf("Node deleted with value: ");
        print(temp->next->data);
        printf("\n");
        temp->next=temp->next->next;
    }

// Main function
int main(){
    node* head=(node*)malloc(sizeof(node));
    node* tail=(node*)malloc(sizeof(node));
    head->next=NULL;
    tail->next=NULL;
    int arr[10]={1,2,3,0};

// Inserting elements in the linked list

    // Inserting elements at the start
    insertElementAtStart(head,tail,&arr[2],sizeof(int));
    printList(head,&printInteger);
    insertElementAtStart(head,tail,&arr[1],sizeof(int));
    printList(head,&printInteger);
    insertElementAtStart(head,tail,&arr[0],sizeof(int));
    printList(head,&printInteger);

    // Inserting elements at the end
    insertElementAtEnd(head,tail,&arr[2],sizeof(int));
    printList(head,&printInteger);
    insertElementAtEnd(head,tail,&arr[1],sizeof(int));
    printList(head,&printInteger);
    insertElementAtEnd(head,tail,&arr[0],sizeof(int));
    printList(head,&printInteger);

    // Inserting elements at a given position
    insertElementAtPosition(head,tail,&arr[3],sizeof(int),3);
    printList(head,&printInteger);

    // Printing element at a given position
    printElementAtPosition(head,3,&printInteger);
    printList(head,&printInteger);

// Deleting elements from the linked list

    // Deleting elements at the start
    deleteElementAtStart(head,tail,&printInteger);
    deleteElementAtStart(head,tail,&printInteger);
    deleteElementAtStart(head,tail,&printInteger);
    printList(head,&printInteger);

    // Deleting elements at the end
    deleteElementAtEnd(head,tail,&printInteger);
    deleteElementAtEnd(head,tail,&printInteger);
    deleteElementAtEnd(head,tail,&printInteger);
    printList(head,&printInteger);

    // Deleting elements at a given position
    deleteElementAtPosition(head,tail,0,&printInteger);
    printList(head,&printInteger);
    
    return 0;
}
//Final output:
// 3 -> NULL
// 2 -> 3 -> NULL
// 1 -> 2 -> 3 -> NULL
// 1 -> 2 -> 3 -> 3 -> NULL
// 1 -> 2 -> 3 -> 3 -> 2 -> NULL
// 1 -> 2 -> 3 -> 3 -> 2 -> 1 -> NULL
// 1 -> 2 -> 3 -> 0 -> 3 -> 2 -> 1 -> NULL
// Element at position 3 is: 0
// 1 -> 2 -> 3 -> 0 -> 3 -> 2 -> 1 -> NULL
// Node deleted with value: 1
// Node deleted with value: 2
// Node deleted with value: 3
// 0 -> 3 -> 2 -> 1 -> NULL
// Node deleted with value: 1
// Node deleted with value: 2
// Node deleted with value: 3
// 0 -> NULL
// Node deleted with value: 0
// NULL