N = int(input())
S = 0
E = 0
for i in range(N):
    Type, T = map(str, input().split())
    H, M = map(int, T.split(':'))
    if Type == 'E':
        E = H * 60 + M
    else:
        S += H * 60 + M - E
        E = 0
print("yes" if S >= 480 else "no")