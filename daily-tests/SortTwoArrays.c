void merge(int arr[], int l, int m, int r)
{
    int len1 = m - l + 1, len2 = r - m;
    int L[len1], R[len2];
    for(int i = 0; i < len1; i++)
        L[i] = arr[l + i];
    for(int i = 0; i < len2; i++)
        R[i] = arr[m + 1 + i];
    int i = 0, j = 0, k = l;
    while(i < len1 && j < len2)
    {
        if(L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }
    while(i < len1)
    {
        arr[k] = L[i];
        k++;i++;
    }
    while(j < len2)
    {
        arr[k] = R[j];
        k++;j++;
    }
}

void mergeSort(int arr[], int l, int r)
{
    if(l < r)
    {
        int mid = (l + r) / 2;
        mergeSort(arr, l, mid);
        mergeSort(arr, mid + 1, r);
        merge(arr, l, mid, r);
    }
}

/** Main Function to be implemented **/
void sortTwoArrays(int array1[], int M, int array2[], int N)
{
    int arr[M + N];
    for(int i = 0; i < M; i++)
        arr[i] = array1[i];
    for(int i = 0; i < N; i++)
        arr[M + i] = array2[i];
    mergeSort(arr, 0, M + N - 1);
    int index = 0;
    for(int i = N - 1; i >= 0; i--)
        array2[i] = arr[index++];
    for(int i = M - 1; i >= 0; i--)
        array1[i] = arr[index++];
}