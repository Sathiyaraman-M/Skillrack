#include <bits/stdc++.h>
#include <stdio.h>
 
using namespace std;

int main(int argc, char** argv)
{
    int N;
    cin>>N;
    for(int i = 1; i <= N; i++)
        cout<<(i < N /2 ? i * 2 : i * 3)<<" ";
    return 0;
}