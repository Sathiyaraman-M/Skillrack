def Update(L, I):
    for i in range(len(L)):
        if L[i] == I:
            return L[:i] + L[i + 1:]
    return L
    
N, M = map(int, input().split())
L1 = list(map(int, input().split()))
L2 = list(map(int, input().split()))
R = L1[::-1]
for i in L2:
    R = Update(R, i)
print(*R[::-1])