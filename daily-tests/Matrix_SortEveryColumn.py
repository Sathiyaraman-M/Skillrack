def transpose(M, R, C):
    N = []
    for i in range(C):
        Row = []
        for j in range(R):
            Row.append(M[j][i])
        N.append(sorted(Row))
    return N
R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
N = transpose(M, R, C)
for i in range(R):
    for j in range(C):
        print(N[j][i], end = ' ')
    print()