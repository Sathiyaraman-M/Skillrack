#include<stdio.h>
#include<stdlib.h>

int main()
{
    int N, max, curr;
    scanf("%d %d", &N, &max);
    for(int i = 1; i < N; i++)
    {
        scanf("%d", &curr);
        if(curr > max)
            max = curr;
    }
    printf("%d", max);
}