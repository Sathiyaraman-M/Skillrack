N = int(input())
M = [list(map(int, input().split())) for _ in range(N)]
Maxs = [0 for _ in range(N)]
for i in range(N):
    Max = 0
    for j in range(N):
        Max = max(M[j][i], Max)
    Maxs[i] = Max
Max1 = Maxs.index(max(Maxs))
Maxs[Max1] = 0
Max2 = Maxs.index(max(Maxs))
for i in range(N):
    print(M[i][Max1], M[i][Max2], end = ' ')