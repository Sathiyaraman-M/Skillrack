N = int(input())
M = [list(map(int, input().split())) for i in range(N)]
S = 0
for i in range(N):
    for j in range(N - i - 1, N):
        S += M[i][j]
print(S)