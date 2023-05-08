N = int(input())
L = [list(map(int, input().split())) for _ in range(N)]
for i in range(N):
    if i % 2 != 0:
        L[i].append(L[i][1])
    else:
        L[i].append(L[i][0])
L = sorted(L, key = lambda x: x[-1])
for i in L:
    print(i[0], i[1])