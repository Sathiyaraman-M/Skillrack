#include<stdio.h>
#include<stdlib.h>

int main()
{
    char ch;
    int N;
    scanf("%c %d", &ch, &N);
    while(N > 0)
    {
        printf("%c", ch++);
        if(ch - 1 == 'z')
            ch = 'a';
        N--;
    }
}