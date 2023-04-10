#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    string input;
    cin >> input;
    int len = input.length();
    for(int i = 0; i < len - 1; i++)
    {
        if(input[i] == input[i + 1])
        {
            int index = i + 1, count = 0;
            while(input[index] == input[i] && count < 2)
            {
                index++;
                count++;
            }
            if(count >= 2)
            {
                cout << "invalid" << endl;
                return 0;
            }
        }
    }
    cout << "valid" << endl;
}