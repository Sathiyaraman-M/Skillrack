A, B = map(str, input().strip().split())
S, N = A, int(B)
W = ""
for i in S[::-1]:
    if N != 0 and i in "aeiouAEIOU":
        N -= 1
    else:
        W = i + W
print(W)