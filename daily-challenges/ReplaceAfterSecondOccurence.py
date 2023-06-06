N, K = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(N)]
for i in range(N):
    C = 0
    Act = False
    for j in range(N):
        if Act:
            M[j][i] = '*'
        else:
            if M[j][i] == K:
                C += 1
            if C == 2:
                Act = True
for i in range(N):
    for j in range(N):
        print(M[i][j], end = ' ')
    print()