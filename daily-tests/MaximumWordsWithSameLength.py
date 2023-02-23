S = input().strip().split()
W = {}
for i in S:
    L = len(i)
    if L in W:
        W[L] += 1
    else:
        W[L] = 1
Max = max(W.values())
MaxLengths = [key for key, val in W.items() if val == Max]
for i in S:
    L = len(i)
    if L in MaxLengths:
        print(i, end = ' ')