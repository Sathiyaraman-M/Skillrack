N = int(input())
for i in range(N):
    print('-' * (N - i - 1) + '*' * (2 * (i + 1)) + '-' * (N - i - 1))