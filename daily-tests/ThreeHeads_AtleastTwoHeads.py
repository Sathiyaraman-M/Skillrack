N = int(input())
C = 0
for i in range(N):
    Tosses = list(input().strip().split())
    C += 1 if Tosses.count('H') >= 2 else 0
print(C)