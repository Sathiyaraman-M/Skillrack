S, A = map(str, input().strip().split())
X = int(A)
C = 0
A = ''
for i in S:
    if i in "aeiouAEIOU":
        A += i
        C += 1
    if C == X:
        break
print(A if C == X else '-1')