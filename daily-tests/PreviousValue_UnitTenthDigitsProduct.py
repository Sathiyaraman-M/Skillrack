N = int(input())
L = list(map(int, input().split()))
for i in L[:len(L) - 1]:
    print((i % 10) * ((i // 10) % 10), end = ' ')