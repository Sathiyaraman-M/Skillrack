#include<stdio.h>
#include<stdlib.h>

int main()
{
    int num, sum = 0;
    do
    {
        scanf("%d", &num);
        if(num % 2 == 0) sum += num;
    } 
    while(num != 10);
    printf("%d", sum);
}