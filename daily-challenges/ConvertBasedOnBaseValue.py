X = int(input())
Y = int(input())
Z = int(input())
C = 0
D = 0
while X > 0:
    D += (X % 10) * (Y ** C)
    C += 1
    X //= 10
L= []
while D > 0:
    L.append(D % Z)
    D //= Z
print(*L[::-1], sep = '')