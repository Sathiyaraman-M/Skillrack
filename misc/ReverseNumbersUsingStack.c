#include<stdio.h>
#include<stdlib.h>

int arr[10000];
int top = -1;

void push(int val)
{
    arr[++top] = val;
}

int pop()
{
    return arr[top--];
}

int isEmpty()
{
    return top == -1;
}

int main()
{
    int N, temp;
    scanf("%d", &N);
    for(int i = 0; i < N; i++)
    {
        scanf("%d", &temp);
        push(temp);
    }
    while(!isEmpty())
    {
        printf("%d ", pop());
    }
    return 0;
}