N = int(input())
for i in range(N, 0, -1):
    print(*range(N - i + 1, N + 1))