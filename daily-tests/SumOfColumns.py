R, C = map(int, input().strip().split())
M = [list(map(int, input().strip().split())) for i in range(R)]
S = 0
for i in range(C):
    if M[0][i] % 2 != 0:
        for j in range(R):
            S += M[j][i]
print(S if S != 0 else -1)