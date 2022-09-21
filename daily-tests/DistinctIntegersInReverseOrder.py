N = int(input())
L = list(map(int, input().split()))[::-1]
M = []
for i in L:
    if i not in M:
        M.append(i)
print(*M)