N = int(input())
print(*range(1, N + 1))
for i in range(N - 1, 1, -1):
    print('* ' * (i - 1), i, sep = '')
print(*range(1, N + 1))