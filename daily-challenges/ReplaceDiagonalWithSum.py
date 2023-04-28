N = int(input())
M = [list(map(int, input().split())) for _ in range(N)]
S = sum([M[i][i] for i in range(N)]) + sum([M[i][N - i - 1] for i in range(N)])
if N % 2 != 0:
    S -= M[N // 2][N // 2]
for i in range(N):
    for j in range(N):
        print(S if i == j or i == N - j - 1 else M[i][j], end = ' ')
    print()