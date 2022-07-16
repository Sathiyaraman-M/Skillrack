#include<stdio.h>
#include<stdlib.h>

char S[10];
int x, closest;

void swap(int left, int right)
{
    char temp = S[left];
    S[left] = S[right];
    S[right] = temp;
}

int absDiff(int a, int b)
{
    return a > b ? a - b : b - a;
}

void permute(int left, int right)
{
    if(left == right)
    {
        int curr = atoid(S);
        if(absDiff(x, curr) < absDiff(x, closest))
            closest = curr;
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
    scanf("%s%n%d", S, &len, &x);
    closest = atoi(S);
    permute(0, len - 1);
    printf("%d", closest);
}