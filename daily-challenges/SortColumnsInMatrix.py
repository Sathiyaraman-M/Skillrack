R, C = map(int, input().strip().split())
M = [list(map(int, input().strip().split())) for _ in range(R)]
Cols = [(max(M[i][j] for i in range(R)), j) for j in range(C)]
Cols.sort(key = lambda x: (-x[0], x[1]))
T = [[M[i][j] for _, j in Cols] for i in range(R)]
for i in T:
    print(*i)