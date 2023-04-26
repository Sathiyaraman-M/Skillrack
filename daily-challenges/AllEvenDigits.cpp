#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    long long int N;
    cin >> N;
    while(N > 0)
    {
        int digit = N % 10;
        if(digit % 2 != 0)
        {
            cout << "NO" << endl;
            return 0;
        }
        N /= 10;
    }
    cout << "YES" << endl;
    return 0;
}