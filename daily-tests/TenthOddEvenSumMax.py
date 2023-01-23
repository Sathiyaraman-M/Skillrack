L = list(map(lambda x: (int(x) // 10) % 10, input().strip().split()))
E, O = [], []
for i in L:
    if i % 2 == 0:
        E.append(i)
    else:
        O.append(i)
print(sum(O) if sum(O) >= sum(E) else sum(E))