#include<stdio.h>
int main()
{
    int N, flag = 0;
    scanf("%d", &N);
    while(N > 0)
    {
        if(N & 1)
        {
            printf("%d ", N);
            flag = 1;
        }
        N /= 10;
    }
    if(flag == 0)
    {
        printf("-1");
    }
    return 0;
}