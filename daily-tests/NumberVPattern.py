N = int(input())
for i in range(N // 2):
    print(i * '*', i + 1, (N - 2 - 2 * i) * '*', N - i, i * '*', sep = '')
print('*' * (N // 2), (N // 2) + 1, '*' * (N // 2), sep = '')