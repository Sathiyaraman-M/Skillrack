X, Y = map(int, input().split())
R = []
for i in range(X, Y + 1):
    V = str(i)
    C1, C2 = 0, 0
    for j in V:
        if j in "13579":
            C1 += 1
        else:
            C2 += 1
    if C1 >= 2 and C2 >= 2:
        R.append(V)
if len(R) > 0:
    print(*R)
else:
    print(-1)