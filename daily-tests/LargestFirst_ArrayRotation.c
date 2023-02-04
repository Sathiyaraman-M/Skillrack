void rotateArr(int arr[], int N)
{
    int max = arr[0];
    for(int i = 1; i < N; i++)
    {
        if(max < arr[i])
        {
            max = arr[i];
        }
    }
    while(arr[0] != max)
    {
        rot(arr, N);
    }
}

void rot(int arr[], int N)
{
    int first = arr[0];
    for(int i = 0; i < N - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    arr[N - 1] = first;
}