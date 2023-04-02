N = int(input())
L = list(map(int, input().split()))
M = max(L)
for i in L:
    print(M - i, end = ' ')