#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int n;
    cin >> n;
    int val = 1;
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < i; j++)
        {
            cout << "- ";
        }
        if(i % 2 == 0)
        {
            for(int j = n - i - 1; j > 0; j--)
            {
                cout << val << " * ";
                val++;
            }
            cout << val << endl;
            val++;
        }
        else
        {
            for(int j = n - i - 1; j > 0; j--)
            {
                cout << val + j << " * ";
            }
            cout << val << endl;
            val += n - i;
        }
    }

}