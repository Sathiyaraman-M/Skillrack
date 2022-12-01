M, N = map(int, input().split())
L = [list(map(int, input().split())) for i in range(M)]
print('* ' * (N + 2))
for i in L:
    print('*', *i, '*')
print('* ' * (N + 2))