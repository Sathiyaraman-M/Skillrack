#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int N;
    cin >> N;
    int sum = 0;
    for(int i = 0; i < N; i++)
    {
        string input;
        cin >> input;
        int len = input.length();
        char max = input[0];
        for(int j = 1; j < len; j++)
        {
            if(input[j] > max)
            {
                max = input[j];
            }
        }
        sum += (int)(max - '0');
    }
    cout << sum << endl;
}