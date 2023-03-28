#include <bits/stdc++.h>
 
using namespace std;

bool prime(int N) 
{
    for(int i = 2; i <= sqrt(N); i++)
        if(N % i == 0)
            return false;
    return true;
}

int main(int argc, char** argv)
{
    long long int N;
    cin >> N;
    vector<long long int> P;
    for(long long int i = 2; i <= N; i++)
        if(prime(i)) 
            P.push_back(i);
    int L = 0, R = P.size() - 1;
    while(L <= R)
    {
        long long int sum = P[L] + P[R];
        if(sum == N)
        {
            cout << P[L] << " " << P[R];
            return 0;
        }
        else if(sum > N)
        {
            R--;
        }
        else
        {
            L++;
        }
    }
    cout << "-1";
}