#include<stdio.h>
#include<stdlib.h>

int main()
{
    int N;
    scanf("%d", &N);
    int arr[N], printValue;
    for(int i = 0; i < N; i++)
    {
        scanf("%d", &arr[i]);
    }
    for(int i = 0; i < N; i++)
    {
        for(int j = i + 1; j < N; j++)
        {
            if(printValue < arr[j] && arr[j] % 2 == 0)
            {
                printValue = arr[j];
                break;
            }
        }
        printf("%d ", printValue);
    }
    return 0;
}