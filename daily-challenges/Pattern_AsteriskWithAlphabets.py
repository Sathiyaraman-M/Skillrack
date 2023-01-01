N = int(input())
for i in range(N):
    print('*' * (N - i - 1), end = '')
    for j in range(i + 1):
        print(chr(ord('A') + j), end = '')
    for j in range(i - 1, -1, -1):
        print(chr(ord('A') + j), end = '')
    print()
