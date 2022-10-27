N = int(input())
print(1)
for i in range(1, N - 1):
    print('1', '0' * (i - 1), '1', sep = '')
print('1' * N)