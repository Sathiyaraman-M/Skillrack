#include<stdio.h>

int main()
{
    char str[101];
    scanf("%s", str);
    int alphaCount[127] = {0}, len = strlen(str);
    for(int index = 0; index < len; index++)
    {
        alphaCount[str[index]]++;
    }
    for(int index = 0; index < len; index++)
    {
        if(alphaCount[str[index]] == 1)
        {
            printf("%c", str[index]);
            return 0;
        }
    }
    printf("-1");
    return 0;
}