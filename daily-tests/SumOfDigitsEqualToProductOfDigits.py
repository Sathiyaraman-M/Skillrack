def SumCondition(N):
    temp = N
    s = 0
    while temp != 0:
        s += temp % 10
        temp //= 10
    return s

def ProductCondition(N):
    temp = N
    p = 1
    while temp != 0:
        p *= temp % 10
        temp //= 10
    return p
    
N1, N2 = map(int, input().split())
N = []
for i in range(N1, N2 + 1):
    if SumCondition(i) == ProductCondition(i):
        N.append(i)
if len(N) > 0:
    print(*N)
else:
    print(-1)
