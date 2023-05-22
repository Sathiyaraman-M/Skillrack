N = int(input())
M = [list(map(int, input().split())) for _ in range(N)]
for i in range(N):
    for j in range(N):
        print(M[j][i] if i + j == N - 1 else M[i][j], end = ' ')
    print()