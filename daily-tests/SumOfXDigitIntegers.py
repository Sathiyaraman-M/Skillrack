A, X = map(int, input().split())
N = str(A)
C = len(N) // X
S = 0
for i in range(C):
    S += int(N[i * X: (i + 1) * X])
print(S)