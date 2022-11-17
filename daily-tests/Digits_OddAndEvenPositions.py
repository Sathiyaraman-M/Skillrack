N = input().strip()
O = []
E = []
for i in range(len(N)):
    if i % 2 == 0:
        O.append(N[i])
    else:
        E.append(N[i])
print(*O)
print(*E)
        