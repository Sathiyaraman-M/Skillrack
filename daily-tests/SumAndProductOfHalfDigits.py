def prod(l):
    S = 1
    for i in l:
        S *= i
    return S
N = input().strip()
A, B = prod([int(i) for i in N[:len(N) // 2]]), sum([int(i) for i in N[len(N) // 2:]])
print(A + B)
