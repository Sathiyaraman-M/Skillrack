N = int(input())
S = 1000
for i in range(N):
    L = input().strip().split()
    S += int(L[1]) if L[0] == '+' else 0 - int(L[1])
print(S)