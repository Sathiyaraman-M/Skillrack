N, X = map(int, input().split())
M = [list(map(int, input().split())) for i in range(N)]
L = []
for i in range(N // 2):
    for j in range(i, N - i):
        L.append(M[i][j])
    for j in range(i + 1, N - i):
        L.append(M[j][N - i - 1])
    for j in range(N - i - 2, i - 1, -1):
        L.append(M[N - i - 1][j])
    for j in range(N - i - 2, i, - 1):
        L.append(M[j][i])
if N % 2:
    L.append(M[N // 2][N // 2])
print(L[X - 1], "Working")
        