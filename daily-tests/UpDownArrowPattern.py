A, C = map(str, input().strip().split())
N = int(A)
for i in range(N):
    if i != 0:
        print('-' * (N - i - 1), C, '-' * (i - 1), C, '-' * (i - 1), C, sep = '')
    else:
        print('-' * (N - i - 1), C, sep = '')
for i in range(N):
    print('-' * (N - 1), C, sep = '')
for i in range(N):
    if i != N - 1:
        print('-' * i, C, '-' * (N - i - 2), C, '-' * (N - i - 2), C, sep = '')
    else:
        print('-' * i, C, sep = '')