N = int(input())
for i in range(N):
    print('- ' * (N - i - 1), end = '')
    print(*range(N, N - i - 1, -1), *range(N - i + 1, N + 1))