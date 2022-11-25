N = int(input().strip())
L = list(map(int, input().strip().split()))
Max, Min = max(L), min(L)
S = 0
C = 0
for i in L:
    if i != Max and i != Min:
        S += i
        C += 1
S += (L.count(Max) - 1) * Max + (L.count(Min) - 1) * Min
C += (L.count(Max) - 1) + (L.count(Min) - 1)
print("{0:.2f}".format(S / C))