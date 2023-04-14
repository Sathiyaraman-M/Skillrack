R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
for i in range(R):
    Row = []
    for j in range(C):
        if j == C - 1:
            Row.append('*')
        else:
            Row.append(M[i][j] if M[i][j + 1] % 2 != 0 else '*')
    print(*Row)