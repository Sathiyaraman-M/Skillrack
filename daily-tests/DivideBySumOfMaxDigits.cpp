#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int N;
    cin >> N;
    int arr[N];
    int max = 0;
    for(int i = 0; i < N; i++)
    {
        cin >> arr[i];
        if(max < arr[i])
        {
            max = arr[i];
        }
    }
    int sum = 0;
    while(max > 0)
    {
        sum += max % 10;
        max /= 10;
    }
    for(int i = 0; i < N; i++)
    {
        double val = arr[i] / (sum * 1.0);
        cout << fixed << setprecision(2) << val << " ";
    }
}