N = int(input())
L = list(map(lambda x: sorted([int(i) for i in x]), input().split()))
R = []
for i in L:
    S = 0
    for j in i:
        if str(j) in "2357":
            S = S * 10 + j
    R.append(S if S != 0 else -1)
print(*R)