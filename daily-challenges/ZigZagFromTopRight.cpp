#include <bits/stdc++.h>
using namespace std;

int main(int argc, char** argv)
{
    int N;
    cin >> N;
    int value = 1;
    for(int i = 0; i < N; i++)
    {
        if(i % 2 == 0)
        {
            for(int j = N - 1; j >= 0; j--)
            {
                cout << value + j << " ";
            }
            value += N;
        }
        else
        {
            for(int j = 0; j < N; j++)
            {
                cout << value << " ";
                value++;
            }
        }
        cout << endl;
    }
    return 0;
}