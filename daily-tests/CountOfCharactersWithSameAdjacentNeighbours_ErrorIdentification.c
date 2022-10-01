#include<stdio.h>
int main()
{
    char str[101];
    int len, count = 2;
    scanf("%s%n", str, &len);
    if(len - 1 <= 2)
    {
        printf("%d", len);
        return 0;
    }
    for(int i = 1; i < len - 1; i++)
    {
        if(str[i - 1] == str[i + 1])
        {
            count++;
        }
    }
    printf("%d", count);
    return 0;
}