N = int(input())
print('-' + ('*' * (2 * N - 1)))
for i in range((N + 1) // 2, 0, -1):
    print('-' * (N - 2 * i + 1) + '*' * i + '-' * (2 * i - 1) + '*' * i)