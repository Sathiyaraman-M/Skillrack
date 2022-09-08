N, K = map(int, input().split())
L = list(map(int, input().split()))
Count = 0
CountedAdj = False
if L[0] == 0 and L[1] == 0:
    Count += 1
    CountedAdj = True
for i in range(1, len(L) - 1):
    if L[i - 1] == 0 and L[i] == 0 and L[i + 1] == 0 and not CountedAdj:
        Count += 1
        CountedAdj = True
    else:
        CountedAdj = False
if L[-2] == 0 and L[-1] == 0 and not CountedAdj:
    Count += 1
print("Yes" if K <= Count else "No")