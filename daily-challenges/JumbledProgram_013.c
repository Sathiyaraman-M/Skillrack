#include<stdio.h>
int main()
{
    int N, K;
    scanf("%d %d", &N, &K);
    int arr[N], count[100000] = {0};
    for(int i = 0; i < N; i++)
    {
        scanf("%d", &arr[i]);
        count[arr[i]]++;
    }
    for(int i = 0; i < N; i++)
    {
        if(count[arr[i]] == K)
        {
            printf("%d ", arr[i]);
            count[arr[i]]--;
        }
    }
}