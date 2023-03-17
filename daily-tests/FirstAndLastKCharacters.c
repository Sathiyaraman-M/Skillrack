#include<stdio.h>
#include<stdlib.h>

int main()
{
    char *str;
    int N;
    scanf("%s", str);
    scanf("%d", &N);
    int len = strlen(str);
    for(int i = 0; i < N; i++) {
        printf("%c", str[i]);
    }
    for(int i = N; i > 0; i--) {
        printf("%c", str[len - i]);
    }
}