#include<stdio.h>
#include<stdlib.h>

int main()
{
    int N, X;
    scanf("%d %d", &N, &X);
    int sum = 0, curr;
    for(int i = 1; i <= N; i++)
    {
        scanf("%d", &curr);
        sum += pow(X, curr);
    }
    printf("%d", sum / X);
}