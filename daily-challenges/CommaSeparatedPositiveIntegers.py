N = int(input())
L = [i for i in list(map(int, input().split(','))) if i > 0]
if len(L) == 0:
    print(-1)
else:
    print(*L, sep = ',')