#include <bits/stdc++.h> 
using namespace std;

int main(int argc, char** argv)
{
    string input;
    cin >> input;
    long len = input.length();
    for(long i = 0; i < len; i += 2)
    {
        if(i == 0 && input[i + 1] == '0')
        { 
            cout << input[i];
        }
        else
        {
            cout << input[i + 1] << input[i];
        }
    }
    return 0;
}