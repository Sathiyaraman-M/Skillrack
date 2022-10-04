#include <stdio.h>
int main()
{
    int N, X;
    scanf("%d %d", &N, &X);
    int arr[N], count[100] = {0};
    for(int index = 0; index < N; index++)
    {
        scanf("%d", &arr[index]);
        count[arr[index]]++;
    }
    for(int index = 0; index < N; index++)
    {
        if(count[arr[index]] == X)
        {
            printf("%d", arr[index]);
            return 0;
        }
    }
}