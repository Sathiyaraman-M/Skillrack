#include<stdlib.h>
#include<stdio.h>
int main()
{
    char *a, *b;
    char *str, x, y;
    scanf("%s", str);
    scanf(" %c %c", &x, &y);
    int i, j;
    for(i = 0; str[i] != '\0'; i++)
    {
        if(str[i] == x)
        {
            a = str + i;
            break;
        }
    }
    for(j = 0; str[j] != '\0'; j++)
    {
        if(str[j] == y)
        {
            b = str + j;
            break;
        }
    }
    printf("%d", abs(b - a) - 1);
    return 0;
}