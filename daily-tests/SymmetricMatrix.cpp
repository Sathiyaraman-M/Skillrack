#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int N;
    cin >> N;
    int M[N][N];
    for(int i = 0; i < N; i++)
    {
        for(int j = 0; j < N; j++)
        {
            cin >> M[i][j];
        }
    }
    for(int i = 0; i < N; i++)
    {
        for(int j = 0; j < N; j++)
        {
            if(M[i][j] != M[j][i])
            {
                cout << "NO" << endl;
                return 0;
            }
        }
    }
    cout << "YES" << endl;
    return 0;
}