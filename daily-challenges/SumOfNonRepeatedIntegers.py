N = int(input())
L = list(map(int, input().split()))
S = 0
for i in L:
    if L.count(i) == 1:
        S += i
print(S if S != 0 else -1)