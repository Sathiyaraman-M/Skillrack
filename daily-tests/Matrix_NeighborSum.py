N = int(input())
M = [list(map(int, input().split())) for _ in range(N)]
R = []
R.append(M[0])
for i in range(1, N - 1):
    Row = [M[i][0]]
    for j in range(1, N - 1):
        Row.append(M[i - 1][j] + M[i + 1][j] + M[i][j - 1] + M[i][j + 1])
    Row.append(M[i][-1])
    R.append(Row)
R.append(M[N - 1])
for i in R:
    print(*i)