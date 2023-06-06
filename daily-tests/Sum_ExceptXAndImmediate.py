N, X = map(int, input().split())
L = list(map(int, input().split()))
S = 0 if L[0] == X else L[0]
for i in range(1, N):
    if L[i] != X and L[i - 1] != X:
        S += L[i]
print(S)