N = int(input())
O, E = [], []
L = list(map(int, input().split()))
for i in L:
    if i % 2 == 0:
        E.append(i)
    else:
        O.append(i)
print(*O, end = ' ')
print(*E)
        