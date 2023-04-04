#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int n;
    cin >> n;
    long temp, minOdd = INT_MAX, maxEven = 0;
    for(int i = 0; i < n; i++)
    {
        cin >> temp;
        if(temp % 2 == 0)
        {
            maxEven = maxEven > temp ? maxEven : temp;
        }
        else
        {
            minOdd = minOdd < temp ? minOdd : temp;
        }
    }
    long a, b;
    if(minOdd < maxEven)
    {
        a = minOdd;
        b = maxEven;
    }
    else
    {
        a = maxEven;
        b = minOdd;
    }
    for(int i = a; i <= b; i++)
    {
        cout << i << " ";
    }
    return 0;
}