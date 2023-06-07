#include <bits/stdc++.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int N, M;
    cin >> N >> M;
    float final = N * 1.0;
    float curr = M * 1.0;
    int C = 0;
    while(curr < final)
    {
        curr += (curr / 4);
        C += 1;
    }
    cout << C;
    return 0;
}