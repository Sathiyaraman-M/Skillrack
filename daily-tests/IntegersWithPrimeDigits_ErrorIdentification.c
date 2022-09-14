#include<stdio.h>
int isPrimeDigit(int val)
{
    return val == 2 || val == 3 || val == 5 || val == 7;
}
int main()
{
    int N, currData, printFlag=0;
    scanf("%d", &N);
    while(N > 0)
    {
        scanf("%d", &currData);
        int value=currData, flag=0;
        while(value > 0)
        {
            if(!isPrimeDigit(value % 10))
            {
                flag=1;
            }
            value /= 10;
        }
        if(flag==0)
        {
            printFlag=1;
            printf("%d ",currData);
        }
        N--;
    }
    if(printFlag==0)
    {
        printf("-1");
    }
    return 0;
}