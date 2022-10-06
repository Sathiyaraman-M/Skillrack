#include<stdio.h>

int main()
{
    int N;
    scanf("%d", &N);
    char str[N][100];
    for(int i = 0; i < N; i++)
        scanf("%s", str[i]);
    int totalRow = strlen(str[0]);
    for(int i = 0; i < totalRow; i++)
    {
        for(int j = 0; j < N; j++)
            printf("%c", str[j][i]);
        printf("\n");
    }
    return 0;
}
