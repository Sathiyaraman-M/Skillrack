N = int(input())
for i in range(1, N + 1):
    if i <= N // 2:
        print(i, '* ' * ((N // 2) - 1), end = '')
        if i == 1:
            print(*range(N - (N // 2), 0, -1))
        else:
            print(N - (N // 2) + i - 1, '* ' * (N - (N // 2) - 1))
    elif i - 1 == N // 2:
        L = list(range(i, N)) + list(range(N, i - 1, -1))
        print(*L)
    else:
        if i == N:
            print(*range(1, (N // 2) + 1), (N // 2) + 1, '* ' * ((N // 2) - 1), end = '1')
        else:
            print('* ' * (N // 2), sep = ' ', end = '')
            print((N // 2) + (N - i) + 1, '* ' * ((N // 2) - 1), end = str(N - i + 1))
            print()