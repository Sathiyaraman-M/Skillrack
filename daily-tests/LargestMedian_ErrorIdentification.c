#include<stdio.h>
int main()
{
    int N, median, value, totalValue;
    scanf("%d %d", &N, &value);
    median = value;
    totalValue = value;
    for(int ctr = 2; ctr <= N; ctr++)
    {
        scanf("%d", &value);
        totalValue += value;
        if((totalValue / ctr) < median)
        {
            median = totalValue / ctr;
        }
    }
    printf("%d", median);
}
