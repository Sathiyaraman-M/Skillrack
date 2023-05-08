N, K = map(int, input().split())
C = 0
while N > 0:
    R = N % K
    C += R
    N -= R
    if R == 0:
        N //= K
        C += 1
print(C)