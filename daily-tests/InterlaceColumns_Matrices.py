R, M, N = map(int, input().split())
M1 = [list(map(int, input().split())) for i in range(R)]
M2 = [list(map(int, input().split())) for i in range(R)]
for i in range(R):
    i1, i2 = 0, 0
    while i1 < M and i2 < N:
        if i1 == i2:
            print(M1[i][i1], end = ' ')
            i1 += 1
        else:
            print(M2[i][i2], end = ' ')
            i2 += 1
    if M > N:
        for j in range(i1, M):
            print(M1[i][j], end = ' ')
    else:
        for j in range(i2, N):
            print(M2[i][j], end = ' ')
    print()
