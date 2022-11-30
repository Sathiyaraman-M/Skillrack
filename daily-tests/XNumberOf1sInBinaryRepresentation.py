N, X = map(int, input().split())
L = list(map(int, input().split()))
S = []
for i in L:
    if bin(i)[2:].count('1') == X:
        S.append(i)
print(*S if len(S) != 0 else ['-1'])