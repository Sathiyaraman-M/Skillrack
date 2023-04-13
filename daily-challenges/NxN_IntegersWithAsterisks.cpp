#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int N;
    cin >> N;
    int val = 1;
    for(int i = 0; i < N; i++)
    {
        for(int j = N - i - 2; j >= 0; j--)
        {
            cout << '*';
        }
        for(int j = i + 1; j > 0; j--)
        {
            cout << val;
            val++;
        }
        cout << endl;
    }
}