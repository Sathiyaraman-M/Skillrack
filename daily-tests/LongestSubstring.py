S1 = input().strip()
S2 = input().strip()
L = S1.split(S2)
W = ''
for i in L:
    if len(i) > len(W):
        W = i
print(W if len(W) > 1 else "-1")