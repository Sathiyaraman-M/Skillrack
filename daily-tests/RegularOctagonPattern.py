N = int(input())
for i in range(N):
    print((N - i - 1) * '-', (N + 2 * i) * '*', (N - i - 1) * '-', sep = '')
for i in range(N - 2):
    print((3 * N - 2) * '*')
for i in range(N - 1, -1, -1):
    print((N - i - 1) * '-', (N + 2 * i) * '*', (N - i - 1) * '-', sep = '')