#include <bits/stdc++.h>
 
using namespace std;

bool isVowel(char ch)
{
    return ch == 'a' || ch == 'e' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
}

int main(int argc, char** argv)
{
    string str;
    cin >> str;
    int len = str.length();
    int v = 0, c = 0;
    for(int i = 0; i < len; i++)
    {
        if(isVowel(str[i]))
        {
            v++;
        }
        else
        {
            c++;
        }
    }
    for(int i = 0; i < len; i++)
    {
        if(v == c || (v < c && !isVowel(str[i])) || (v > c && isVowel(str[i])))
        {
            cout << str[i];
        }
    }
    return 0;
}