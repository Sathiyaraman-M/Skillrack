L = sorted(list(map(int, input().split())))
print(*[i for i in range(L[0], L[1] + 1)], end = " ")
print(*[i for i in range(L[-1], L[1] - 1, -1)])