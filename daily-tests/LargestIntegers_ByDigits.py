N = int(input())
L = input().strip().split()
D = dict()
for i in L:
    Len = len(i)
    if Len not in D:
        D[Len] = [i]
    else:
        D[Len].append(i)
for i in sorted(D.keys()):
    print(max(D[i]), end = ' ')