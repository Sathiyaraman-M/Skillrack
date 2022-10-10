N, X = map(int, input().split())
L = []
for i in range(N + 1):
    if str(X) in str(i):
        L.append(i)
if len(L) != 0:
    print(*L)
else:
    print(-1)