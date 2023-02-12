def genFactors(N):
    R = []
    for i in range(2, N + 1):
        if N % i == 0:
            R.append(i)
    return R
X, Y = map(int, input().split())
LX, LY = genFactors(X), genFactors(Y)
L = set(LX + LY)
R = []
for i in L:
    if (i in LX and i not in LY) or (i in LY and i not in LX):
        R.append(i)
if len(R) == 0:
    print(-1)
    exit()
print(*sorted(R))