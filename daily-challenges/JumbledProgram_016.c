#include<stdio.h>
int main()
{
    int N, sum = 0, product = 1;
    scanf("%d", &N);
    while(N > 0)
    {
        if(N % 2  == 0)
        {
            product*= N % 10;
        }
        else
        {
            sum+=N % 10;
        }
        N /= 10;
    }
    if(product % sum == 0)
    {
        printf("Yes");
    }
    else
    {
        printf("No");
    }
}