N = int(input())
M = [list(map(int, input().split())) for i in range(N)]
for i in range(N):
    for j in range(N):
        print(M[N - j - 1][N - i - 1] if j <= i else M[i][j], end = ' ')
    print()