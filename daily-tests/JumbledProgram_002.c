#include<stdio.h>
#include<stdlib.h>

int main()
{
    int N, count = 0;
    scanf("%d", &N);
    while(N > 0)
    {
        N /= 10;
        count++;
    }
    printf("%d", count);
}