N = int(input())
Sizes = input()
L = []
for i in range(N):
    L.extend(list(map(int, input().strip().split())))
print(*sorted(L))