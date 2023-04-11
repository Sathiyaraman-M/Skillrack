#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    char ch;
    int K;
    cin >> ch >> K;
    for(int i = K + (int)ch - 1; i >= (int)ch; i--)
    {
        if(isalpha((char)i))
        {
            cout << (char)i;
        }
    }
}