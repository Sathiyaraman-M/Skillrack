N, X, Y = map(int, input().strip().split())
L = list(map(int, input().strip().split()))
S = 0
for i in L:
    if i >= X and i <= Y:
        S += i
print(S)