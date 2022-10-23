#include<stdio.h>
int main()
{
    char str[101], lastPrinted;
    scanf("%s",str);
    printf("%c",str[0]);
    lastPrinted=str[0];
    for(int index=1 ; str[index]!='\0'; index++)
    {
        if(str[index] > lastPrinted)
        {
            lastPrinted=str[index];
            printf("%c",lastPrinted);
        }
    }
    return 0;
}