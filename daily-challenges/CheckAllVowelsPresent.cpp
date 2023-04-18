#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    string str;
    cin >> str;
    bool a = false, e = false, i = false, o = false, u = false;
    for(char c: str)
    {
        switch(tolower(c))
        {
            case 'a':
                a = true;
                break;
            case 'e':
                e = true;
                break;
            case 'i':
                i = true;
                break;
            case 'o':
                o = true;
                break;
            case 'u':
                u = true;
                break;
            default:
                break;
        }
    }
    cout << (a && e && i && o && u ? "yes" : "no") << endl;    
    return 0;
}