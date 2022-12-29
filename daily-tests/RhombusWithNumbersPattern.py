N = int(input())
Index = 1
for i in range(N):
    if i == 0 or i == N - 1:
        print('- ' * (N - i - 1), '* ' * N, sep = '')
        continue
    print('- ' * (N - i - 1), '* ', sep = '', end = '')
    for j in range(1, N - 1):
        print(Index, end = " ")
        Index += 1
    print('* ')