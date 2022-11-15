A, B, C = map(str, input().strip().split())
N = int(C)
A += ' '
B += ' '
for i in range(N):
    print((i + 1) * A, (N - i - 1) * B, sep = '')