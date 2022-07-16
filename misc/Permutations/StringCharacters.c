#include<stdio.h>
#include<stdlib.h>

char S[10];

void swap(int left, int right)
{
    char temp = S[left];
    S[left] = S[right];
    S[right] = temp;
}

void permute(int left, int right)
{
    if(left == right)
    {
        printf("%s\n", S);
        return;
    }
    for(int i = left; i <= right; i++)
    {
        swap(i, left);
        permute(left + 1, right);
        swap(i, left);
    }
}

int main()
{
    int len;
    scanf("%s%n", S, &len);
    permute(0, len - 1);
    return 0;
}