N, X, Y = map(int, input().split())
L = input().split()
L[X - 1], L[Y - 1] = L[Y - 1], L[X - 1]
print(*L)
