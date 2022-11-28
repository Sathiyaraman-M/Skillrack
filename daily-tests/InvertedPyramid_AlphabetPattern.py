N = int(input())
for i in range(N - 1, -1, -1):
    print('* ' * (N - i - 1), end = '')
    print((str(chr(ord('A') + i)) + " ") * (i * 2 + 1))