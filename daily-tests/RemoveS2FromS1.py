S1 = input().strip()
S2 = input().strip()
C = 0
while S2 in S1:
    C += S1.count(S2)
    S1 = S1.replace(S2, '')
print(C if C != 0 else -1)