R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
T = []
for i in range(C):
    Row = []
    for j in range(R):
        Row.append(M[j][i])
    T.append(Row)
for i in range(C):
    if i % 2 != 0:
        print(*T[i][::-1])
    else:
        print(*T[i])