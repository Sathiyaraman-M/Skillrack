N, X = map(int, input().split())
L = [i for i in range(X, N + 1, X)]
i, j = 0, len(L) - 1
while i < j:
    print(L[i], L[j], end = ' ')
    i += 1
    j -= 1
if i == j:
    print(L[i])