#include <bits/stdc++.h>
 
using namespace std;

int getCount(string str)
{
    int len = str.length();
    int count = 0;
    for(int i = 0; i < len; i++)
    {
        if(str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u' && str[i] != 'A' && str[i] != 'E' && str[i] != 'I' && str[i] != 'O' && str[i] != 'U')
        {
            count++;
        }
    }
    return count;
}

int main(int argc, char** argv)
{
    int N;
    cin >> N;
    string word;
    cin >> word;
    int max = getCount(word);
    for(int i = 1; i < N; i++)
    {
        string temp;
        cin >> temp;
        int count = getCount(temp);
        if(max < count)
        {
            word = temp;
            max = count;
        }
    }
    cout << word;
    return 0;
}