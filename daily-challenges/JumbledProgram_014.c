#include<stdio.h>
void countDivisors(int N, int X)
{
    int count = 0, ctr;
    for(ctr = 1; ctr <= N; ctr++)
    {
        if(N % ctr == 0 && ctr % X == 0)
        {
            count++;
        }
    }
    printf("%d", count);
}

int main()
{
    int num, X;
    scanf("%d %d", &num, &X);
    countDivisors(num, X);
}