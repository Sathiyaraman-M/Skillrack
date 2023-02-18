N, A = map(int, input().split())
L = list(map(int, input().strip().split()))
R = []
for i in range(1, N + 1):
    S = 0
    for j in range(i, N + 1, i):
        S += L[j - 1]
    if S == A:
        R.append(i)
print(min(R))