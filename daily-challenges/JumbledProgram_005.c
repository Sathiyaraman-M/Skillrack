#include<stdio.h>

int main()
{
    int N, ctr = 0, till;
    scanf("%d", &N);
    till = N % 10;
    if(till != 0)
    {
        ctr++;
    }
    while(ctr <= till)
    {
        printf("%d", ctr--);
        ctr++;
        ctr++;
    }
    /*
    ****ORIGINAL QUESTION****
    int N, ctr = 0, till;
    while(ctr <= till)
    {
        scanf("%d",&N);
    }
    ctr++;
    ctr++;
    till = N%10;
    ctr++;
    if(till!=0)
    {
        printf("%d",ctr--);
    }*/
}