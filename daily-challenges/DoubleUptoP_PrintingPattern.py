N, P = map(int, input().split())
for i in range(1, N + 1):
    print((str(i) + ' ') * i if i > P else 2 * i * (str(i) + ' '))