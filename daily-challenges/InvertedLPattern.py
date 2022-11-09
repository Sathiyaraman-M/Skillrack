N = int(input())
print(*list(range(1, N + 1, 2)))
print(*list(range(2, N, 2)), sep = '\n')