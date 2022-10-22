#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    char str[101];
    cin>>str;
    int len = strlen(str);
    for(int i = 0; i < len; i++)
    {
        for(int j = i + 1; j < len; j++)
        {
            if(abs(str[j] - str[i]) == abs(j - i))
                cout<<str[i]<<str[j];
        }
    }
}