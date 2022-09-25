S1 = input().strip().split()
S2 = input().strip().split()
C = 0
for i in set(S1):
    C += 1 if i in S2 else 0
print(C)