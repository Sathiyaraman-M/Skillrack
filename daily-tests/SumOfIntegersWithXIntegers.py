N, X = map(int, input().split())
L = list(map(int, input().split()))
S = 0
for i in L:
    if len(str(i)) == X:
        S += i
print(S if S != 0 else -1)