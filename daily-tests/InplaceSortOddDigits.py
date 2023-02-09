N = list(input())
O = []
for i in range(len(N)):
    V = int(N[i])
    if V % 2 != 0:
        O.append(V)
O = sorted(O)
I = 0
for i in range(len(N)):
    V = int(N[i])
    if V % 2 != 0:
        print(O[I], end = '')
        I += 1
    else:
        print(V, end = '')