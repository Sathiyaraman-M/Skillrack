N = int(input())
M = [list(map(int, input().split())) for i in range(N)]
L = []
for i in M:
    for j in i:
        if j % 2 == 0:
            L.append(j)
C = len(L)
if C == 0:
    print("-1")
    exit()
if C == 1:
    print(*L)
    exit()
minFactor = 2
while C % minFactor != 0 and minFactor < C:
    minFactor += 1
I = 0
for i in range(minFactor):
    for j in range(C // minFactor):
        print(L[I], end = ' ')
        I += 1
    print()