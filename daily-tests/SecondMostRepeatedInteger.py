N = int(input())
L = list(map(int, input().strip().split()))
D = dict()
for i in L:
    l = L.count(i)
    if l == 1:
        continue
    if l not in D.keys():
        D[l] = [i]
    else:
        if i not in D[l]:
            D[l].append(i)
K = sorted(D.keys())
if len(K) < 2:
    print(-1)
    exit()
print(D[K[-2]][0])