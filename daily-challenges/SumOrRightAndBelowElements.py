R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
for i in range(R):
    for j in range(C):
        if i == R - 1 and j == C - 1:
            print(M[i][j], end = ' ')
        elif i == R - 1:
            print(M[i][j + 1], end = ' ')
        elif j == C - 1:
            print(M[i + 1][j], end = ' ')
        else:
            print(M[i][j + 1] + M[i + 1][j], end = ' ')
    print()