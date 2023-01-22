N = int(input())
L = list(map(int, input().split()))
E = []
for i in L:
    S = True
    for j in str(i):
        if int(j) % 2 != 0:
            S = False
            break
    if S == True:
        E.append(i)
if len(E) > 0:
    print(*E)
else:
    print("-1")