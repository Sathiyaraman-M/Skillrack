N = int(input())
L = list(map(int, input().strip().split()))
S = 0
i = 0
while i < N:
    S += L[i]
    i += L[i] % 10
print(S)