#include <stdio.h>
int main()
{
    int left, right, divisor, count = 0;
    scanf("%d %d %d", &left, &right, &divisor);
    for(int i = left; i <= right; i++)
        if(i % divisor == 0)
            count++;
    printf(count > 1 ? "Yes" : "No");
}