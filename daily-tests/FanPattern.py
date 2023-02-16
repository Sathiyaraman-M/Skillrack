N = int(input())
for i in range(N):
    print(*range(i + 1, 0, -1), end = ' ')
    print('* ' * (N - i - 1), end = '')
    print(*range(N - i, 0, -1), end = ' ')
    print('* ' * i)
for i in range(N):
    print('* ' * (N - i - 1), end = '')
    print(*range(i + 1, 0, -1), end = ' ')
    print('* ' * i, end = '')
    print(*range(N - i, 0, -1))