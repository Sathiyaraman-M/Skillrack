N = int(input())
L = list(map(int, input().strip().split()))
S = 0
for i in L:
    S += min(list(map(int, list(str(i)))))
print(S)