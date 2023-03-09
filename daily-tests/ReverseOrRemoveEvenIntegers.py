N = input().strip()
O, E = 0, 0
for i in N:
    D = int(i)
    if D % 2 == 0:
        E += D
    else:
        O += D
if E >= O:
    print(int(N[::-1]))
else:
    S = ''
    for i in N:
        D = int(i)
        if D % 2 != 0:
            S += i
    print(int(S))