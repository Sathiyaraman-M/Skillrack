#include<stdio.h>
#include<stdlib.h>

int main()
{
    int N, X, sum = 0, curr;
    scanf("%d %d", &N, &X);
    for(int ctr = 1; ctr <= N; ctr++)
    {
        scanf("%d", &curr);
        if(curr % X == 0)
        {
            sum = sum | curr;
        }
    }
    printf("%d", sum);
}