N, X = map(int, input().split())
L = list(map(int, input().split()))
for i in range(0, N // X):
    print(min(L[(i * X):((i + 1) *X)]), end = ' ')