N, X = map(int, input().split())
if X % 2 == 0:
    print(-1)
    exit()
L = []
i = X
count = 0
while count != N:
    if (X * i) % 2 != 0:
        L.append(i)
        count += 1
    i += X
print(*L)