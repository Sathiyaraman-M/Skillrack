R, C = map(int, input().split())
M1 = [list(map(int, input().strip().split())) for _ in range(R)]
M2 = [list(map(int, input().strip().split())) for _ in range(R)]
for i in range(R):
    for j in range(C):
        print(str(M1[i][j]) if M1[i][j] == M2[i][j] else '*', end = ' ')
    print()